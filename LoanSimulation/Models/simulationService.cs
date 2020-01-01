using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanSimulation.Models
{
    public class simulationService
    {

        public double calculatePayment(simulation simul)
        {
            double result = simul.amount.Value * simul.rate.Value;
            return result;
        }
    }
}