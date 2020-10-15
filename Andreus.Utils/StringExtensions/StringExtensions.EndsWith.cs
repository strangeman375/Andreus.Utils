using System;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="string"/>.
    /// </summary>
    public static partial class StringExtensions
    {
        public static bool EndsWithIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.EndsWith(value, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool EndsWithInvariant(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.EndsWith(value, StringComparison.InvariantCulture);
        }

        public static bool EndsWithInvariantIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.EndsWith(value, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool EndsWithOrdinal(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.EndsWith(value, StringComparison.Ordinal);
        }

        public static bool EndsWithOrdinalIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.EndsWith(value, StringComparison.OrdinalIgnoreCase);
        }
    }
}