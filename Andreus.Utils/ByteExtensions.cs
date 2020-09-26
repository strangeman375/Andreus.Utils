using System.Globalization;

namespace Andreus.Utils
{
    public static class ByteExtensions
    {
        public static string ToStringInvariant(this byte value)
        {
            return value.ToString(NumberFormatInfo.InvariantInfo);
        }

        public static string ToStringInvariant(this byte value, string format)
        {
            return value.ToString(format, NumberFormatInfo.InvariantInfo);
        }
    }
}