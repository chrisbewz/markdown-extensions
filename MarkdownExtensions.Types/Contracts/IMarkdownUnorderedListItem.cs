using MarkdownExtensions.Types.Implementations;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownUnorderedListItem : IMarkdownLongTextElement
{
    MarkdownListBullet Bullet { get; set; }
    
    string Content { get; set; }
}