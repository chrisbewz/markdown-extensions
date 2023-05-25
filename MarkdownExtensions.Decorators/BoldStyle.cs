namespace MarkdownExtensions.Decorators
{
    public static class BoldStyle
    {

        public static string SetBold(this string content,IDecorator boldDecorator)
        {
            var stringDecorator = (string)boldDecorator.Decorator;

            return string.Format("{0}{1}{2}",stringDecorator, content, stringDecorator);
        }
        
    }
}