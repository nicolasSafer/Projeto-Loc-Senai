namespace Projeto_Loc_Senai.FormsAdm
{
    partial class TelaCadastroEvento
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_local_evento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_nome_evento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_descricao_evento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cadas_sala = new System.Windows.Forms.Button();
            this.box_horario_evento = new System.Windows.Forms.MaskedTextBox();
            this.box_data_evento = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_dia_da_semana = new System.Windows.Forms.ComboBox();
            this.PainelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelSuperior.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelSuperior.Controls.Add(this.label6);
            this.PainelSuperior.Controls.Add(this.Fechar);
            this.PainelSuperior.Controls.Add(this.iconPictureBox1);
            this.PainelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PainelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(662, 162);
            this.PainelSuperior.TabIndex = 1;
            this.PainelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainelSuperior_MouseDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(244, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 110);
            this.label6.TabIndex = 8;
            this.label6.Text = " Cadastro \r\nde Evento\r\n";
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
            this.Fechar.Location = new System.Drawing.Point(619, 16);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(22, 24);
            this.Fechar.TabIndex = 6;
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 112;
            this.iconPictureBox1.Location = new System.Drawing.Point(135, 20);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(112, 122);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Horário";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data";
            // 
            // box_local_evento
            // 
            this.box_local_evento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_local_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_local_evento.Location = new System.Drawing.Point(305, 235);
            this.box_local_evento.Name = "box_local_evento";
            this.box_local_evento.Size = new System.Drawing.Size(180, 26);
            this.box_local_evento.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Local do Evento";
            // 
            // box_nome_evento
            // 
            this.box_nome_evento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_nome_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_nome_evento.Location = new System.Drawing.Point(305, 189);
            this.box_nome_evento.Name = "box_nome_evento";
            this.box_nome_evento.Size = new System.Drawing.Size(180, 26);
            this.box_nome_evento.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome do Evento";
            // 
            // box_descricao_evento
            // 
            this.box_descricao_evento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_descricao_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_descricao_evento.Location = new System.Drawing.Point(236, 331);
            this.box_descricao_evento.Name = "box_descricao_evento";
            this.box_descricao_evento.Size = new System.Drawing.Size(273, 26);
            this.box_descricao_evento.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descrição";
            // 
            // cadas_sala
            // 
            this.cadas_sala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cadas_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadas_sala.Location = new System.Drawing.Point(282, 392);
            this.cadas_sala.Name = "cadas_sala";
            this.cadas_sala.Size = new System.Drawing.Size(98, 41);
            this.cadas_sala.TabIndex = 25;
            this.cadas_sala.Text = "Cadastrar";
            this.cadas_sala.UseVisualStyleBackColor = true;
            this.cadas_sala.Click += new System.EventHandler(this.cadas_sala_Click);
            // 
            // box_horario_evento
            // 
            this.box_horario_evento.Location = new System.Drawing.Point(461, 281);
            this.box_horario_evento.Mask = "00:00";
            this.box_horario_evento.Name = "box_horario_evento";
            this.box_horario_evento.Size = new System.Drawing.Size(48, 20);
            this.box_horario_evento.TabIndex = 35;
            // 
            // box_data_evento
            // 
            this.box_data_evento.Location = new System.Drawing.Point(331, 279);
            this.box_data_evento.Mask = "00/00";
            this.box_data_evento.Name = "box_data_evento";
            this.box_data_evento.Size = new System.Drawing.Size(46, 20);
            this.box_data_evento.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Dia";
            // 
            // cmb_dia_da_semana
            // 
            this.cmb_dia_da_semana.FormattingEnabled = true;
            this.cmb_dia_da_semana.Items.AddRange(new object[] {
            "SEGUNDA",
            "TERÇA",
            "QUARTA",
            "QUINTA",
            "SEXTA",
            "SABADO",
            "DOMINGO"});
            this.cmb_dia_da_semana.Location = new System.Drawing.Point(186, 278);
            this.cmb_dia_da_semana.Name = "cmb_dia_da_semana";
            this.cmb_dia_da_semana.Size = new System.Drawing.Size(86, 21);
            this.cmb_dia_da_semana.TabIndex = 37;
            // 
            // TelaCadastroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 511);
            this.Controls.Add(this.cmb_dia_da_semana);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_horario_evento);
            this.Controls.Add(this.box_data_evento);
            this.Controls.Add(this.cadas_sala);
            this.Controls.Add(this.box_descricao_evento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_local_evento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_nome_evento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PainelSuperior);
            this.Name = "TelaCadastroEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroEvento";
            this.Load += new System.EventHandler(this.TelaCadastroEvento_Load);
            this.PainelSuperior.ResumeLayout(false);
            this.PainelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROL.GradientPanel PainelSuperior;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton Fechar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_local_evento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_nome_evento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_descricao_evento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cadas_sala;
        private System.Windows.Forms.MaskedTextBox box_horario_evento;
        private System.Windows.Forms.MaskedTextBox box_data_evento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_dia_da_semana;
    }
}