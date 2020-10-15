using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Andreus.Utils
{
    // <summary>
    /// Extensions for <see cref="DateTimeOffset"/>.
    /// </summary>
    public static partial class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Converts the span representation of a date and time in a culture-independent format to its <see cref="DateTimeOffset"/> equivalent.
        /// </summary>
        /// <param name="s">A span containing the characters representing the date and time to convert.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in span for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTimeOffset"/> value that is equivalent to the date and time contained in span.</returns>
        public static DateTimeOffset ParseInvariant(ReadOnlySpan<char> s, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.Parse(s, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the span representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the span representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A span containing the characters representing the date and time to convert.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in span for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTimeOffset"/> value that is equivalent to the date and time contained in span.</returns>
        public static DateTimeOffset ParseExactInvariant(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.ParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the span representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the span representation must match one of the specified formats exactly.
        /// </summary>
        /// <param name="s">A span containing the characters representing the date and time to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="DateTimeOffset"/> format strings.</param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in span for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>A <see cref="DateTimeOffset"/> value that is equivalent to the date and time contained in span.</returns>
        public static DateTimeOffset ParseExactInvariant(ReadOnlySpan<char> s, string[] formats, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.ParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles);
        }

        /// <summary>
        /// Converts the span representation of a date and time in a culture-independent format to its <see cref="DateTimeOffset"/> equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A span containing the characters representing the date and time to convert.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTimeOffset"/> value equivalent to the date and time contained in a span if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in span for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if span was converted successfully, otherwise, false.</returns>
        public static bool TryParseInvariant(ReadOnlySpan<char> s, out DateTimeOffset value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.TryParse(s, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the span representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified format, culture-independent formatting information, and styles.
        /// The format of the span representation must match the specified format exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A span containing the characters representing the date and time to convert.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTimeOffset"/> value equivalent to the date and time contained in a span if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in span for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if span was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(ReadOnlySpan<char> s, ReadOnlySpan<char> format, out DateTimeOffset value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.TryParseExact(s, format, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Converts the span representation of a date and time to its <see cref="DateTimeOffset"/> equivalent
        /// using the specified formats, culture-independent formatting information, and styles.
        /// The format of the span representation must match one of the specified formats exactly.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A span containing the characters representing the date and time to convert.</param>
        /// <param name="formats">An array of standard or custom <see cref="DateTimeOffset"/> format strings.</param>
        /// <param name="value">
        /// When this method returns, contains <see cref="DateTimeOffset"/> value equivalent to the date and time contained in a span if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <param name="styles">
        /// A bitwise combination of the enumeration values that indicates the style elements that can be present in span for the parse operation to succeed,
        /// and that defines how to interpret the parsed date in relation to the current time zone or the current date.
        /// </param>
        /// <returns>True if span was converted successfully, otherwise, false.</returns>
        public static bool TryParseExactInvariant(ReadOnlySpan<char> s, [NotNullWhen(true)] string?[]? formats, out DateTimeOffset value, DateTimeStyles styles = DateTimeStyles.None)
        {
            return DateTimeOffset.TryParseExact(s, formats, DateTimeFormatInfo.InvariantInfo, styles, out value);
        }

        /// <summary>
        /// Tries to format the value into the provided span of characters using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="destination">When this method returns, value formatted as a span of characters.</param>
        /// <param name="charsWritten">When this method returns, the number of characters that were written in destination.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <returns>True if the formatting was successful, otherwise, false.</returns>
        public static bool TryFormatInvariant(this DateTimeOffset value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default)
        {
            return value.TryFormat(destination, out charsWritten, format, NumberFormatInfo.InvariantInfo);
        }
    }
}