namespace AdminGrpc
{
    partial class ListarT
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
            this.lbListarTeatros = new System.Windows.Forms.ListBox();
            this.btnadicionarT = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListarTeatros
            // 
            this.lbListarTeatros.AccessibleName = "";
            this.lbListarTeatros.FormattingEnabled = true;
            this.lbListarTeatros.ItemHeight = 15;
            this.lbListarTeatros.Location = new System.Drawing.Point(108, 54);
            this.lbListarTeatros.Name = "lbListarTeatros";
            this.lbListarTeatros.Size = new System.Drawing.Size(533, 169);
            this.lbListarTeatros.TabIndex = 0;
            // 
            // btnadicionarT
            // 
            this.btnadicionarT.Location = new System.Drawing.Point(289, 251);
            this.btnadicionarT.Name = "btnadicionarT";
            this.btnadicionarT.Size = new System.Drawing.Size(75, 23);
            this.btnadicionarT.TabIndex = 1;
            this.btnadicionarT.Text = "Adicionar";
            this.btnadicionarT.UseVisualStyleBackColor = true;
            this.btnadicionarT.Click += new System.EventHandler(this.btnadicionarT_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(391, 251);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // ListarT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdminGrpc.Properties.Resources.teatroslista;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnadicionarT);
            this.Controls.Add(this.lbListarTeatros);
            this.Name = "ListarT";
            this.Text = "Lista Teatros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListarTeatros;
        private System.Windows.Forms.Button btnadicionarT;
        private System.Windows.Forms.Button btnvoltar;
    }
}