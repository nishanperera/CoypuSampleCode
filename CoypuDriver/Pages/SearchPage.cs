namespace CoypuDriver.Pages
{
    public class SearchPage:Bootstrap
    {
        public static bool IsAt()
        {
            return CurrentBrowserSession.FindFieldset("primarycriteria").Exists();
        }
    }
}