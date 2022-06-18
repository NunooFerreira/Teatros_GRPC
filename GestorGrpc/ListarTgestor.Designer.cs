namespace GestorGrpc
{
    partial class ListarTgestor
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
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblistarT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(186, 290);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(102, 42);
            this.btnadicionar.TabIndex = 0;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(319, 290);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(102, 42);
            this.btnalterar.TabIndex = 1;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(454, 290);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 42);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblistarT
            // 
            this.lblistarT.FormattingEnabled = true;
            this.lblistarT.ItemHeight = 15;
            this.lblistarT.Location = new System.Drawing.Point(149, 58);
            this.lblistarT.Name = "lblistarT";
            this.lblistarT.Size = new System.Drawing.Size(450, 199);
            this.lblistarT.TabIndex = 3;
            // 
            // ListarTgestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorGrpc.Properties.Resources.teatroslista;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblistarT);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnadicionar);
            this.Name = "ListarTgestor";
            this.Text = "ListarTgestor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ListBox lblistarT;
    }
}