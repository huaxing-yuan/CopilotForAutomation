using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using HomeInsurrance.KeywordDriven.Tests.PageModels;

namespace HomeInsurrance.KeywordDriven.Tests.Actions
{
    public class Prospect : SharedActionWeb
    {
        public override Variable[]? RequiredParameters => null;

        public override void DoAction()
        {
            var prospect = new PageProspect(Browser);
            prospect.ProspectId.SetValue(GetParameter(ParameterList.ProspectId));
            prospect.ButtonNextStep.Click();
        }

        public override bool DoCheckpoint()
        {
            var prospect = new PageProspect(Browser);
            if (prospect.ErrorMessage.Exists(5) && !string.IsNullOrWhiteSpace(prospect.ErrorMessage.InnerText))
            {
                Information.AppendLine("Error message is shown, prospect search failed");
                return false;
            }
            return true;
        }
    }
}