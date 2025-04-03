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
    public partial class Atualizar : Form
    {
        DAO atua;
        public Atualizar()
        {
            atua= new DAO();
            InitializeComponent();
            codigo.ReadOnly= false;
            nome.ReadOnly= true;
            telefone.ReadOnly= true;
            endereco.ReadOnly= true;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
           // Form1 principal = new Form1();
          //  principal.ShowDialog();
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

        private void atualiza_Click(object sender, EventArgs e)
        {
            int codi = Convert.ToInt32(codigo.Text);
            string nom = nome.Text;
            string tele = telefone.Text;
            string ende = endereco.Text;
            atua.Atualizar(codi, "nome", nom);
            atua.Atualizar(codi, "telefone", tele);
            atua.Atualizar(codi, "endereco", ende);
            MessageBox.Show("Dados Atualizados com sucesso");
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int codi = Convert.ToInt32(codigo.Text);

            atua.ConsultarPorCodigo(codi); // coletando o código

            nome.Text = atua.ConsultarPorCodigo(codi); //Preenchendo o campo nome

            codigo.ReadOnly= true;
            nome.ReadOnly = false;
            telefone.ReadOnly = false;
            endereco.ReadOnly = false;

        }
    }
}
