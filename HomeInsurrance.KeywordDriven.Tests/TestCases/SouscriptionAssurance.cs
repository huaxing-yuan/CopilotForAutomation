using AxaFrance.WebEngine;
using AxaFrance.WebEngine.Web;
using System.ComponentModel;

namespace HomeInsurrance.KeywordDriven.Tests.TestCases
{
    [Description("Test de souscription d'assurance complète - ApptT4Intermediaire")]
    public class SouscriptionAssurance : TestCaseWeb
    {
        public SouscriptionAssurance()
        {
            TestSteps = new TestStep[] {
                new TestStep { Action = nameof(Actions.Login) },
                new TestStep { Action = nameof(Actions.Prospect) },
                new TestStep { Action = nameof(Actions.Form_HomeDetails) }
                // Ajouter ici les étapes suivantes : Antecedents, OfferAndOptions, etc.
            };
        }
    }
}
