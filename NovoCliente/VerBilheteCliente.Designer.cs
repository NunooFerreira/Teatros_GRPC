namespace NovoCliente
{
    partial class VerBilheteCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbBilhete = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilhetes Comprados:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(340, 309);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 45);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lbBilhete
            // 
            this.lbBilhete.FormattingEnabled = true;
            this.lbBilhete.ItemHeight = 15;
            this.lbBilhete.Location = new System.Drawing.Point(66, 94);
            this.lbBilhete.Name = "lbBilhete";
            this.lbBilhete.Size = new System.Drawing.Size(646, 184);
            this.lbBilhete.TabIndex = 2;
            // 
            // VerBilheteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NovoCliente.Properties.Resources.bilhete__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBilhete);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Name = "VerBilheteCliente";
            this.Text = "VerB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ListBox lbBilhete;
    }
}