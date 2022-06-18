namespace GestorGrpc
{
    partial class ListarEgestor
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
            this.lblistarE = new System.Windows.Forms.ListBox();
            this.btnadicionarE = new System.Windows.Forms.Button();
            this.btnalterarE = new System.Windows.Forms.Button();
            this.btncancelarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblistarE
            // 
            this.lblistarE.FormattingEnabled = true;
            this.lblistarE.ItemHeight = 15;
            this.lblistarE.Location = new System.Drawing.Point(115, 75);
            this.lblistarE.Name = "lblistarE";
            this.lblistarE.Size = new System.Drawing.Size(582, 169);
            this.lblistarE.TabIndex = 0;
            // 
            // btnadicionarE
            // 
            this.btnadicionarE.Location = new System.Drawing.Point(155, 278);
            this.btnadicionarE.Name = "btnadicionarE";
            this.btnadicionarE.Size = new System.Drawing.Size(125, 49);
            this.btnadicionarE.TabIndex = 1;
            this.btnadicionarE.Text = "Adicionar";
            this.btnadicionarE.UseVisualStyleBackColor = true;
            this.btnadicionarE.Click += new System.EventHandler(this.btnadicionarE_Click);
            // 
            // btnalterarE
            // 
            this.btnalterarE.Location = new System.Drawing.Point(343, 278);
            this.btnalterarE.Name = "btnalterarE";
            this.btnalterarE.Size = new System.Drawing.Size(125, 49);
            this.btnalterarE.TabIndex = 2;
            this.btnalterarE.Text = "Alterar";
            this.btnalterarE.UseVisualStyleBackColor = true;
            this.btnalterarE.Click += new System.EventHandler(this.btnalterarE_Click);
            // 
            // btncancelarE
            // 
            this.btncancelarE.Location = new System.Drawing.Point(526, 278);
            this.btncancelarE.Name = "btncancelarE";
            this.btncancelarE.Size = new System.Drawing.Size(125, 49);
            this.btncancelarE.TabIndex = 3;
            this.btncancelarE.Text = "Cancelar";
            this.btncancelarE.UseVisualStyleBackColor = true;
            this.btncancelarE.Click += new System.EventHandler(this.btncancelarE_Click);
            // 
            // ListarEgestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorGrpc.Properties.Resources.espetaculolista;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelarE);
            this.Controls.Add(this.btnalterarE);
            this.Controls.Add(this.btnadicionarE);
            this.Controls.Add(this.lblistarE);
            this.Name = "ListarEgestor";
            this.Text = "ListarEgestor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblistarE;
        private System.Windows.Forms.Button btnadicionarE;
        private System.Windows.Forms.Button btnalterarE;
        private System.Windows.Forms.Button btncancelarE;
    }
}