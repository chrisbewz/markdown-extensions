namespace MarkdownExtensions.Types;

public interface IMarkdownTableElement : IMarkdownElement
{
    public string Content { get; }
    public int TableIndex { get; }
    public void SetIndex(int index);
    public void SetContent(string content);
    
}