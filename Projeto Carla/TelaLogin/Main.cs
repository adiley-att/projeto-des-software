﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace TelaLogin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

            Quantidade quantidad = new Quantidade();
            quantidad.Show();

        }

        private void label10_Click(object sender, EventArgs e)
        {

            //aaaaaaaaaaa

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
