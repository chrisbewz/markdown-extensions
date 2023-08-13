using System.Text;
using MarkdownExtensions.Types.Contracts;

namespace MarkdownExtensions.Types.Implementations;

public class MarkdownImage : IMarkDownImage
{
    private MarkdownLink _imageLink;
    
    private string _imageAlt;
    
    private string _imagePath;
    
    private string _imageContent;
    
    private string _imageTitle;

    public void Construct()
    {
        switch (CheckImageLinkInternal())
        {
            case true:
                ConstructCompositeImageInternal();
                break;
            case false:
                ConstructSimpleImageInternal();
                break;
        }
    }

    private void ConstructSimpleImageInternal()
    {
        var parsedImage = new StringBuilder();

        if (!string.IsNullOrEmpty(this._imageTitle))
        {
            parsedImage.Append($"![{this._imageAlt}]({this._imagePath} '{this._imageTitle}')");
            this._imageContent = parsedImage.ToString();
            return;
        }
        
        parsedImage.Append($"[{this._imageAlt}]({this._imagePath})");
        this._imageContent = parsedImage.ToString();
        return;
    }

    private void ConstructCompositeImageInternal()
    {
        var parsedImage = new StringBuilder();

        if (!string.IsNullOrEmpty(this._imageTitle))
        {
            parsedImage.Append($"[![{this._imageAlt}]({this._imagePath} '{this._imageTitle}')]({this._imageLink.LinkAddress})]");
            this._imageContent = parsedImage.ToString();
            return;
        }
        
        parsedImage.Append($"[![{this._imageAlt}]({this._imagePath})]({this._imageLink.LinkAddress})]");
        this._imageContent = parsedImage.ToString();
        return;
    }

    private bool CheckImageLinkInternal()
    {
        var linkContent = this._imageLink;

        if (string.IsNullOrEmpty(linkContent.LinkAddress) & string.IsNullOrEmpty(linkContent.LinkAlias)) return false;

        if (string.IsNullOrEmpty(linkContent.LinkAddress) & !string.IsNullOrEmpty(linkContent.LinkAlias)) return false;
        
        return true;

    }

    public MarkdownImage(string imagePath,string caption)
    {
        this._imagePath = imagePath;
        this._imageAlt = caption;
        this._imageTitle = string.Empty;
        ImageLink = new MarkdownLink();
        Construct();
    }
    
    public MarkdownImage(string imagePath,string caption,string imageTitle)
    {
        this._imageTitle = imageTitle;
        this._imagePath = imagePath;
        this._imageAlt = caption;
        ImageLink = new MarkdownLink();
        Construct();
    }
    
    public MarkdownImage(string imagePath,string caption ,MarkdownLink link)
    {
        this._imageTitle = string.Empty;
        this._imagePath = imagePath;
        this._imageAlt = caption;
        ImageLink = link;
        Construct();
    }
    
    public MarkdownImage(string imagePath,string caption,string imageTitle ,MarkdownLink link)
    {
        this._imageTitle = imageTitle;
        this._imagePath = imagePath;
        this._imageAlt = caption;
        ImageLink = link;
        Construct();
    }

    public MarkdownLink ImageLink
    {
        get => _imageLink;
        set => _imageLink = value;
    }

    public string ImageAlt
    {
        get => _imageAlt;
        set => _imageAlt = value;
    }

    public string ImagePath
    {
        get => _imagePath;
        set => _imagePath = value;
    }

    public string ImageContent => _imageContent;

    public string ImageTitle
    {
        get => _imageTitle;
        set => _imageTitle = value;
    }

    public override string ToString()
    {
        return this._imageContent;
    }
}