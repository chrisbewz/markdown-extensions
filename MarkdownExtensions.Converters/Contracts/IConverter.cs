namespace MarkdownExtensions.Converters.Contracts;

public interface IConverter
{
    string Contents { get; }

    IConverter Convert();
}