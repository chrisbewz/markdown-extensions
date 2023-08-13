using MarkdownExtensions.Types.BaseTypes;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownBaseElement : IMarkdownElement
{
    MarkdownBaseElement BaseKind { get; }
}