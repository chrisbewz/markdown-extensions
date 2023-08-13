namespace MarkdownExtensions.Decorators.Variants;

public sealed class ItalicStarredDecorator : IDecorator
{
    private string _decorator = "*";

    public override string ToString()
    {
        return this._decorator;
    }
}