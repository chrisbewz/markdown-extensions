using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MarkdownExtensions.Types.Contracts;
using MarkdownExtensions.Types.Enumerations;

namespace MarkdownExtensions.Types.BaseTypes;

public class MarkdownTable : IMarkdownTable,IEqualityComparer<MarkdownTableRow>
{
    private string _tableName;
    private IEnumerable<MarkdownTableColumn> _columns;
    private IEnumerable<MarkdownTableRow> _rows;
    private int _tableLenght;
    private ColumnsLenghtType _columnFormat;
    private string _table;

    public string TableName => _tableName;

    public IEnumerable<MarkdownTableColumn> Columns => _columns;

    public IEnumerable<MarkdownTableRow> Rows => _rows;

    public int TableLenght => _tableLenght;
    
    public void AppendRow(IMarkdownTableRow row)
    {
        this._rows.Append(row);
    }
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void AppendRowAt(int index)
    {
        
    }
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void DeleteRow(int rowIndex)
    {
        if (Enumerable.Range(0, this._rows.Count() - 1).Contains(rowIndex)) throw new ArgumentOutOfRangeException("The index specified does not exists in rows enumerable");

    }

    public void SetName(string newName)
    {
        this._tableName = newName;
    }

    public int RowsCount()
    {
        return this._rows.Count();
    }

    public IEnumerable<MarkdownTableColumn> GetColums()
    {
        return this._columns?.AsEnumerable();
    }

    public ColumnsLenghtType ColumnFormat => _columnFormat;

    public string Table => _table;
    private void SetupDefaults()
    {
        this._columns = new List<MarkdownTableColumn>();
        _columnFormat = ColumnsLenghtType.UniformLenght;
        this._rows = new List<MarkdownTableRow>();
    }
    
    public MarkdownTable(string tableName)
    {
        this._tableName = tableName;
        SetupDefaults();
    }

    public MarkdownTable(string tableName, IEnumerable<MarkdownTableColumn> columns, IEnumerable<MarkdownTableRow> rows,ColumnsLenghtType columnFormat = ColumnsLenghtType.UniformLenght)
    {
        _columnFormat = columnFormat;
        _tableName = tableName;
        _columns = columns;
        _rows = rows;
        Construct();
    }
    
    public MarkdownTable(string tableName, IEnumerable<MarkdownTableColumn> columns,ColumnsLenghtType columnFormat = ColumnsLenghtType.UniformLenght)
    {
        _columnFormat = columnFormat;
        _tableName = tableName;
        _columns = columns;
        Construct();
    }

    public bool Equals(MarkdownTableRow x, MarkdownTableRow y)
    {
        return x == y;
    }

    public int GetHashCode(MarkdownTableRow obj)
    {
        return obj.GetHashCode();
    }

    private void RefreshIndexesInternal()
    {
        
    }
    
    public void Construct()
    {
        var tableCotnentBuilder = new StringBuilder();
        tableCotnentBuilder.Append(BuildHeaderStructureInternal());
        this._table = tableCotnentBuilder.Append(BuildRowsStructureInternal()).ToString();
    }

    private string BuildHeaderStructureInternal()
    {
        var headerContent = new StringBuilder();
        
        var rowSpan = new Span<MarkdownTableColumn>(this._columns.ToArray());
        
        for (int i = 0; i < rowSpan.Length; i++)
        {
            if (i == 0)
            {
                headerContent.Append(rowSpan[i].ColumnParsed);
                continue;
            }
            if (i == (rowSpan.Length - 1))
            {
                headerContent.Append(rowSpan[i].ColumnParsed.Replace(MarkdownConstants.TBL_DELIMITER_WILDCARD.ToString(),string.Empty)); 
                headerContent.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
                headerContent.Append(Environment.NewLine);
                continue;
            }
            var minLenght = rowSpan[i].ColumnParsed;
        }
        return headerContent.ToString();
    }

    private string BuildRowsStructureInternal()
    {
        var rowsParsed = new StringBuilder();

        Span<MarkdownTableRow> rowsSpan = this._rows.ToArray();

        for (int i = 0; i < rowsSpan.Length; i++)
        {
            rowsParsed.Append(BuildRowFromItemSetDataInternal(rowsSpan[i]));
        }

        return rowsParsed.ToString();
    }

    private string BuildRowFromItemSetDataInternal(MarkdownTableRow row)
    {
        var rowContentBuilder = new StringBuilder();

        switch (this._columnFormat)
        {
            case ColumnsLenghtType.UniformLenght:
                rowContentBuilder.Append(BuildUniformContentRowInternal(row));
                break;

            case ColumnsLenghtType.Independent:
                rowContentBuilder.Append(BuildContentAwareRowInternal(row));
                break;

            default:
                rowContentBuilder.Append(BuildUniformContentRowInternal(row));
                break;
        }

        return rowContentBuilder.ToString();
    }
    private string BuildUniformContentRowInternal(MarkdownTableRow row)
    {
        var content = new StringBuilder();
        
        var rowSpan = new Span<MarkdownTableItem>(row.ItemArray.ToArray());
        
        for (int i = 0; i < rowSpan.Length; i++)
        {
            string initial = string.Empty;
            var columnLenght = (this._columns.ElementAt(i) as MarkdownTableColumn).ColumnLenght;
            var desiredLenght = (columnLenght > rowSpan[i].ItemParsed.Length) 
                ?  columnLenght
                : rowSpan[i].ItemParsed.Length;

            this._columns.ElementAt(i).ColumnLenght = desiredLenght;

            initial = ((desiredLenght % 2) == 0)
                ? PadItemUniform(rowSpan[i], columnLenght)
                : PadItemLeft(rowSpan[i], columnLenght);

            if (i == 0)
            {
                content.Append(initial);
                continue;
            }
            
            if (i == (rowSpan.Length - 1))
            {
                content.Append(initial.Replace(MarkdownConstants.TBL_DELIMITER_WILDCARD.ToString(),string.Empty)); 
                content.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
                content.Append(Environment.NewLine);
                continue;
            }

        }

        return content.ToString();
    }

    private string PadItemLeft(MarkdownTableItem item,int paddingCount)
    {
        var builder = new StringBuilder();
        builder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        builder.Append(new string(MarkdownConstants.BLK_SPACE_CHAR, paddingCount));
        builder.Append(item.Content);
        builder.Append(MarkdownConstants.BLK_SPACE_CHAR);
        builder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);

        return builder.ToString();
    }

    private string PadItemUniform(MarkdownTableItem item, int paddingCount)
    {
        int minPadding = 1;
        var builder = new StringBuilder();
        
        int padCount =((paddingCount % 2) == 0 & paddingCount >= 2 ) 
            ? paddingCount / 2
            : minPadding ;
        
        builder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        builder.Append(new string(MarkdownConstants.BLK_SPACE_CHAR, padCount));
        builder.Append(item.Content);
        builder.Append(new string(MarkdownConstants.BLK_SPACE_CHAR, padCount));
        builder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        
        return builder.ToString();
    }

    private string BuildContentAwareRowInternal(MarkdownTableRow row)
    {
        var content = new StringBuilder();
        
        var rowSpan = new Span<MarkdownTableItem>(row.ItemArray.ToArray());
        
        for (int i = 0; i < rowSpan.Length; i++)
        {
            if (i == 0)
            {
                content.Append(rowSpan[i].ItemParsed);
                continue;
            }
            if (i == (rowSpan.Length - 1))
            {
                content.Append(rowSpan[i].ItemParsed.Replace(MarkdownConstants.TBL_DELIMITER_WILDCARD.ToString(),string.Empty)); 
                content.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
                content.Append(Environment.NewLine);
                continue;
            }
            var minLenght = rowSpan[i].ItemParsed;
        }
        return content.ToString();
    }

    public override string ToString()
    {
        return this._table;
    }
}