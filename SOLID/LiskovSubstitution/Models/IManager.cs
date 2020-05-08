using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Models
{
    interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
