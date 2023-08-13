using System.Collections.Generic;
using MarkdownExtensions.Types.Implementations;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownTableRow
{
    public IEnumerable<MarkdownTableItem> ItemArray { get; set; }
}