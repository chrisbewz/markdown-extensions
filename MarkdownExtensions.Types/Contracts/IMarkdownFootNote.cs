namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownFootNote : IMarkdownExtendedElement
{
    int FootnoteNumber { get; }
    string FootnoteText { get; }
}