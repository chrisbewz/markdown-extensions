using System.Runtime.CompilerServices;
using MarkdownExtensions.Converters.Contracts;

namespace MarkdownExtensions.Converters.Markdown;

public class BaseMarkdownConverter : IConverter
{
    public string Contents { get; }

    private BaseMarkdownConverter()
    {
        this.Contents = string.Empty;
    }

    private BaseMarkdownConverter(string contents)
    {
        this.Contents = contents;
    }

    public static BaseMarkdownConverter Init()
    {
        return new BaseMarkdownConverter();
    }

    public static BaseMarkdownConverter Init(string contents)
    {
        return new BaseMarkdownConverter(contents);
    }

    public IConverter Convert()
    {
        return (IConverter)this;
    }
}