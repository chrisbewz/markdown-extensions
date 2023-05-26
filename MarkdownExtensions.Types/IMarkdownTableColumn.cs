namespace MarkdownExtensions.Types;

public interface IMarkdownTableColumn : IMarkdownTableElement
{
    public int ColumnLenght { get; set; }
    
    public string ColumnAlias { get; set; }
    
    public TableColumnAlignment ContentAlignment { get; }
    
    public string ColumnParsed { get; }
    

}