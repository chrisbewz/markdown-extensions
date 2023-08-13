
using MarkdownExtensions.Converters.Contracts;

namespace MarkdownExtensions.Converters.Text;

public class BaseTextConverter : IConverter
{
    public string Contents { get; }
    
    public IConverter Convert()
    {
        return (IConverter)this;
    }
}