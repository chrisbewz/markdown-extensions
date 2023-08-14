namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownUrlElement : IMarkdownExtendedElement
{
    bool DisableAutoLinking { get; set; }
    bool AutoPrefix { get; }
    string Content { get; }
    void ToggleLinking();
}