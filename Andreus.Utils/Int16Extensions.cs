﻿using System.Globalization;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="short"/>.
    /// </summary>
    public static partial class Int16Extensions
    {
        /// <summary>
        /// Converts the string representation of a number in a culture-independent format to its numeric equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <returns>A numeric value that is equivalent to the number contained in string.</returns>
        public static short ParseInvariant(string s)
        {
            return short.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Converts the string representation of a number in a culture-independent format to its numeric equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <param name="value">
        /// When this method returns, contains numeric value equivalent to the number contained in a string if the conversion succeeded,
        /// or the default value if the conversion failed.
        /// </param>
        /// <returns>True if string was converted successfully, otherwise, false.</returns>
        public static bool TryParseInvariant(
#if NETSTANDARD2_1
            [System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            string? s, out short value)
        {
            return short.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out value);
        }

        /// <summary>
        /// Converts the numeric value to its equivalent string representation
        /// using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The numeric value.</param>
        /// <returns>The string representation of the value.</returns>
        public static string ToStringInvariant(this short value)
        {
            return value.ToString(NumberFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Converts the numeric value to its equivalent string representation
        /// using the specified format and culture-independent formatting information.
        /// </summary>
        /// <param name="value">The numeric value.</param>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <returns>The string representation of the value, formatted as specified by the format parameter.</returns>
        public static string ToStringInvariant(this short value, string? format)
        {
            return value.ToString(format, NumberFormatInfo.InvariantInfo);
        }
    }
}