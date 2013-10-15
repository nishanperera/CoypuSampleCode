using CoypuDriver.Pages;
using NUnit.Framework;
using CoypuDriver;

namespace CustomerUITests.Pages
{
    public class HomePageTests
    {
        [Test]
        public void WhenLoginWithValidCredentialsShouldLoadDashboard()
        {
            HomePage.Visit();
            
            HomePage.SearchWith("croydon")
                     .Search();

            Assert.IsTrue(SearchPage.IsAt());
        }
    }
}
