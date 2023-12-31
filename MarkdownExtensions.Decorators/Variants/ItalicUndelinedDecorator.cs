﻿namespace MarkdownExtensions.Decorators.Variants;

public sealed class ItalicUndelinedDecorator : IDecorator
{
    private string _decorator = "_";

    public override string ToString()
    {
        return this._decorator;
    }
}