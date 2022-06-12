namespace AdminGrpc
{
    partial class ListarE
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
            this.lblistare = new System.Windows.Forms.ListBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblistare
            // 
            this.lblistare.FormattingEnabled = true;
            this.lblistare.ItemHeight = 15;
            this.lblistare.Location = new System.Drawing.Point(63, 67);
            this.lblistare.Name = "lblistare";
            this.lblistare.Size = new System.Drawing.Size(410, 154);
            this.lblistare.TabIndex = 0;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(119, 263);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(264, 266);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // ListarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.lblistare);
            this.Name = "ListarE";
            this.Text = "ListarE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblistare;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnvoltar;
    }
}