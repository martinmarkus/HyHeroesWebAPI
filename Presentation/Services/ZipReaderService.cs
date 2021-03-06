using ExcelDataReader;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Extensions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class ZipReaderService : IZipReaderService
    {
        private static bool _isResourceInUse = false;
        private static List<ZipCode> _hungarianZips = new List<ZipCode>();

        private readonly string _filePath;

        public ZipReaderService(IOptions<AppSettings> options)
        {
            _filePath = options.Value.ZipCodesFilePath ?? throw new ArgumentException(nameof(options));
        }

        public IList<ZipCode> ReadInZipData()
        {
            while (_isResourceInUse)
            {
                System.Threading.Thread.Sleep(50);
            }

            _isResourceInUse = true;
            var clonedZips = new List<ZipCode>();
            try
            {
                if (_hungarianZips.Count == 0)
                {
                    InitZipList();
                }
                clonedZips = _hungarianZips.DeepClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            _isResourceInUse = false;

            return clonedZips;
        }

        private void InitZipList()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using var stream = File.Open(_filePath, FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);
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
                        _hungarianZips.Add(new ZipCode()
                        {
                            Zip = Convert.ToInt32(reader.GetDouble(0)),
                            City = reader.GetString(1)
                        });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
