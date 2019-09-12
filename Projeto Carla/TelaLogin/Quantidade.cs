using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class Quantidade : Form
    {
        public Quantidade()
        {
            InitializeComponent();
        }

        public int unidades = 0;

        private void bok_Click(object sender, EventArgs e)
        {
            unidades = int.Parse(txtquant.Text);
            this.Dispose();
        }

        private void bcancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtquant_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
