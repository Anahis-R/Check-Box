using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Box
{
    public partial class NumeroInverso : Form
    {
        public NumeroInverso()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            lblRespuesta.Text = Convert.ToString(inverso(numero));
        }
        static int inverso(int n)
        {
            int numeroinver=0;
            while(n > 0)
            {
                numeroinver = numeroinver * 10 + n % 10;
                n = n / 10;
            }
            return numeroinver;

        }
    }
}
