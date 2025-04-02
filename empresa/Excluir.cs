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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

      

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
           // Form1 principal = new Form1();
           // principal.ShowDialog();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void exclui_Click(object sender, EventArgs e)
        {

        }
    }
}
