namespace Projeto_Loc_Senai.FormsVisitante
{
    partial class TelaContatosSenai
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
            this.PainelCentral = new CONTROL.GradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PainelSuperior = new CONTROL.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PainelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PainelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelCentral
            // 
            this.PainelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelCentral.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelCentral.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelCentral.Controls.Add(this.dataGridView1);
            this.PainelCentral.Controls.Add(this.PainelSuperior);
            this.PainelCentral.Location = new System.Drawing.Point(35, 35);
            this.PainelCentral.Name = "PainelCentral";
            this.PainelCentral.Size = new System.Drawing.Size(900, 650);
            this.PainelCentral.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelSuperior.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelSuperior.Controls.Add(this.panel1);
            this.PainelSuperior.Controls.Add(this.label6);
            this.PainelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PainelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(900, 150);
            this.PainelSuperior.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 1);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 46.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(100, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(692, 77);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contatos Informativos";
            // 
            // TelaContatosSenai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 714);
            this.Controls.Add(this.PainelCentral);
            this.Name = "TelaContatosSenai";
            this.Text = "TelaContatosSenai";
            this.PainelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PainelSuperior.ResumeLayout(false);
            this.PainelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CONTROL.GradientPanel PainelCentral;
        private CONTROL.GradientPanel PainelSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}