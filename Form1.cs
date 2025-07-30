
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            //options.AddArgument("--mute-audio");
            //options.AddArgument("--disable-extensions");
            options.AddArgument("--window-size=530,1000");
            //options.AddArgument("--disable-notifications");

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

                // Tìm và nhập mật khẩu
                var password = Chromedriver.FindElement(By.Id("m_login_password"));

                password.SendKeys("290962328");

                // Nhấn nút đăng nhập
                var loginButton = Chromedriver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/div/div/div/div/div[1]/div/div/div/div[3]/div/div/div/div/div/div/div/div[2]/div[3]/div[3]/div/div/div/div/div/div/div/div/div/span"));
                loginButton.Click();
                Thread.Sleep(5000);

                //Chromedriver.Navigate().GoToUrl("https://www.facebook.com/bong.teen/posts/pfbid0EpsaM2KwrkN4VyFVJVx4dVvqbXgks4ppJeXHfhvZKTWms6mLFCeGG3QaZoKupD1bl");
                //Chromedriver.Navigate().GoToUrl("https://www.facebook.com/story.php?story_fbid=1173509351469154&id=100064302996623");

                //Chromedriver.Navigate().GoToUrl("https://www.facebook.com/photo.php?fbid=1235704111902406");
                Chromedriver.Navigate().GoToUrl(textBox1.Text);

                Thread.Sleep(5000);

                // khúc trên ngon rồi, giờ làm phía dưới
                
                // Khúc này sẽ bấm vào biểu tượng bình luận để vào commet
                // nếu lỗi thì không làm gì cả
                try
                {
                    Thread.Sleep(5000);
                    // Nhấn nút đăng nhập
                    var bieuTuongBinhLuanXpath = "/html/body/div[3]/div/div[4]/div/div[5]";
                    var bieuTuongBinhLuanXpathButton = Chromedriver.FindElement(By.XPath(bieuTuongBinhLuanXpath));
                    bieuTuongBinhLuanXpathButton.Click();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // gửi nội dung bình luận vào input
                try
                {
                    Thread.Sleep(3000);

                    var inputNoiDungBinhLuanXpath = "/html/body/div[3]/div/div[4]/div/div/div[1]/div[3]/div[2]/div/div[1]/textarea";
                    var inputNoiDungBinhLuanXpathButton = Chromedriver.FindElement(By.XPath(inputNoiDungBinhLuanXpath));
                    inputNoiDungBinhLuanXpathButton.SendKeys(textBoxNoiDungComment.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //nhấn vào biểu tưởng gửi comment
                try
                {
                    Thread.Sleep(2000);

                    var bieuTuongGuiCommentXpath = "/html/body/div[3]/div/div[4]/div/div/div[1]/div[3]/div[2]/div/div[8]/div[1]/div/div[2]/div/div";
                    var bieuTuongGuiCommentXpathButton = Chromedriver.FindElement(By.XPath(bieuTuongGuiCommentXpath));
                    bieuTuongGuiCommentXpathButton.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                MessageBox.Show("Thông báo từ a huy", "Ngon lành nha");
                //Màn hình đang ở hiển thị anh, giờ bấm nút bình luận để hiện giao diện cho phép nhập bình luận


                // sau khi chờ -> hiển thị arena thì send text


                // sau khi sendtext thì bấm gửi để hoàn thành comment


                // thoát phiên làm việc hiện tại











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

