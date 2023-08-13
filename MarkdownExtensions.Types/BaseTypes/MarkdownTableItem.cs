using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.BaseTypes;

public class MarkdownTableItem : IMarkdownTableItem
{
    private string _content;
    
    private int _tableIndex;
    
    private string _itemParsed;

    public string Content => _content;

    public int TableIndex => _tableIndex;

    public string ItemParsed => _itemParsed;

    public MarkdownTableItem(string content, int tableIndex)
    {
        _content = content;
        _tableIndex = tableIndex;
        Construct();
    }

    public MarkdownTableItem()
    {
        _content = string.Empty;
        _tableIndex = default;
        Construct();
    }
    
    public void SetIndex(int index)
    {
        if (index != this._tableIndex) this._tableIndex = index;
    }

    public void SetContent(string content)
    {
        if (content != this._content) this._content = content;
    }

    public void Construct()
    {
        var tableItemBuilder = new StringBuilder();

        tableItemBuilder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        tableItemBuilder.Append(MarkdownConstants.BLK_SPACE_CHAR);
        tableItemBuilder.Append(this._content);
        tableItemBuilder.Append(MarkdownConstants.BLK_SPACE_CHAR);
        tableItemBuilder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);

        this._itemParsed = tableItemBuilder.ToString();
    }
}