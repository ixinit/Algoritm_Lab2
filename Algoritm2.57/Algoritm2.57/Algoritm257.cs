using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._57
{
    public partial class Algoritm257 : Form
    {
        private double a, b, c;
        private int count;

        public Algoritm257()
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
            lblResult.Text = "";
            inputCheckExeption();
            count = 0;
            if (a < 0)
            {
                count++;
            }
            if (b < 0)
            {
                count++;
            }
            if (c < 0)
            {
                count++;
            }
            lblResult.Text = count.ToString();
        }
    }
}
