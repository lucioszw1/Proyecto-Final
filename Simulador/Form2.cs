using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncrear_Click_1(object sender, EventArgs e)
        {
            Form1 formaSiguiente = new Form1();
            this.Hide();
            formaSiguiente.Show();
        }
    }
}
