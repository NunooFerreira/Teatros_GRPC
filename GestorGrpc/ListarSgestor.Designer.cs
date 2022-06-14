namespace GestorGrpc
{
    partial class ListarSgestor
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
            this.lblistarS = new System.Windows.Forms.ListBox();
            this.btnadicionarS = new System.Windows.Forms.Button();
            this.btnremoverS = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblistarS
            // 
            this.lblistarS.FormattingEnabled = true;
            this.lblistarS.ItemHeight = 15;
            this.lblistarS.Location = new System.Drawing.Point(94, 67);
            this.lblistarS.Name = "lblistarS";
            this.lblistarS.Size = new System.Drawing.Size(577, 169);
            this.lblistarS.TabIndex = 0;
            // 
            // btnadicionarS
            // 
            this.btnadicionarS.Location = new System.Drawing.Point(142, 289);
            this.btnadicionarS.Name = "btnadicionarS";
            this.btnadicionarS.Size = new System.Drawing.Size(111, 50);
            this.btnadicionarS.TabIndex = 1;
            this.btnadicionarS.Text = "Adicionar";
            this.btnadicionarS.UseVisualStyleBackColor = true;
            // 
            // btnremoverS
            // 
            this.btnremoverS.Location = new System.Drawing.Point(323, 289);
            this.btnremoverS.Name = "btnremoverS";
            this.btnremoverS.Size = new System.Drawing.Size(111, 50);
            this.btnremoverS.TabIndex = 2;
            this.btnremoverS.Text = "Remover";
            this.btnremoverS.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(503, 289);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(111, 50);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // ListarSgestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorGrpc.Properties.Resources.sessaolista;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnremoverS);
            this.Controls.Add(this.btnadicionarS);
            this.Controls.Add(this.lblistarS);
            this.Name = "ListarSgestor";
            this.Text = "ListarSgestor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblistarS;
        private System.Windows.Forms.Button btnadicionarS;
        private System.Windows.Forms.Button btnremoverS;
        private System.Windows.Forms.Button btncancelar;
    }
}