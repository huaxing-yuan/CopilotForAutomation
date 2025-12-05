using AxaFrance.WebEngine.Web;
using OpenQA.Selenium;

namespace HomeInsurance.Reqnroll.Tests.PageModels
{
    public class LoginPageModel : PageModel
    {
        public WebElementDescription LoginInput { get; set; }
        public WebElementDescription PasswordInput { get; set; }
        public WebElementDescription LoginButton { get; set; }

        public LoginPageModel(WebDriver driver) : base(driver)
        {
            LoginInput = new WebElementDescription(driver)
            {
                TagName = "input",
                Name = "login"
            };
            PasswordInput = new WebElementDescription(driver)
            {
                TagName = "input",
                Name = "password"
            };
            LoginButton = new WebElementDescription(driver)
            {
                TagName = "button",
                InnerText = "Login"
            };
        }
    }
}