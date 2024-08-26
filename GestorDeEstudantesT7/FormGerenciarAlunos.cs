using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormGerenciarAlunos : Form
    {
        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            // Preenche a tabela com os alunos do banco de dados.
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
        }

        // Metódo que preenche a tabela com os alunos do banco de dados.
        public void preencheTabela(MySqlCommand comando) 
        {
            // Impede que os dados exibidos na tabela sejam alterados.
            dataGridViewListaDeAlunos.ReadOnly = true;
            // Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            // Determina uma altura padrão para as linhas da tabela.
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            // Determina a origem dos dados da tabela.
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);
            // Determinar qual SERÁ a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;

            // Mostra o total de alunos
            labelTotalDeAlunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
        }

        private void dataGridViewListaDeAlunos_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[1].Value.ToString();
            textBoxSobrenome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[2].Value.ToString();

            dateTimePickerNascimento.Value = (DateTime)dataGridViewListaDeAlunos.CurrentRow.Cells[3].Value;

            if (dataGridViewListaDeAlunos.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                radioButtonFeminino.Checked = true;
            }
            else
            {
                radioButtonMasculino.Checked = true;
            }

            textBoxTelefone.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[5].Value.ToString();
            textBoxEndereco.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[6].Value.ToString();

            byte[] imagem;
            imagem = (byte[])dataGridViewListaDeAlunos.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoAluno = new MemoryStream(imagem);
            pictureBoxFoto.Image = Image.FromStream(fotoDoAluno);
        }

        private void buttonRedefinir_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
            textBoxEndereco.Text = "";
            textBoxTelefone.Text = "";
            radioButtonFeminino.Checked = true;
            dateTimePickerNascimento.Value = DateTime.Now;
            pictureBoxFoto.Image = null;
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Abre janela para pesquisar a imagem no computador.
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        private void buttonBaixarFoto_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarArquivo = new SaveFileDialog();
            // Define o nome do arquivo que será salvo.
            salvarArquivo.FileName = "Estudante_" + textBoxID.Text;

            // Verifica se tem imagem na caixa de imagem.
            if (pictureBoxFoto.Image == null)
            {
                MessageBox.Show("Não tem foto para baixar.");
            }
            else
            {
                salvarArquivo.ShowDialog();
                pictureBoxFoto.Image.Save(salvarArquivo.FileName + ("." +
                    ImageFormat.Jpeg.ToString()));
            }
        }

        private void buttonBuscarDado_Click(object sender, EventArgs e)
        {
            string pesquisa = "SELECT * FROM `estudantes` WHERE CONCAT" +
                "(`nome`,`sobrenome`,`endereco`) LIKE'%"+textBoxDado.Text+"%'";
            MySqlCommand comando = new MySqlCommand(pesquisa);
            preencheTabela(comando);
        }
    }
}
