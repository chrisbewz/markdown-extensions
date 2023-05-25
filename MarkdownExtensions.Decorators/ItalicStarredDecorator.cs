namespace MarkdownExtensions.Decorators;

public class ItalicStarredDecorator : IDecorator
{
    private string _decorator;

    public string Decorator => _decorator;

    public ItalicStarredDecorator()
    {
        this._decorator = "*";
    }

    public override string ToString()
    {
        return this._decorator;
    }
}