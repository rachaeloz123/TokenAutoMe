using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V85.IndexedDB;
using OpenQA.Selenium.Interactions;
using OpenDialogWindowHandler;


namespace TokenAutoMe
{
    class Program
    {
        static void Main(string[] args)
        {

         

            var driver = new ChromeDriver();
            driver.Url = "http://vf-live.dmi.com/portal#/login";
            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            actions.Click(driver.FindElement(By.Id("userName")))
                .SendKeys("rozarowski" + Keys.Tab)
                .SendKeys("Frijoles1." + Keys.Tab)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
            Thread.Sleep(2000);
            driver.Url = "http://vf-live.dmi.com/portal#/instructions/shapes";
            Thread.Sleep(3000);
            int slideNumber = 11;
            for (int t = 610; t < 699; t++)
            {
                driver.FindElement(By.CssSelector(".icon-plus-circle")).Click();
                Thread.Sleep(2000);

                IWebElement newToken = driver.FindElement(By.Name("caption"));
                newToken.SendKeys("8L9" + t + Keys.Tab);
                Thread.Sleep(3000);

                //IWebElement uploadPic = driver.FindElement(By.CssSelector(".btn-file"));
                var uploadDrop = driver.FindElement(By.XPath("//span[contains(.,'Choose file')]"));
                uploadDrop.SendKeys(@"C:\Users\rozarowski\Downloads\Tokens 600-699\Slide" + slideNumber + ".JPG");
                
                Thread.Sleep(1000);
               

                //string fileName = @"Slide" + slideNumber + ".JPG";
                
                Thread.Sleep(3000);
                slideNumber++;

                //IWebElement close = driver.FindElement(By.CssSelector("")).Click();
                //uploadPic.SendKeys(folderPath);
            }

            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
                 //DirectoryInfo d = new DirectoryInfo(folderPath);