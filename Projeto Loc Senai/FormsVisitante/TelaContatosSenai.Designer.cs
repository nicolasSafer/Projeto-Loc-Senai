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
            this.PainelSuperior = new CONTROL.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelArredondado1 = new CONTROL.PainelArredondado();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PainelCentral.SuspendLayout();
            this.PainelSuperior.SuspendLayout();
            this.painelArredondado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelCentral
            // 
            this.PainelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelCentral.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelCentral.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(140)))), ((int)(((byte)(189)))));
            this.PainelCentral.Controls.Add(this.painelArredondado1);
            this.PainelCentral.Controls.Add(this.PainelSuperior);
            this.PainelCentral.Location = new System.Drawing.Point(47, 43);
            this.PainelCentral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PainelCentral.Name = "PainelCentral";
            this.PainelCentral.Size = new System.Drawing.Size(1200, 800);
            this.PainelCentral.TabIndex = 1;
            // 
            // PainelSuperior
            // 
            this.PainelSuperior.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelSuperior.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.PainelSuperior.Controls.Add(this.panel1);
            this.PainelSuperior.Controls.Add(this.label6);
            this.PainelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PainelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PainelSuperior.Name = "PainelSuperior";
            this.PainelSuperior.Size = new System.Drawing.Size(1200, 185);
            this.PainelSuperior.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 1);
            this.panel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 46.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(160, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(857, 92);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contatos Informativos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SENAI - Campus da Indústria  /   Fone: (41) 3271-7900\r\n";
            // 
            // painelArredondado1
            // 
            this.painelArredondado1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.painelArredondado1.BackColor = System.Drawing.Color.White;
            this.painelArredondado1.BorderRadius = 30;
            this.painelArredondado1.Controls.Add(this.label5);
            this.painelArredondado1.Controls.Add(this.label4);
            this.painelArredondado1.Controls.Add(this.label3);
            this.painelArredondado1.Controls.Add(this.label2);
            this.painelArredondado1.Controls.Add(this.label1);
            this.painelArredondado1.ForeColor = System.Drawing.Color.Black;
            this.painelArredondado1.GradientAngle = 90F;
            this.painelArredondado1.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
            this.painelArredondado1.GradientTopColor = System.Drawing.Color.White;
            this.painelArredondado1.Location = new System.Drawing.Point(149, 227);
            this.painelArredondado1.Name = "painelArredondado1";
            this.painelArredondado1.Size = new System.Drawing.Size(897, 514);
            this.painelArredondado1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(95, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(695, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENAI - Celso Charuri              /   Fone: (41) 3271-9946\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(695, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "SENAI - Boqueirão                    /   Fone: (41) 3271-8947\r\n";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(95, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(695, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "SENAI - CIC                                /   Fone: (41) 3271-7114\r\n";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(95, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(697, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "SENAI - Portão                           /   Fone: (41) 3271-8450\r\n";
            // 
            // TelaContatosSenai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 879);
            this.Controls.Add(this.PainelCentral);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaContatosSenai";
            this.Text = "TelaContatosSenai";
            this.PainelCentral.ResumeLayout(false);
            this.PainelSuperior.ResumeLayout(false);
            this.PainelSuperior.PerformLayout();
            this.painelArredondado1.ResumeLayout(false);
            this.painelArredondado1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CONTROL.GradientPanel PainelCentral;
        private CONTROL.GradientPanel PainelSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private CONTROL.PainelArredondado painelArredondado1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}