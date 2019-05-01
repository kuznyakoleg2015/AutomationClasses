using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PetCareTests.Pages;
using Shouldly;


namespace PetCareTests.Tests
{
    [TestFixture]
    public class CareRequestTest
    {
        [Test]
        public void CareRequestPageTest()
        {
            var testPhoneNumber = "7733969481";
            var testEmail = "lemeha.iryna@gmail.com";
            var firstNameValue = "iryna";
            var lastNameValue = "Lemeha";

            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://nitro.duckdns.org/Pets.QA/index.html");

                var navigationMenuPage = new NavigationMenuPage(driver);
                navigationMenuPage.OpenCareRequestPage();
                var careRequestPage = new CareRequestPage(driver);
                careRequestPage.FillOutContactInformation(firstNameValue, lastNameValue, testPhoneNumber, testEmail);


                
                careRequestPage.RequestCatCare("3+");
                
                careRequestPage.SetVisitsPerDay(4);
                
                careRequestPage.FillOutComments("I would like to hire a person for 1-2 years.");

                
               
                careRequestPage.ClickRequestButton();

                Thread.Sleep(1000);

                var closeButton = driver.FindElementByXPath("//button[.='Close']");
                var modal = driver.FindElement(By.ClassName("modal-body"));
                var modalText = modal.Text;
                Console.WriteLine(modalText);
                modalText.ShouldContain($"Phone #: {testPhoneNumber}");
                modalText.ShouldContain($"Email: {testEmail}");
                modalText.ShouldContain($"First Name: {firstNameValue}");
                modalText.ShouldContain($"Last Name: {lastNameValue}");

                closeButton.Click();
            }
        }
    }
}
