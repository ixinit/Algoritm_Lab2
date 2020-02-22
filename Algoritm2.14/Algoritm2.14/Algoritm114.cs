using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._14
{
    public partial class Algoritm114 : Form
    {
        private double minute, sum;

        public Algoritm114()
        {
            InitializeComponent();
            cbDay.SelectedIndex = 0;
        }

        private void inputCheckExeption()
        {
            try
            {
                minute = Convert.ToDouble(tbMinet.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool isDiscountDay()
        {
            if (cbDay.SelectedIndex == 6 | cbDay.SelectedIndex == 5)
            {
                return true;
            }
            return false;
        }
        private void btbCalc_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            
            if (minute <= 0)
            {
                MessageBox.Show("Значение минут меньше нуля, либо равено нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isDiscountDay())
                {
                    sum = minute * 2.3 * 4 / 5;
                }
                else
                {
                    sum = minute * 2.3;
                }
                lblEchoSum.Text = Convert.ToString(sum);
            }
        }
    }
}
