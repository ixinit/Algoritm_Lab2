using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm2._25
{
    public partial class Algoritm225 : Form
    {
        private double price;
        public Algoritm225()
        {
            InitializeComponent();
        }

        private void inputCheckExeption()
        {
            try
            {
                price = Convert.ToDouble(tbPrice.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            inputCheckExeption();
            
            if(price <= 0)
            {
                MessageBox.Show("Значение меньше нуля, либо равено нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (price > 1000)
            {
                price = price * 19 / 20;
            }else if (price > 500 & price <= 1000)
            {
                price = price * 97 / 100;
            }
            lblSum.Text = price.ToString();
        }
    }
}
