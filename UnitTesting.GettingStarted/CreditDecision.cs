using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.CreditDecisionExample
{
    public class CreditDecision : ICreditDecision
    {
        private readonly ICreditDecisionService _creditDecisionService;

        public CreditDecision(ICreditDecisionService creditDecisionService)
        {
            this._creditDecisionService = creditDecisionService;
        }

        public string MakeCreditDecision()
        {
            int creditScore = _creditDecisionService.GetCreditScore();

            if (creditScore < 550)
            {
                return "Declined";
            }
            else if (creditScore <= 675)
            {
                return "Maybe";
            }
            else
            {
                return "We look forward to doing business with you!";
            }
        }
    }

    public interface ICreditDecision
    {
        string MakeCreditDecision();
    }
}