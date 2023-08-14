using MarkdownExtensions.Types.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkdownExtensions.Types.ExtendedTypes;

class MarkdownDefinitionList : IMarkdownDefinitionList
{
    private List<(string Term, string Definition)> _items;

    public bool BoldTerms { get; }
    public IEnumerable<string> Terms => _items.Select(item => item.Term);
    public IEnumerable<string> Definitions => _items.Select(item => item.Definition);

    public MarkdownDefinitionList(bool boldTerms = true)
    {
        _items = new List<(string, string)>();
        BoldTerms = boldTerms;
    }

    public void AddItems(IEnumerable<string> terms, IEnumerable<string> definitions)
    {
        var termEnumerator = terms.GetEnumerator();
        var definitionEnumerator = definitions.GetEnumerator();

        while (termEnumerator.MoveNext() && definitionEnumerator.MoveNext())
        {
            _items.Add((termEnumerator.Current, definitionEnumerator.Current));
        }
    }

    public void AddItems(IEnumerable<string> terms)
    {
        foreach (var term in terms)
        {
            _items.Add((term, ""));
        }
    }

    public void AddDefinition(string term, string definition)
    {
        var existingItem = _items.FirstOrDefault(item => item.Term == term);

        if (existingItem != default)
        {
            _items.Remove(existingItem);
        }

        _items.Add((term, definition));
    }

    public void AddDefinition(int termIndex, string definition)
    {
        if (termIndex >= 0 && termIndex < _items.Count)
        {
            _items[termIndex] = (_items[termIndex].Term, definition);
        }
    }

    public override string ToString()
    {
        StringBuilder definitionList = new StringBuilder();

        foreach (var item in _items)
        {
            string term = BoldTerms ? $"**{item.Term}**" : item.Term;
            definitionList.AppendLine($"{term}\n{item.Definition}\n");
        }

        return definitionList.ToString();
    }
}

