using System.Globalization;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="int"/>.
    /// </summary>
    public static class Int32Extensions
    {
        /// <summary>
        /// Converts the string representation of a number in a culture-independent format to its numeric equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <returns>A numeric value that is equivalent to the number contained in string.</returns>
        public static int ParseInvariant(string s)
        {
            return int.Parse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo);
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
        public static bool TryParseInvariant(string s, out int value)
        {
            return int.TryParse(s, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out value);
        }

        /// <summary>
        /// Converts the numeric value to its equivalent string representation
        /// using culture-independent formatting information.
        /// </summary>
        /// <param name="value">The numeric value.</param>
        /// <returns>The string representation of the value.</returns>
        public static string ToStringInvariant(this int value)
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
        public static string ToStringInvariant(this int value, string format)
        {
            return value.ToString(format, NumberFormatInfo.InvariantInfo);
        }
    }
}