using MarkdownExtensions.Types.Implementations;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownBaseElement : IMarkdownElement
{
    MarkdownBaseElement BaseKind { get; }
}