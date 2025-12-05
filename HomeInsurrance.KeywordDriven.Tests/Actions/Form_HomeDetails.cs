using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using HomeInsurrance.KeywordDriven.Tests.PageModels;

namespace HomeInsurrance.KeywordDriven.Tests.Actions
{
    public class Form_HomeDetails : SharedActionWeb
    {
        public override Variable[]? RequiredParameters => null;

        public override void DoAction()
        {
            var form = new PageFormHome(Browser);
            // Localisation
            form.StreetNumber.SetValue(GetParameter(ParameterList.StreetNumber));
            form.StreetName.SetValue(GetParameter(ParameterList.StreetName));
            form.City.SetValue(GetParameter(ParameterList.City));
            form.PostCode.SetValue(GetParameter(ParameterList.PostCode));
            form.Region.SetValue(GetParameter(ParameterList.Region));
            form.Country.SelectByValue(GetParameter(ParameterList.Country));

            // Type de logement
            var homeType = GetParameter(ParameterList.HomeType)?.ToLower();
            if (homeType == "apartment")
            {
                form.HomeTypeApartment.Click();
                form.TotalFloors.SelectByValue(GetParameter(ParameterList.TotalFloors));
                form.MyFloors.SetValue(GetParameter(ParameterList.MyFloors));
                var elevator = GetParameter(ParameterList.Elevator)?.ToLower();
                if (elevator == "yes")
                    form.ElevatorYes.Click();
                else if (elevator == "no")
                    form.ElevatorNo.Click();
            }
            else if (homeType == "house")
            {
                form.HomeTypeHouse.Click();
                form.HouseFloors.SetValue(GetParameter(ParameterList.HouseFloors));
                form.SurfaceBackyard.SetValue(GetParameter(ParameterList.SurfaceBackyard));
                var pool = GetParameter(ParameterList.Pool)?.ToLower();
                if (pool == "yes")
                    form.PoolYes.Click();
                else if (pool == "no")
                    form.PoolNo.Click();
            }

            // Commun
            form.Rooms.SelectByValue(GetParameter(ParameterList.Rooms));
            form.Surface.SetValue(GetParameter(ParameterList.Surface));

            form.ButtonNextStep.Click();
        }

        public override bool DoCheckpoint()
        {
            var form = new PageFormHome(Browser);
            if (form.ErrorMessage.Exists(5) && !string.IsNullOrWhiteSpace(form.ErrorMessage.InnerText))
            {
                Information.AppendLine("Erreur lors du remplissage du formulaire habitation");
                return false;
            }
            return true;
        }
    }
}