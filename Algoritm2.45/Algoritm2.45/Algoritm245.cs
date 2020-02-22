using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._45
{
    public partial class Algoritm245 : Form
    {
        private double kmch, mc;
        public Algoritm245()
        {
            InitializeComponent();
        }
        private void inputCheckExeption()
        {
            try
            {
                kmch = Convert.ToDouble(tbKmCh.Text);
                mc = Convert.ToDouble(tbMC.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       /* private bool checkValues()
        {
            if (a <= 0 | b <= 0 | angle <= 0 | angle >= 180)
            {
                MessageBox.Show("Неверное значение в одном из полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }*/
        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            inputCheckExeption();

            if (kmch * 5 / 18 == mc)
            {
                lblResult.Text = "=";
            }
            else if (kmch * 5 / 18 > mc)
            {
                lblResult.Text = ">";
            }
            else
            {
                lblResult.Text = "<";
            }
        }
    }
}
