namespace NovoCliente
{
    partial class AdicionarFCliente
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
            this.labelatuais = new System.Windows.Forms.Label();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.lbcreditos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Fundos à Conta";
            // 
            // labelatuais
            // 
            this.labelatuais.AutoSize = true;
            this.labelatuais.BackColor = System.Drawing.Color.Transparent;
            this.labelatuais.Location = new System.Drawing.Point(223, 128);
            this.labelatuais.Name = "labelatuais";
            this.labelatuais.Size = new System.Drawing.Size(90, 15);
            this.labelatuais.TabIndex = 1;
            this.labelatuais.Text = "Créditos Atuais:";
            // 
            // tbvalor
            // 
            this.tbvalor.Location = new System.Drawing.Point(369, 194);
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(151, 23);
            this.tbvalor.TabIndex = 2;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(223, 294);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(120, 34);
            this.btnadicionar.TabIndex = 3;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(400, 294);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(120, 34);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(221, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Créditos para Adicionar:";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(369, 128);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(0, 15);
            this.labeltotal.TabIndex = 6;
            // 
            // lbcreditos
            // 
            this.lbcreditos.AutoSize = true;
            this.lbcreditos.Location = new System.Drawing.Point(333, 128);
            this.lbcreditos.Name = "lbcreditos";
            this.lbcreditos.Size = new System.Drawing.Size(38, 15);
            this.lbcreditos.TabIndex = 7;
            this.lbcreditos.Text = "label2";
            // 
            // AdicionarFCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NovoCliente.Properties.Resources.adicionar_fundos;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbcreditos);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.labelatuais);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarFCliente";
            this.Text = "AdicionarF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelatuais;
        private System.Windows.Forms.TextBox tbvalor;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label lbcreditos;
    }
}