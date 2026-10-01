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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textusuario_TextChanged(object sender, EventArgs e)
        {
            if (textusuario.Text == "marleny" && Textcontraseña.Text == "63=36") ;
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();
            }
            MessageBox.Show("intente de nuevo");
        

        }
    }
}
