using System.Collections.Generic;

namespace MarkdownExtensions.Types;

public interface IMarkdownTableRow
{
    public IEnumerable<MarkdownTableItem> ItemArray { get; set; }
}