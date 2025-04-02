using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }// método construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
           
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
           
            Consultar consul = new Consultar();
            consul.ShowDialog();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
           
            Atualizar atua = new Atualizar();
            atua.ShowDialog();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            
            Excluir exc= new Excluir();
            exc.ShowDialog();
        }
    }
}
