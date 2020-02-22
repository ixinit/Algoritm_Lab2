using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._3
{
    public partial class Algoritm23 : Form
    {
        public Algoritm23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            try
            {
                x = Convert.ToDouble(tbX.Text);

                if (x>3)
                {
                    y = Math.Pow(x, 2) + 5;
                }
                else
                {
                    y = x - 8;
                }
                lblEchoY.Text = Convert.ToString(y);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
