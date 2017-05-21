using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace test_selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver chrome = new ChromeDriver();
            //navigate to ius system webpage
            chrome.Navigate().GoToUrl("http://sis.ius.edu.ba/");
            //enters id and password
            chrome.FindElement(By.Id("txtLogin")).SendKeys("heregoesId");
            chrome.FindElement(By.Id("txtPassword")).SendKeys("here thepassword");
            //press login
            chrome.FindElement(By.Id("btnLogin")).Click();
            //opens the  course schedule
            chrome.FindElement(By.ClassName("file")).Click();
            //download the time table in pdf
            chrome.FindElement(By.TagName("RptExportYaz_btnExportTo")).Click();
            




        }

    }
}