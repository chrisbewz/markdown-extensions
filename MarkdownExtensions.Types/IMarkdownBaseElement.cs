namespace MarkdownExtensions.Types;

public interface IMarkdownBaseElement : IMarkdownElement
{
    MarkdownBaseElement BaseKind { get; }
}