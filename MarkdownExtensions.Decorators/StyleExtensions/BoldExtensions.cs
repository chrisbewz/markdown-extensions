using MarkdownExtensions.Decorators.Formatting;

namespace MarkdownExtensions.Decorators.StyleExtensions
{
    public static class BoldExtensions
    {

        public static string AsBold(this string content,IDecorator boldDecorator)
        {
            var stringDecorator = (string)boldDecorator.Decorator;

            return string.Format("{0}{1}{2}",stringDecorator, content, stringDecorator);
        }
        
        public static string AsBold(this string content,IDecorator boldDecorator,Position decoratorPosition = Position.Both)
        {
            var stringDecorator = (string)boldDecorator.Decorator;
            
            if (string.IsNullOrWhiteSpace(content)) return string.Empty;
            
            if (decoratorPosition == Position.Both)
            {
                return content.AsBold(boldDecorator);    
            }
            else if (decoratorPosition == Position.LeftOnly)
            {
                return string.Format("{0}{1}", stringDecorator, content);
            }
            else
            {
                return string.Format("{0}{1}",content, stringDecorator);
            }
            
        }
        
    }
}