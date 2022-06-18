namespace NovoCliente
{
    partial class PesquisarInfoCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbpesquisas = new System.Windows.Forms.ListBox();
            this.btnefetuapesquisa = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.cbteatros = new System.Windows.Forms.ComboBox();
            this.cbespetaculos = new System.Windows.Forms.ComboBox();
            this.cbsessao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(227, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teatros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(393, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Espetaculos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(613, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sessao";
            // 
            // lbpesquisas
            // 
            this.lbpesquisas.FormattingEnabled = true;
            this.lbpesquisas.ItemHeight = 15;
            this.lbpesquisas.Location = new System.Drawing.Point(182, 126);
            this.lbpesquisas.Name = "lbpesquisas";
            this.lbpesquisas.Size = new System.Drawing.Size(535, 199);
            this.lbpesquisas.TabIndex = 7;
            // 
            // btnefetuapesquisa
            // 
            this.btnefetuapesquisa.Location = new System.Drawing.Point(311, 97);
            this.btnefetuapesquisa.Name = "btnefetuapesquisa";
            this.btnefetuapesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnefetuapesquisa.TabIndex = 8;
            this.btnefetuapesquisa.Text = "Pesquisar";
            this.btnefetuapesquisa.UseVisualStyleBackColor = true;
            this.btnefetuapesquisa.Click += new System.EventHandler(this.btnefetuapesquisa_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(487, 97);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(393, 372);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // cbteatros
            // 
            this.cbteatros.FormattingEnabled = true;
            this.cbteatros.Location = new System.Drawing.Point(182, 63);
            this.cbteatros.Name = "cbteatros";
            this.cbteatros.Size = new System.Drawing.Size(150, 23);
            this.cbteatros.TabIndex = 11;
            // 
            // cbespetaculos
            // 
            this.cbespetaculos.FormattingEnabled = true;
            this.cbespetaculos.Location = new System.Drawing.Point(359, 63);
            this.cbespetaculos.Name = "cbespetaculos";
            this.cbespetaculos.Size = new System.Drawing.Size(165, 23);
            this.cbespetaculos.TabIndex = 12;
            // 
            // cbsessao
            // 
            this.cbsessao.FormattingEnabled = true;
            this.cbsessao.Location = new System.Drawing.Point(546, 63);
            this.cbsessao.Name = "cbsessao";
            this.cbsessao.Size = new System.Drawing.Size(171, 23);
            this.cbsessao.TabIndex = 13;
            // 
            // PesquisarInfoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NovoCliente.Properties.Resources.registologin__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbsessao);
            this.Controls.Add(this.cbespetaculos);
            this.Controls.Add(this.cbteatros);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnefetuapesquisa);
            this.Controls.Add(this.lbpesquisas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PesquisarInfoCliente";
            this.Text = "PesquisarInfoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbpesquisas;
        private System.Windows.Forms.Button btnefetuapesquisa;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.ComboBox cbteatros;
        private System.Windows.Forms.ComboBox cbespetaculos;
        private System.Windows.Forms.ComboBox cbsessao;
    }
}