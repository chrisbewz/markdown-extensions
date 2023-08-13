namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownTableItem : IMarkdownTableElement
{
    public string ItemParsed { get; }
}