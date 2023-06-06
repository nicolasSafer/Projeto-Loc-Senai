namespace Projeto_Loc_Senai.FormsAdm
{
    partial class TelaEditarFeedback
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
            this.Fechar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.dtFeedBack = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.box_nome_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_avaliacao_software = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_observacao_software = new System.Windows.Forms.TextBox();
            this.cadas_sala = new System.Windows.Forms.Button();
            this.PainelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFeedBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelSuperior.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelSuperior.Controls.Add(this.label6);
            this.PainelSuperior.Controls.Add(this.Fechar);
            this.PainelSuperior.Controls.Add(this.iconPictureBox2);
            this.PainelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PainelSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(736, 162);
            this.PainelSuperior.TabIndex = 3;
            this.PainelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainelSuperior_MouseDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(300, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 116);
            this.label6.TabIndex = 8;
            this.label6.Text = "  Atualizar  \r\n Feedback";
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
            this.Fechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(22, 24);
            this.Fechar.TabIndex = 6;
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 112;
            this.iconPictureBox2.Location = new System.Drawing.Point(184, 20);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(112, 122);
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
            // 
            // dtFeedBack
            // 
            this.dtFeedBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFeedBack.Location = new System.Drawing.Point(18, 184);
            this.dtFeedBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFeedBack.Name = "dtFeedBack";
            this.dtFeedBack.RowHeadersWidth = 51;
            this.dtFeedBack.RowTemplate.Height = 24;
            this.dtFeedBack.Size = new System.Drawing.Size(698, 102);
            this.dtFeedBack.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome do Usuário";
            // 
            // box_nome_usuario
            // 
            this.box_nome_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_nome_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_usuario.Location = new System.Drawing.Point(178, 309);
            this.box_nome_usuario.Name = "box_nome_usuario";
            this.box_nome_usuario.Size = new System.Drawing.Size(180, 26);
            this.box_nome_usuario.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Avaliação do Software";
            // 
            // box_avaliacao_software
            // 
            this.box_avaliacao_software.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_avaliacao_software.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_avaliacao_software.Location = new System.Drawing.Point(573, 308);
            this.box_avaliacao_software.Name = "box_avaliacao_software";
            this.box_avaliacao_software.Size = new System.Drawing.Size(143, 26);
            this.box_avaliacao_software.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Observações";
            // 
            // box_observacao_software
            // 
            this.box_observacao_software.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_observacao_software.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_observacao_software.Location = new System.Drawing.Point(18, 370);
            this.box_observacao_software.Multiline = true;
            this.box_observacao_software.Name = "box_observacao_software";
            this.box_observacao_software.Size = new System.Drawing.Size(698, 87);
            this.box_observacao_software.TabIndex = 32;
            // 
            // cadas_sala
            // 
            this.cadas_sala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cadas_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadas_sala.Location = new System.Drawing.Point(330, 463);
            this.cadas_sala.Name = "cadas_sala";
            this.cadas_sala.Size = new System.Drawing.Size(98, 41);
            this.cadas_sala.TabIndex = 33;
            this.cadas_sala.Text = "Editar";
            this.cadas_sala.UseVisualStyleBackColor = true;
            this.cadas_sala.Click += new System.EventHandler(this.cadas_sala_Click);
            // 
            // TelaEditarFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 561);
            this.Controls.Add(this.cadas_sala);
            this.Controls.Add(this.box_observacao_software);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_avaliacao_software);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_nome_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFeedBack);
            this.Controls.Add(this.PainelSuperior);
            this.Name = "TelaEditarFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEditarFeedback";
            this.Load += new System.EventHandler(this.TelaEditarFeedback_Load);
            this.PainelSuperior.ResumeLayout(false);
            this.PainelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFeedBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROL.GradientPanel PainelSuperior;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton Fechar;
        private System.Windows.Forms.DataGridView dtFeedBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_nome_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_avaliacao_software;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_observacao_software;
        private System.Windows.Forms.Button cadas_sala;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}