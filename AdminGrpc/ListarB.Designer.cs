namespace AdminGrpc
{
    partial class ListarB
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
            this.lbbilhetes = new System.Windows.Forms.ListBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbbilhetes
            // 
            this.lbbilhetes.FormattingEnabled = true;
            this.lbbilhetes.ItemHeight = 15;
            this.lbbilhetes.Location = new System.Drawing.Point(96, 66);
            this.lbbilhetes.Name = "lbbilhetes";
            this.lbbilhetes.Size = new System.Drawing.Size(581, 184);
            this.lbbilhetes.TabIndex = 0;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(352, 294);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 1;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // ListarB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdminGrpc.Properties.Resources.listarb;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lbbilhetes);
            this.Name = "ListarB";
            this.Text = "ListarB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbbilhetes;
        private System.Windows.Forms.Button btnvoltar;
    }
}