using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_final_4tobi
{
    public partial class Form2 : Form
    {
        private int n3;

        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int Producto = Num1 + Num2;
            MessageBox.Show("El resultado del producto es" + Producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int suma = Num1 + Num2;
            MessageBox.Show("el resultado de la suma es" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextVar1.Text);
            int n2 = int.Parse(TextVar2.Text);
            int potencial= 1;
            while (3 != n2) ;
            {
                potencial = potencial * n1;
                n3 = n3 + 1;
            }



        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(TextVar1.Text);
            float n2 = float.Parse(TextVar2.Text);
            if (n2 > 0) ;
            { float Division = n1 / n2;
                MessageBox.Show("el resultadoes" + Division);
                 }
        }
    }
}
