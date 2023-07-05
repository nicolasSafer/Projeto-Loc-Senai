namespace Projeto_Loc_Senai
{
    partial class TelaVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisitante));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Minimizar = new FontAwesome.Sharp.IconButton();
            this.Janelas = new FontAwesome.Sharp.IconButton();
            this.Fechar = new FontAwesome.Sharp.IconButton();
            this.Nomepag = new System.Windows.Forms.Label();
            this.iconeprin = new System.Windows.Forms.PictureBox();
            this.PainelLateral = new CONTROL.GradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSair = new FontAwesome.Sharp.IconButton();
            this.BtnInfo = new FontAwesome.Sharp.IconButton();
            this.BtnContato = new FontAwesome.Sharp.IconButton();
            this.BtnFeedback = new FontAwesome.Sharp.IconButton();
            this.BtnEvento = new FontAwesome.Sharp.IconButton();
            this.BtnMapa = new FontAwesome.Sharp.IconButton();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.PainelGeral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconesenai = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeprin)).BeginInit();
            this.PainelLateral.SuspendLayout();
            this.PainelGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconesenai)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BarraSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraSuperior.Controls.Add(this.Minimizar);
            this.BarraSuperior.Controls.Add(this.Janelas);
            this.BarraSuperior.Controls.Add(this.Fechar);
            this.BarraSuperior.Controls.Add(this.Nomepag);
            this.BarraSuperior.Controls.Add(this.iconeprin);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1066, 41);
            this.BarraSuperior.TabIndex = 3;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimizar.IconColor = System.Drawing.Color.White;
            this.Minimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimizar.IconSize = 25;
            this.Minimizar.Location = new System.Drawing.Point(946, 9);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(22, 24);
            this.Minimizar.TabIndex = 7;
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Janelas
            // 
            this.Janelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Janelas.BackColor = System.Drawing.Color.Transparent;
            this.Janelas.FlatAppearance.BorderSize = 0;
            this.Janelas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Janelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.Janelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Janelas.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.Janelas.IconColor = System.Drawing.Color.White;
            this.Janelas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Janelas.IconSize = 25;
            this.Janelas.Location = new System.Drawing.Point(988, 9);
            this.Janelas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Janelas.Name = "Janelas";
            this.Janelas.Size = new System.Drawing.Size(22, 24);
            this.Janelas.TabIndex = 6;
            this.Janelas.UseVisualStyleBackColor = false;
            this.Janelas.Click += new System.EventHandler(this.Janelas_Click);
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
            this.Fechar.Location = new System.Drawing.Point(1026, 9);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(22, 24);
            this.Fechar.TabIndex = 5;
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Nomepag
            // 
            this.Nomepag.AutoSize = true;
            this.Nomepag.BackColor = System.Drawing.Color.Transparent;
            this.Nomepag.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomepag.ForeColor = System.Drawing.Color.White;
            this.Nomepag.Location = new System.Drawing.Point(54, 3);
            this.Nomepag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nomepag.Name = "Nomepag";
            this.Nomepag.Size = new System.Drawing.Size(253, 33);
            this.Nomepag.TabIndex = 1;
            this.Nomepag.Text = "Guia de Visitantes";
            // 
            // iconeprin
            // 
            this.iconeprin.Image = ((System.Drawing.Image)(resources.GetObject("iconeprin.Image")));
            this.iconeprin.Location = new System.Drawing.Point(8, -6);
            this.iconeprin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconeprin.Name = "iconeprin";
            this.iconeprin.Size = new System.Drawing.Size(45, 49);
            this.iconeprin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconeprin.TabIndex = 0;
            this.iconeprin.TabStop = false;
            // 
            // PainelLateral
            // 
            this.PainelLateral.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelLateral.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelLateral.Controls.Add(this.panel3);
            this.PainelLateral.Controls.Add(this.panel2);
            this.PainelLateral.Controls.Add(this.BtnSair);
            this.PainelLateral.Controls.Add(this.BtnInfo);
            this.PainelLateral.Controls.Add(this.BtnContato);
            this.PainelLateral.Controls.Add(this.BtnFeedback);
            this.PainelLateral.Controls.Add(this.BtnEvento);
            this.PainelLateral.Controls.Add(this.BtnMapa);
            this.PainelLateral.Controls.Add(this.BtnInicio);
            this.PainelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelLateral.Location = new System.Drawing.Point(0, 41);
            this.PainelLateral.Name = "PainelLateral";
            this.PainelLateral.Size = new System.Drawing.Size(70, 753);
            this.PainelLateral.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(10, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 2);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(10, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 2);
            this.panel2.TabIndex = 17;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnSair.IconColor = System.Drawing.Color.White;
            this.BtnSair.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnSair.IconSize = 50;
            this.BtnSair.Location = new System.Drawing.Point(0, 697);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnSair.Size = new System.Drawing.Size(70, 55);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInfo.FlatAppearance.BorderSize = 0;
            this.BtnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.BtnInfo.IconColor = System.Drawing.Color.White;
            this.BtnInfo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnInfo.IconSize = 46;
            this.BtnInfo.Location = new System.Drawing.Point(0, 288);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnInfo.Size = new System.Drawing.Size(70, 55);
            this.BtnInfo.TabIndex = 15;
            this.BtnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInfo.UseVisualStyleBackColor = false;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnContato
            // 
            this.BtnContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnContato.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnContato.FlatAppearance.BorderSize = 0;
            this.BtnContato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContato.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContato.ForeColor = System.Drawing.Color.White;
            this.BtnContato.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.BtnContato.IconColor = System.Drawing.Color.White;
            this.BtnContato.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnContato.IconSize = 46;
            this.BtnContato.Location = new System.Drawing.Point(0, 230);
            this.BtnContato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnContato.Name = "BtnContato";
            this.BtnContato.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnContato.Size = new System.Drawing.Size(70, 55);
            this.BtnContato.TabIndex = 11;
            this.BtnContato.UseVisualStyleBackColor = false;
            this.BtnContato.Click += new System.EventHandler(this.BtnContato_Click);
            // 
            // BtnFeedback
            // 
            this.BtnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnFeedback.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFeedback.FlatAppearance.BorderSize = 0;
            this.BtnFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFeedback.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFeedback.ForeColor = System.Drawing.Color.White;
            this.BtnFeedback.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnFeedback.IconColor = System.Drawing.Color.White;
            this.BtnFeedback.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnFeedback.Location = new System.Drawing.Point(0, 175);
            this.BtnFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnFeedback.Name = "BtnFeedback";
            this.BtnFeedback.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnFeedback.Size = new System.Drawing.Size(70, 55);
            this.BtnFeedback.TabIndex = 10;
            this.BtnFeedback.UseVisualStyleBackColor = false;
            this.BtnFeedback.Click += new System.EventHandler(this.BtnFeedback_Click);
            // 
            // BtnEvento
            // 
            this.BtnEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnEvento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEvento.FlatAppearance.BorderSize = 0;
            this.BtnEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvento.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEvento.ForeColor = System.Drawing.Color.White;
            this.BtnEvento.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.BtnEvento.IconColor = System.Drawing.Color.White;
            this.BtnEvento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEvento.IconSize = 46;
            this.BtnEvento.Location = new System.Drawing.Point(0, 120);
            this.BtnEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEvento.Name = "BtnEvento";
            this.BtnEvento.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnEvento.Size = new System.Drawing.Size(70, 55);
            this.BtnEvento.TabIndex = 9;
            this.BtnEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEvento.UseVisualStyleBackColor = false;
            this.BtnEvento.Click += new System.EventHandler(this.BtnEvento_Click);
            // 
            // BtnMapa
            // 
            this.BtnMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnMapa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMapa.FlatAppearance.BorderSize = 0;
            this.BtnMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMapa.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMapa.ForeColor = System.Drawing.Color.White;
            this.BtnMapa.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.BtnMapa.IconColor = System.Drawing.Color.White;
            this.BtnMapa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMapa.Location = new System.Drawing.Point(0, 65);
            this.BtnMapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMapa.Name = "BtnMapa";
            this.BtnMapa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnMapa.Size = new System.Drawing.Size(70, 55);
            this.BtnMapa.TabIndex = 8;
            this.BtnMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMapa.UseVisualStyleBackColor = false;
            this.BtnMapa.Click += new System.EventHandler(this.BtnMapa_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.BtnInicio.IconColor = System.Drawing.Color.White;
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.IconSize = 50;
            this.BtnInicio.Location = new System.Drawing.Point(0, 2);
            this.BtnInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnInicio.Size = new System.Drawing.Size(70, 55);
            this.BtnInicio.TabIndex = 7;
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // PainelGeral
            // 
            this.PainelGeral.Controls.Add(this.panel1);
            this.PainelGeral.Controls.Add(this.iconesenai);
            this.PainelGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelGeral.Location = new System.Drawing.Point(70, 41);
            this.PainelGeral.Name = "PainelGeral";
            this.PainelGeral.Size = new System.Drawing.Size(996, 753);
            this.PainelGeral.TabIndex = 5;
            this.PainelGeral.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelGeral_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 753);
            this.panel1.TabIndex = 3;
            // 
            // iconesenai
            // 
            this.iconesenai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconesenai.Image = ((System.Drawing.Image)(resources.GetObject("iconesenai.Image")));
            this.iconesenai.Location = new System.Drawing.Point(163, 315);
            this.iconesenai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconesenai.Name = "iconesenai";
            this.iconesenai.Size = new System.Drawing.Size(670, 122);
            this.iconesenai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconesenai.TabIndex = 2;
            this.iconesenai.TabStop = false;
            // 
            // TelaVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 794);
            this.Controls.Add(this.PainelGeral);
            this.Controls.Add(this.PainelLateral);
            this.Controls.Add(this.BarraSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVisitante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeprin)).EndInit();
            this.PainelLateral.ResumeLayout(false);
            this.PainelGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconesenai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private FontAwesome.Sharp.IconButton Minimizar;
        private FontAwesome.Sharp.IconButton Janelas;
        private FontAwesome.Sharp.IconButton Fechar;
        private System.Windows.Forms.Label Nomepag;
        private System.Windows.Forms.PictureBox iconeprin;
        private CONTROL.GradientPanel PainelLateral;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private System.Windows.Forms.Panel PainelGeral;
        private FontAwesome.Sharp.IconButton BtnMapa;
        private FontAwesome.Sharp.IconButton BtnEvento;
        private FontAwesome.Sharp.IconButton BtnSair;
        private FontAwesome.Sharp.IconButton BtnInfo;
        private FontAwesome.Sharp.IconButton BtnContato;
        private FontAwesome.Sharp.IconButton BtnFeedback;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox iconesenai;
        private System.Windows.Forms.Panel panel1;
    }
}