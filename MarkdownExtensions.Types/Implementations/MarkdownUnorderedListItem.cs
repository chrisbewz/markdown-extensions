using System;
using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Implementations;

public class MarkdownUnorderedListItem : IMarkdownDerivedElement,IMarkdownUnorderedListItem
{
    private MarkdownDerivedElement _kind;
    
    private string _itemContent;
    
    private string _listItemContent;
    
    private MarkdownListBullet _bullet;

    public MarkdownDerivedElement NestedKind => MarkdownDerivedElement.ListItem;
    
    public MarkdownUnorderedListItem(string itemContent)
    {
        _itemContent = itemContent;
        _bullet = new MarkdownListBullet();
        Construct();
    }

    public MarkdownUnorderedListItem(string itemContent,MarkdownListBullet bullet)
    {
        _itemContent = itemContent;
        _bullet = bullet;
        Construct();
    }
    
    public void Construct()
    {
        var parsedContent = new StringBuilder();

        parsedContent.Append(MarkdownConstants.BLK_SPACE_CHAR);
        parsedContent.Append(this._bullet.ToString());
        parsedContent.Append(MarkdownConstants.BLK_SPACE_CHAR);
        parsedContent.Append(this._itemContent);
        parsedContent.Append(Environment.NewLine);

        this._listItemContent = parsedContent.ToString();
    }

    public MarkdownListBullet Bullet
    {
        get => _bullet;
        set => _bullet = value;
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