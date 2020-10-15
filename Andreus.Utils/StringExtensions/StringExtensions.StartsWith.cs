using System;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="string"/>.
    /// </summary>
    public static partial class StringExtensions
    {
        public static bool StartsWithIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.StartsWith(value, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool StartsWithInvariant(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.StartsWith(value, StringComparison.InvariantCulture);
        }

        public static bool StartsWithInvariantIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.StartsWith(value, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool StartsWithOrdinal(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.StartsWith(value, StringComparison.Ordinal);
        }

        public static bool StartsWithOrdinalIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.StartsWith(value, StringComparison.OrdinalIgnoreCase);
        }
    }
}