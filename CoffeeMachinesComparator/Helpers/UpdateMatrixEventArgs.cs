using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeMachinesComparator.AHP;

namespace CoffeeMachinesComparator.Helpers
{
    public class UpdateMatrixEventArgs : EventArgs
    {
        public string Criterion;
        public List<AlternativesPairwiseComparisonModel> comparisons;

        public UpdateMatrixEventArgs(string criterion)
        {
            Criterion = criterion;
            comparisons = new List<AlternativesPairwiseComparisonModel>();
        }

        public void AddPairwiseComparison(AlternativesPairwiseComparisonModel comparison)
        {
            comparisons.Add(comparison);
        }
    }
}
