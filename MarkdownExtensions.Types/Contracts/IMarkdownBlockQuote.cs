namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownBlockQuote : IMarkdownElement
{
    public string Quote { get; }
}