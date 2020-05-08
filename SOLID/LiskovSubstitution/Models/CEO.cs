using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Models
{
    class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I am reviewing a direct report");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're fired!");
        }


    }
}
