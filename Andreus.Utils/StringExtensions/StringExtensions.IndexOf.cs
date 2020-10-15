using System;

namespace Andreus.Utils
{
    /// <summary>
    /// Extensions for <see cref="string"/>.
    /// </summary>
    public static partial class StringExtensions
    {
        public static int IndexOfIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int IndexOfIgnoreCase(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int IndexOfIgnoreCase(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, count, StringComparison.CurrentCultureIgnoreCase);
        }

        public static int IndexOfInvariant(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, StringComparison.InvariantCulture);
        }

        public static int IndexOfInvariant(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, StringComparison.InvariantCulture);
        }

        public static int IndexOfInvariant(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, count, StringComparison.InvariantCulture);
        }

        public static int IndexOfInvariantIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, StringComparison.InvariantCultureIgnoreCase);
        }

        public static int IndexOfInvariantIgnoreCase(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, StringComparison.InvariantCultureIgnoreCase);
        }

        public static int IndexOfInvariantIgnoreCase(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, count, StringComparison.InvariantCultureIgnoreCase);
        }

        public static int IndexOfOrdinal(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, StringComparison.Ordinal);
        }

        public static int IndexOfOrdinal(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, StringComparison.Ordinal);
        }

        public static int IndexOfOrdinal(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, count, StringComparison.Ordinal);
        }

        public static int IndexOfOrdinalIgnoreCase(this string s, string value)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, StringComparison.OrdinalIgnoreCase);
        }

        public static int IndexOfOrdinalIgnoreCase(this string s, string value, int startIndex)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, StringComparison.OrdinalIgnoreCase);
        }

        public static int IndexOfOrdinalIgnoreCase(this string s, string value, int startIndex, int count)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));

            return s.IndexOf(value, startIndex, count, StringComparison.OrdinalIgnoreCase);
        }
    }
}