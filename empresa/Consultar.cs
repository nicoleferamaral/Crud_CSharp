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
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarView();
            NomeColunas();
            Adicionardados();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 principal = new Form1();
           // principal.ShowDialog();
        }

     

        private void consulta_Click(object sender, EventArgs e)
        {

        }

        public void NomeColunas()
        {
            View.Columns[0].Name = "Código";
            View.Columns[1].Name = "Nome";
            View.Columns[2].Name = "Telefone";
            View.Columns[3].Name = "Endereço";

        }

        public void ConfigurarView()
        {
            View.AllowUserToAddRows = false; //Usuario não pode adicionar linhas
            View.AllowUserToDeleteRows = false; //Não pode apagar linhas
            View.AllowUserToResizeColumns = false; //Não pode redimensionar colunas
            View.AllowUserToResizeRows= false; // Não pode redimensionar linhas

            View.ColumnCount = 4;
        }

        public void Adicionardados()
        {
            consul.PreencherVetor(); //Preencher vetor com dados do banco
            for(int i = 0; i < consul.QuantidadeDados(); i++) {
                View.Rows.Add(consul.codigo[i], consul.nome[i], consul.telefone[i], consul.endereco[i]);
            }
        }

        private void View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
