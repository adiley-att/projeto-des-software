using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TelaLogin
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //essa parte é chata de explicar entao se quiser saber como funciona me pergunta q eu mando vc aprender sozinho lixo

        private void blogin_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";

            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select * from loginc.users where Username='" + this.txtUser.Text + "'", myConn);
            MySqlDataReader myReader;

            myConn.Open();

            myReader = SelectCommand.ExecuteReader();


            int count = 0;
            bool existe = false;


            while (myReader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                existe = true;
            }

            myReader.Close();

            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Usuário'");
            }
            else if(txtPassword.Text != txtPassword1.Text)
            {
                MessageBox.Show("Senhas diferentes, por favor tente novamente");
            }
            else if(existe == true){
                MessageBox.Show("Usuário já existe, tente outro usuário");
            }
            else
            {
                try
                {
                    
                    MySqlCommand SelectCommand1 = new MySqlCommand("insert into loginc.users (Username, Passwd) values ('" + this.txtUser.Text + "', '" + this.txtPassword.Text + "');", myConn);
                    MySqlDataReader myReader1;

                    myReader1 = SelectCommand1.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Sucesso!");
                this.Dispose();
            }

        }

        //o bagulhinho de mostrar a senha

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword1.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword1.UseSystemPasswordChar = false;
            }
        }
    }
}
