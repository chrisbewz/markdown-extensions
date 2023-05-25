namespace MarkdownExtensions.Types;

public interface IMarkdownLongTextElement : IMarkdownElement
{
    public string Content { get; set; }
}