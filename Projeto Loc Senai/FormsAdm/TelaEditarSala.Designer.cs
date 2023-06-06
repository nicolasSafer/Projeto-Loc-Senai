namespace Projeto_Loc_Senai.FormsAdm
{
    partial class TelaEditarSala
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
            this.PainelSuperior = new CONTROL.GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.quadro = new FontAwesome.Sharp.IconPictureBox();
            this.Fechar = new FontAwesome.Sharp.IconButton();
            this.dtSala = new System.Windows.Forms.DataGridView();
            this.box_nome_sala = new System.Windows.Forms.TextBox();
            this.descricao_sala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_numeracao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_bloco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PainelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSala)).BeginInit();
            this.SuspendLayout();
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
            this.PainelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(736, 162);
            this.PainelSuperior.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(300, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 110);
            this.label6.TabIndex = 8;
            this.label6.Text = "Atualizar \r\n   Sala\r\n";
            // 
            // quadro
            // 
            this.quadro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quadro.BackColor = System.Drawing.Color.Transparent;
            this.quadro.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.quadro.IconColor = System.Drawing.Color.White;
            this.quadro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.quadro.IconSize = 112;
            this.quadro.Location = new System.Drawing.Point(184, 20);
            this.quadro.Margin = new System.Windows.Forms.Padding(2);
            this.quadro.Name = "quadro";
            this.quadro.Size = new System.Drawing.Size(112, 122);
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
            this.Fechar.Location = new System.Drawing.Point(694, 16);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(22, 24);
            this.Fechar.TabIndex = 6;
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // dtSala
            // 
            this.dtSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSala.Location = new System.Drawing.Point(19, 179);
            this.dtSala.Margin = new System.Windows.Forms.Padding(2);
            this.dtSala.Name = "dtSala";
            this.dtSala.RowHeadersWidth = 51;
            this.dtSala.RowTemplate.Height = 24;
            this.dtSala.Size = new System.Drawing.Size(698, 102);
            this.dtSala.TabIndex = 2;
            // 
            // box_nome_sala
            // 
            this.box_nome_sala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_nome_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_sala.Location = new System.Drawing.Point(151, 300);
            this.box_nome_sala.Name = "box_nome_sala";
            this.box_nome_sala.Size = new System.Drawing.Size(180, 26);
            this.box_nome_sala.TabIndex = 10;
            // 
            // descricao_sala
            // 
            this.descricao_sala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descricao_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_sala.Location = new System.Drawing.Point(151, 343);
            this.descricao_sala.Name = "descricao_sala";
            this.descricao_sala.Size = new System.Drawing.Size(180, 26);
            this.descricao_sala.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição sala";
            // 
            // box_numeracao
            // 
            this.box_numeracao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_numeracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_numeracao.Location = new System.Drawing.Point(525, 300);
            this.box_numeracao.Name = "box_numeracao";
            this.box_numeracao.Size = new System.Drawing.Size(180, 26);
            this.box_numeracao.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Numeração";
            // 
            // box_bloco
            // 
            this.box_bloco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_bloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_bloco.Location = new System.Drawing.Point(525, 344);
            this.box_bloco.Name = "box_bloco";
            this.box_bloco.Size = new System.Drawing.Size(180, 26);
            this.box_bloco.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bloco";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome sala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TelaEditarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_bloco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_numeracao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descricao_sala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_nome_sala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSala);
            this.Controls.Add(this.PainelSuperior);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaEditarSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEditarSala";
            this.Load += new System.EventHandler(this.TelaEditarSala_Load);
            this.PainelSuperior.ResumeLayout(false);
            this.PainelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROL.GradientPanel PainelSuperior;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox quadro;
        private FontAwesome.Sharp.IconButton Fechar;
        private System.Windows.Forms.DataGridView dtSala;
        private System.Windows.Forms.TextBox box_nome_sala;
        private System.Windows.Forms.TextBox descricao_sala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_numeracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_bloco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}