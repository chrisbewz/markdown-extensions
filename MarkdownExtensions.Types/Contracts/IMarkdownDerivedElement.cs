using MarkdownExtensions.Types.BaseTypes;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownDerivedElement : IMarkdownElement
{
    public MarkdownDerivedElement NestedKind { get; }
}