using System.Text;

namespace Andreus.Utils.Text
{
    /// <summary>
    /// Provides functionality to append the value of an object to a <see cref="StringBuilder"/>.
    /// </summary>
    public interface IStringBuilderAppendable
    {
        /// <summary>
        /// Appends the value of the current instance to a specified <see cref="StringBuilder"/>.
        /// </summary>
        /// <param name="stringBuilder">The <see cref="StringBuilder"/> to append to.</param>
        void AppendSelf(StringBuilder stringBuilder);
    }
}