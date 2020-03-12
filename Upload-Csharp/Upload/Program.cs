using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Upload
{
    class Program
    {


        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            ChromeDriverService Chrome_Servis = ChromeDriverService.CreateDefaultService();
            ChromeOptions Chrome_Ayar = new ChromeOptions();

            string[] mobileTarayici =
                {
                        //"Galaxy S5",
                        //"iPhone 5/SE",
                        //"iPhone 6/7/8",
                        "iPhone 6/7/8 Plus",
                        "iPhone X"
                        //"iPad",
                        //"iPad Pro"
                    };
            Random rand_tarayici = new Random();
            int index_tarayici = rand_tarayici.Next(mobileTarayici.Length);
            Chrome_Ayar.EnableMobileEmulation(mobileTarayici[index_tarayici]);


            // Gizli sekme
            Chrome_Ayar.AddArguments("--incognito");
            Chrome_Ayar.AddArgument("disable-infobars");
            Chrome_Ayar.AddArguments("--allow-file-access");
            Chrome_Ayar.AddArgument("--disable-web-security");
            Chrome_Ayar.AddArgument("--allow-running-insecure-content");

            driver = new ChromeDriver(Chrome_Servis, Chrome_Ayar);



            driver.Navigate().GoToUrl("http://localhost/google-login/index.php");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a")).Click();
            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//input[@name='identifier']")).SendKeys("");
            Thread.Sleep(5000);


            driver.FindElement(By.XPath("//div[@id='identifierNext']")).Click();
            Thread.Sleep(5000);



            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("");
            Thread.Sleep(5000);


            driver.FindElement(By.XPath("//div[@id='passwordNext']")).Click();
            Thread.Sleep(5000);


            driver.Navigate().GoToUrl("https://www.youtube.com/upload");

            /*IWebElement element = Chrome_Sekme.FindElement(By.XPath("//div[@class='XX1Wc']//div//input[@class='tb_sK']"));
            element.SendKeys(filePath);*/

        }
    }
}
