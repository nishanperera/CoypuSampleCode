using CoypuDriver.Pages;
using NUnit.Framework;

namespace CustomerUITests.Pages
{
    public class HomePageTests
    {
        [Test]
        public void WhenLoginWithValidCredentialsShouldLoadDashboard()
        {
            HomePage.Visit();
            
            HomePage.SearchWith("Croydon")
                     .Search();

            Assert.IsTrue(SearchPage.IsAt());
        }
    }
}
