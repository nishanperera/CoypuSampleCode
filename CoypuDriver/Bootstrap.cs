using Coypu;
using Coypu.Drivers;

namespace CoypuDriver
{
    public class Bootstrap
    {
        private static BrowserSession _browserSession;

        public static BrowserSession CurrentBrowserSession {
            get
            {
                if (_browserSession == null)
                {
                    _browserSession = new BrowserSession(new SessionConfiguration()
                    {
                        AppHost = "www.rightmove.co.uk",
                        Browser = Browser.Firefox,
                    });
                }
                return _browserSession;
                
            }
        }
    }
}
