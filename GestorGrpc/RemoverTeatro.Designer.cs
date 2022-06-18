namespace GestorGrpc
{
    partial class RemoverTeatro
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.cmbremoverteatro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(249, 243);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(90, 243);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(75, 23);
            this.btnremover.TabIndex = 20;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            // 
            // cmbremoverteatro
            // 
            this.cmbremoverteatro.FormattingEnabled = true;
            this.cmbremoverteatro.Location = new System.Drawing.Point(51, 165);
            this.cmbremoverteatro.Name = "cmbremoverteatro";
            this.cmbremoverteatro.Size = new System.Drawing.Size(321, 23);
            this.cmbremoverteatro.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(140, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Remover Teatro";
            // 
            // RemoverTeatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorGrpc.Properties.Resources.Teatros;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.cmbremoverteatro);
            this.Controls.Add(this.label1);
            this.Name = "RemoverTeatro";
            this.Text = "RemoverTeatro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.ComboBox cmbremoverteatro;
        private System.Windows.Forms.Label label1;
    }
}