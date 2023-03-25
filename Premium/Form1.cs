using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premium
{
    public partial class FormPremiumScoring : Form
    {
        public FormPremiumScoring()
        {
            InitializeComponent();
        }
        Double TotalPremium = 0;
        Double SpeedPremium = 0;
        Double DecorPremium = 0;
        Double QualityPremium = 0;
        private void RadioButtonSpeed5_CheckedChanged(object sender, EventArgs e)
        {
            SpeedPremium = 5;
        }

        private void RadioButtonSpeed4_CheckedChanged(object sender, EventArgs e)
        {
            SpeedPremium = 4;
        }

        private void RadioButtonSpeed3_CheckedChanged(object sender, EventArgs e)
        {
            SpeedPremium = 3;
        }

        private void RadioButtonSpeed2_CheckedChanged(object sender, EventArgs e)
        {
            SpeedPremium = 2;
        }

        private void RadioButtonSpeed1_CheckedChanged(object sender, EventArgs e)
        {
            SpeedPremium = 1;
        }

        private void RadioButtonSpeed0_CheckedChanged(object sender, EventArgs e)
        {
            SpeedPremium = 0;
        }

        private void RadioButtonDecor5_CheckedChanged(object sender, EventArgs e)
        {
            DecorPremium = 5;
        }

        private void RadioButtonDecor4_CheckedChanged(object sender, EventArgs e)
        {
            DecorPremium = 4;
        }

        private void RadioButtonDecor3_CheckedChanged(object sender, EventArgs e)
        {
            DecorPremium = 3;
        }

        private void RadioButtonDecor2_CheckedChanged(object sender, EventArgs e)
        {
            DecorPremium = 2;
        }

        private void RadioButtonDecor1_CheckedChanged(object sender, EventArgs e)
        {
            DecorPremium = 1;
        }

        private void RadioButtonDecor0_CheckedChanged(object sender, EventArgs e)
        {
            DecorPremium = 0;
        }

        private void RadioButtonQuality5_CheckedChanged(object sender, EventArgs e)
        {
            QualityPremium = 5;
        }

        private void RadioButtonQuality4_CheckedChanged(object sender, EventArgs e)
        {
            QualityPremium = 4;
        }

        private void RadioButtonQuality3_CheckedChanged(object sender, EventArgs e)
        {
            QualityPremium = 3;
        }

        private void RadioButtonQuality2_CheckedChanged(object sender, EventArgs e)
        {
            QualityPremium = 2;
        }

        private void RadioButtonQuality1_CheckedChanged(object sender, EventArgs e)
        {
            QualityPremium = 1;
        }

        private void RadioButtonQuality0_CheckedChanged(object sender, EventArgs e)
        {
            QualityPremium = 0;
        }

        private void ButtonScoring_Click(object sender, EventArgs e)
        {
            if (TextBoxSalary.Text == "")
            {
                MessageBox.Show("Укажите пожалуйста плату за работу");
            }
            else
            {
                if (TextBoxAdditionalPremium.Text == "")
                {
                    TotalPremium = (Convert.ToDouble(TextBoxSalary.Text) / 100) * (SpeedPremium + DecorPremium + QualityPremium);
                }
                else
                {
                    TotalPremium = (Convert.ToDouble(TextBoxSalary.Text) / 100) * (SpeedPremium + DecorPremium + QualityPremium) + Convert.ToInt32(TextBoxAdditionalPremium.Text);
                }
                LabelTotalPremium.Text = "Премия за работу составляет: " + Convert.ToInt32(TotalPremium) + " " + TextBoxCurrency.Text;
            }
        }
    }
}
