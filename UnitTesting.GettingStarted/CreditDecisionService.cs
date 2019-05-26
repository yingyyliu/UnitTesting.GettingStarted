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
        public int GetCreditScore()
        {
            // Simulate a long (2500ms) call to a remote web service:
            Thread.Sleep(2500);

            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }
    }

    public interface ICreditDecisionService
    {
        int GetCreditScore();
    }
}
