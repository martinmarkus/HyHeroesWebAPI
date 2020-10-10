using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Extensions
{
    public static class ObjectExtensions
    {
        public static decimal GetAsDecimal(this object obj)
        {
            if (obj == null)
            {
                return 0;
            }

            var isDecimal = Decimal.TryParse(obj.ToString(), out decimal convertedValue);

            return isDecimal ? convertedValue : 0;
        }


        public static int GetAsInt32(this object obj)
        { 
            if (obj == null)
            {
                return 0;
            }

            var isInt32 = Int32.TryParse(obj.ToString(), out int convertedValue);

            return isInt32 ? convertedValue : 0;
        }

        public static long GetAsInt64(this object obj)
        {
            if (obj == null)
            {
                return 0;
            }

            var isInt64 = Int64.TryParse(obj.ToString(), out long convertedValue);

            return isInt64 ? convertedValue : 0;
        }

        public static bool GetAsBool(this object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var isBool = Boolean.TryParse(obj.ToString(), out bool convertedValue);

            return isBool ? convertedValue : false;
        }

        public static DateTime GetAsDateTime(this object obj)
        {
            if (obj == null)
            {
                return default;
            }

            var isDateTime = DateTime.TryParse(obj.ToString(), out DateTime convertedValue);

            return isDateTime ? convertedValue : default;
        }

    }
}
