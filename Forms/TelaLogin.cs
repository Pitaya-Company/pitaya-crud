﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pitaya_crud.Forms;
using pitaya_crud.Services;

namespace PitayaCompany
{
    public partial class TelaLogin : Form
    {
        private readonly AuthService _authService;

        public TelaLogin()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = TextBoxLogin.Text.Trim();
            string senha = TextBoxSenha.Text.Trim();

            if (_authService.Login(email,senha))
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                new TelaListagem().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lema_Click(object sender, EventArgs e)
        {

        }

        private void FormaBackground_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBoxLogin.Clear();
            TextBoxSenha.Clear();
        }
    }
}
