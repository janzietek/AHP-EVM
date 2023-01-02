using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachinesComparator.Forms;

public partial class EnterAlternativesForm : Form
{
    public EnterAlternativesForm()
    {
        InitializeComponent();
    }

    private void EnterAlternativesForm_Load(object sender, EventArgs e)
    {

    }

    private void Continue_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
        {
            MessageBox.Show("Cannot be empty");
            return;
        }

        List<string> list = new()
        {
            textBox1.Text,
            textBox2.Text,
            textBox3.Text
        };

        Form NextForm = new CriteriaWindowForm(list);
        NextForm.Show();
    }
}
