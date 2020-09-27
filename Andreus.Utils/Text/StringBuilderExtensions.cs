using System;
using System.Collections.Generic;
using System.Text;

namespace Andreus.Utils.Text
{
    /// <summary>
    /// Extensions for <see cref="StringBuilder"/>.
    /// </summary>
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendValue<T>(this StringBuilder stringBuilder, T value)
            where T : IStringBuilderAppendable
        {
            if (stringBuilder is null)
                throw new ArgumentNullException(nameof(stringBuilder));

            value?.AppendSelf(stringBuilder);
            return stringBuilder;
        }

        public static StringBuilder AppendJoinValues<T>(this StringBuilder stringBuilder, string separator, IEnumerable<T> values)
            where T : IStringBuilderAppendable
        {
            if (stringBuilder is null)
                throw new ArgumentNullException(nameof(stringBuilder));

            if (values is null)
                throw new ArgumentNullException(nameof(values));

            using (var enumerator = values.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                    return stringBuilder;

                enumerator.Current?.AppendSelf(stringBuilder);

                while (enumerator.MoveNext())
                {
                    stringBuilder.Append(separator);
                    enumerator.Current?.AppendSelf(stringBuilder);
                }
            }

            return stringBuilder;
        }

        public static StringBuilder AppendJoinValues<T>(this StringBuilder stringBuilder, char separator, IEnumerable<T> values)
            where T : IStringBuilderAppendable
        {
            if (stringBuilder is null)
                throw new ArgumentNullException(nameof(stringBuilder));

            if (values is null)
                throw new ArgumentNullException(nameof(values));

            using (var enumerator = values.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                    return stringBuilder;

                enumerator.Current?.AppendSelf(stringBuilder);

                while (enumerator.MoveNext())
                {
                    stringBuilder.Append(separator);
                    enumerator.Current?.AppendSelf(stringBuilder);
                }
            }

            return stringBuilder;
        }
    }
}