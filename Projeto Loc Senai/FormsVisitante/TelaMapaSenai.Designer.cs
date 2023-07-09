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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.picture_map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 68);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sala de Jogos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 68);
            this.button2.TabIndex = 12;
            this.button2.Text = "Lab info 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 68);
            this.button3.TabIndex = 13;
            this.button3.Text = "Lab info 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 68);
            this.button4.TabIndex = 14;
            this.button4.Text = "Lab redes 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 636);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 68);
            this.button5.TabIndex = 15;
            this.button5.Text = "Lab redes 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // picture_map
            // 
            this.picture_map.Image = global::Projeto_Loc_Senai.Properties.Resources.map3;
            this.picture_map.Location = new System.Drawing.Point(189, 4);
            this.picture_map.Name = "picture_map";
            this.picture_map.Size = new System.Drawing.Size(1006, 1011);
            this.picture_map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_map.TabIndex = 10;
            this.picture_map.TabStop = false;
            // 
            // TelaMapaSenai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 1013);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture_map);
            this.Name = "TelaMapaSenai";
            this.Text = "TelaMapaSenai";
            this.Load += new System.EventHandler(this.TelaMapaSenai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_map;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}