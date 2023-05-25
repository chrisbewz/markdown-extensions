namespace MarkdownExtensions.Types;

public class MarkdownBlockQuote : IMarkdownBlockQuote
{
    private string _quote;

    public void Construct()
    {
        this._quote = ">";
    }
    
    public string Quote => _quote;

    public override string ToString()
    {
        return this._quote + MarkdownConstants.BLK_SPACE_CHAR;
    }
}