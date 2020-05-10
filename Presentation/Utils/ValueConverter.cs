using System;

namespace HyHeroesWebAPI.Presentation.Utils
{
    public class ValueConverter
    {
        public int ConvertToInt(string input, int valueIfNotNumber)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (Exception)
            {
            }
            return valueIfNotNumber;
        }

        public bool ConvertToBool(string input, bool valueIfNotBool)
        {
            try
            {
                return Convert.ToBoolean(input);
            }
            catch (Exception)
            {
            }

            return valueIfNotBool;
        }
    }
}
