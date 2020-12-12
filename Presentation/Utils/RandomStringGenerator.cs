using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.Presentation.Utils
{
    public class RandomStringGenerator
    {
        public string GetRandomString(
            IList<EDSMSActivationCode> unusedCodes,
            int size = 8)
        {
            char offset = 'A';
            int lettersOffset = 26;
            var codeBuilder = new StringBuilder(size);
            var random = new Random();

            for (var i = 0; i < size; i++)
            {
                try
                {
                    var @char = (char)random.Next(offset, offset + lettersOffset);
                    codeBuilder.Append(@char);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            var generatedCode = codeBuilder.ToString();
            var isDuplicant = CheckActivationCodeDuplication(unusedCodes, generatedCode);

            return isDuplicant ? GetRandomString(unusedCodes) : generatedCode;
        }

        private bool CheckActivationCodeDuplication(
            IList<EDSMSActivationCode> unusedCodes,
            string generatedCode)
        {
            if (unusedCodes != null)
            {
                foreach (var unusedCode in unusedCodes)
                {
                    if (unusedCode.Code.Equals(generatedCode, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
