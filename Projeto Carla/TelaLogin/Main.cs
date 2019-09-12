using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;


namespace TelaLogin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        int quant = 0;

        public void showquant()
        {
            Quantidade quantidad = new Quantidade();
            quantidad.ShowDialog();
            quant = quantidad.unidades;
            TxtControle.Text = TxtControle.Text + "\n quantidade: " + quant + " | ";
        }

        public string showname(int id)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";

            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select nome from loginc.produtos where Id='" + id + "'", myConn);
            MySqlDataReader myReader;

            myConn.Open();

            myReader = SelectCommand.ExecuteReader();

            string resultado = "";

            while (myReader.Read())
            {
                resultado = myReader["nome"].ToString();
            }


            TxtControle.Text = TxtControle.Text + "produto: " + resultado + " | ";

            myConn.Close();
            
            return resultado;

        }

        public string showprice(int id)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";

            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select preco from loginc.produtos where Id='" + id + "'", myConn);
            MySqlDataReader myReader;

            myConn.Open();

            myReader = SelectCommand.ExecuteReader();

            string resultado = "";

            while (myReader.Read())
            {
                resultado = myReader["preco"].ToString();
            }


            TxtControle.Text = TxtControle.Text + "v un: " + resultado + " | ";

            myConn.Close();

            return resultado;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            string usu = login.usuario;
            bLogin.Visible = false;
            lblLogged.Text = ("Bem vindo " + usu + "!");
            lblLogged.Visible = true;
        }

        private void lblLogged_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showquant();
            showname(1);
            showprice(1);
        }

        private void label10_Click(object sender, EventArgs e)
        {

            //aaaaaaaaaaa

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void barroz_Click(object sender, EventArgs e)
        {
            showquant();
            showname(2);
            showprice(2);
        }

        private void bfeijao_Click(object sender, EventArgs e)
        {
            showquant();
            showname(3);
            showprice(3);
        }

        private void bmacarrao_Click(object sender, EventArgs e)
        {
            showquant();
            showname(4);
            showprice(4);
        }

        private void bovo_Click(object sender, EventArgs e)
        {
            showquant();
            showname(5);
            showprice(5);
        }

        private void bmaca_Click(object sender, EventArgs e)
        {
            showquant();
            showname(6);
            showprice(6);
        }

        private void bxampu_Click(object sender, EventArgs e)
        {
            showquant();
            showname(7);
            showprice(7);
        }

        private void bdetergente_Click(object sender, EventArgs e)
        {
            showquant();
            showname(8);
            showprice(8);
        }
    }
}
