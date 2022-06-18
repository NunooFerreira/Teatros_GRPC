namespace GestorGrpc
{
    partial class AssociarSessao
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
            this.cbsessao = new System.Windows.Forms.ComboBox();
            this.cbespetaculos = new System.Windows.Forms.ComboBox();
            this.cbteatros = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnassociar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbsessao
            // 
            this.cbsessao.FormattingEnabled = true;
            this.cbsessao.Location = new System.Drawing.Point(207, 205);
            this.cbsessao.Name = "cbsessao";
            this.cbsessao.Size = new System.Drawing.Size(171, 23);
            this.cbsessao.TabIndex = 20;
            // 
            // cbespetaculos
            // 
            this.cbespetaculos.FormattingEnabled = true;
            this.cbespetaculos.Location = new System.Drawing.Point(384, 64);
            this.cbespetaculos.Name = "cbespetaculos";
            this.cbespetaculos.Size = new System.Drawing.Size(165, 23);
            this.cbespetaculos.TabIndex = 19;
            // 
            // cbteatros
            // 
            this.cbteatros.FormattingEnabled = true;
            this.cbteatros.Location = new System.Drawing.Point(207, 64);
            this.cbteatros.Name = "cbteatros";
            this.cbteatros.Size = new System.Drawing.Size(150, 23);
            this.cbteatros.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(261, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sessao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(418, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Espetaculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(252, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Teatros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pesquisar por:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Associar:";
            // 
            // btnassociar
            // 
            this.btnassociar.Location = new System.Drawing.Point(303, 315);
            this.btnassociar.Name = "btnassociar";
            this.btnassociar.Size = new System.Drawing.Size(75, 23);
            this.btnassociar.TabIndex = 22;
            this.btnassociar.Text = "Associar";
            this.btnassociar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(419, 315);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // AssociarSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorGrpc.Properties.Resources.registologin__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnassociar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbsessao);
            this.Controls.Add(this.cbespetaculos);
            this.Controls.Add(this.cbteatros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssociarSessao";
            this.Text = "AssociarSessao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbsessao;
        private System.Windows.Forms.ComboBox cbespetaculos;
        private System.Windows.Forms.ComboBox cbteatros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnassociar;
        private System.Windows.Forms.Button btncancelar;
    }
}