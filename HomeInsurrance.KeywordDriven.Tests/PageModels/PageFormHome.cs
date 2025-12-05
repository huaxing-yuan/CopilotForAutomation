using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using OpenQA.Selenium;

namespace HomeInsurrance.KeywordDriven.Tests.PageModels
{
    public class PageFormHome : PageModel
    {
        // Home Location
        public WebElementDescription StreetNumber = new WebElementDescription { Name = "streetNumber", TagName = "input" };
        public WebElementDescription StreetName = new WebElementDescription { Name = "streetName", TagName = "input" };
        public WebElementDescription City = new WebElementDescription { Name = "city", TagName = "input" };
        public WebElementDescription PostCode = new WebElementDescription { Name = "postcode", TagName = "input" };
        public WebElementDescription Region = new WebElementDescription { Name = "region", TagName = "input" };
        public WebElementDescription Country = new WebElementDescription { Name = "country", TagName = "select" };

        // Home Type
        public WebElementDescription HomeTypeApartment = new WebElementDescription { Name = "homeType", Id = "home-type-appt", TagName = "input", Attributes = new HtmlAttribute[] { new HtmlAttribute("value", "apartment") } };
        public WebElementDescription HomeTypeHouse = new WebElementDescription { Name = "homeType", Id = "home-type-house", TagName = "input", Attributes = new HtmlAttribute[] { new HtmlAttribute("value", "house") } };

        // House specific
        public WebElementDescription HouseFloors = new WebElementDescription { Name = "floors", TagName = "input" };
        public WebElementDescription SurfaceBackyard = new WebElementDescription { Name = "surface-backyard", TagName = "input" };
        public WebElementDescription PoolYes = new WebElementDescription { Name = "pool", Id = "pool-yes", TagName = "input", Attributes = new HtmlAttribute[] { new HtmlAttribute("value", "yes") } };
        public WebElementDescription PoolNo = new WebElementDescription { Name = "pool", Id = "pool-no", TagName = "input", Attributes = new HtmlAttribute[] { new HtmlAttribute("value", "no") } };

        // Apartment specific
        public WebElementDescription TotalFloors = new WebElementDescription { Name = "total-floors", TagName = "select" };
        public WebElementDescription MyFloors = new WebElementDescription { Name = "my-floors", TagName = "input" };
        public WebElementDescription ElevatorYes = new WebElementDescription { Name = "elevator", Id = "elevator-yes", TagName = "input", Attributes = new HtmlAttribute[] { new HtmlAttribute("value", "yes") } };
        public WebElementDescription ElevatorNo = new WebElementDescription { Name = "elevator", Id = "elevator-no", TagName = "input", Attributes = new HtmlAttribute[] { new HtmlAttribute("value", "no") } };

        // Commun
        public WebElementDescription Rooms = new WebElementDescription { Name = "rooms", TagName = "select" };
        public WebElementDescription Surface = new WebElementDescription { Name = "surface", TagName = "input" };

        // Messages et navigation
        public WebElementDescription InfoMessage = new WebElementDescription { Id = "info", ClassName = "alert-info" };
        public WebElementDescription ErrorMessage = new WebElementDescription { Id = "error", ClassName = "alert-danger" };
        public WebElementDescription ButtonNextStep = new WebElementDescription { TagName = "button", InnerText = "Next Step" };

        public PageFormHome(WebDriver driver) : base(driver) { }
    }
}