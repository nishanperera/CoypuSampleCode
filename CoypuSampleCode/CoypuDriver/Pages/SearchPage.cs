namespace CoypuDriver.Pages
{
    public class SearchPage
    {
        public static bool IsAt()
        {
            var browser = Bootstrap.GetBrowserSession();
            return browser.FindFieldset("primarycriteria").Exists();
        }
    }
}