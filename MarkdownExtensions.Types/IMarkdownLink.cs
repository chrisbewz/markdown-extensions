namespace MarkdownExtensions.Types;

public interface IMarkdownLink : IMarkdownElement
{
    public string LinkAddress { get; set; }
    
    public string LinkAlias { get; set; }
    
    public string Link { get; }
    
    public void SetLink(string newLink);

    public void SetLinkAlias(string newAlias);
}