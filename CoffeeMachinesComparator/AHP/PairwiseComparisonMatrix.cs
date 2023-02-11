using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace CoffeeMachinesComparator.AHP;

public class PairwiseComparisonMatrix
{
    public readonly string CriterionName;
    private Matrix<double> ?matrix;
    private readonly int matrixSize;
    public readonly List<string> Alternatives;

    public PairwiseComparisonMatrix(List<string> alternatives, string criterionName)
    {
        Alternatives = alternatives;
        matrixSize = alternatives.Count;
        this.CriterionName = criterionName;
        matrix = Matrix<double>.Build.DenseIdentity(matrixSize);
    }

    public Vector<double> CalculateEigenVector()
    {
        Evd<double> evd;
        evd = matrix.Evd();
        var eigenValues = evd.EigenValues;
        var eigenValuesReal = eigenValues.Real();
        var maxindex = eigenValuesReal.MaximumIndex();

        var values = evd.EigenVectors;
        var column = values.Column(maxindex);
        if (column.Sum() < 0)
        {
            column= column.Multiply(-1.0);
        }
        column = column.Normalize(1.0);

        return column;
    }

    public Vector<double> CalculateGeometricVector()
    {
        Vector<double> gvm = Vector<double>.Build.Dense(matrixSize);

        for (int i = 0; i < matrixSize; i++)
        {
            double val = 1.0;
            for (int j = 0; j < matrixSize; j++)
            {
                val *= matrix.At(i, j);
            }
            gvm[i] = Math.Pow(val, 1.0 / matrixSize);
        }

        var sum = gvm.Sum();

        return gvm / sum;
    }

    public double GetMatrixConsistencyIndex()
    {
        int n = Alternatives.Count;
        Evd<double> evd;
        evd = matrix.Evd();
        var eigenValues = evd.EigenValues;
        var eigenValuesReal = eigenValues.Real();
        var max = eigenValuesReal.Max();

        return (max - n) / (n - 1);
    }

    public void SetValueAt(int i, int j, double value)
    {
        matrix[i, j] = value;
        matrix[j, i] = 1 / value;
    }

    public double GetValueAt(int i, int j)
    {
        return matrix[i, j];
    }

    #region Getters and Setters
    public Matrix<double> Matrix { get => matrix; set => matrix = value; }
    #endregion
}
