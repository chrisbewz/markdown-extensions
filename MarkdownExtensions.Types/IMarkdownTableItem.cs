namespace MarkdownExtensions.Types;

public interface IMarkdownTableItem : IMarkdownTableElement
{
    public string ItemParsed { get; }
}