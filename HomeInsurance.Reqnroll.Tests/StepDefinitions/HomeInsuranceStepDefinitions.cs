using System;
using Reqnroll;
using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using HomeInsurance.Reqnroll.Tests.PageModels;
using OpenQA.Selenium;

namespace HomeInsurance.Reqnroll.Tests.StepDefinitions
{
    [Binding]
    public class HomeInsuranceStepDefinitions
    {
        private WebDriver driver;
        private LoginPageModel loginPage;
        private ProspectPageModel prospectPage;
        private HomeDetailsPageModel homeDetailsPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = BrowserFactory.GetDriver(AxaFrance.WebEngine.Platform.Windows, AxaFrance.WebEngine.BrowserType.ChromiumEdge);
            loginPage = new LoginPageModel(driver);
            prospectPage = new ProspectPageModel(driver);
            homeDetailsPage = new HomeDetailsPageModel(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver?.Dispose();
        }

        [Given("je suis sur la page de connexion")]
        public void GivenJeSuisSurLaPageDeConnexion()
        {
            driver.Navigate().GoToUrl("https://webengine-test.azurewebsites.net/home-insurance/"); // Remplacez par l'URL réelle
        }

        [When("je saisis {string} dans le champ login")]
        public void WhenJeSaisisDansLeChampLogin(string login)
        {
            loginPage.LoginInput.SetValue(login);
        }

        [When("je saisis {string} dans le champ password")]
        public void WhenJeSaisisDansLeChampPassword(string password)
        {
            loginPage.PasswordInput.SetValue(password);
        }

        [When("je clique sur le bouton Login")]
        public void WhenJeCliqueSurLeBoutonLogin()
        {
            loginPage.LoginButton.Click();
        }

        [Then("je suis redirigé vers la page de sélection du prospect")]
        public void ThenJeSuisRedirigeVersLaPageDeSelectionDuProspect()
        {
            // Ajoutez une vérification selon le comportement attendu, par exemple :
            // Assert.True(driver.Url.Contains("prospect"));
        }

        [When("je saisis {string} dans le champ de recherche par identifiant client")]
        public void WhenJeSaisisDansLeChampDeRechercheParIdentifiantClient(string prospectId)
        {
            prospectPage.ProspectIdInput.SetValue(prospectId);
        }

        [When("je clique sur le bouton Next Step")]
        public void WhenJeCliqueSurLeBoutonNextStep()
        {
            prospectPage.NextStepButton.Click();
        }

        [Then("je suis redirigé vers la page de remplissage des détails du logement")]
        public void ThenJeSuisRedirigeVersLaPageDeRemplissageDesDetailsDuLogement()
        {
            // Add assertion or navigation check as needed
        }


        [When(@"je remplis l'adresse du logement avec les informations suivantes:")]
        public void WhenJeRemplisAdresseDuLogementAvecInformations(Table table)
        {
            foreach (var row in table.Rows)
            {
                switch (row["Champ"])
                {
                    case "Street Number":
                        homeDetailsPage.StreetNumberInput.SetValue(row["Valeur"]);
                        break;
                    case "Street Name":
                        homeDetailsPage.StreetNameInput.SetValue(row["Valeur"]);
                        break;
                    case "City":
                        homeDetailsPage.CityInput.SetValue(row["Valeur"]);
                        break;
                    case "Post Code":
                        homeDetailsPage.PostCodeInput.SetValue(row["Valeur"]);
                        break;
                    case "Region":
                        homeDetailsPage.RegionInput.SetValue(row["Valeur"]);
                        break;
                    case "Country":
                        homeDetailsPage.CountrySelect.SelectByText(row["Valeur"]);
                        break;
                }
            }
        }

        [When(@"je sélectionne ""(.*)"" comme type de logement")]
        public void WhenJeSelectionneCommeTypeDeLogement(string type)
        {
            if (type == "Apartment")
                homeDetailsPage.ApartmentRadio.Click();
            else if (type == "House")
                homeDetailsPage.HouseRadio.Click();
        }

        [When(@"je remplis les détails de l'appartement avec les informations suivantes:")]
        public void WhenJeRemplisDetailsAppartement(Table table)
        {
            foreach (var row in table.Rows)
            {
                switch (row["Champ"])
                {
                    case "Total floors of the building":
                        homeDetailsPage.TotalFloorsSelect.SelectByValue(row["Valeur"]);
                        break;
                    case "Your apartment is at (x)th floor":
                        homeDetailsPage.MyFloorsInput.SetValue(row["Valeur"]);
                        break;
                    case "Do you have an elevator":
                        if (row["Valeur"].ToLower() == "yes")
                            homeDetailsPage.ElevatorYesRadio.Click();
                        else
                            homeDetailsPage.ElevatorNoRadio.Click();
                        break;
                    case "Number of rooms":
                        homeDetailsPage.RoomsSelect.SelectByValue(row["Valeur"]);
                        break;
                    case "Surface (sq meters)":
                        homeDetailsPage.SurfaceInput.SetValue(row["Valeur"]);
                        break;
                }
            }
        }

        [Then(@"je suis redirigé vers la page suivante du processus de souscription")]
        public void ThenJeSuisRedirigeVersLaPageSuivanteDuProcessusDeSouscription()
        {
            // Add assertion or navigation check as needed, e.g.:
            // Assert.True(driver.Url.Contains("antecedent"));
        }
    }
}
