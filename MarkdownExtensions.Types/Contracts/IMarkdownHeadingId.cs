namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownHeadingId : IMarkdownExtendedElement
{
    int Level { get; }
    string Text { get; }
    string Id { get; }
}