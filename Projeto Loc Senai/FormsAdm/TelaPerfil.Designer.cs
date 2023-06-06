namespace Projeto_Loc_Senai.FormsAdm
{
    partial class TelaPerfil
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
            this.gradientPanel1 = new CONTROL.GradientPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_pesquisa = new System.Windows.Forms.TextBox();
            this.FotoPerfil = new CONTROL.BordasPerfil();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_email_funcionario = new System.Windows.Forms.TextBox();
            this.box_funcao_funcionario = new System.Windows.Forms.TextBox();
            this.box_nome_funcionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_id_funcionario = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.gradientPanel1.Controls.Add(this.iconPictureBox1);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(886, 162);
            this.gradientPanel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 112;
            this.iconPictureBox1.Location = new System.Drawing.Point(90, 24);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(112, 122);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 46.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(207, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(642, 77);
            this.label6.TabIndex = 2;
            this.label6.Text = "Perfil do Funcionário";
            // 
            // box_pesquisa
            // 
            this.box_pesquisa.Location = new System.Drawing.Point(10, 168);
            this.box_pesquisa.Name = "box_pesquisa";
            this.box_pesquisa.Size = new System.Drawing.Size(56, 20);
            this.box_pesquisa.TabIndex = 14;
            this.box_pesquisa.Visible = false;
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FotoPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.FotoPerfil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.FotoPerfil.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.FotoPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.FotoPerfil.BorderSize = 3;
            this.FotoPerfil.GradientAngle = 100F;
            this.FotoPerfil.Image = global::Projeto_Loc_Senai.Properties.Resources.do_utilizador;
            this.FotoPerfil.Location = new System.Drawing.Point(98, 182);
            this.FotoPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(184, 184);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPerfil.TabIndex = 15;
            this.FotoPerfil.TabStop = false;
            this.FotoPerfil.Click += new System.EventHandler(this.bordasPerfil1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Histórico";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 478);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 228);
            this.dataGridView1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Função";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome do Funcionário";
            // 
            // box_email_funcionario
            // 
            this.box_email_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_email_funcionario.Enabled = false;
            this.box_email_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_email_funcionario.Location = new System.Drawing.Point(346, 318);
            this.box_email_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.box_email_funcionario.MaxLength = 50;
            this.box_email_funcionario.Name = "box_email_funcionario";
            this.box_email_funcionario.Size = new System.Drawing.Size(470, 32);
            this.box_email_funcionario.TabIndex = 20;
            // 
            // box_funcao_funcionario
            // 
            this.box_funcao_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_funcao_funcionario.Enabled = false;
            this.box_funcao_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_funcao_funcionario.Location = new System.Drawing.Point(346, 400);
            this.box_funcao_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.box_funcao_funcionario.MaxLength = 50;
            this.box_funcao_funcionario.Name = "box_funcao_funcionario";
            this.box_funcao_funcionario.Size = new System.Drawing.Size(470, 32);
            this.box_funcao_funcionario.TabIndex = 19;
            // 
            // box_nome_funcionario
            // 
            this.box_nome_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_nome_funcionario.Enabled = false;
            this.box_nome_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_funcionario.Location = new System.Drawing.Point(346, 237);
            this.box_nome_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.box_nome_funcionario.MaxLength = 50;
            this.box_nome_funcionario.Name = "box_nome_funcionario";
            this.box_nome_funcionario.Size = new System.Drawing.Size(470, 32);
            this.box_nome_funcionario.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID usuário";
            // 
            // box_id_funcionario
            // 
            this.box_id_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_id_funcionario.Enabled = false;
            this.box_id_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_id_funcionario.Location = new System.Drawing.Point(84, 400);
            this.box_id_funcionario.Margin = new System.Windows.Forms.Padding(2);
            this.box_id_funcionario.MaxLength = 50;
            this.box_id_funcionario.Name = "box_id_funcionario";
            this.box_id_funcionario.Size = new System.Drawing.Size(207, 32);
            this.box_id_funcionario.TabIndex = 16;
            this.box_id_funcionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(886, 715);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_email_funcionario);
            this.Controls.Add(this.box_funcao_funcionario);
            this.Controls.Add(this.box_nome_funcionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_id_funcionario);
            this.Controls.Add(this.FotoPerfil);
            this.Controls.Add(this.box_pesquisa);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaPerfil";
            this.Text = "TelaPerfil";
            this.Load += new System.EventHandler(this.TelaPerfil_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROL.GradientPanel gradientPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_pesquisa;
        private CONTROL.BordasPerfil FotoPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_email_funcionario;
        private System.Windows.Forms.TextBox box_funcao_funcionario;
        private System.Windows.Forms.TextBox box_nome_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_id_funcionario;
    }
}