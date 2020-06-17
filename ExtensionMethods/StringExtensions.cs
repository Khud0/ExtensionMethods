using System;
using System.Text;

namespace Khud0.Extensions
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int maxCharacters)
        {
            if (maxCharacters <= 0)
                throw new InvalidOperationException("Number of characters in a shortened string must be greater than 0!");

            // Given string fits the desired size, there's nothing to shorten
            if (maxCharacters >= str.Length)
                return str;

            var stringBuilder = new StringBuilder();
            for (int i=0; i<maxCharacters; i++)
            {
                stringBuilder.Append(str[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
