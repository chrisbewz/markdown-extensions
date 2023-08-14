using System;
using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

using System.Text;

public class MarkdownCodeBlock : IMarkdownExtendedElement
{
    public string Code { get; }
    public string Language { get; }

    public MarkdownCodeBlock(string code, string language = "")
    {
        Code = code;
        Language = language;
    }

    public override string ToString()
    {
        StringBuilder codeBlock = new StringBuilder();
        
        if (!string.IsNullOrWhiteSpace(Language))
        {
            codeBlock.AppendLine($"```{Language}");
        }
        else
        {
            codeBlock.AppendLine("```");
        }
        
        codeBlock.AppendLine(Code);
        codeBlock.AppendLine("```");

        return codeBlock.ToString();
    }
}
