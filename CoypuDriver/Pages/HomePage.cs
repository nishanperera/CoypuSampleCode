using Coypu;
using Coypu.Drivers;

namespace CoypuDriver.Pages
{
    public class HomePage : Bootstrap
    {
        public static void Visit()
        {
            CurrentBrowserSession.Visit("/");
        }

        public static SearchCommand SearchWith(string searchText)
        {
            return new SearchCommand(searchText);
        }


        public class SearchCommand
        {
            private readonly string _searchText;

            public SearchCommand(string searchText)
            {
                this._searchText = searchText;
            }

            public void Search()
            {
                //Search
                CurrentBrowserSession.FillIn("searchLocation").With(_searchText);
                CurrentBrowserSession.ClickButton("buy");

            }
        }
    }
}
