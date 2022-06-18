namespace GestorGrpc
{
    partial class InicioGestor
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
            this.btnAdicionarT = new System.Windows.Forms.Button();
            this.btnAdicionarS = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarT
            // 
            this.btnAdicionarT.Location = new System.Drawing.Point(303, 106);
            this.btnAdicionarT.Name = "btnAdicionarT";
            this.btnAdicionarT.Size = new System.Drawing.Size(216, 40);
            this.btnAdicionarT.TabIndex = 0;
            this.btnAdicionarT.Text = "Adicionar/Alterar Teatro";
            this.btnAdicionarT.UseVisualStyleBackColor = true;
            this.btnAdicionarT.Click += new System.EventHandler(this.btnAdicionarT_Click);
            // 
            // btnAdicionarS
            // 
            this.btnAdicionarS.Location = new System.Drawing.Point(303, 176);
            this.btnAdicionarS.Name = "btnAdicionarS";
            this.btnAdicionarS.Size = new System.Drawing.Size(216, 40);
            this.btnAdicionarS.TabIndex = 1;
            this.btnAdicionarS.Text = "Adicionar/Alterar Sessão";
            this.btnAdicionarS.UseVisualStyleBackColor = true;
            this.btnAdicionarS.Click += new System.EventHandler(this.btnAdicionarS_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(351, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 40);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionarE
            // 
            this.btnAdicionarE.Location = new System.Drawing.Point(303, 246);
            this.btnAdicionarE.Name = "btnAdicionarE";
            this.btnAdicionarE.Size = new System.Drawing.Size(216, 40);
            this.btnAdicionarE.TabIndex = 5;
            this.btnAdicionarE.Text = "Associar/Remover Sessões";
            this.btnAdicionarE.UseVisualStyleBackColor = true;
            this.btnAdicionarE.Click += new System.EventHandler(this.btnAdicionarE_Click);
            // 
            // InicioGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorGrpc.Properties.Resources.sistemasdistribuidos;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarE);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionarS);
            this.Controls.Add(this.btnAdicionarT);
            this.Name = "InicioGestor";
            this.Text = "InicioGestor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarT;
        private System.Windows.Forms.Button btnAdicionarS;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionarE;
    }
}