namespace Projeto_Loc_Senai.FormsAdm
{
    partial class TelaSala
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
            this.quadro = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_pesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtSala = new System.Windows.Forms.DataGridView();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.BtnAttSala = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSala)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.gradientPanel1.Controls.Add(this.quadro);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(886, 162);
            this.gradientPanel1.TabIndex = 0;
            // 
            // quadro
            // 
            this.quadro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quadro.BackColor = System.Drawing.Color.Transparent;
            this.quadro.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.quadro.IconColor = System.Drawing.Color.White;
            this.quadro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.quadro.IconSize = 128;
            this.quadro.Location = new System.Drawing.Point(90, 24);
            this.quadro.Margin = new System.Windows.Forms.Padding(2);
            this.quadro.Name = "quadro";
            this.quadro.Size = new System.Drawing.Size(128, 138);
            this.quadro.TabIndex = 3;
            this.quadro.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 46.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(207, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(486, 71);
            this.label6.TabIndex = 2;
            this.label6.Text = "Controle de Sala";
            // 
            // box_pesquisa
            // 
            this.box_pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_pesquisa.Location = new System.Drawing.Point(20, 187);
            this.box_pesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.box_pesquisa.MaxLength = 1000;
            this.box_pesquisa.Name = "box_pesquisa";
            this.box_pesquisa.Size = new System.Drawing.Size(738, 41);
            this.box_pesquisa.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(16, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 1);
            this.panel1.TabIndex = 17;
            // 
            // dtSala
            // 
            this.dtSala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSala.BackgroundColor = System.Drawing.Color.Snow;
            this.dtSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSala.Location = new System.Drawing.Point(20, 251);
            this.dtSala.Margin = new System.Windows.Forms.Padding(2);
            this.dtSala.Name = "dtSala";
            this.dtSala.RowHeadersWidth = 51;
            this.dtSala.RowTemplate.Height = 24;
            this.dtSala.Size = new System.Drawing.Size(739, 427);
            this.dtSala.TabIndex = 22;
            this.dtSala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSala_CellClick);
            this.dtSala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSala_CellContentClick);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(762, 358);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(120, 50);
            this.iconButton2.TabIndex = 21;
            this.iconButton2.Text = "  Excluir";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // BtnAttSala
            // 
            this.BtnAttSala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAttSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.BtnAttSala.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAttSala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.BtnAttSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAttSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttSala.ForeColor = System.Drawing.Color.Black;
            this.BtnAttSala.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.BtnAttSala.IconColor = System.Drawing.Color.Black;
            this.BtnAttSala.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAttSala.IconSize = 32;
            this.BtnAttSala.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAttSala.Location = new System.Drawing.Point(762, 305);
            this.BtnAttSala.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAttSala.Name = "BtnAttSala";
            this.BtnAttSala.Size = new System.Drawing.Size(120, 50);
            this.BtnAttSala.TabIndex = 20;
            this.BtnAttSala.Text = "  Editar";
            this.BtnAttSala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAttSala.UseVisualStyleBackColor = false;
            this.BtnAttSala.Click += new System.EventHandler(this.BtnAttSala_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(231)))), ((int)(((byte)(134)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(763, 251);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 50);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "    Add  ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnPesquisar.IconColor = System.Drawing.Color.White;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 40;
            this.btnPesquisar.Location = new System.Drawing.Point(762, 187);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 40);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // TelaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(886, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSala);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.BtnAttSala);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.box_pesquisa);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaSala";
            this.Text = "TelaSala";
            this.Load += new System.EventHandler(this.TelaSala_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROL.GradientPanel gradientPanel1;
        private FontAwesome.Sharp.IconPictureBox quadro;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.TextBox box_pesquisa;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton BtnAttSala;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridView dtSala;
        private System.Windows.Forms.Label label1;
    }
}