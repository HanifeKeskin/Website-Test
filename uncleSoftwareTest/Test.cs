using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace uncleSoftwareTest
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver = new ChromeDriver(); // tarayıcımızı driver nesnesine atadık
        [Test]
        public void siteninAcilmasi()
        {
            // TODO: Add your test code here
            driver.Navigate().GoToUrl("http://unclesoftware.com/"); // tarayıcımızın gitmesi gerektiği sitenin urlsini verdik 
            Assert.Pass("sitenin açılması passing test");
        }
      
      

       [Test]
        public void profesyonelBaslikEkleme()
        {
            //kullanıcı profesyonel başlık ekleme testi
            driver.Navigate().GoToUrl("http://unclesoftware.com/");

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.Name("emailorname")).SendKeys("beyzahanife@gmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("profilebirseyyaz");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='loginForm']/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000); //giris yapildi

             driver.FindElement(By.ClassName("caret")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.XPath("//*[@id='navigation-index']/ul/li[6]/ul/li[6]/a")).Click(); //profili goruntule tıklama
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("user_title")).SendKeys("Odev 3 test gorevlisi");
             System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='accountEditForm']/div[2]/table/tbody/tr[6]/td[2]/button")).Click();
             System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.ClassName("caret")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='doLogOut']")).Click();
            System.Threading.Thread.Sleep(3000);   //Cıkış yapıldı

            Assert.Pass("profile bir sey yaz testi basarılı");

        }
        [Test]
        public void sifreDegistirme()
        {
            //kullanıcı şifre değiştirme testi
            driver.Navigate().GoToUrl("http://unclesoftware.com/");

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.Name("emailorname")).SendKeys("bookas@gmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("12345beyza");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='loginForm']/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000); //giris yapildi

            driver.FindElement(By.ClassName("caret")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='navigation-index']/ul/li[6]/ul/li[6]/a")).Click(); //ayarlara tıklama
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/ul/li[4]/a")).Click(); //ayarlar-sifre
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password_current")).SendKeys("12345beyza");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password_new")).SendKeys("beyza12345");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password_new_confirm")).SendKeys("beyza12345");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='passwordEditForm']/div[2]/table/tbody/tr[4]/td[2]/button")).Click(); //sifre degistirme butonu tıklandı
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.ClassName("caret")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='doLogOut']")).Click();
            System.Threading.Thread.Sleep(3000); //çıkış yapıldı

            Assert.Pass("sifre degistirme passing test");

        }
        
           [Test]
        //kullanıcı kurumsal kayıt olma testi
        public void kurumsalKayitOlma()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[1]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("name")).SendKeys("Beyza H Ozkara");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("mail")).SendKeys("kurumsalkayitmaili@gmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("kayitolmatestiparola");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='signupForm']/div[2]/div[4]/label[2]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='signupForm']/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.Name("nick")).SendKeys("hanifekeskin");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("phoneUser")).SendKeys("1234567890");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyName")).SendKeys("beyhananonimmm");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("phoneCompany")).SendKeys("1234567890");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyDate")).SendKeys("20181010");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyMail")).SendKeys("beyhananon@gmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyWeb")).SendKeys("beyhananonim.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("companyAbout")).SendKeys("ödev deneme şirketidir. 10.10.18de kuruldu ");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='welcomeCForm']/div[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.ClassName("caret")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='doLogOut']")).Click();
            System.Threading.Thread.Sleep(3000); //çıkış yapıldı

            Assert.Pass("kurumsal kayıt passing test");
        }



    }
}
