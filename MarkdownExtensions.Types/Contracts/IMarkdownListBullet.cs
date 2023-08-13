using MarkdownExtensions.Types.Enumerations;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownListBullet : IMarkdownElement
{
    ListBulletKind BulletKind { get; }
    
    public char BulletContent { get; set; }
}