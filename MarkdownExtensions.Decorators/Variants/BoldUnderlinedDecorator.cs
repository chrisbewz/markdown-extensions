namespace MarkdownExtensions.Decorators.Variants;

public sealed class BoldUnderlinedDecorator : IDecorator
{
    private string _decorator = "__";

    public override string ToString()
    {
        return this._decorator;
    }
}