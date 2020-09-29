using System;
using System.Globalization;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="TimeSpan"/>.
    /// </summary>
    public static partial class TimeSpanExtensions
    {
        /// <summary>
        /// Converts the string representation of a time interval in a culture-independent format to its <see cref="TimeSpan"/> equivalent.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <returns>A <see cref="TimeSpan"/> value that is equivalent to the time interval contained in string.</returns>
        public static TimeSpan ParseInvariant(string s)
        {
            return TimeSpan.Parse(s, DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Converts the string representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the string representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="format">A standard or custom <see cref="TimeSpan"/> format string.</param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in string.</param>
        /// <returns>A <see cref="TimeSpan"/> value that is equivalent to the time interval contained in string.</returns>
        public static TimeSpan ParseExactInvariant(string s, string format, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.ParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the string representation must match one of the specified formats exactly.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="TimeSpan"/> format strings.</param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in string.</param>
        /// <returns>A <see cref="TimeSpan"/> value that is equivalent to the time interval contained in string.</returns>
        public static TimeSpan ParseExactInvariant(string s, string[] formats, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.ParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the string representation of a time interval in a culture-independent format to its <see cref="TimeSpan"/> equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="TimeSpan"/> value equivalent to the time interval contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseInvariant(string s, out TimeSpan value)
        {
            return TimeSpan.TryParse(s, DateTimeFormatInfo.InvariantInfo, out value);
        }

        /// <summary>
        /// Converts the string representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the string representation must match the specified format exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="format">A standard or custom <see cref="TimeSpan"/> format string.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="TimeSpan"/> value equivalent to the time interval contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in string.</param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(string s, string format, out TimeSpan value, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.TryParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the string representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the string representation must match one of the specified formats exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="TimeSpan"/> format strings.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="TimeSpan"/> value equivalent to the time interval contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in string.</param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(string s, string[] formats, out TimeSpan value, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.TryParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the <see cref="TimeSpan"/> value to its equivalent string representation
        /// using the specified format and culture-independent formatting information.
        /// </summary>
        /// <param name="value">The <see cref="TimeSpan"/> value.</param>
        /// <param name="format">A standard or custom <see cref="TimeSpan"/> format string.</param>
        /// <returns>The string representation of the value, formatted as specified by the format parameter.</returns>
        public static string ToStringInvariant(this TimeSpan value, string format)
        {
            return value.ToString(format, DateTimeFormatInfo.InvariantInfo);
        }
    }
}