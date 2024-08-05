namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTotalDeEstudantes = new System.Windows.Forms.Panel();
            this.labelTotalDeEstudantes = new System.Windows.Forms.Label();
            this.PanelMeninos = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.PanelMeninas = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.PanelTotalDeEstudantes.SuspendLayout();
            this.PanelMeninos.SuspendLayout();
            this.PanelMeninas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTotalDeEstudantes
            // 
            this.PanelTotalDeEstudantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelTotalDeEstudantes.Controls.Add(this.labelTotalDeEstudantes);
            this.PanelTotalDeEstudantes.Location = new System.Drawing.Point(12, 12);
            this.PanelTotalDeEstudantes.Name = "PanelTotalDeEstudantes";
            this.PanelTotalDeEstudantes.Size = new System.Drawing.Size(776, 176);
            this.PanelTotalDeEstudantes.TabIndex = 0;
            // 
            // labelTotalDeEstudantes
            // 
            this.labelTotalDeEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeEstudantes.Location = new System.Drawing.Point(171, 70);
            this.labelTotalDeEstudantes.Name = "labelTotalDeEstudantes";
            this.labelTotalDeEstudantes.Size = new System.Drawing.Size(446, 40);
            this.labelTotalDeEstudantes.TabIndex = 0;
            this.labelTotalDeEstudantes.Text = "Total De Estudante 999%";
            // 
            // PanelMeninos
            // 
            this.PanelMeninos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PanelMeninos.Controls.Add(this.labelMeninos);
            this.PanelMeninos.Location = new System.Drawing.Point(12, 194);
            this.PanelMeninos.Name = "PanelMeninos";
            this.PanelMeninos.Size = new System.Drawing.Size(383, 244);
            this.PanelMeninos.TabIndex = 1;
            // 
            // labelMeninos
            // 
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(56, 112);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(240, 40);
            this.labelMeninos.TabIndex = 1;
            this.labelMeninos.Text = "Meninos 50%";
            // 
            // PanelMeninas
            // 
            this.PanelMeninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelMeninas.Controls.Add(this.labelMeninas);
            this.PanelMeninas.Location = new System.Drawing.Point(405, 194);
            this.PanelMeninas.Name = "PanelMeninas";
            this.PanelMeninas.Size = new System.Drawing.Size(383, 244);
            this.PanelMeninas.TabIndex = 2;
            // 
            // labelMeninas
            // 
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(78, 110);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(242, 42);
            this.labelMeninas.TabIndex = 1;
            this.labelMeninas.Text = "Meninas 50%";
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMeninas);
            this.Controls.Add(this.PanelMeninos);
            this.Controls.Add(this.PanelTotalDeEstudantes);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.PanelTotalDeEstudantes.ResumeLayout(false);
            this.PanelMeninos.ResumeLayout(false);
            this.PanelMeninas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTotalDeEstudantes;
        private System.Windows.Forms.Panel PanelMeninos;
        private System.Windows.Forms.Panel PanelMeninas;
        private System.Windows.Forms.Label labelTotalDeEstudantes;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Label labelMeninas;
    }
}