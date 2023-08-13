namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownOrderedListItem : IMarkdownLongTextElement
{
    int Index { get; set; }
    
    string Content { get; set; }
}