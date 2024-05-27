using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT7
{
    public partial class FormListarEstudantes : Form
    {
        public FormListarEstudantes()
        {
            InitializeComponent();
        }
        Estudante estudante = new Estudante();

        private void FormListarEstudantes_Load(object sender, EventArgs e)
        {
            // Preenche o dataGridView co mas informações dos estudantes.
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            //impede que os dados exibidosna tabela sejam alteradas
            dataGridViewListaDeAlunos.ReadOnly = true;
            //cria uma coluna para exibir as fotos dos alunos
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            // determina uma altura padrao para as linhas da tabela.
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            //determina a origem dos dados da tabela
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);
            //determinar qual SERA a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;
           
        }
    }
}
