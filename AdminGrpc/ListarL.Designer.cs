namespace AdminGrpc
{
    partial class ListarL
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
            this.lblogin = new System.Windows.Forms.ListBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblogin
            // 
            this.lblogin.FormattingEnabled = true;
            this.lblogin.ItemHeight = 20;
            this.lblogin.Location = new System.Drawing.Point(85, 95);
            this.lblogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(637, 224);
            this.lblogin.TabIndex = 1;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(350, 345);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(86, 31);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // ListarL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lblogin);
            this.Name = "ListarL";
            this.Text = "ListarL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblogin;
        private System.Windows.Forms.Button btnvoltar;
    }
}