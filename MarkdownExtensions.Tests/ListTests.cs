using System;
using System.Collections.Generic;
using MarkdownExtensions.Types;
using Xunit;

namespace MarkdownExtensions.Tests
{
    public class ListTests
    {
        [Fact]
        public void SimpleUnorderedListSetupTest()
        {
            List<MarkdownUnorderedListItem> items = new List<MarkdownUnorderedListItem>();

            items.Add(new MarkdownUnorderedListItem("bla"));
            items.Add(new MarkdownUnorderedListItem("blabla"));
            items.Add(new MarkdownUnorderedListItem("blablabla"));
            items.Add(new MarkdownUnorderedListItem("blablablabla"));

            var markdownUnorderedList = new MarkdownUnorderedList(items);

            var list = markdownUnorderedList.ToString();
            var expectedListString = " - bla" + Environment.NewLine
                                               + " - blabla" + Environment.NewLine
                                               + " - blablabla" + Environment.NewLine
                                               + " - blablablabla" + Environment.NewLine;
            
            Assert.True(markdownUnorderedList.ToString().Equals(expectedListString));
        }
        [Fact]
        public void SimpleOrderedListSetupTest()
        {
            List<MarkdownOrderedListItem> items = new List<MarkdownOrderedListItem>();

            items.Add(new MarkdownOrderedListItem(0,"bla"));
            items.Add(new MarkdownOrderedListItem(1,"blabla"));
            items.Add(new MarkdownOrderedListItem(2,"blablabla"));
            items.Add(new MarkdownOrderedListItem(3,"blablablabla"));

            var markdownOrderedList = new MarkdownOrderedList(items);
            var list = markdownOrderedList.ToString();
            
            var expectedListString = " 0. bla" + Environment.NewLine
                                               + " 1. blabla" + Environment.NewLine
                                               + " 2. blablabla" + Environment.NewLine
                                               + " 3. blablablabla" + Environment.NewLine;
            
            Assert.True(markdownOrderedList.ToString().Equals(expectedListString));

        }
    }
}