using CoffeeMachinesComparator.Helpers;
using CoffeeMachinesComparator.AHP;

namespace CoffeeMachinesComparator.Forms
{
    public partial class FillMatrixByComparison : Form
    {
        public delegate void MatrixUpdateHandler(object sender, UpdateMatrixEventArgs e);
        public event MatrixUpdateHandler MatrixUpdate;
        private List<string> Alternatives;
        private string Criterion;

        public FillMatrixByComparison(List<string> alternatives, string criterion)
        {
            InitializeComponent();
            Alternatives = alternatives;
            Criterion = criterion;
        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox12.Checked = !CheckBox11.Checked;
        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox11.Checked = !CheckBox12.Checked;
        }

        private void CheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox22.Checked = !CheckBox21.Checked;
        }

        private void CheckBox22_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox21.Checked = !CheckBox22.Checked;
        }

        private void CheckBox31_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox32.Checked = !CheckBox31.Checked;
        }

        private void CheckBox32_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox31.Checked = !CheckBox32.Checked;
        }

        private void PassData_Click(object sender, EventArgs e)
        {
            UpdateMatrixEventArgs args = new(Criterion);
            args.AddPairwiseComparison(new AlternativesPairwiseComparisonModel(Alternatives[0], Alternatives[1], CheckBox11.Checked, (int)NumericUpDown1.Value));
            args.AddPairwiseComparison(new AlternativesPairwiseComparisonModel(Alternatives[0], Alternatives[2], CheckBox21.Checked, (int)NumericUpDown2.Value));
            args.AddPairwiseComparison(new AlternativesPairwiseComparisonModel(Alternatives[1], Alternatives[2], CheckBox31.Checked, (int)NumericUpDown3.Value));
            MatrixUpdate(this, args);
            Dispose();
        }

        private void FillMatrixByComparison_Load(object sender, EventArgs e)
        {
            CheckBox11.Text = Alternatives[0];
            CheckBox12.Text = Alternatives[1];
            CheckBox21.Text = Alternatives[0];
            CheckBox22.Text = Alternatives[2];
            CheckBox31.Text = Alternatives[1];
            CheckBox32.Text = Alternatives[2];
        }
    }
}
