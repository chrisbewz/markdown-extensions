namespace MarkdownExtensions.Decorators.Variants;

public sealed class SubscriptDecorator : IDecorator
{
    private string _decorator = "~";

    public override string ToString()
    {
        return this._decorator;
    }
}