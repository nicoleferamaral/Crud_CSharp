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
        public Consultar()
        {
            InitializeComponent();
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

        private void consulta_Click(object sender, EventArgs e)
        {

        }
    }
}
