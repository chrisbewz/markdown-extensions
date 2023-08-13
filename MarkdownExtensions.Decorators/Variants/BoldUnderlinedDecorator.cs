namespace MarkdownExtensions.Decorators.Variants;

public class BoldUnderlinedDecorator : IDecorator
{
    private string _decorator;

    public string Decorator => _decorator;

    public BoldUnderlinedDecorator()
    {
        this._decorator = "__";
    }

    public override string ToString()
    {
        return this._decorator;
    }
}