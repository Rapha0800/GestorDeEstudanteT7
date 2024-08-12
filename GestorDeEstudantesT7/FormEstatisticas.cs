using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = PanelTotalDeEstudantes.BackColor;
            corPainelMeninos = PanelMeninos.BackColor;
            corPainelMeninas = PanelMeninas.BackColor;

            //Exibe os valores (total geral, total de meninos, meninas etc)
            Estudante estudante = new Estudante();
            double totalEstudantes = Convert.ToDouble (estudante.totalDeEstudantes());
            double totalMeninos = Convert.ToDouble (estudante.totalDeEstudantesMeninos()); 
            double totalMeninas = Convert.ToDouble(estudante.totalDeEstudantesMeninas());

            //contar  PORCENTAGEM (%)
            double porcentagemDeMeninos = totalMeninos * 100 / totalEstudantes;
            double porcentagemDeMeninas = totalMeninas * 100 / totalEstudantes;

            labelTotalDeEstudantes.Text = "Total de Estudantes: " + totalEstudantes.ToString();

            labelMeninos.Text = " % de Meninos: " + porcentagemDeMeninos.ToString("0.00") + "%";

            labelMeninas.Text = " % de Meninas: " + porcentagemDeMeninas.ToString("0.00") + "%";
        }
        //MENINOS
        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            PanelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelMeninos;

        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            PanelMeninos.BackColor = corPainelMeninos;
            labelMeninos.ForeColor = Color.Black;
        }


        //MENINAS
        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            PanelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelMeninas;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            PanelMeninas.BackColor = corPainelMeninas;
            labelMeninas.ForeColor = Color.Black;
        }


        //PAINEL TOTAL  
        private void labelTotalDeEstudantes_MouseEnter(object sender, EventArgs e)
        {
            PanelTotalDeEstudantes.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }

        private void labelTotalDeEstudantes_MouseLeave(object sender, EventArgs e)
        {
            PanelTotalDeEstudantes.BackColor = corPainelTotal;
            labelTotalDeEstudantes.ForeColor= Color.Black;
        }
    }
}
