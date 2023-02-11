using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace CoffeeMachinesComparator.AHP;

public class AHPHierarchy
{
    public List<PairwiseComparisonMatrix> AlternativesCriterionMatrixes = new();
    public List<PairwiseComparisonMatrix> CriterionImportanceMatrices = new();
    private List<string> criterions = new();
    private List<string> alternatives = new();

    public List<string> Criterions { get => criterions; set => criterions = value; }
    public List<string> Alternatives { get => alternatives; set => alternatives = value; }

    public AHPHierarchy(List<string> alternatives)
    {
        GetCriterionsFromJson();

        this.alternatives = alternatives;
        foreach (string criterion in criterions)
        {
            AlternativesCriterionMatrixes.Add(new PairwiseComparisonMatrix(alternatives, criterion));
        }
    }

    public void FillAlternativeMatrix(string matrixCriterion, List<AlternativesPairwiseComparisonModel> alternativesComparison)
    {
        var matrix = AlternativesCriterionMatrixes.FirstOrDefault(x => x.CriterionName.Equals(matrixCriterion));

        foreach (AlternativesPairwiseComparisonModel alternative in alternativesComparison)
        {
            int first = alternatives.IndexOf(alternative.FirstAlternative);
            int second = alternatives.IndexOf(alternative.SecondAlternative);
            if (alternative.IsFirstBetter)
            {
                matrix.SetValueAt(first, second, (double)alternative.HowMuchBetter);
            }
            else
            {
                matrix.SetValueAt(second, first, (double)alternative.HowMuchBetter);
            }
        }
    }

    public void AddExpert(List<AlternativesPairwiseComparisonModel> criterionComparison)
    {
        PairwiseComparisonMatrix expert = new(criterions, "CriterionsImportance");
        foreach (AlternativesPairwiseComparisonModel criterion in criterionComparison)
        {
            int first = criterions.IndexOf(criterion.FirstAlternative);
            int second = criterions.IndexOf(criterion.SecondAlternative);
            if (criterion.IsFirstBetter)
            {
                expert.SetValueAt(first, second, (double)criterion.HowMuchBetter);
            }
            else
            {
                expert.SetValueAt(second, first, (double)criterion.HowMuchBetter);
            }
        }
        this.CriterionImportanceMatrices.Add(expert);
    }

    public Dictionary<string, double> CalculateRankingWithEVGMethod()
    {
        Dictionary<string, double> AlternativesRanking = new();
        AlternativesRanking.Clear();
        List<Vector<double>> alternativesWagesVectors = new();

        foreach(string criterion in criterions)
        {
            PairwiseComparisonMatrix matrix = AlternativesCriterionMatrixes.FirstOrDefault(c => c.CriterionName.Equals(criterion, StringComparison.Ordinal));
            alternativesWagesVectors.Add(matrix.CalculateEigenVector());
        }

        alternativesWagesVectors.Reverse();

        Matrix<double> alternativesWagesMatrix = Matrix<double>.Build.DenseOfColumnVectors(alternativesWagesVectors);

        Vector<double> criterionsWagesVector = CalculateCriterionsWagesVector().CalculateEigenVector();

        Vector<double> ranking = alternativesWagesMatrix * criterionsWagesVector;

        foreach (string alternative in alternatives)
        {
            AlternativesRanking.Add(alternative, ranking[alternatives.IndexOf(alternative)]);
        }

        return AlternativesRanking;
    }

    public Dictionary<string, double> CalculateRankingWithGVMMethod()
    {
        Dictionary<string, double> AlternativesRanking = new();
        AlternativesRanking.Clear();
        List<Vector<double>> alternativesWagesVectors = new();

        foreach (string criterion in criterions)
        {
            PairwiseComparisonMatrix matrix = AlternativesCriterionMatrixes.FirstOrDefault(c => c.CriterionName.Equals(criterion, StringComparison.Ordinal));
            alternativesWagesVectors.Add(matrix.CalculateGeometricVector());
        }

        alternativesWagesVectors.Reverse();

        Matrix<double> alternativesWagesMatrix = Matrix<double>.Build.DenseOfColumnVectors(alternativesWagesVectors);

        Vector<double> criterionsWagesVector = CalculateCriterionsWagesVector().CalculateGeometricVector();

        Vector<double> ranking = alternativesWagesMatrix * criterionsWagesVector;

        foreach (string alternative in alternatives)
        {
            AlternativesRanking.Add(alternative, ranking[alternatives.IndexOf(alternative)]);
        }

        return AlternativesRanking;
    }

    private PairwiseComparisonMatrix CalculateCriterionsWagesVector()
    {
        PairwiseComparisonMatrix CriterionsMatrix = new(criterions, "CriterionsImportance");

        for (int i = 0; i < Criterions.Count; i++)
        {
            for (int j = 0; j < Criterions.Count; j++)
            {
                double value = 0.0;
                foreach (PairwiseComparisonMatrix matrix in CriterionImportanceMatrices)
                {
                    value += matrix.GetValueAt(i, j);
                }
                CriterionsMatrix.SetValueAt(i, j, value / CriterionImportanceMatrices.Count);
            }
        }

        return CriterionsMatrix;
    }


    private void GetCriterionsFromJson()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
        var path = basePath + @"\AHP\Criterions.json";
        string jsonFile;

        FileInfo f = new FileInfo(path);
        if (f.Exists)
        {
            jsonFile = File.ReadAllText(path);
        }
        else
        {
            Console.WriteLine("Json file not found");
            return;
        }

        var criterions = JsonConvert.DeserializeObject<JsonCriterions>(jsonFile);
        this.criterions = criterions.Criterions.ToList();
    }
}


public class JsonCriterions
{
    public string[] Criterions;
}