using MarkdownExtensions.Decorators.Variants;

namespace MarkdownExtensions.Decorators.Extensions
{
    public static partial class TextExtensions
    {
        public static string AsItalic(this string content,IDecorator italicDecorator)
        {
            var decorator = italicDecorator;

            return string.Format("{0}{1}{2}",decorator, content, decorator);
        }
        
        public static string AsItalic(this string content)
        {
            var decorator = new ItalicStarredDecorator();

            return string.Format("{0}{1}{2}",decorator, content, decorator);
        }
    }
}