namespace Projeto_Loc_Senai.FormsVisitante
{
    partial class TelaDescEvento
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
            this.box_nome_evento = new System.Windows.Forms.TextBox();
            this.box_data_evento = new System.Windows.Forms.TextBox();
            this.box_local_evento = new System.Windows.Forms.TextBox();
            this.box_desc_evento = new System.Windows.Forms.TextBox();
            this.box_hora_evento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // box_nome_evento
            // 
            this.box_nome_evento.Location = new System.Drawing.Point(386, 147);
            this.box_nome_evento.Name = "box_nome_evento";
            this.box_nome_evento.Size = new System.Drawing.Size(100, 20);
            this.box_nome_evento.TabIndex = 1;
            // 
            // box_data_evento
            // 
            this.box_data_evento.Location = new System.Drawing.Point(386, 199);
            this.box_data_evento.Name = "box_data_evento";
            this.box_data_evento.Size = new System.Drawing.Size(100, 20);
            this.box_data_evento.TabIndex = 2;
            // 
            // box_local_evento
            // 
            this.box_local_evento.Location = new System.Drawing.Point(386, 173);
            this.box_local_evento.Name = "box_local_evento";
            this.box_local_evento.Size = new System.Drawing.Size(100, 20);
            this.box_local_evento.TabIndex = 3;
            // 
            // box_desc_evento
            // 
            this.box_desc_evento.Location = new System.Drawing.Point(386, 251);
            this.box_desc_evento.Name = "box_desc_evento";
            this.box_desc_evento.Size = new System.Drawing.Size(100, 20);
            this.box_desc_evento.TabIndex = 4;
            // 
            // box_hora_evento
            // 
            this.box_hora_evento.Location = new System.Drawing.Point(386, 225);
            this.box_hora_evento.Name = "box_hora_evento";
            this.box_hora_evento.Size = new System.Drawing.Size(100, 20);
            this.box_hora_evento.TabIndex = 5;
            // 
            // TelaDescEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 580);
            this.Controls.Add(this.box_hora_evento);
            this.Controls.Add(this.box_desc_evento);
            this.Controls.Add(this.box_local_evento);
            this.Controls.Add(this.box_data_evento);
            this.Controls.Add(this.box_nome_evento);
            this.Name = "TelaDescEvento";
            this.Text = "TelaDescEvento";
            this.Load += new System.EventHandler(this.TelaDescEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_nome_evento;
        private System.Windows.Forms.TextBox box_data_evento;
        private System.Windows.Forms.TextBox box_local_evento;
        private System.Windows.Forms.TextBox box_desc_evento;
        private System.Windows.Forms.TextBox box_hora_evento;
    }
}