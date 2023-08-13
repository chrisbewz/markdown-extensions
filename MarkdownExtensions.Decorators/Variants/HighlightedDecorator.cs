namespace MarkdownExtensions.Decorators.Variants;

public sealed class HighlightedDecorator : IDecorator
{
    private string _decorator = "==";

    public override string ToString()
    {
        return this._decorator;
    }
}