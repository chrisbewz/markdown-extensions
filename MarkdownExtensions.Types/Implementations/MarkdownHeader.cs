using System;
using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Implementations;

public class MarkdownHeader : IMarkdownBaseElement,IMarkdownHeader
{
    private MarkdownBaseElement _baseKind;

    private int _headerLevel;
    
    private string _inlineHeaderContent;
    private string _headerContent;

    public MarkdownBaseElement BaseKind => _baseKind;
    public int HeaderLevel => _headerLevel;
    public string Content
    {
        get => _inlineHeaderContent;
        set => _inlineHeaderContent = value;
    }

    public MarkdownHeader()
    {
        this._inlineHeaderContent = "Default Header";
        this._headerLevel = 1;
        Construct();
    }

    public MarkdownHeader(int headerLevel)
    {
        this._inlineHeaderContent = "Default Header";
        _headerLevel = headerLevel;
        Construct();
    }
    
    public MarkdownHeader(int headerLevel,string inlineHeaderContent)
    {
        this._inlineHeaderContent = inlineHeaderContent;
        _headerLevel = headerLevel;
        Construct();
    }
    public void Construct()
    {
        this._baseKind = MarkdownBaseElement.Block;
        ConfigureContent();
    }
    private void ConfigureContent()
    {
        var headerParser = new StringBuilder();
        headerParser.Append(new string(MarkdownConstants.HEADER_MARKER, this._headerLevel));
        headerParser.Append(MarkdownConstants.BLK_SPACE_CHAR);
        headerParser.Append(this._inlineHeaderContent + Environment.NewLine);

        this._headerContent = headerParser.ToString();
    }

    public override string ToString()
    {
        return this._headerContent;
    }

    public string HeaderContent => _headerContent;
}