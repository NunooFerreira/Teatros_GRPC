namespace GestorGrpc
{
    partial class AlterarEgestor
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
            this.btnremover = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbespetaculo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(253, 229);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(75, 23);
            this.btnremover.TabIndex = 0;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(437, 229);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 1;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha um Espetaculo para Remover";

            // 
            // cmbespetaculo
            // 
            this.cmbespetaculo.FormattingEnabled = true;
            this.cmbespetaculo.Location = new System.Drawing.Point(225, 142);
            this.cmbespetaculo.Name = "cmbespetaculo";
            this.cmbespetaculo.Size = new System.Drawing.Size(314, 23);
            this.cmbespetaculo.TabIndex = 3;
            // 
            // AlterarEgestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbespetaculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnremover);
            this.Name = "AlterarEgestor";
            this.Text = "AlterarEgestor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbespetaculo;
    }
}