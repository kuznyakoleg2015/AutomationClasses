using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using PetCareTests.Pages;

namespace PetCareTests.Tests
{
    [TestFixture]
    public class CareRequstMenuTests
    {
        [Test]
        public void MenuTest()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                var navigationMenuPage = new NavigationMenuPage(driver);
                navigationMenuPage.OpenPicturesPage();
                navigationMenuPage.OpenCareRequestPage();

            }
        }
    }
}
