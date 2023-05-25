using System;
using MarkdownExtensions.Types;
using Xunit;

namespace MarkdownExtensions.Tests
{
    public class HeaderTests
    {
        [Fact]
        public void DefaultHeaderSetupTest()
        {
            var header = new MarkdownHeader();
            var expectedHeader = "# Default Header" + Environment.NewLine;
            Assert.True(header.ToString().Equals(expectedHeader));
        }
        
        [Fact]
        public void SimpleContentHeaderSetupTest()
        {
            var testString = "Hello Header";
            var header = new MarkdownHeader(5,testString);
            var expectedHeader = $"##### {testString}{Environment.NewLine}";
            Assert.True(header.ToString().Equals(expectedHeader));
        }
        
        [Fact]
        public void MultipleLevelHeaderSetupTest()
        {
            var header = new MarkdownHeader(5);
            var expectedHeader = $"##### Default Header{Environment.NewLine}";
            Assert.True(header.ToString().Equals(expectedHeader));
        }
    }
}