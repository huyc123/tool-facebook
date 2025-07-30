
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace selenium66
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new ChromeOptions();
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;

            options.AddArgument("--user-agent=Mozilla/5.0 (iPhone; CPU iPhone OS 13_3_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.5 Mobile/15E148 Safari/604.1");
            //            //options.AddArgument("--mute-audio");
            //            //options.AddArgument("--disable-extensions");
            options.AddArgument("--window-size=530,1000");
            //            //options.AddArgument("--disable-notifications");

            var Chromedriver = new ChromeDriver(chromeDriverService, options);

            var wait = new WebDriverWait(Chromedriver, TimeSpan.FromSeconds(10));
            Chromedriver.Navigate().GoToUrl("https://m.facebook.com/login/");


            var element1 = Chromedriver.FindElements(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div/div/div/div[1]/div/div/div/div[3]/div/div/div/div[2]/div/div/div/div/div/div[1]/div[2]/div"));
            //var element2 = Chromedriver.FindElements(By.XPath("//xpath_thu_2"));

            if (element1.Count > 0 && element1[0].Displayed)
            {
                element1[0].Click();
            }
            //else if (element2.Count > 0 && element2[0].Displayed)
            //{
            //    element2[0].Click();
            //}
            else
            {
                // Không có phần tử nào -> tiếp tục chạy chương trình
               



                
                var email = Chromedriver.FindElement(By.Id("m_login_email"));
                email.SendKeys("0967814637");

                //            // Tìm và nhập mật khẩu
                var password = Chromedriver.FindElement(By.Id("m_login_password"));

                password.SendKeys("290962328");

                //            // Nhấn nút đăng nhập
                var loginButton = Chromedriver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div/div/div/div[1]/div/div/div/div[3]/div/div/div/div/div/div/div/div[2]/div[3]/div[3]/div/div/div/div/div/div/div/div/div/span"));
                loginButton.Click();


                Thread.Sleep(5000);

                //Chromedriver.Navigate().GoToUrl("https://www.facebook.com/bong.teen/posts/pfbid0EpsaM2KwrkN4VyFVJVx4dVvqbXgks4ppJeXHfhvZKTWms6mLFCeGG3QaZoKupD1bl");
                //Chromedriver.Navigate().GoToUrl("https://www.facebook.com/story.php?story_fbid=1173509351469154&id=100064302996623");


                Chromedriver.Navigate().GoToUrl("https://www.facebook.com/photo.php?fbid=1235704111902406");



                Thread.Sleep(5000);



                //bamvaocmt

                string nutanvao = "/html/body/div[3]/div/div[3]/div/div/div/div[5]/div[2]/div";
                var XPathnutanvao = wait.Until(driver => driver.FindElement(By.XPath(nutanvao)));


                //// Cuộn phần tử vào giữa màn hình
                ((IJavaScriptExecutor)Chromedriver).ExecuteScript("arguments[0].scrollIntoView({block: 'center'});", XPathnutanvao);
                Thread.Sleep(500); // Chờ một chút sau khi scroll

               

                if (Chromedriver.FindElements(By.XPath(nutanvao)).Count == 0)
                {
                    // Thực hiện hành động với phần tử tiếp theo
                    string nutTieptheo = "/html/body/div[3]/div/div[3]/div/div/div/div[5]/div[2]/div";
                    var XPathnutTiepTheo = Chromedriver.FindElement(By.XPath(nutTieptheo));
                    ((IJavaScriptExecutor)Chromedriver).ExecuteScript("arguments[0].scrollIntoView({block: 'center'});", XPathnutTiepTheo);
                    Thread.Sleep(500);
                    XPathnutTiepTheo.Click();
                }



                Thread.Sleep(2000);
                string xpathCmtNoiDung = "/html/body/div[3]/div/div[4]/div/div/div[1]/div[3]/div[2]/div/div[1]/textarea";
                var xpathCmtNoiDungcmt = wait.Until(driver => driver.FindElement(By.XPath(xpathCmtNoiDung)));
                xpathCmtNoiDungcmt.SendKeys("Còn không chị ơi");

                string xpathCmtgui = "/html/body/div[3]/div/div[4]/div/div/div[1]/div[3]/div[2]/div/div[8]/div[1]/div/div[2]/div/div";
                var cmtxpathCmtgui = wait.Until(driver => driver.FindElement(By.XPath(xpathCmtgui)));
                cmtxpathCmtgui.Click();

            }
        }
    }
}


// bước 1 xác định vị trí lỗi : có tên file và dòng 48
// bước 2 xác định lỗi : coppy dịch sang tiếng việt xem nó lỗi gì
// nếu hiểu tự sửa chưa dùng AI
// sửa mà không chạy hỏi GPT, yêu cầu nó giải thích từng dòng code, luồng chạy
// tốt nhất e mới nên gõ lại không nên coppy paste -> lý do: e mới nên khoogn nhớ được, ta đang hocjkhoong phải mục tiêu bất chấp làm ra sản phẩm

// đọc thì không hiểu lắm đúng không? đại loại là bool -> kiểu dữ liệu true false> nghi ngờ kiểu dữ liệu bị sai.

