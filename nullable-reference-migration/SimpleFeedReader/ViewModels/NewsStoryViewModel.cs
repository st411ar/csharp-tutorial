using System;

namespace SimpleFeedReader.ViewModels
{
    // <SnippetStarterViewModel>
    #nullable enable
    public class NewsStoryViewModel
    {
        public DateTimeOffset Published { get; set; }
        public string Title { get; set; } = default!;
        public string Uri { get; set; } = default!;
    }
    #nullable restore
    // </SnippetStarterViewModel>
}
