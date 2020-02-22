using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._30
{
    public partial class Algoritm230 : Form
    {
        private double a, b, angle;

        public Algoritm230()
        {
            InitializeComponent();
        }

        private void inputCheckExeption()
        {
            try
            {
                a = Convert.ToDouble(tbA.Text);
                b = Convert.ToDouble(tbB.Text);
                angle = Convert.ToDouble(tbAngle.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkValues()
        {
            if (a <= 0 | b <= 0 | angle <= 0 | angle >= 180)
            {
                MessageBox.Show("Неверное значение в одном из полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            inputCheckExeption();

            if (checkValues())
            {
                if (angle == 90)
                {
                    if (a == b)
                    {
                        lblResult.Text = "квадрат";
                    }
                    else
                    {
                        lblResult.Text = "прямоугольник";
                    }
                }
                else
                {
                    if (a == b)
                    {
                        lblResult.Text = "ромб";
                    }
                    else
                    {
                        lblResult.Text = "обыкновенный параллелограмм";
                    }
                }
            }
        }
    }
}
