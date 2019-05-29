using System;

namespace SimpleFeedReader.ViewModels
{
    // <SnippetStarterViewModel>
    #nullable enable
    public class NewsStoryViewModel
    {
        public DateTimeOffset Published { get; }
        public string Title { get; }
        public string Uri { get; }

        public NewsStoryViewModel(DateTimeOffset published, string title, string uri) =>
            (Published, Title, Uri) = (published, title, uri);
    }
    #nullable restore
    // </SnippetStarterViewModel>
}
