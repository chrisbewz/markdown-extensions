using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Implementations;

public class MarkdownUnorderedList : IMarkdownElement
{
    private string _listContent;
    
    public MarkdownBaseElement Kind => MarkdownBaseElement.Block;

    public IEnumerable<MarkdownUnorderedListItem> InnerItems { get; set; }
    
    public MarkdownUnorderedList()
    {
        this.InnerItems = new List<MarkdownUnorderedListItem>();
        Construct();
    }

    public MarkdownUnorderedList(IEnumerable<MarkdownUnorderedListItem> innerItems)
    {
        InnerItems = innerItems;
        Construct();
    }
    
    public void Construct()
    {
        var contentLenght = this.InnerItems.Count();

        if (!(contentLenght > 0))
        {
            this._listContent = string.Empty;
        }
        else
        {
            BuildStructure();
        }
    }

    private void BuildStructure()
    {
        var parsedContent = new StringBuilder();

        foreach (var listItem in this.InnerItems)
        {
            parsedContent.Append(listItem.ToString());
        }

        this._listContent = parsedContent.ToString();
    }

    public string ListContent => _listContent;

    public override string ToString()
    {
        return this._listContent;
    }
}