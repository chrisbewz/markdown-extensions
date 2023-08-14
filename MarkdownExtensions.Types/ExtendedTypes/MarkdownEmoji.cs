using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownEmoji : IMarkdownEmoji
{
    public string Name { get; }

    public MarkdownEmoji(string emojiName)
    {
        Name = emojiName;
    }

    public override string ToString()
    {
        return $":{Name}:";
    }
}