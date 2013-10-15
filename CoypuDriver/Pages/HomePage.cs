using Coypu;
using Coypu.Drivers;

namespace CoypuDriver.Pages
{
    public class HomePage
    {

        public static void Visit()
        {
        }

        public static SearchCommand SearchWith(string searchText)
        {
            return new SearchCommand(searchText);
        }


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
            var browser = Bootstrap.GetBrowserSession();
            browser.Visit("/");
            browser.FillIn("searchLocation").With(_searchText);
            browser.ClickButton("buy");

        }
    }
}
