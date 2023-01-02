using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachinesComparator.Forms
{
    public partial class ShowRankingForm : Form
    {
        private readonly Dictionary<string, double> ranking;

        public ShowRankingForm(Dictionary<string, double> alternativesRanking)
        {
            InitializeComponent();
            ranking = alternativesRanking;
        }

        private void ShowRankingForm_Load(object sender, EventArgs e)
        {
            var sth = ranking.ToArray();
            label1.Text = getPhrase(sth[0].Key, sth[0].Value);
            label2.Text = getPhrase(sth[1].Key, sth[1].Value);
            label3.Text = getPhrase(sth[2].Key, sth[2].Value);
        }

        private string getPhrase(string name, double ranking)
        {
            return name + ": " + Math.Round(ranking, 2);
        }
    }
}
