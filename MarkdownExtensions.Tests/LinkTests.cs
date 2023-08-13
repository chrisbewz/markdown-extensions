using System;
using MarkdownExtensions.Types;
using MarkdownExtensions.Types.Implementations;
using Xunit;

namespace MarkdownExtensions.Tests
{
    public class LinkTests
    {
        [Fact]
        public void SimpleLinkSetupTest()
        {
            string linkall = "default";
            string linkadd = "default-content";
            
            var link = new MarkdownLink();
            var expectedLink = $"[]()";
            Assert.True(link.ToString().Equals(expectedLink));
        }
        
        [Fact]
        public void CompleteLinkSetupTest()
        {
            string linkall = "foo-link";
            string linkadd = "bar-content";
            
            var link = new MarkdownLink(linkAddress:linkadd,linkAlias:linkall);
            var expectedLink = $"[{linkall}]({linkadd})";
            Assert.True(link.ToString().Equals(expectedLink));
        }
    }
}