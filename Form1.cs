using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Declarando váriaveis
        double n1, n2, total;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);

            total = n1 - n2;

            txtResultado.Text = total.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);

            total = n1 / n2;

            txtResultado.Text = total.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtValor1.Clear();
            txtValor2.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair mesmo ?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes);
            this.Close();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);

            total = n1 * n2;

            txtResultado.Text = total.ToString();
        }

        

        private void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtValor1.Text);
            n2 = Convert.ToDouble(txtValor2.Text);

            total = n1 + n2;

            txtResultado.Text = total.ToString();

        }
    }
}
