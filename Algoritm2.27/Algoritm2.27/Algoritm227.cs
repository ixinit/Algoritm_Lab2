using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._27
{
    public partial class Algoritm227 : Form
    {
        private double a, b, c, D, x1, x2;
        public Algoritm227()
        {
            InitializeComponent();
        }
        private void inputCheckExeption()
        {
            try
            {
                a = Convert.ToDouble(tbA.Text);
                b = Convert.ToDouble(tbB.Text);
                c = Convert.ToDouble(tbC.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            D = Math.Pow(b, 2) - 4 * a * c;
            if(D >0 || D == 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                lblResult.Text = "x1 = " + x1 + " x2 = " + x2;
            }
            else
            {
                lblResult.Text = "Действительных корней нет";
            }
        }
    }
}
