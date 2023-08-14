namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownHeadingId
{
    int Level { get; }
    string Text { get; }
    string Id { get; }
}