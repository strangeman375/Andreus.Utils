﻿using System;
using System.Globalization;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="double"/>.
    /// </summary>
    public static partial class DoubleExtensions
    {
        /// <summary>
        /// Converts the span representation of a number in a culture-independent format to its numeric equivalent.
        /// </summary>
        /// <param name="s">A span containing the characters representing the value to convert.</param>
        /// <returns>A numeric value that is equivalent to the number contained in span.</returns>
        public static double ParseInvariant(ReadOnlySpan<char> s)
        {
            return double.Parse(s, DefaultParseNumberStyles, NumberFormatInfo.InvariantInfo);
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
        public static bool TryParseInvariant(ReadOnlySpan<char> s, out double value)
        {
            return double.TryParse(s, DefaultParseNumberStyles, NumberFormatInfo.InvariantInfo, out value);
        }

        /// <summary>
        /// Tries to format the value into the provided span of characters using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The value to format.</param>
        /// <param name="destination">When this method returns, value formatted as a span of characters.</param>
        /// <param name="charsWritten">When this method returns, the number of characters that were written in destination.</param>
        /// <param name="format">A span containing the charactes that represent a standard or custom numeric format string.</param>
        /// <returns>True if the formatting was successful, otherwise, false.</returns>
        public static bool TryFormatInvariant(this double value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default)
        {
            return value.TryFormat(destination, out charsWritten, format, NumberFormatInfo.InvariantInfo);
        }
    }
}