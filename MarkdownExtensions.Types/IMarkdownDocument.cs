namespace MarkdownExtensions.Types;

public interface IMarkdownDocumentContainer
{
    public DocumentSettings Metadata { get; set; }

    void ComposeDocument(IMarkdownContentContainer contents);
}