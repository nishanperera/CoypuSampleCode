using Coypu;
using Coypu.Drivers;

namespace CoypuDriver
{
    public class Bootstrap
    {
        public static BrowserSession CurrentBrowserSession { get; private set; }

        public static BrowserSession GetBrowserSession()
        {
            if (CurrentBrowserSession == null)
            {
                CurrentBrowserSession = new BrowserSession(new SessionConfiguration()
                    {
                        AppHost = "www.rightmove.co.uk",
                        Browser = Browser.Firefox,
                    });
            }
            return CurrentBrowserSession;
        }
    }
}
