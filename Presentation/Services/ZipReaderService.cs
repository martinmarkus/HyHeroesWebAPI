﻿using ExcelDataReader;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class ZipReaderService : IZipReaderService
    {
        private static bool _isExcelInUse = false;

        private readonly string _filePath;

        public ZipReaderService(IOptions<AppSettings> options)
        {
            _filePath = options.Value.ZipCodesFilePath ?? throw new ArgumentException(nameof(options));
        }

        public IList<ZipCode> ReadInZipData()
        {
            var hungarianZips = new List<ZipCode>();

            while (_isExcelInUse)
            {
                System.Threading.Thread.Sleep(50);
            }

            _isExcelInUse = true;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(_filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                var type1 = reader.GetFieldType(0);
                                var type2 = reader.GetFieldType(1);

                                if (type1 == null || type2 == null)
                                {
                                    continue;
                                }

                                if (type1.Name.Equals("Double", StringComparison.OrdinalIgnoreCase)
                                    && type2.Name.Equals("String", StringComparison.OrdinalIgnoreCase))
                                {
                                    hungarianZips.Add(new ZipCode()
                                    {
                                        Zip = Convert.ToInt32(reader.GetDouble(0)),
                                        City = reader.GetString(1)
                                    });
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    while (reader.NextResult());
                }
            }
            _isExcelInUse = false;

            return hungarianZips;
        }
    }
}
