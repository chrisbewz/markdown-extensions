using System.Collections.Generic;
using MarkdownExtensions.Types.BaseTypes;
using MarkdownExtensions.Types.Enumerations;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownTable : IMarkdownElement
{
    public string TableName { get;}
    IEnumerable<MarkdownTableColumn> Columns { get; }
    IEnumerable<MarkdownTableRow> Rows { get; }
    public int TableLenght { get; }
    public void AppendRow(IMarkdownTableRow row);
    public void AppendRowAt(int index);
    public void DeleteRow(int rowIndex);
    public void SetName(string newName);
    public int RowsCount();
    public IEnumerable<MarkdownTableColumn> GetColums();
    public ColumnsLenghtType ColumnFormat { get; }
    
    public string Table { get; }
    
}