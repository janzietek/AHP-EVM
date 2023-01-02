using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachinesComparator.AHP;

public class AlternativesPairwiseComparisonModel
{
    public string FirstAlternative;
    public string SecondAlternative;
    public bool IsFirstBetter;
    public int HowMuchBetter;

    public AlternativesPairwiseComparisonModel(string first, string second, bool isFirstBetter, int howMuchBetter)
    {
        FirstAlternative = first;
        SecondAlternative = second;
        IsFirstBetter = isFirstBetter;
        HowMuchBetter = howMuchBetter;
    }
}
