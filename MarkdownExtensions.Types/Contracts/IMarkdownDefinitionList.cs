using System.Collections.Generic;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkdownDefinitionList : IMarkdownExtendedElement
{
    bool BoldTerms { get; }
    IEnumerable<string> Terms { get; }
    IEnumerable<string> Definitions { get; }

    void AddItems(IEnumerable<string> terms, IEnumerable<string> definitions);
    void AddItems(IEnumerable<string> terms);
    void AddDefinition(string term, string definition);
    void AddDefinition(int termIndex, string definition);
}