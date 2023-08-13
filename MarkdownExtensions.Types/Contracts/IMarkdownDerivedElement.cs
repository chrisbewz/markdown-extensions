using MarkdownExtensions.Types.Implementations;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownDerivedElement : IMarkdownElement
{
    public MarkdownDerivedElement NestedKind { get; }
}