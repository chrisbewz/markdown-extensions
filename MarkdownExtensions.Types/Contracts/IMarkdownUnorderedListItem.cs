using MarkdownExtensions.Types.BaseTypes;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownUnorderedListItem : IMarkdownLongTextElement
{
    MarkdownListBullet Bullet { get; set; }
    
    string Content { get; set; }
}