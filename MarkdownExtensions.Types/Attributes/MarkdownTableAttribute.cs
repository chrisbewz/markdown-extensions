using System;

namespace MarkdownExtensions.Types.Attributes;

[AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
public sealed class MarkdownTableAttribute : Attribute
{
    public MarkdownTableAttribute(){ }
}