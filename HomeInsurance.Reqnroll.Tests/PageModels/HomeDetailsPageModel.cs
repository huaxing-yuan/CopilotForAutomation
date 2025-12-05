using AxaFrance.WebEngine.Web;
using OpenQA.Selenium;

public class HomeDetailsPageModel : PageModel
{
    // Home Location
    public WebElementDescription StreetNumberInput { get; set; }
    public WebElementDescription StreetNameInput { get; set; }
    public WebElementDescription CityInput { get; set; }
    public WebElementDescription PostCodeInput { get; set; }
    public WebElementDescription RegionInput { get; set; }
    public WebElementDescription CountrySelect { get; set; }

    // Home Type
    public WebElementDescription ApartmentRadio { get; set; }
    public WebElementDescription HouseRadio { get; set; }

    // House Details
    public WebElementDescription HouseFloorsInput { get; set; }
    public WebElementDescription SurfaceBackyardInput { get; set; }
    public WebElementDescription PoolYesRadio { get; set; }
    public WebElementDescription PoolNoRadio { get; set; }

    // Apartment Details
    public WebElementDescription TotalFloorsSelect { get; set; }
    public WebElementDescription MyFloorsInput { get; set; }
    public WebElementDescription ElevatorYesRadio { get; set; }
    public WebElementDescription ElevatorNoRadio { get; set; }

    // Common
    public WebElementDescription RoomsSelect { get; set; }
    public WebElementDescription SurfaceInput { get; set; }
    public WebElementDescription NextStepButton { get; set; }

    public HomeDetailsPageModel(WebDriver driver) : base(driver)
    {
        StreetNumberInput = new WebElementDescription(driver) { Name = "streetNumber", TagName = "input" };
        StreetNameInput = new WebElementDescription(driver) { Name = "streetName", TagName = "input" };
        CityInput = new WebElementDescription(driver) { Name = "city", TagName = "input" };
        PostCodeInput = new WebElementDescription(driver) { Name = "postcode", TagName = "input" };
        RegionInput = new WebElementDescription(driver) { Name = "region", TagName = "input" };
        CountrySelect = new WebElementDescription(driver) { Name = "country", TagName = "select" };

        ApartmentRadio = new WebElementDescription(driver) { Name = "homeType", Id = "home-type-appt", TagName = "input", Attributes = new[] { new HtmlAttribute("value", "apartment") } };
        HouseRadio = new WebElementDescription(driver) { Name = "homeType", Id = "home-type-house", TagName = "input", Attributes = new[] { new HtmlAttribute("value", "house") } };

        HouseFloorsInput = new WebElementDescription(driver) { Name = "floors", TagName = "input" };
        SurfaceBackyardInput = new WebElementDescription(driver) { Name = "surface-backyard", TagName = "input" };
        PoolYesRadio = new WebElementDescription(driver) { Name = "pool", Id = "pool-yes", TagName = "input", Attributes = new[] { new HtmlAttribute("value", "yes") } };
        PoolNoRadio = new WebElementDescription(driver) { Name = "pool", Id = "pool-no", TagName = "input", Attributes = new[] { new HtmlAttribute("value", "no") } };

        TotalFloorsSelect = new WebElementDescription(driver) { Name = "total-floors", TagName = "select" };
        MyFloorsInput = new WebElementDescription(driver) { Name = "my-floors", TagName = "input" };
        ElevatorYesRadio = new WebElementDescription(driver) { Name = "elevator", Id = "elevator-yes", TagName = "input", Attributes = new[] { new HtmlAttribute("value", "yes") } };
        ElevatorNoRadio = new WebElementDescription(driver) { Name = "elevator", Id = "elevator-no", TagName = "input", Attributes = new[] { new HtmlAttribute("value", "no") } };

        RoomsSelect = new WebElementDescription(driver) { Name = "rooms", TagName = "select" };
        SurfaceInput = new WebElementDescription(driver) { Name = "surface", TagName = "input" };
        NextStepButton = new WebElementDescription(driver) { TagName = "button", InnerText = "Next Step" };
    }
}