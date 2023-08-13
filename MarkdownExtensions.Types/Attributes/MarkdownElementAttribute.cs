using System;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Attributes;

[AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
public class MarkdownElementAttribute : Attribute
{
    private IMarkdownElement _elementKind;
    
    public MarkdownElementAttribute(IMarkdownElement kind)
    {
        this._elementKind = kind;
    }

    public IMarkdownElement ElementKind => _elementKind;
}