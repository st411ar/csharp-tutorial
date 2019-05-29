using System;

namespace SimpleFeedReader.ViewModels
{
    // <SnippetStarterViewModel>
    #nullable enable
    public class NewsStoryViewModel
    {
        public DateTimeOffset Published { get; set; }
        public string Title { get; set; }
        public string Uri { get; set; }
    }
    #nullable restore
    // </SnippetStarterViewModel>
}
