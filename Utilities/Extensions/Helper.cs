using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StructEnumTask.Utilities.Extensions
{
    internal static class Helper
    {
        public static bool IsOdd(this int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool HasDigit(this string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckPassword(this string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    hasUpper = true;
                else if (char.IsLower(password[i]))
                    hasLower = true;
                else if (char.IsDigit(password[i]))
                    hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }
        public static string Capitalize(string value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(value[0]));
            for (int i = 1; i < value.Length; i++)
            {
                sb.Append(char.ToLower(value[i]));
            }
            return sb.ToString();
        }
    }
}
