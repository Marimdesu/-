using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string mailAddress = "メアド";
            string password = "パスワード";

            // Seleniumが操作するTwitter.Bootstrapを宣言
            var options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(options);

            // Googleログイン画面へ
            driver.Url = "https://www.google.com/accounts?hl=ja-JP";

            // 要素が見つかるまで待機するための準備
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));


            // メールアドレスの入力欄を探す
            var mailAddressElement = wait.Until(drv => drv.FindElement(By.XPath("//input[@id='identifierId']")));

            // メールアドレスを入力
            mailAddressElement.SendKeys(mailAddress);
            mailAddressElement.SendKeys(Keys.Enter);


            // 画面が変わるまで時間がかかるので、2000ミリ秒（＝2秒)待ち
            System.Threading.Thread.Sleep(2000);


            // パスワードの入力欄を探す
            var passwordElement = wait.Until(drv => drv.FindElement(By.XPath("//input[@type='password']")));

            // パスワードを入力
            passwordElement.SendKeys(password);
            passwordElement.SendKeys(Keys.Enter);
        }
    }
}