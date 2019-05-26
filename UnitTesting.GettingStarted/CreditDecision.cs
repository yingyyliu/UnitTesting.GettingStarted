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

        public string MakeCreditDecision(int creditScore)
        {
            return _creditDecisionService.GetDecision(creditScore);
        }
    }

    public interface ICreditDecision
    {
        string MakeCreditDecision(int creditScore);
    }
}