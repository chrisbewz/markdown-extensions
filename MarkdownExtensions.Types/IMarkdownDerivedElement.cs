namespace MarkdownExtensions.Types;

public interface IMarkdownDerivedElement : IMarkdownElement
{
    public MarkdownDerivedElement NestedKind { get; }
}