namespace MarkdownExtensions.Types;

public interface IMarkdownListBullet : IMarkdownElement
{
    ListBulletKind BulletKind { get; }
    
    public char BulletContent { get; set; }
}