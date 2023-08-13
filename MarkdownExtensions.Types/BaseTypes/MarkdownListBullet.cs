using MarkdownExtensions.Types.Contracts;
using MarkdownExtensions.Types.Enumerations;

namespace MarkdownExtensions.Types.BaseTypes;

public class MarkdownListBullet : IMarkdownListBullet
{
    private ListBulletKind _bulletKind;
    
    private char _bulletContent;

    public void Construct()
    {
        switch (this._bulletKind)
        {
            case ListBulletKind.Default:
                this._bulletContent = '-';
                break;
            case ListBulletKind.Star:
                this._bulletContent = '*';
                break;
            default:
                this._bulletContent = '-';
                break;
        }
    }

    public MarkdownListBullet()
    {
        this._bulletKind = ListBulletKind.Default;
        Construct();
    }
    
    public MarkdownListBullet(ListBulletKind bulletKind)
    {
        _bulletKind = bulletKind;
        Construct();
    }

    public ListBulletKind BulletKind => _bulletKind;

    public char BulletContent
    {
        get => _bulletContent;
        set => _bulletContent = value;
    }

    public override string ToString()
    {
        return (this._bulletContent).ToString();
    }
}