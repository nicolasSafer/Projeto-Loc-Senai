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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMapaSenai));
            this.picture_map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_map
            // 
            this.picture_map.Image = ((System.Drawing.Image)(resources.GetObject("picture_map.Image")));
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
    }
}