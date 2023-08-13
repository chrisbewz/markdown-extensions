using System.IO;
using MarkdownExtensions.Types;
using MarkdownExtensions.Types.Implementations;
using Xunit;

namespace MarkdownExtensions.Tests
{
    public class ImageTests
    {
        [Fact]
        public void SimpleImageSetupTest()
        {
            string imageCaption = "foo-caption";
            string imagePath = "phi-test-path";
            var markdownImage = new MarkdownImage(imagePath,imageCaption);
            var expectedImage = $"[{imageCaption}]({imagePath})";
            Assert.True(markdownImage.ToString().Equals(expectedImage));
        }
        
        [Fact]
        public void SimpleImageWithTitleSetupTest()
        {
            string imageCaption = "foo-caption";
            string imagePath = "phi-test-path";
            string imageTitle = "a simple title";
            
            var markdownImage = new MarkdownImage(imagePath,imageCaption,imageTitle:imageTitle);
            var expectedImage = $"![{imageCaption}]({imagePath} '{imageTitle}')";
            
            Assert.True(markdownImage.ToString().Equals(expectedImage));
        }
        
        [Fact]
        public void CompleteImageLinkSetupTest()
        {
            string imageCaption = "foo-caption";
            string imageTitle = "a simple title";
            string defAdd = "default-link-add";
            string defAll = "default-link-all";
            var imageLink = new MarkdownLink(defAdd, defAll);
            string imagePath = "phi-test-path";
            
            var markdownImage = new MarkdownImage(imagePath,imageCaption,imageTitle,imageLink);
            var expectedImage = $"[![{imageCaption}]({imagePath} '{imageTitle}')]({imageLink.LinkAddress})]";
            Assert.True(markdownImage.ToString().Equals(expectedImage));
        }
        
        [Fact]
        public void MissingTitleImageLinkSetupTest()
        {
            string imageCaption = "foo-caption";
            string imageTitle = "a simple title";
            string defAdd = "default-link-add";
            string defAll = "default-link-all";
            var imageLink = new MarkdownLink(defAdd, defAll);
            string imagePath = "phi-test-path";
            
            var markdownImage = new MarkdownImage(imagePath,imageCaption,imageLink);
            var expectedImage = $"[![{imageCaption}]({imagePath})]({imageLink.LinkAddress})]";
            
            Assert.True(markdownImage.ToString().Equals(expectedImage));
        }
    }
}