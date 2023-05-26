using System;
using System.Collections.Generic;

namespace MarkdownExtensions.Types;

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