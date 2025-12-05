using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using HomeInsurrance.KeywordDriven.Tests.PageModels;

namespace HomeInsurrance.KeywordDriven.Tests.Actions
{
    public class Login : SharedActionWeb
    {
        public override Variable[]? RequiredParameters => null;

        public override void DoAction()
        {
            Browser.Navigate().GoToUrl(GetParameter("URL_RECETTE"));
            var login = new PageLogin(Browser);
            login.UserName.SetValue(GetParameter("User"));
            login.Password.SetSecure(GetParameter("EncPassword"));
            login.ButtonLogin.Click();
        }

        public override bool DoCheckpoint()
        {
            var login = new PageLogin(Browser);
            if (login.ErrorMessage.Exists(5) && !string.IsNullOrWhiteSpace(login.ErrorMessage.InnerText))
            {
                Information.AppendLine("Error message is shown, login failed");
                return false;
            }
            return true;
        }
    }
}