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

namespace empresa
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 principal = new Form1();
           // principal.ShowDialog();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            DAO inserir = new DAO();

            int cod = Convert.ToInt32(codigo.Text);
            string nom = nome.Text;
            string tele = telefone.Text;    
            string ende = endereco.Text;

            MessageBox.Show(inserir.Inserir(cod, nom,tele,ende));
            this.Close();
        }
    }
}
