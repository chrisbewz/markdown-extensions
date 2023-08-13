using System.Collections.Generic;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Implementations;

public class MarkdownTableRow : IMarkdownTableRow
{
    private IEnumerable<MarkdownTableItem> _itemArray;

    public IEnumerable<MarkdownTableItem> ItemArray
    {
        get => _itemArray;
        set => _itemArray = value;
    }

    public MarkdownTableRow(IEnumerable<MarkdownTableItem> itemArray)
    {
        _itemArray = itemArray;
    }

    public MarkdownTableRow()
    {
        this._itemArray = new List<MarkdownTableItem>();
    }
}