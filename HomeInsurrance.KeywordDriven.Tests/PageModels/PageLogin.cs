using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using OpenQA.Selenium;

namespace HomeInsurrance.KeywordDriven.Tests.PageModels
{
    public class PageLogin : PageModel
    {
        public WebElementDescription UserName = new WebElementDescription
        {
            Name = "login",
            TagName = "input"
        };

        public WebElementDescription Password = new WebElementDescription
        {
            Name = "password",
            TagName = "input"
        };

        public WebElementDescription ButtonLogin = new WebElementDescription
        {
            TagName = "button",
            InnerText = "Login"
        };

        public WebElementDescription ErrorMessage = new WebElementDescription
        {
            Id = "errorMessage",
            ClassName = "alert-danger"
        };

        public PageLogin(WebDriver driver) : base(driver) { }
    }
}