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
    public PairwiseComparisonMatrix CriterionImportanceMatrix;
    private List<string> criterions = new();
    private List<string> alternatives = new();
    public Dictionary<string, double> AlternativesRanking = new();

    public List<string> Criterions { get => criterions; set => criterions = value; }
    public List<string> Alternatives { get => alternatives; set => alternatives = value; }

    public AHPHierarchy(List<string> alternatives)
    {
        GetCriterionsFromJson();
        CriterionImportanceMatrix = new PairwiseComparisonMatrix(criterions, "CriterionsImportance");

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

    public void FilCriterionMatrix(List<AlternativesPairwiseComparisonModel> criterionComparison)
    {
        foreach (AlternativesPairwiseComparisonModel criterion in criterionComparison)
        {
            int first = criterions.IndexOf(criterion.FirstAlternative);
            int second = criterions.IndexOf(criterion.SecondAlternative);
            if (criterion.IsFirstBetter)
            {
                CriterionImportanceMatrix.SetValueAt(first, second, (double)criterion.HowMuchBetter);
            }
            else
            {
                CriterionImportanceMatrix.SetValueAt(second, first, (double)criterion.HowMuchBetter);
            }
        }
    }

    public void FillRanking()
    {
        AlternativesRanking.Clear();
        List<Vector<double>> alternativesWagesVectors = new();

        foreach(string criterion in criterions)
        {
            PairwiseComparisonMatrix matrix = AlternativesCriterionMatrixes.FirstOrDefault(c => c.CriterionName.Equals(criterion));
            alternativesWagesVectors.Add(matrix.CalculateEigenVector());
        }

        alternativesWagesVectors.Reverse();

        Matrix<double> alternativesWagesMatrix = Matrix<double>.Build.DenseOfColumnVectors(alternativesWagesVectors);

        Vector<double> criterionsWagesVector = CriterionImportanceMatrix.CalculateEigenVector();

        Vector<double> ranking = alternativesWagesMatrix * criterionsWagesVector;

        foreach (string alternative in alternatives)
        {
            AlternativesRanking.Add(alternative, ranking[alternatives.IndexOf(alternative)]);
        }
    }

    public void AddCriterion(string name)
    {
        criterions.Add(name);
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