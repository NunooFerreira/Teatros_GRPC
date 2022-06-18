namespace AdminGrpc
{
    partial class ListarRegistosEspetaculos
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.registosEspetaculosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(420, 342);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(86, 31);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(310, 342);
            this.btnadicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(86, 31);
            this.btnadicionar.TabIndex = 4;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // registosEspetaculosListBox
            // 
            this.registosEspetaculosListBox.FormattingEnabled = true;
            this.registosEspetaculosListBox.ItemHeight = 20;
            this.registosEspetaculosListBox.Location = new System.Drawing.Point(83, 78);
            this.registosEspetaculosListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registosEspetaculosListBox.Name = "registosEspetaculosListBox";
            this.registosEspetaculosListBox.Size = new System.Drawing.Size(635, 224);
            this.registosEspetaculosListBox.TabIndex = 3;
            // 
            // ListarRegistosEspetaculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.registosEspetaculosListBox);
            this.Name = "ListarRegistosEspetaculos";
            this.Text = "ListarRegistosEspetaculos";
            this.Load += new System.EventHandler(this.ListarRegistosEspetaculos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.ListBox registosEspetaculosListBox;
    }
}