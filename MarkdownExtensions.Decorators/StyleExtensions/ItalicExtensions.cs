namespace MarkdownExtensions.Decorators.StyleExtensions
{
    public static class ItalicExtensions
    {
        public static string SetItalic(this string content,IDecorator italicDecorator)
        {
            var stringDecorator = (string)italicDecorator.Decorator;

            return string.Format("{0}{1}{2}",stringDecorator, content, stringDecorator);
        }
    }
}