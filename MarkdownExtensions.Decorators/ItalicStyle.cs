namespace MarkdownExtensions.Decorators
{
    public static class ItalicStyle
    {
        public static string SetItalic(this string content,IDecorator italicDecorator)
        {
            var stringDecorator = (string)italicDecorator.Decorator;

            return string.Format("{0}{1}{2}",stringDecorator, content, stringDecorator);
        }
    }
}