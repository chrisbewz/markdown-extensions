namespace MarkdownExtensions.Decorators.Variants;

public sealed class StrikethroughDecorator
{
    private string _decorator = "~~";

    public override string ToString()
    {
        return this._decorator;
    }
}