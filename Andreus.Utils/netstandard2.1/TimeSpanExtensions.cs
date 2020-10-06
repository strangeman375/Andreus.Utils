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
        /// Converts the span representation of a time interval in a culture-independent format to its <see cref="TimeSpan"/> equivalent.
        /// </summary>
        /// <param name="s">A span containing the characters representing the time interval to convert.</param>
        /// <returns>A <see cref="TimeSpan"/> value that is equivalent to the time interval contained in span.</returns>
        public static TimeSpan ParseInvariant(ReadOnlySpan<char> s)
        {
            return TimeSpan.Parse(s, DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Converts the span representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the span representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A span containing the characters representing the time interval to convert.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in span.</param>
        /// <returns>A <see cref="TimeSpan"/> value that is equivalent to the time interval contained in span.</returns>
        public static TimeSpan ParseExactInvariant(ReadOnlySpan<char> s, ReadOnlySpan<char> format, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.ParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the span representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the span representation must match one of the specified formats exactly.
        /// </summary>
        /// <param name="s">A span containing the characters representing the time interval to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="TimeSpan"/> format strings.</param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in span.</param>
        /// <returns>A <see cref="TimeSpan"/> value that is equivalent to the time interval contained in span.</returns>
        public static TimeSpan ParseExactInvariant(ReadOnlySpan<char> s, string[] formats, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.ParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the span representation of a time interval in a culture-independent format to its <see cref="TimeSpan"/> equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A span containing the characters representing the time interval to convert.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="TimeSpan"/> value equivalent to the time interval contained in a span if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <returns>True if span was converted successfully, otherwise, false.</returns>
        public static bool TryParseInvariant(ReadOnlySpan<char> s, out TimeSpan value)
        {
            return TimeSpan.TryParse(s, DateTimeFormatInfo.InvariantInfo, out value);
        }

        /// <summary>
        /// Converts the span representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the span representation must match the specified format exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A span containing the characters representing the time interval to convert.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="TimeSpan"/> value equivalent to the time interval contained in a span if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in span.</param>
        /// <returns>True if span was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(ReadOnlySpan<char> s, ReadOnlySpan<char> format, out TimeSpan value, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.TryParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the span representation of a time interval to its <see cref="TimeSpan"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the span representation must match one of the specified formats exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A span containing the characters representing the time interval to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="TimeSpan"/> format strings.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="TimeSpan"/> value equivalent to the time interval contained in a span if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">A bitwise combination of enumeration values that defines the style elements that may be present in span.</param>
        /// <returns>True if span was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(ReadOnlySpan<char> s, string[] formats, out TimeSpan value, TimeSpanStyles styles = TimeSpanStyles.None)
        {
            return TimeSpan.TryParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Tries to format the value into the provided span of characters using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="destination">When this method returns, value formatted as a span of characters.</param>
        /// <param name="charsWritten">When this method returns, the number of characters that were written in destination.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <returns>True if the formatting was successful, otherwise, false.</returns>
        public static bool TryFormatInvariant(this TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default)
        {
            return value.TryFormat(destination, out charsWritten, format, NumberFormatInfo.InvariantInfo);
        }
    }
}