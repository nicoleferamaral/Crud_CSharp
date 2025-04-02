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
        public Atualizar()
        {
            InitializeComponent();
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

        }
    }
}
