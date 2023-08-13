using MarkdownExtensions.Converters.Contracts;

namespace MarkdownExtensions.Converters.Html;

public class BaseHtmlConverter : IConverter
{
    public string Contents { get; }
    
    public IConverter Convert()
    {
        return (IConverter)this;
    }
}