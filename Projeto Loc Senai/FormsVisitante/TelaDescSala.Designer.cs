namespace Projeto_Loc_Senai.FormsVisitante
{
    partial class TelaDescSala
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
            this.test_id = new System.Windows.Forms.TextBox();
            this.nome_sala = new System.Windows.Forms.TextBox();
            this.descricao_sala = new System.Windows.Forms.TextBox();
            this.numeracao_sala = new System.Windows.Forms.TextBox();
            this.bloco_sala = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test_id
            // 
            this.test_id.Location = new System.Drawing.Point(568, 61);
            this.test_id.Name = "test_id";
            this.test_id.Size = new System.Drawing.Size(100, 20);
            this.test_id.TabIndex = 0;
            // 
            // nome_sala
            // 
            this.nome_sala.Location = new System.Drawing.Point(248, 198);
            this.nome_sala.Name = "nome_sala";
            this.nome_sala.Size = new System.Drawing.Size(100, 20);
            this.nome_sala.TabIndex = 1;
            // 
            // descricao_sala
            // 
            this.descricao_sala.Location = new System.Drawing.Point(248, 224);
            this.descricao_sala.Name = "descricao_sala";
            this.descricao_sala.Size = new System.Drawing.Size(100, 20);
            this.descricao_sala.TabIndex = 2;
            // 
            // numeracao_sala
            // 
            this.numeracao_sala.Location = new System.Drawing.Point(248, 250);
            this.numeracao_sala.Name = "numeracao_sala";
            this.numeracao_sala.Size = new System.Drawing.Size(100, 20);
            this.numeracao_sala.TabIndex = 3;
            // 
            // bloco_sala
            // 
            this.bloco_sala.Location = new System.Drawing.Point(248, 276);
            this.bloco_sala.Name = "bloco_sala";
            this.bloco_sala.Size = new System.Drawing.Size(100, 20);
            this.bloco_sala.TabIndex = 4;
            // 
            // TelaDescSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bloco_sala);
            this.Controls.Add(this.numeracao_sala);
            this.Controls.Add(this.descricao_sala);
            this.Controls.Add(this.nome_sala);
            this.Controls.Add(this.test_id);
            this.Name = "TelaDescSala";
            this.Text = "TelaDiscSala";
            this.Load += new System.EventHandler(this.TelaDescSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox test_id;
        private System.Windows.Forms.TextBox nome_sala;
        private System.Windows.Forms.TextBox descricao_sala;
        private System.Windows.Forms.TextBox numeracao_sala;
        private System.Windows.Forms.TextBox bloco_sala;
    }
}