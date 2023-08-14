using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.ExtendedTypes;

public class MarkdownHeadingId : IMarkdownHeadingId
{
    public int Level { get; }
    public string Text { get; }
    public string Id { get; }

    public MarkdownHeadingId(int level, string text, string id)
    {
        Level = level;
        Text = text;
        Id = id;
    }

    public override string ToString()
    {
        return $"###{new string('#', Level)} {Text} {{#{Id}}}";
    }
}
