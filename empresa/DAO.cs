using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace empresa
{
     class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;

        public DAO() { 
            
            conexao = new MySqlConnection("server=localhost;Database=tintCSharp;Uid=root;password=");

            try
            {
                conexao.Open();
                MessageBox.Show("Conectado");
            } catch(Exception Erro) {
                MessageBox.Show("Algo deu errado \n\n\n" + Erro);
            }

        }// fim do construtor

        public string Inserir(int codigo, string nome, string telefone, string endereco)
        {
            string inserir = $"insert into pessoa(codigo,nome,telefone,endereco) values('{codigo}','{nome}','{telefone}','{endereco}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado";
            return resultado;
        } //fim do inserir

        public void PreencherVetor()
        {
            string query = "select * from pessoa";

            //instanciar vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            //Prepara o comando para o banco

            MySqlCommand sql = new MySqlCommand(query, conexao);

            //chamar o leitor

            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            while(leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + ""; //Utilizamos "" para converter para string
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++; // contador girar
            } // fim do while

            //encerrar o leitura 

            leitura.Close();
        }
       

    } // fim da classe
} // fim do projeto
