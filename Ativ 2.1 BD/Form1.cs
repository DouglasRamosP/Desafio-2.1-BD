using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ativ_2._1_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmExecutar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder string_conexao = new MySqlConnectionStringBuilder();
            string_conexao.Server = txtServidor.Text;
            string_conexao.UserID = txtUsuario.Text;
            string_conexao.Password = txtSenha.Text;
            string_conexao.Database = txtBanco.Text;

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = string_conexao.ConnectionString;

            try
            {
                conexao.Open();
                MessageBox.Show("Conectado!");
                try
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandText = txtSql.Text;
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery(); //executar sem retorno
                }
                catch
                {
                    MessageBox.Show("Erro ao criar tabela!");
                }
            }

            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao conectar!");
            }



            finally
            {
                conexao.Close();
            }
        }
    }
}
