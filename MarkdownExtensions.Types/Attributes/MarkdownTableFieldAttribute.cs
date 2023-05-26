using System;

namespace MarkdownExtensions.Types.Attributes;

[AttributeUsage(AttributeTargets.Property,AllowMultiple = false)]
public class MarkdownTableFieldAttribute : Attribute
{
    private string _fieldName;

    public MarkdownTableFieldAttribute(string fieldName)
    {
        _fieldName = fieldName;
    }

    public string Field => _fieldName;
}