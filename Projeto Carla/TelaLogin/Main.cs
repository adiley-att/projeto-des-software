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


        //Método para pegar a quantidade de produtos

        int quant = 0;

        public void showquant()
        {
            Quantidade quantidad = new Quantidade();
            quantidad.ShowDialog();
            quant = quantidad.unidades;
            TxtControle.Text = TxtControle.Text + "\n quantidade: " + quant + " | ";
        }

        //Método para mostrar o nome do produto

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

        //Método para mostrar preço unitário

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

        //Valor total

        double valortotal = 0;

        public double showtprice(int id)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=root";

            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select preco from loginc.produtos where Id='" + id + "'", myConn);
            MySqlDataReader myReader;

            myConn.Open();

            myReader = SelectCommand.ExecuteReader();

            string controle = "";

            while (myReader.Read())
            {
                controle = myReader["preco"].ToString();
            }

            double preco = Convert.ToDouble(controle);
            double resultado = preco * quant;
            valortotal += resultado;

            TxtControle.Text = TxtControle.Text + "v tot: " + resultado + " | ";

            myConn.Close();
            
            return resultado;
        }

        //Botão de Login

        private void bLogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            string usu = login.usuario;
            bLogin.Visible = false;
            lblLogged.Text = ("Bem vindo " + usu + "!");
            lblLogged.Visible = true;
        }


        

        private void label10_Click(object sender, EventArgs e)
        {

            //aaaaaaaaaaa

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Botões de adicionar produto

        private void button1_Click(object sender, EventArgs e)
        {
            showquant();
            showname(1);
            showprice(1);
            showtprice(1);
        }

        private void barroz_Click(object sender, EventArgs e)
        {
            showquant();
            showname(2);
            showprice(2);
            showtprice(2);
        }

        private void bfeijao_Click(object sender, EventArgs e)
        {
            showquant();
            showname(3);
            showprice(3);
            showtprice(3);
        }

        private void bmacarrao_Click(object sender, EventArgs e)
        {
            showquant();
            showname(4);
            showprice(4);
            showtprice(4);
        }

        private void bovo_Click(object sender, EventArgs e)
        {
            showquant();
            showname(5);
            showprice(5);
            showtprice(5);
        }

        private void bmaca_Click(object sender, EventArgs e)
        {
            showquant();
            showname(6);
            showprice(6);
            showtprice(6);
        }

        private void bxampu_Click(object sender, EventArgs e)
        {
            showquant();
            showname(7);
            showprice(7);
            showtprice(7);
        }

        private void bdetergente_Click(object sender, EventArgs e)
        {
            showquant();
            showname(8);
            showprice(8);
            showtprice(8);
        }
        
        private void bmanga_Click_1(object sender, EventArgs e)
        {
            showquant();
            showname(9);
            showprice(9);
            showtprice(9);
        }

        private void bcuzcuz_Click(object sender, EventArgs e)
        {
            showquant();
            showname(10);
            showprice(10);
            showtprice(10);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showquant();
            showname(11);
            showprice(11);
            showtprice(11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showquant();
            showname(12);
            showprice(12);
            showtprice(12);
        }

        
    }
}
