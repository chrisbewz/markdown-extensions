namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownEmoji : IMarkdownExtendedElement
{
    string Name { get; }
}