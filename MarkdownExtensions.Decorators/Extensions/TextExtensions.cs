using MarkdownExtensions.Decorators.Variants;

namespace MarkdownExtensions.Decorators.Extensions;

public static partial class TextExtensions
{
    public static string Highlight(string content)
    {
        var decorator = new HighlightedDecorator();
        return string.Format("{0}{1}{2}", decorator, content, decorator);

    }
    
    public static string AsStrikeThrough(string content)
    {
        var decorator = new StrikethroughDecorator();
        return string.Format("{0}{1}{2}", decorator, content, decorator);
    }
    
    public static string AsSuperscript(string content)
    {
        var decorator = new SuperscriptDecorator();
        return string.Format("{0}{1}{2}", decorator, content, decorator);
    }
    
    public static string AsSubscript(string content)
    {
        var decorator = new SubscriptDecorator();
        return string.Format("{0}{1}{2}", decorator, content, decorator);
    }
}