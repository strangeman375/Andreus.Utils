using System.Text;

namespace Andreus.Utils.Text
{
    public interface IStringBuilderAppendable
    {
        void AppendSelf(StringBuilder stringBuilder);
    }
}