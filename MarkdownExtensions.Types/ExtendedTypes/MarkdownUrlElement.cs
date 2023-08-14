using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

using System;
using System.Text.RegularExpressions;

public class MarkdownUrlElement : IMarkdownUrlElement
{
    private string _defaultPrefix = "https://";
    public bool DisableAutoLinking { get; set; }
    public bool AutoPrefix { get; }
    public string Content { get; private set; }

    public MarkdownUrlElement()
    {
        AutoPrefix = true;
        Content = string.Empty;
        DisableAutoLinking = false;
    }

    public MarkdownUrlElement(string content, bool disableAutoLinking = false, bool autoPrefix = false)
    {
        DisableAutoLinking = disableAutoLinking;
        AutoPrefix = autoPrefix;

        if (autoPrefix && !content.StartsWith(_defaultPrefix, StringComparison.OrdinalIgnoreCase))
        {
            Content = _defaultPrefix + content;
        }
        else
        {
            Content = content;
        }

        // Check if the default prefix exists in the content and remove it
        if (Content.StartsWith(_defaultPrefix, StringComparison.OrdinalIgnoreCase))
        {
            Content = Regex.Replace(Content, $"^{Regex.Escape(_defaultPrefix)}", "", RegexOptions.IgnoreCase);
        }
    }

    public void ToggleLinking()
    {
        DisableAutoLinking = !DisableAutoLinking;
        ReplaceLinkingDecorator();
    }

    private void ReplaceLinkingDecorator()
    {
        if (this.DisableAutoLinking)
        {
            this.Content = $"`{this.Content}`";
        }
        else
        {
            this.Content = this.Content.Replace("`", string.Empty);
        }
    }

    public override string ToString()
    {
        return Content;
    }
}
