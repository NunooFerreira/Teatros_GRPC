namespace AdminGrpc
{
    partial class AdicionarRegistoEspetaculo
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
            this.teatrosListBox = new System.Windows.Forms.ListBox();
            this.labelTeatros = new System.Windows.Forms.Label();
            this.labelEspetaculos = new System.Windows.Forms.Label();
            this.espetaculosListBox = new System.Windows.Forms.ListBox();
            this.labelSessoes = new System.Windows.Forms.Label();
            this.sessoesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfimar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teatrosListBox
            // 
            this.teatrosListBox.DisplayMember = "Text";
            this.teatrosListBox.FormattingEnabled = true;
            this.teatrosListBox.ItemHeight = 20;
            this.teatrosListBox.Location = new System.Drawing.Point(12, 65);
            this.teatrosListBox.Name = "teatrosListBox";
            this.teatrosListBox.Size = new System.Drawing.Size(221, 284);
            this.teatrosListBox.TabIndex = 0;
            // 
            // labelTeatros
            // 
            this.labelTeatros.AutoSize = true;
            this.labelTeatros.Location = new System.Drawing.Point(12, 42);
            this.labelTeatros.Name = "labelTeatros";
            this.labelTeatros.Size = new System.Drawing.Size(57, 20);
            this.labelTeatros.TabIndex = 1;
            this.labelTeatros.Text = "Teatros";
            // 
            // labelEspetaculos
            // 
            this.labelEspetaculos.AutoSize = true;
            this.labelEspetaculos.Location = new System.Drawing.Point(254, 42);
            this.labelEspetaculos.Name = "labelEspetaculos";
            this.labelEspetaculos.Size = new System.Drawing.Size(87, 20);
            this.labelEspetaculos.TabIndex = 2;
            this.labelEspetaculos.Text = "Espetáculos";
            // 
            // espetaculosListBox
            // 
            this.espetaculosListBox.DisplayMember = "Text";
            this.espetaculosListBox.FormattingEnabled = true;
            this.espetaculosListBox.ItemHeight = 20;
            this.espetaculosListBox.Location = new System.Drawing.Point(254, 65);
            this.espetaculosListBox.Name = "espetaculosListBox";
            this.espetaculosListBox.Size = new System.Drawing.Size(237, 284);
            this.espetaculosListBox.TabIndex = 3;
            // 
            // labelSessoes
            // 
            this.labelSessoes.AutoSize = true;
            this.labelSessoes.Location = new System.Drawing.Point(512, 42);
            this.labelSessoes.Name = "labelSessoes";
            this.labelSessoes.Size = new System.Drawing.Size(60, 20);
            this.labelSessoes.TabIndex = 4;
            this.labelSessoes.Text = "Sessões";
            // 
            // sessoesListBox
            // 
            this.sessoesListBox.DisplayMember = "Text";
            this.sessoesListBox.FormattingEnabled = true;
            this.sessoesListBox.ItemHeight = 20;
            this.sessoesListBox.Location = new System.Drawing.Point(512, 65);
            this.sessoesListBox.Name = "sessoesListBox";
            this.sessoesListBox.Size = new System.Drawing.Size(237, 284);
            this.sessoesListBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adicionar Registo Espetáculo";
            // 
            // buttonConfimar
            // 
            this.buttonConfimar.Location = new System.Drawing.Point(282, 391);
            this.buttonConfimar.Name = "buttonConfimar";
            this.buttonConfimar.Size = new System.Drawing.Size(94, 29);
            this.buttonConfimar.TabIndex = 7;
            this.buttonConfimar.Text = "Confirmar";
            this.buttonConfimar.UseVisualStyleBackColor = true;
            this.buttonConfimar.Click += new System.EventHandler(this.buttonConfimar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(382, 391);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // AdicionarRegistoEspetaculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfimar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessoesListBox);
            this.Controls.Add(this.labelSessoes);
            this.Controls.Add(this.espetaculosListBox);
            this.Controls.Add(this.labelEspetaculos);
            this.Controls.Add(this.labelTeatros);
            this.Controls.Add(this.teatrosListBox);
            this.Name = "AdicionarRegistoEspetaculo";
            this.Text = "AdicionarRegistoEspetaculo";
            this.Load += new System.EventHandler(this.AdicionarRegistoEspetaculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teatrosListBox;
        private System.Windows.Forms.Label labelTeatros;
        private System.Windows.Forms.Label labelEspetaculos;
        private System.Windows.Forms.ListBox espetaculosListBox;
        private System.Windows.Forms.Label labelSessoes;
        private System.Windows.Forms.ListBox sessoesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfimar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}