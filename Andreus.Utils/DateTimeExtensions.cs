using System;
using System.Globalization;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="DateTime"/>.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts the string representation of a date and time in a culture-independent format to its <see cref="DateTime"/> equivalent.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTime"/> value that is equivalent to the date and time contained in string.</returns>
        public static DateTime ParseInvariant(string s, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.Parse(s, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTime"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the string representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="format">A standard or custom <see cref="DateTime"/> format string.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTime"/> value that is equivalent to the date and time contained in string.</returns>
        public static DateTime ParseExactInvariant(string s, string format, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.ParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTime"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the string representation must match one of the specified formats exactly.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="DateTime"/> format strings.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTime"/> value that is equivalent to the date and time contained in string.</returns>
        public static DateTime ParseExactInvariant(string s, string[] formats, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.ParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a date and time in a culture-independent format to its <see cref="DateTime"/> equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTime"/> value equivalent to the date and time contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseInvariant(string s, out DateTime value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.TryParse(s, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTime"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the string representation must match the specified format exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="format">A standard or custom <see cref="DateTime"/> format string.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTime"/> value equivalent to the date and time contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(string s, string format, out DateTime value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.TryParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTime"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the string representation must match one of the specified formats exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="DateTime"/> format strings.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTime"/> value equivalent to the date and time contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(string s, string[] formats, out DateTime value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTime.TryParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the <see cref="DateTime"/> value to its equivalent string representation
        /// using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> value.</param>
        /// <returns>The string representation of the value.</returns>
        public static string ToStringInvariant(this DateTime value)
        {
            return value.ToString(DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Converts the <see cref="DateTime"/> value to its equivalent string representation
        /// using the specified format and culture-independent formatting information.
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> value.</param>
        /// <param name="format">A standard or custom <see cref="DateTime"/> format string.</param>
        /// <returns>The string representation of the value, formatted as specified by the format parameter.</returns>
        public static string ToStringInvariant(this DateTime value, string format)
        {
            return value.ToString(format, DateTimeFormatInfo.InvariantInfo);
        }
    }
}