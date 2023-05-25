namespace MarkdownExtensions.Types;

public interface IMarkdownBlockQuote : IMarkdownElement
{
    public string Quote { get; }
}