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
            this.PainelSuperior = new CONTROL.GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.quadro = new FontAwesome.Sharp.IconPictureBox();
            this.Fechar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PainelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadro)).BeginInit();
            this.SuspendLayout();
            // 
            // test_id
            // 
            this.test_id.Location = new System.Drawing.Point(4, 176);
            this.test_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.test_id.Name = "test_id";
            this.test_id.Size = new System.Drawing.Size(10, 22);
            this.test_id.TabIndex = 0;
            this.test_id.Visible = false;
            // 
            // nome_sala
            // 
            this.nome_sala.BackColor = System.Drawing.Color.White;
            this.nome_sala.Enabled = false;
            this.nome_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_sala.Location = new System.Drawing.Point(376, 221);
            this.nome_sala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nome_sala.Name = "nome_sala";
            this.nome_sala.Size = new System.Drawing.Size(374, 38);
            this.nome_sala.TabIndex = 1;
            // 
            // descricao_sala
            // 
            this.descricao_sala.BackColor = System.Drawing.Color.White;
            this.descricao_sala.Enabled = false;
            this.descricao_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_sala.Location = new System.Drawing.Point(79, 425);
            this.descricao_sala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descricao_sala.Multiline = true;
            this.descricao_sala.Name = "descricao_sala";
            this.descricao_sala.Size = new System.Drawing.Size(825, 115);
            this.descricao_sala.TabIndex = 2;
            // 
            // numeracao_sala
            // 
            this.numeracao_sala.BackColor = System.Drawing.Color.White;
            this.numeracao_sala.Enabled = false;
            this.numeracao_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeracao_sala.Location = new System.Drawing.Point(376, 274);
            this.numeracao_sala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeracao_sala.Name = "numeracao_sala";
            this.numeracao_sala.Size = new System.Drawing.Size(374, 38);
            this.numeracao_sala.TabIndex = 3;
            // 
            // bloco_sala
            // 
            this.bloco_sala.BackColor = System.Drawing.Color.White;
            this.bloco_sala.Enabled = false;
            this.bloco_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloco_sala.Location = new System.Drawing.Point(376, 327);
            this.bloco_sala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bloco_sala.Name = "bloco_sala";
            this.bloco_sala.Size = new System.Drawing.Size(374, 38);
            this.bloco_sala.TabIndex = 4;
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelSuperior.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelSuperior.Controls.Add(this.label6);
            this.PainelSuperior.Controls.Add(this.quadro);
            this.PainelSuperior.Controls.Add(this.Fechar);
            this.PainelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PainelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(982, 199);
            this.PainelSuperior.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(375, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 138);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cadastro \r\n de Sala\r\n";
            // 
            // quadro
            // 
            this.quadro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quadro.BackColor = System.Drawing.Color.Transparent;
            this.quadro.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.quadro.IconColor = System.Drawing.Color.White;
            this.quadro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.quadro.IconSize = 149;
            this.quadro.Location = new System.Drawing.Point(230, 25);
            this.quadro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quadro.Name = "quadro";
            this.quadro.Size = new System.Drawing.Size(149, 150);
            this.quadro.TabIndex = 7;
            this.quadro.TabStop = false;
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Fechar.IconColor = System.Drawing.Color.White;
            this.Fechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Fechar.IconSize = 25;
            this.Fechar.Location = new System.Drawing.Point(924, 20);
            this.Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(29, 30);
            this.Fechar.TabIndex = 6;
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bloco";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numeração";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome Sala";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição Sala";
            // 
            // TelaDescSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PainelSuperior);
            this.Controls.Add(this.bloco_sala);
            this.Controls.Add(this.numeracao_sala);
            this.Controls.Add(this.descricao_sala);
            this.Controls.Add(this.nome_sala);
            this.Controls.Add(this.test_id);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaDescSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDiscSala";
            this.Load += new System.EventHandler(this.TelaDescSala_Load);
            this.PainelSuperior.ResumeLayout(false);
            this.PainelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox test_id;
        private System.Windows.Forms.TextBox nome_sala;
        private System.Windows.Forms.TextBox descricao_sala;
        private System.Windows.Forms.TextBox numeracao_sala;
        private System.Windows.Forms.TextBox bloco_sala;
        private CONTROL.GradientPanel PainelSuperior;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox quadro;
        private FontAwesome.Sharp.IconButton Fechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}