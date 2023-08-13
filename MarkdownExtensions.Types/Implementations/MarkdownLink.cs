using System;
using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Implementations;

public class MarkdownLink: IMarkdownLink
{
    private string _linkAddress;
    
    private string _linkAlias;
    
    private string _link;

    public void Construct()
    {
        var parsedLink = new StringBuilder();

        parsedLink.Append($"[{this._linkAlias}]({this._linkAddress})");
        
        this._link = parsedLink.ToString();
    }

    public MarkdownLink()
    {
        this._linkAlias = String.Empty;
        this._linkAddress = String.Empty;
        Construct();
    }
    
    public MarkdownLink(string linkAddress,string linkAlias)
    {
        this._linkAlias = linkAlias;
        this._linkAddress = linkAddress;
        Construct();
    }

    public string LinkAddress
    {
        get => _linkAddress;
        set => _linkAddress = value;
    }

    public string LinkAlias
    {
        get => _linkAlias;
        set => _linkAlias = value;
    }

    public string Link => _link;

    public void SetLink(string newLink)
    {
        this._link = GenerateLinkInternal(newLink,this._linkAlias);
    }

    public void SetLinkAlias(string newAlias)
    {
        this._link = GenerateLinkInternal(this._linkAddress,newAlias);
    }

    private string GenerateLinkInternal(string newLink,string newAlias)
    {
        var parsedLink = new StringBuilder();

        parsedLink.Append($"[{newAlias}]({newLink})");
        
        return parsedLink.ToString();
    }

    public override string ToString()
    {
        return this._link;
    }
}