namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringExtensions
    {
        /// <summary>
        /// Convert the input string to md5 hash.
        /// </summary>
        /// <param name="input">Text that should be converted.</param>
        /// <returns>Md5 hash of input.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Convert given string to boolean value.
        /// </summary>
        /// <param name="input">Text that should be converted.</param>
        /// <returns>True if inputed string is one of specific words.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Convert given string to short value.
        /// </summary>
        /// <param name="input">Text that should be converted.</param>
        /// <returns>Parsed value of input if conversion succeeded.</returns>
        public static short ToShort(this string input)
        {
            short.TryParse(input, out short shortValue);
            return shortValue;
        }

        /// <summary>
        /// Convert given string to int value.
        /// </summary>
        /// <param name="input">Text that should be converted.</param>
        /// <returns>Parsed value of input if conversion succeeded.</returns>
        public static int ToInteger(this string input)
        {
            int.TryParse(input, out int integerValue);
            return integerValue;
        }

        /// <summary>
        /// Convert given string to long value.
        /// </summary>
        /// <param name="input">Text that should be converted.</param>
        /// <returns>Parsed value of input if conversion succeeded.</returns>
        public static long ToLong(this string input)
        {
            long.TryParse(input, out long longValue);
            return longValue;
        }

        /// <summary>
        /// Convert given string to date.
        /// </summary>
        /// <param name="input">Text that should be converted to date.</param>
        /// <returns>Parsed date of input if conversion succeeded.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime.TryParse(input, out DateTime dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalize first letter of given string.
        /// </summary>
        /// <param name="input">Text witch first letter should be capitalized.</param>
        /// <returns>If input is null or empty returns given string, otherwise returns same string with first letter capitalized.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get string located between two strings in given sentence.
        /// </summary>
        /// <param name="input">Given string where should find wanted string.</param>
        /// <param name="startString">String from which start wanted string.</param>
        /// <param name="endString">String where end wanted string.</param>
        /// <param name="startFrom">Index from where start searching.</param>
        /// <returns>Empty string if input string not contain any of two boundary string,
        /// otherwise returns the string which is located between them</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Represent bulgarian string to string with latin letters.
        /// </summary>
        /// <param name="input">Given bulgarian string.</param>
        /// <returns>Converted string which represent bulgarian string with latin letters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Represent latin string to string with cyrillic letters.
        /// </summary>
        /// <param name="input">Given latin string.</param>
        /// <returns>Converted string which represent latin string with cyrillic letters.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Remove all symbols that are not valid for username from given string.
        /// </summary>
        /// <param name="input">Given username that should be validated.</param>
        /// <returns>Valid username without any invalid symbols.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Remove all symbols that are not valid for filename from given string.
        /// </summary>
        /// <param name="input">Given filename that should be validated.</param>
        /// <returns>Valid filename without any invalid symbols.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Get first characters from given string
        /// </summary>
        /// <param name="input">Given text</param>
        /// <param name="charsCount">Count of characters that must be get from beginning of the string</param>
        /// <returns>First characters from given text</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get extension of given file
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <returns>Empty string if filename is empty or not contain extension,
        /// otherwise returns the extension</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Convert extension of the file to content type
        /// </summary>
        /// <param name="fileExtension">Extension of file</param>
        /// <returns>Content type of given extension</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert given string to array from bytes.
        /// </summary>
        /// <param name="input">Given string</param>
        /// <returns>Array from bytes made by given string</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
