using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using OpenQA.Selenium;

namespace HomeInsurrance.KeywordDriven.Tests.PageModels
{
    public class PageProspect : PageModel
    {
        public WebElementDescription ProspectId = new WebElementDescription
        {
            Name = "prospectId",
            Id = "prospectId",
            TagName = "input"
        };

        public WebElementDescription ProspectName = new WebElementDescription
        {
            Name = "prospectName",
            Id = "prospectName",
            TagName = "input"
        };

        public WebElementDescription ButtonSearch = new WebElementDescription
        {
            TagName = "button",
            InnerText = "Search"
        };

        public WebElementDescription InfoMessage = new WebElementDescription
        {
            Id = "info",
            ClassName = "alert-info"
        };

        public WebElementDescription ErrorMessage = new WebElementDescription
        {
            Id = "error",
            ClassName = "alert-danger"
        };

        public WebElementDescription ButtonNextStep = new WebElementDescription
        {
            TagName = "button",
            InnerText = "Next Step"
        };

        public PageProspect(WebDriver driver) : base(driver) { }
    }
}