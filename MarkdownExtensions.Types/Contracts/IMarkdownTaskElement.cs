namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownTaskElement : IMarkdownExtendedElement
{
    bool Checked { get; set; }
    string Task { get; }

    void Toggle();
}