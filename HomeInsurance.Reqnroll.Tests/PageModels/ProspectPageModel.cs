using AxaFrance.WebEngine.Web;
using OpenQA.Selenium;

namespace HomeInsurance.Reqnroll.Tests.PageModels
{
    public class ProspectPageModel : PageModel
    {
        public WebElementDescription ProspectIdInput { get; set; }
        public WebElementDescription ProspectNameInput { get; set; }
        public WebElementDescription SearchButton { get; set; }
        public WebElementDescription NextStepButton { get; set; }

        public ProspectPageModel(WebDriver driver) : base(driver)
        {
            ProspectIdInput = new WebElementDescription(driver)
            {
                TagName = "input",
                Name = "prospectId",
                Id = "prospectId"
            };
            ProspectNameInput = new WebElementDescription(driver)
            {
                TagName = "input",
                Name = "prospectName",
                Id = "prospectName"
            };
            SearchButton = new WebElementDescription(driver)
            {
                TagName = "button",
                InnerText = "Search"
            };
            NextStepButton = new WebElementDescription(driver)
            {
                TagName = "button",
                InnerText = "Next Step"
            };
        }
    }
}