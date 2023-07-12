namespace Projeto_Loc_Senai.FormsVisitante
{
    partial class TelaMapaSenai
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_Lab_Costura = new System.Windows.Forms.Button();
            this.btn_Lab_modelagem = new System.Windows.Forms.Button();
            this.btn_Sala_10 = new System.Windows.Forms.Button();
            this.btn_Sala_03 = new System.Windows.Forms.Button();
            this.btn_Biblioteca = new System.Windows.Forms.Button();
            this.btn_almoxarifado = new System.Windows.Forms.Button();
            this.btn_Coordenacao = new System.Windows.Forms.Button();
            this.btn_secretaria = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mapa = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.gradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mapa)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.gradientPanel1.Controls.Add(this.iconButton1);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(250, 953);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_inicio);
            this.panel3.Controls.Add(this.btn_Lab_Costura);
            this.panel3.Controls.Add(this.btn_Lab_modelagem);
            this.panel3.Controls.Add(this.btn_Sala_10);
            this.panel3.Controls.Add(this.btn_Sala_03);
            this.panel3.Controls.Add(this.btn_Biblioteca);
            this.panel3.Controls.Add(this.btn_almoxarifado);
            this.panel3.Controls.Add(this.btn_Coordenacao);
            this.panel3.Controls.Add(this.btn_secretaria);
            this.panel3.Location = new System.Drawing.Point(25, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 497);
            this.panel3.TabIndex = 4;
            // 
            // btn_inicio
            // 
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Location = new System.Drawing.Point(0, 0);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(200, 56);
            this.btn_inicio.TabIndex = 8;
            this.btn_inicio.Text = "Início";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_Lab_Costura
            // 
            this.btn_Lab_Costura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lab_Costura.Location = new System.Drawing.Point(0, 440);
            this.btn_Lab_Costura.Name = "btn_Lab_Costura";
            this.btn_Lab_Costura.Size = new System.Drawing.Size(200, 56);
            this.btn_Lab_Costura.TabIndex = 7;
            this.btn_Lab_Costura.Text = "Lab. de Costura";
            this.btn_Lab_Costura.UseVisualStyleBackColor = true;
            this.btn_Lab_Costura.Click += new System.EventHandler(this.btn_Lab_Costura_Click);
            // 
            // btn_Lab_modelagem
            // 
            this.btn_Lab_modelagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lab_modelagem.Location = new System.Drawing.Point(0, 385);
            this.btn_Lab_modelagem.Name = "btn_Lab_modelagem";
            this.btn_Lab_modelagem.Size = new System.Drawing.Size(200, 56);
            this.btn_Lab_modelagem.TabIndex = 6;
            this.btn_Lab_modelagem.Text = "Lab. de Modelagem 01";
            this.btn_Lab_modelagem.UseVisualStyleBackColor = true;
            this.btn_Lab_modelagem.Click += new System.EventHandler(this.btn_Lab_modelagem_Click);
            // 
            // btn_Sala_10
            // 
            this.btn_Sala_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sala_10.Location = new System.Drawing.Point(0, 330);
            this.btn_Sala_10.Name = "btn_Sala_10";
            this.btn_Sala_10.Size = new System.Drawing.Size(200, 56);
            this.btn_Sala_10.TabIndex = 5;
            this.btn_Sala_10.Text = "Sala de Aula 10";
            this.btn_Sala_10.UseVisualStyleBackColor = true;
            this.btn_Sala_10.Click += new System.EventHandler(this.btn_Sala_10_Click);
            // 
            // btn_Sala_03
            // 
            this.btn_Sala_03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sala_03.Location = new System.Drawing.Point(0, 275);
            this.btn_Sala_03.Name = "btn_Sala_03";
            this.btn_Sala_03.Size = new System.Drawing.Size(200, 56);
            this.btn_Sala_03.TabIndex = 4;
            this.btn_Sala_03.Text = "Sala de Aula 03";
            this.btn_Sala_03.UseVisualStyleBackColor = true;
            this.btn_Sala_03.Click += new System.EventHandler(this.btn_Sala_03_Click);
            // 
            // btn_Biblioteca
            // 
            this.btn_Biblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Biblioteca.Location = new System.Drawing.Point(0, 220);
            this.btn_Biblioteca.Name = "btn_Biblioteca";
            this.btn_Biblioteca.Size = new System.Drawing.Size(200, 56);
            this.btn_Biblioteca.TabIndex = 3;
            this.btn_Biblioteca.Text = "Biblioteca";
            this.btn_Biblioteca.UseVisualStyleBackColor = true;
            this.btn_Biblioteca.Click += new System.EventHandler(this.btn_Biblioteca_Click);
            // 
            // btn_almoxarifado
            // 
            this.btn_almoxarifado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_almoxarifado.Location = new System.Drawing.Point(0, 165);
            this.btn_almoxarifado.Name = "btn_almoxarifado";
            this.btn_almoxarifado.Size = new System.Drawing.Size(200, 56);
            this.btn_almoxarifado.TabIndex = 2;
            this.btn_almoxarifado.Text = "Almoxarifado";
            this.btn_almoxarifado.UseVisualStyleBackColor = true;
            this.btn_almoxarifado.Click += new System.EventHandler(this.btn_almoxarifado_Click);
            // 
            // btn_Coordenacao
            // 
            this.btn_Coordenacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Coordenacao.Location = new System.Drawing.Point(0, 110);
            this.btn_Coordenacao.Name = "btn_Coordenacao";
            this.btn_Coordenacao.Size = new System.Drawing.Size(200, 56);
            this.btn_Coordenacao.TabIndex = 1;
            this.btn_Coordenacao.Text = "Coordenação";
            this.btn_Coordenacao.UseVisualStyleBackColor = true;
            this.btn_Coordenacao.Click += new System.EventHandler(this.btn_Coordenacao_Click);
            // 
            // btn_secretaria
            // 
            this.btn_secretaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_secretaria.Location = new System.Drawing.Point(0, 55);
            this.btn_secretaria.Name = "btn_secretaria";
            this.btn_secretaria.Size = new System.Drawing.Size(200, 56);
            this.btn_secretaria.TabIndex = 0;
            this.btn_secretaria.Text = "Secretaria";
            this.btn_secretaria.UseVisualStyleBackColor = true;
            this.btn_secretaria.Click += new System.EventHandler(this.btn_secretaria_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 953);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bloco C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mapa";
            // 
            // Mapa
            // 
            this.Mapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mapa.Image = global::Projeto_Loc_Senai.Properties.Resources.Mapa_Terreo_pin;
            this.Mapa.Location = new System.Drawing.Point(250, 0);
            this.Mapa.Name = "Mapa";
            this.Mapa.Size = new System.Drawing.Size(1132, 953);
            this.Mapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mapa.TabIndex = 1;
            this.Mapa.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(25, 688);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 117);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Descrição \r\nda Sala";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // TelaMapaSenai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 953);
            this.Controls.Add(this.Mapa);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaMapaSenai";
            this.Text = "TelaMapaSenai";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CONTROL.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox Mapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_secretaria;
        private System.Windows.Forms.Button btn_Lab_Costura;
        private System.Windows.Forms.Button btn_Lab_modelagem;
        private System.Windows.Forms.Button btn_Sala_10;
        private System.Windows.Forms.Button btn_Sala_03;
        private System.Windows.Forms.Button btn_Biblioteca;
        private System.Windows.Forms.Button btn_almoxarifado;
        private System.Windows.Forms.Button btn_Coordenacao;
        private System.Windows.Forms.Button btn_inicio;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}