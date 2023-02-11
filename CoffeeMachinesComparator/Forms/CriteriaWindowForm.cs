using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeMachinesComparator.AHP;
using CoffeeMachinesComparator.Helpers;

namespace CoffeeMachinesComparator.Forms;

public partial class CriteriaWindowForm : Form
{
    AHPHierarchy Hierarchy;
    protected List<string> Alternatives;
    protected bool CriterionsCompared = false;
    protected Dictionary<string, bool> MatrixesFilled = new();

    public CriteriaWindowForm(List<string> alternatives)
    {
        InitializeComponent();
        Alternatives = alternatives;
        Hierarchy = new AHPHierarchy(alternatives);
        for (int i = 0; i < Hierarchy.Criterions.Count; i++)
        {
            MatrixesFilled.Add(Hierarchy.Criterions[i], false);
        }
    }

    private void CriteriaWindowForm_Load(object sender, EventArgs e)
    {
        Experts.Text = "Number of experts: " + Hierarchy.CriterionImportanceMatrices.Count.ToString();
        Button2.Text = Hierarchy.Criterions[0];
        Button3.Text = Hierarchy.Criterions[1];
        Button4.Text = Hierarchy.Criterions[2];
    }

    private void CalculateEVG_CalculateWithEVG_Click(object sender, EventArgs e)
    {
        if (IsValid())
        {
            Experts.Text = Hierarchy.CriterionImportanceMatrices.Count.ToString();
            Consistency2.Text = Math.Round(Hierarchy.AlternativesCriterionMatrixes[0].GetMatrixConsistencyIndex(), 2).ToString();
            Consistency3.Text = Math.Round(Hierarchy.AlternativesCriterionMatrixes[1].GetMatrixConsistencyIndex(), 2).ToString();
            Consistency4.Text = Math.Round(Hierarchy.AlternativesCriterionMatrixes[2].GetMatrixConsistencyIndex(), 2).ToString();

            var ranking = Hierarchy.CalculateRankingWithEVGMethod();
            Form form = new ShowRankingForm(ranking);
            form.Show();
        }
    }

    private void CalculateGVM_CalculateWithGVM_Click(object sender, EventArgs e)
    {
        if (IsValid())
        {
            Experts.Text = Hierarchy.CriterionImportanceMatrices.Count.ToString();
            Consistency2.Text = Math.Round(Hierarchy.AlternativesCriterionMatrixes[0].GetMatrixConsistencyIndex(), 2).ToString();
            Consistency3.Text = Math.Round(Hierarchy.AlternativesCriterionMatrixes[1].GetMatrixConsistencyIndex(), 2).ToString();
            Consistency4.Text = Math.Round(Hierarchy.AlternativesCriterionMatrixes[2].GetMatrixConsistencyIndex(), 2).ToString();

            var ranking = Hierarchy.CalculateRankingWithGVMMethod();
            Form form = new ShowRankingForm(ranking);
            form.Show();
        }
    }

    private bool IsValid()
    {
        if (!CriterionsCompared)
        {
            MessageBox.Show("You forgot to compare Criterions!");
            return false;
        }
        foreach (bool isFilled in MatrixesFilled.Values)
        {
            if (!isFilled)
            {
                MessageBox.Show("You forgot to compare alternatives according to all Criterion!");
                return false;
            }
        }
        return true;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        FillMatrixByComparison f = new(Hierarchy.Criterions, Button1.Text);
        f.MatrixUpdate += new FillMatrixByComparison.MatrixUpdateHandler(AddExpert);
        f.Show();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        FillMatrixByComparison f = new(Alternatives, Button2.Text);
        f.MatrixUpdate += new FillMatrixByComparison.MatrixUpdateHandler(FillAlternativeMatrix);
        f.Show();
    }

    private void Button3_Click(object sender, EventArgs e)
    {
        FillMatrixByComparison f = new(Alternatives, Button3.Text);
        f.MatrixUpdate += new FillMatrixByComparison.MatrixUpdateHandler(FillAlternativeMatrix);
        f.Show();
    }

    private void Button4_Click(object sender, EventArgs e)
    {
        FillMatrixByComparison f = new(Alternatives, Button4.Text);
        f.MatrixUpdate += new FillMatrixByComparison.MatrixUpdateHandler(FillAlternativeMatrix);
        f.Show();
    }

    private void FillAlternativeMatrix(object sender, UpdateMatrixEventArgs e)
    {
        Hierarchy.FillAlternativeMatrix(e.Criterion, e.comparisons);
        MatrixesFilled[e.Criterion] = true;
    }

    private void AddExpert(object sender, UpdateMatrixEventArgs e)
    {
        Hierarchy.AddExpert(e.comparisons);
        CriterionsCompared = true;
        Experts.Text = "Number of experts: " + Hierarchy.CriterionImportanceMatrices.Count.ToString();
    }
}
