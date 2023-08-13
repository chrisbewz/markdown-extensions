using System.Collections.Generic;
using MarkdownExtensions.Types.BaseTypes;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownTableRow
{
    public IEnumerable<MarkdownTableItem> ItemArray { get; set; }
}