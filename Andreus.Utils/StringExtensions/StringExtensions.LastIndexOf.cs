using System;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="string"/>.
    /// </summary>
    public static partial class StringExtensions
    {
        public static int LastIndexOfIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int LastIndexOfIgnoreCase(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int LastIndexOfIgnoreCase(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, count, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int LastIndexOfInvariant(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, StringComparison.InvariantCulture);
        }

        public static int LastIndexOfInvariant(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, StringComparison.InvariantCulture);
        }

        public static int LastIndexOfInvariant(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, count, StringComparison.InvariantCulture);
        }

        public static int LastIndexOfInvariantIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, StringComparison.InvariantCultureIgnoreCase);
        }

        public static int LastIndexOfInvariantIgnoreCase(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, StringComparison.InvariantCultureIgnoreCase);
        }

        public static int LastIndexOfInvariantIgnoreCase(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, count, StringComparison.InvariantCultureIgnoreCase);
        }

        public static int LastIndexOfOrdinal(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, StringComparison.Ordinal);
        }

        public static int LastIndexOfOrdinal(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, StringComparison.Ordinal);
        }

        public static int LastIndexOfOrdinal(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, count, StringComparison.Ordinal);
        }

        public static int LastIndexOfOrdinalIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, StringComparison.OrdinalIgnoreCase);
        }

        public static int LastIndexOfOrdinalIgnoreCase(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, StringComparison.OrdinalIgnoreCase);
        }

        public static int LastIndexOfOrdinalIgnoreCase(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.LastIndexOf(value, startIndex, count, StringComparison.OrdinalIgnoreCase);
        }
    }
}