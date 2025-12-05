using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

Console.WriteLine("Test starts !");

// Initialize Edge WebDriver
var options = new EdgeOptions();
using var driver = new EdgeDriver(options);

// Navigate to the login page (replace with your actual URL)
driver.Navigate().GoToUrl("https://axafrance.github.io/webengine-dotnet/demo/home-insurance/");

// Fill in the login form
driver.FindElement(By.Name("login")).SendKeys("A89387");
driver.FindElement(By.Name("password")).SendKeys("EF2vSK89");

// Click the Login button (second button in the container)
var buttons = driver.FindElements(By.TagName("button"));
if (buttons.Count > 1)
{
    buttons[1].Click();
}
else
{
    throw new Exception("Login button not found.");
}

// Wait for possible error message to appear
System.Threading.Thread.Sleep(1000); // Simple wait, consider using WebDriverWait for robustness

// Assert that the error message is not displayed
var errorMessage = driver.FindElement(By.Id("errorMessage"));
if (errorMessage.Displayed)
{
    throw new Exception("Login failed: error message is displayed.");
}

Console.WriteLine("Login succeeded: error message not displayed.");