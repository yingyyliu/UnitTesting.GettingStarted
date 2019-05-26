using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTesting.GettingStarted.CreditDecisionExample
{
    public class CreditDecisionService : ICreditDecisionService
    {
        public string GetDecision(int creditScore)
        {
            // Simulate a long (2500ms) call to a remote web service:
            Thread.Sleep(2500);

            if (creditScore < 550)
                return "Declined";
            if (creditScore <= 675)
                return "Maybe";
            return "We look forward to doing business with you!";
        }
    }

    public interface ICreditDecisionService
    {
        string GetDecision(int creditScore);
    }
}
