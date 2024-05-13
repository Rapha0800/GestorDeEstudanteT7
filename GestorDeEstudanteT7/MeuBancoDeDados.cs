using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace GestorDeEstudanteT7
{
    internal class MeuBancoDeDados
    {
        // A conexao com o banco de dados
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudante_bd_t7");
        
        //acessor
        public MySqlConnection getConexao
        {
            get 
            {
                return conexao;            
            }
        }

        //funçao para ABRIR a conexão com o banco de dados.
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed) 
            {
                conexao.Open();
            }
        }

        //Função para FECHAR a conexão com o banco de dados.
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
