using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._1
{
    public partial class Algoritm21 : Form
    {
        public Algoritm21()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x, a, b; 
            string res;
            try
            {
                x = Convert.ToDouble(tbX.Text);
                a = Convert.ToDouble(tbA.Text);
                b = Convert.ToDouble(tbB.Text);

                if (a > x | b < x)
                {
                    res = "нет";
                }
                else
                {
                    res = "да";
                }
                lblEchoRes.Text = res;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
