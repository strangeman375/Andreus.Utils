using System;
using System.Globalization;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="DateTimeOffset"/>.
    /// </summary>
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Converts the string representation of a date and time in a culture-independent format to its <see cref="DateTimeOffset"/> equivalent.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTimeOffset"/> value that is equivalent to the date and time contained in string.</returns>
        public static DateTimeOffset ParseInvariant(string s, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.Parse(s, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the string representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="format">A standard or custom <see cref="DateTimeOffset"/> format string.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTimeOffset"/> value that is equivalent to the date and time contained in string.</returns>
        public static DateTimeOffset ParseExactInvariant(string s, string format, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.ParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the string representation must match one of the specified formats exactly.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="DateTimeOffset"/> format strings.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTimeOffset"/> value that is equivalent to the date and time contained in string.</returns>
        public static DateTimeOffset ParseExactInvariant(string s, string[] formats, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.ParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a date and time in a culture-independent format to its <see cref="DateTimeOffset"/> equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTimeOffset"/> value equivalent to the date and time contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseInvariant(string s, out DateTimeOffset value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.TryParse(s, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the string representation must match the specified format exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="format">A standard or custom <see cref="DateTimeOffset"/> format string.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTimeOffset"/> value equivalent to the date and time contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(string s, string format, out DateTimeOffset value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.TryParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the string representation must match one of the specified formats exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="DateTimeOffset"/> format strings.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTimeOffset"/> value equivalent to the date and time contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in string for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(string s, string[] formats, out DateTimeOffset value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.TryParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the <see cref="DateTimeOffset"/> value to its equivalent string representation
        /// using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The <see cref="DateTimeOffset"/> value.</param>
        /// <returns>The string representation of the value.</returns>
        public static string ToStringInvariant(this DateTimeOffset value)
        {
            return value.ToString(DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Converts the <see cref="DateTimeOffset"/> value to its equivalent string representation
        /// using the specified format and culture-independent formatting information.
        /// </summary>
        /// <param name="value">The <see cref="DateTimeOffset"/> value.</param>
        /// <param name="format">A standard or custom <see cref="DateTimeOffset"/> format string.</param>
        /// <returns>The string representation of the value, formatted as specified by the format parameter.</returns>
        public static string ToStringInvariant(this DateTimeOffset value, string format)
        {
            return value.ToString(format, DateTimeFormatInfo.InvariantInfo);
        }
    }
}