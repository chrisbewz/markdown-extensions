using MarkdownExtensions.Types.BaseTypes;

namespace MarkdownExtensions.Types.Contracts;

public interface IMarkDownImage : IMarkdownElement
{
    public MarkdownLink ImageLink { get; set; }
    
    public string ImageAlt { get; set; }
    
    public string ImagePath { get; set; }
    
    public string ImageContent { get; }
    
    public string ImageTitle { get; set; }
}