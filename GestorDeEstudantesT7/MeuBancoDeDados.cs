using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using GestorDeEstudantesT7;
using System.IO;

namespace GestorDeEstudantesT7
{
    internal class MeuBancoDeDados
    {
        // A conexão com o Banco de Dados.
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudante_bd_t7");
        
        // Acessor da variável "conexao".
        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }

        // Função para ABRIR a conexão com o banco de dados.
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        // Função para FECHAR a conexão com o banco de dados.
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}

    internal class Estudante
    {
        MeuBancoDeDados MeuBancoDeDados = new MeuBancoDeDados();

        public bool inserirEstudante(string nome, string sobrenome, DateTime nascimento, string telefone, string genero, string endereco, MemoryStream foto)
        {
             MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`id`, `nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nome,@sobrenome,@nascimento,@genero,@telefone,@endereco,@foto)", MeuBancoDeDados.getConexao);

            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.VarChar).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.VarChar).Value = foto.ToArray();

            MeuBancoDeDados.abrirConexao();

            if(comando.ExecuteNonQuery() == 1)
            {
                MeuBancoDeDados.fecharConexao();
                return true;                
            }
            else
            {
                MeuBancoDeDados.fecharConexao();
                return false;
            }
        }
        
        //RETORNA A TABELA DPS ESTUDANTES QUE ESTAO NO BANCO DE DADOS
        public DataTable getEstudantes(MySqlCommand comando) 
        {
            comando.Connection = MeuBancoDeDados.getConexao;

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabelaDeDados = new DataTable();
            adaptador.Fill(tabelaDeDados);

            return tabelaDeDados;
        }
    }




