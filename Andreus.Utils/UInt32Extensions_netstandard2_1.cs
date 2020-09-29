using System;
using System.Globalization;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="uint"/>.
    /// </summary>
    public static partial class UInt32Extensions
    {
        /// <summary>
        /// Converts the span representation of a number in a culture-independent format to its numeric equivalent.
        /// </summary>
        /// <param name="s">A span containing the characters representing the value to convert.</param>
        /// <returns>A numeric value that is equivalent to the number contained in span.</returns>
        public static uint ParseInvariant(ReadOnlySpan<char> s)
        {
            return uint.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Converts the span representation of a number in a culture-independent format to its numeric equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A span containing the characters representing the value to convert.</param>
        /// <param name="value">
        /// When this method returns, contains numeric value equivalent to the number contained in a span if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseInvariant(ReadOnlySpan<char> s, out uint value)
        {
            return uint.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out value);
        }

        /// <summary>
        /// Tries to format the value into the provided span of characters using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="destination">When this method returns, value formatted as a span of characters.</param>
        /// <param name="charsWritten">When this method returns, the number of characters that were written in destination.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <returns>True if the formatting was successful, otherwise, false.</returns>
        public static bool TryFormatInvariant(this uint value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default)
        {
            return value.TryFormat(destination, out charsWritten, format, NumberFormatInfo.InvariantInfo);
        }
    }
}