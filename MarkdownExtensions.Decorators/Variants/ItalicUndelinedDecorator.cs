namespace MarkdownExtensions.Decorators.Variants;

public class ItalicUndelinedDecorator : IDecorator
{
    private string _decorator;

    public string Decorator => _decorator;

    public ItalicUndelinedDecorator()
    {
        this._decorator = "_";
    }

    public override string ToString()
    {
        return this._decorator;
    }
}