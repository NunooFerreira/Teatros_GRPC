namespace AdminGrpc
{
    partial class ListarS
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
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.ItemHeight = 15;
            this.lbSessoes.Location = new System.Drawing.Point(109, 72);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(198, 154);
            this.lbSessoes.TabIndex = 0;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(109, 255);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(207, 255);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // ListarS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.lbSessoes);
            this.Name = "ListarS";
            this.Text = "ListarSessoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnvoltar;
    }
}