using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownEmoji : IMarkdownExtendedElement
{
    public string EmojiName { get; }

    public MarkdownEmoji(string emojiName)
    {
        EmojiName = emojiName;
    }

    public override string ToString()
    {
        return $":{EmojiName}:";
    }
}
