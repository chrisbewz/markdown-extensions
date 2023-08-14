namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownCodeBlock : IMarkdownExtendedElement
{
    string Code { get; }
    string Language { get; }
}