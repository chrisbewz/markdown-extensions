﻿using MarkdownExtensions.Types;
using MarkdownExtensions.Types.BaseTypes;
using Xunit;

namespace MarkdownExtensions.Tests
{
    
    public class BlockQuoteTestsap
    {
        [Fact]
        public void SimplebBlockquoteTest()
        {
            var markdownBlockQuote = new MarkdownBlockQuote();
            var expectedQuote = "> ";
            
            Assert.True(markdownBlockQuote.ToString().Equals(expectedQuote));
        }
    }
}