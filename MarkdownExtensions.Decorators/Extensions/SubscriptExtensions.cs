using MarkdownExtensions.Decorators.Variants;

namespace MarkdownExtensions.Decorators.Extensions;

public static partial class DecoratorExtensions
{
    public static string AsSubscript(string content)
    {
        var decorator = new SubscriptDecorator();
        return string.Format("{0}{1}{2}", decorator, content, decorator);
    }
}