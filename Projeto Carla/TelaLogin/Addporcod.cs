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
    public partial class Addporcod : Form
    {
        public Addporcod()
        {
            InitializeComponent();
        }

        // as variaveis são declaradas com public pra q possam ser acessadas por outros formulários
        public int quant = 0;
        public int cod = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bcancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bok_Click(object sender, EventArgs e)
        {
            quant = Convert.ToInt32(textquant.Text);
            cod = Convert.ToInt32(textcod.Text);
            MessageBox.Show("Item adicionado com sucesso");
            this.Dispose();
        }
    }
}
