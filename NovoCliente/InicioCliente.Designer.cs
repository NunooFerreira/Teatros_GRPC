namespace NovoCliente
{
    partial class InicioCliente
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
            this.btncomprarbilhetes = new System.Windows.Forms.Button();
            this.btnadicionarfundos = new System.Windows.Forms.Button();
            this.btnbilhetescomprados = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnanularcompra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncomprarbilhetes
            // 
            this.btncomprarbilhetes.Location = new System.Drawing.Point(369, 253);
            this.btncomprarbilhetes.Name = "btncomprarbilhetes";
            this.btncomprarbilhetes.Size = new System.Drawing.Size(115, 23);
            this.btncomprarbilhetes.TabIndex = 0;
            this.btncomprarbilhetes.Text = "Comprar Bilhetes";
            this.btncomprarbilhetes.UseVisualStyleBackColor = true;
            this.btncomprarbilhetes.Click += new System.EventHandler(this.btncomprarbilhetes_Click);
            // 
            // btnadicionarfundos
            // 
            this.btnadicionarfundos.Location = new System.Drawing.Point(369, 282);
            this.btnadicionarfundos.Name = "btnadicionarfundos";
            this.btnadicionarfundos.Size = new System.Drawing.Size(115, 23);
            this.btnadicionarfundos.TabIndex = 1;
            this.btnadicionarfundos.Text = "Adicionar Fundos";
            this.btnadicionarfundos.UseVisualStyleBackColor = true;
            this.btnadicionarfundos.Click += new System.EventHandler(this.btnadicionarfundos_Click);
            // 
            // btnbilhetescomprados
            // 
            this.btnbilhetescomprados.Location = new System.Drawing.Point(369, 311);
            this.btnbilhetescomprados.Name = "btnbilhetescomprados";
            this.btnbilhetescomprados.Size = new System.Drawing.Size(115, 23);
            this.btnbilhetescomprados.TabIndex = 2;
            this.btnbilhetescomprados.Text = "Bilhetes Comprados";
            this.btnbilhetescomprados.UseVisualStyleBackColor = true;
            this.btnbilhetescomprados.Click += new System.EventHandler(this.btnbilhetescomprados_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(387, 415);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnanularcompra
            // 
            this.btnanularcompra.Location = new System.Drawing.Point(369, 340);
            this.btnanularcompra.Name = "btnanularcompra";
            this.btnanularcompra.Size = new System.Drawing.Size(115, 23);
            this.btnanularcompra.TabIndex = 7;
            this.btnanularcompra.Text = "Anular Compra";
            this.btnanularcompra.UseVisualStyleBackColor = true;
            this.btnanularcompra.Click += new System.EventHandler(this.btnanularcompra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(391, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ações";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(369, 224);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(115, 23);
            this.btnpesquisar.TabIndex = 11;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // InicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::NovoCliente.Properties.Resources.sistemasdistribuidos;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnanularcompra);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnbilhetescomprados);
            this.Controls.Add(this.btnadicionarfundos);
            this.Controls.Add(this.btncomprarbilhetes);
            this.Name = "InicioCliente";
            this.Text = "InicioCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncomprarbilhetes;
        private System.Windows.Forms.Button btnadicionarfundos;
        private System.Windows.Forms.Button btnbilhetescomprados;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnanularcompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnpesquisar;
    }
}