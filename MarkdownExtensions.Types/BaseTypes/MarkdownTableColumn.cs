using System;
using System.Text;
using MarkdownExtensions.Types.Contracts;
using MarkdownExtensions.Types.Enumerations;

namespace MarkdownExtensions.Types.BaseTypes;

public class MarkdownTableColumn : IMarkdownTableColumn
{
    private string _content;

    private readonly int _defaultLenght = 10;
    
    private int _tableIndex;
    
    private int _columnLenght;
    
    private string _columnAlias;
    
    private TableColumnAlignment _contentAlignment;
    
    private string _columnParsed;

    public string Content => _content;

    public int TableIndex => _tableIndex;
    
    public void SetIndex(int index)
    {
        if (index != this._tableIndex) this._tableIndex = index;
    }

    public void SetContent(string content)
    {
        if (content != this._content) this._content = content;
    }

    public int ColumnLenght
    {
        get => _columnLenght;
        set => _columnLenght = value;
    }

    public string ColumnAlias
    {
        get => _columnAlias;
        set => _columnAlias = value;
    }

    public MarkdownTableColumn()
    {
        this._columnAlias = "default";
        this._columnLenght = this._defaultLenght;
        this._content = String.Empty;
        this._contentAlignment = TableColumnAlignment.Centered;
        this._tableIndex = default;
        Construct();
    }

    public MarkdownTableColumn(string columnAlias,string content)
    {
        this._columnAlias = columnAlias;
        this._content = content;
        this._columnLenght = this._defaultLenght;
        this._tableIndex = default;
        Construct();
    }

    public MarkdownTableColumn(string content, int defaultLenght, int tableIndex, int columnLenght, string columnAlias)
    {
        this._content = content;
        this._defaultLenght = defaultLenght;
        this._tableIndex = tableIndex;
        this._columnLenght = columnLenght;
        this._columnAlias = columnAlias;
        this._contentAlignment = TableColumnAlignment.Centered;
        Construct();
    }

    public MarkdownTableColumn(string content, int defaultLenght, int tableIndex, int columnLenght, string columnAlias, TableColumnAlignment contentAlignment)
    {
        this._content = content;
        this._defaultLenght = defaultLenght;
        this._tableIndex = tableIndex;
        this._columnLenght = columnLenght;
        this._columnAlias = columnAlias;
        this._contentAlignment = contentAlignment;
        Construct();
    }
    
    public TableColumnAlignment ContentAlignment => _contentAlignment;

    public string ColumnParsed => _columnParsed;

    public void Construct()
    {
        string lenghtHeader = this.BuildColumnStructure();

        var contentBuilder = new StringBuilder();
        
        contentBuilder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        contentBuilder.Append(MarkdownConstants.BLK_SPACE_CHAR);
        contentBuilder.Append(this._content);
        contentBuilder.Append(MarkdownConstants.BLK_SPACE_CHAR);
        contentBuilder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        contentBuilder.Append(Environment.NewLine);
        
        this._columnParsed = contentBuilder.ToString();
    }

    public string BuildColumnStructure()
    {
        var columnLenghtBuilder = new StringBuilder();
        
        columnLenghtBuilder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        columnLenghtBuilder.Append(MarkdownConstants.BLK_SPACE_CHAR);
        columnLenghtBuilder.Append(MarkdownConstants.TBL_ALIGN_WILDCARD);
        columnLenghtBuilder.Append(new string(MarkdownConstants.TBL_LENGHT_WILDCARD,this._columnLenght));
        columnLenghtBuilder.Append(MarkdownConstants.TBL_ALIGN_WILDCARD);
        columnLenghtBuilder.Append(MarkdownConstants.BLK_SPACE_CHAR);
        columnLenghtBuilder.Append(MarkdownConstants.TBL_DELIMITER_WILDCARD);
        columnLenghtBuilder.Append(Environment.NewLine);

        return columnLenghtBuilder.ToString();
    }

    public override string ToString()
    {
        return this._columnParsed;
    }
}