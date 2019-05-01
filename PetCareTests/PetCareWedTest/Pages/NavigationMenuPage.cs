using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PetCareTests.Pages
{
    public class NavigationMenuPage
    {
        private ChromeDriver driver;

        public NavigationMenuPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement CareRequestMenuItem => driver.FindElement(By.LinkText("Care Request"));
        private IWebElement PicturesMenuItem => driver.FindElement(By.LinkText(""));

        public void OpenCareRequestPage()
        {
            CareRequestMenuItem.Click();
        }
        public void OpenPicturesPage()
        {
            PicturesMenuItem.Click();
        }
    }
}
