using System;
using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Implementations;

public class MarkdownOrderedListItem : IMarkdownDerivedElement,IMarkdownOrderedListItem
{
    private MarkdownDerivedElement _nestedKind;
    
    private string _listItemContent;
    
    private int _index;

    public void Construct()
    {
        var parsedContent = new StringBuilder();

        parsedContent.Append(MarkdownConstants.BLK_SPACE_CHAR);
        parsedContent.Append(this._index);
        parsedContent.Append(".");
        parsedContent.Append(MarkdownConstants.BLK_SPACE_CHAR);
        parsedContent.Append(this._listItemContent);
        parsedContent.Append(Environment.NewLine);

        this._listItemContent = parsedContent.ToString();
    }

    public MarkdownOrderedListItem()
    {
        this._listItemContent = string.Empty;
        Construct();
    }
    
    public MarkdownOrderedListItem(int index)
    {
        this.Index = index;
        this._listItemContent = string.Empty;
        Construct();
    }
    
    public MarkdownOrderedListItem(int index,string content)
    {
        this.Index = index;
        this._listItemContent = content;
        Construct();
    }
    
    public MarkdownDerivedElement NestedKind => MarkdownDerivedElement.ListItem;

    public int Index
    {
        get => _index;
        set => _index = value;
    }

    public string Content
    {
        get => _listItemContent;
        set => _listItemContent = value;
    }

    public override string ToString()
    {
        return this._listItemContent;
    }
}