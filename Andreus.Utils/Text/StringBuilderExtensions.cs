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
        /// <summary>
        /// Appends the string representation of a specified object to this instance.
        /// </summary>
        /// <typeparam name="T">The type of a specified object.</typeparam>
        /// <param name="stringBuilder">The <see cref="StringBuilder"/> to append to.</param>
        /// <param name="value">The object to append.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
        public static StringBuilder AppendValue<T>(this StringBuilder stringBuilder, T value)
            where T : IStringBuilderAppendable
        {
            if (stringBuilder is null)
                throw new ArgumentNullException(nameof(stringBuilder));

            value?.AppendSelf(stringBuilder);
            return stringBuilder;
        }

        /// <summary>
        /// Concatenates and appends the members of a collection, using the specified <see cref="string"/> separator between each member.
        /// </summary>
        /// <typeparam name="T">The type of the members of values.</typeparam>
        /// <param name="stringBuilder">The <see cref="StringBuilder"/> to append to.</param>
        /// <param name="separator">The string to use as a separator.</param>
        /// <param name="values">A collection that contains the objects to concatenate and append to the current instance of the <see cref="StringBuilder"/>.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
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

        /// <summary>
        /// Concatenates and appends the members of a collection, using the specified <see cref="char"/> separator between each member.
        /// </summary>
        /// <typeparam name="T">The type of the members of values.</typeparam>
        /// <param name="stringBuilder">The <see cref="StringBuilder"/> to append to.</param>
        /// <param name="separator">The char to use as a separator.</param>
        /// <param name="values">A collection that contains the objects to concatenate and append to the current instance of the <see cref="StringBuilder"/>.</param>
        /// <returns>A reference to this instance after the append operation has completed.</returns>
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