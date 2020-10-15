using System;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="string"/>.
    /// </summary>
    public static partial class StringExtensions
    {
        public static bool EqualsIgnoreCase(string? a, string? b)
        {
            return string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool EqualsInvariant(string? a, string? b)
        {
            return string.Equals(a, b, StringComparison.InvariantCulture);
        }

        public static bool EqualsInvariantIgnoreCase(string? a, string? b)
        {
            return string.Equals(a, b, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool EqualsOrdinal(string? a, string? b)
        {
            return string.Equals(a, b, StringComparison.Ordinal);
        }

        public static bool EqualsOrdinalIgnoreCase(string? a, string? b)
        {
            return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }
    }
}