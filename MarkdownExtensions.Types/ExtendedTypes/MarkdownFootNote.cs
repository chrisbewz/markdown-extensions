using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownFootnote : IMarkdownExtendedElement
{
    public int FootnoteNumber { get; }
    public string FootnoteText { get; }

    public MarkdownFootnote(int footnoteNumber, string footnoteText)
    {
        FootnoteNumber = footnoteNumber;
        FootnoteText = footnoteText;
    }

    public override string ToString()
    {
        return $"[^{FootnoteNumber}]: {FootnoteText}";
    }
}
