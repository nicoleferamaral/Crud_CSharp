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
        public int contador;

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
            contador = 0;
            while(leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + ""; //Utilizamos "" para converter para string
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++; // contador girar
                contador++; //copntar a quantidade de dados que preenchem o vetor
            } // fim do while

            //encerrar o leitura 

            leitura.Close();
        }



        public int ConsultarPorCodigo(int cod)
        {

            PreencherVetor(); //Preenchendo vetor com dados do bd


            i = 0;
           
            while (i< QuantidadeDados())
            {
                if (codigo[i] == cod)
                {
                    return i ;
                }
                i++; // contador girar
              
            } // fim do while

            //encerrar o leitura 

  
            return -1;
        }

        public string RetornarNome(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return nome[posicao];
            }
            return "Código digitado não é valido";

        }

        public int QuantidadeDados()
        {
            return contador;
        }

        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update pessoa set {campo} = '{dado}' where codigo = '{codigo} '"; // se tivesse mais de uma tabela utilizaria $"update {nomedatabela} ..."
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado";
            return resultado;
        
        }

        public string Excluir(int codigo)
        {
            string query = $"delete from pessoa where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Deletado";
            return resultado;
        }



       

    } // fim da classe
} // fim do projeto
