namespace MarkdownExtensions.Types;

public interface IMarkdownUnorderedListItem : IMarkdownLongTextElement
{
    MarkdownListBullet Bullet { get; set; }
    
    string Content { get; set; }
}