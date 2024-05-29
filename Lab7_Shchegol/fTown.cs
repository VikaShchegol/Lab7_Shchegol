using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Lab7_Shchegol
{
    public partial class fTown : Form
    {
        private Town _town;
        public fTown(ref Town town)
        {
            InitializeComponent();
            _town = town;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtCountry.Text) ||
        string.IsNullOrWhiteSpace(txtRegion.Text) ||
        !int.TryParse(txtPopulation.Text, out int population) ||
        !double.TryParse(txtYearIncome.Text, out double yearIncome) ||
        !double.TryParse(txtSquare.Text, out double square))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }

            _town.Name = txtName.Text;
            _town.Country = txtCountry.Text;
            _town.Region = txtRegion.Text;
            _town.Population = population;
            _town.YearIncome = yearIncome;
            _town.Square = square;
            _town.HasPort = chkHasPort.Checked;
            _town.HasAirport = chkHasAirport.Checked;

            this.DialogResult = DialogResult.OK;
        }

    }
}
