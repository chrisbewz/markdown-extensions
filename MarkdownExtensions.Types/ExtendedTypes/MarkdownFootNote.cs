using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownFootNote : IMarkdownFootNote
{
    public int FootnoteNumber { get; }
    public string FootnoteText { get; }

    public MarkdownFootNote(int footnoteNumber, string footnoteText)
    {
        FootnoteNumber = footnoteNumber;
        FootnoteText = footnoteText;
    }

    public override string ToString()
    {
        return $"[^{FootnoteNumber}]: {FootnoteText}";
    }
}