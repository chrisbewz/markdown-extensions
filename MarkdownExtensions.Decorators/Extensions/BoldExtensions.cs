using MarkdownExtensions.Decorators.Formatting;
using MarkdownExtensions.Decorators.Variants;

namespace MarkdownExtensions.Decorators.Extensions
{
    public static partial class DecoratorExtensions
    {

        public static string AsBold(this string content,IDecorator boldDecorator)
        {
            var stringDecorator = boldDecorator;

            return string.Format("{0}{1}{2}",stringDecorator, content, stringDecorator);
        }
        
        public static string AsBold(this string content)
        {
            var decorator = new BoldStarredDecorator();

            return string.Format("{0}{1}{2}",decorator, content, decorator);
        }
        
        public static string AsBold(this string content,IDecorator boldDecorator,Position decoratorPosition = Position.Both)
        {
            var stringDecorator = boldDecorator;
            
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
        
        public static string AsBold(this string content,Position decoratorPosition = Position.Both)
        {
            var decorator = new BoldStarredDecorator();
            
            if (string.IsNullOrWhiteSpace(content)) return string.Empty;
            
            if (decoratorPosition == Position.Both)
            {
                return content.AsBold();    
            }
            else if (decoratorPosition == Position.LeftOnly)
            {
                return string.Format("{0}{1}", decorator, content);
            }
            else
            {
                return string.Format("{0}{1}",content, decorator);
            }
            
        }
        
    }
}