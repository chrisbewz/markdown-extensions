using System;
using System.Text;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownCodeBlock
{
    private string _language;

    private string _languageContent;

    public MarkdownCodeBlock()
    {
        this._language = string.Empty;
        this._languageContent = String.Empty;
    }

    public override string ToString()
    {
        var content = new StringBuilder();
        content.AppendLine(string.Format("```{0}",this._language));
        content.AppendLine(this._languageContent);
        content.AppendLine("´´´");

        return content.ToString();
    }
}