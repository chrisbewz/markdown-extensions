namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownLongTextElement : IMarkdownElement
{
    public string Content { get; set; }
}