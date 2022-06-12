namespace AdminGrpc
{
    partial class InicioAdmin
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
            this.Btnlistarteatros = new System.Windows.Forms.Button();
            this.btnlistarsessao = new System.Windows.Forms.Button();
            this.btnmostrarlogin = new System.Windows.Forms.Button();
            this.btnlistarespetaculos = new System.Windows.Forms.Button();
            this.btnlistarbilhetes = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnlistarteatros
            // 
            this.Btnlistarteatros.Location = new System.Drawing.Point(315, 53);
            this.Btnlistarteatros.Name = "Btnlistarteatros";
            this.Btnlistarteatros.Size = new System.Drawing.Size(166, 52);
            this.Btnlistarteatros.TabIndex = 0;
            this.Btnlistarteatros.Text = "Listar Teatros";
            this.Btnlistarteatros.UseVisualStyleBackColor = true;
            this.Btnlistarteatros.Click += new System.EventHandler(this.Btnlistarteatros_Click);
            // 
            // btnlistarsessao
            // 
            this.btnlistarsessao.Location = new System.Drawing.Point(315, 111);
            this.btnlistarsessao.Name = "btnlistarsessao";
            this.btnlistarsessao.Size = new System.Drawing.Size(166, 52);
            this.btnlistarsessao.TabIndex = 1;
            this.btnlistarsessao.Text = "Listar Sessões";
            this.btnlistarsessao.UseVisualStyleBackColor = true;
            this.btnlistarsessao.Click += new System.EventHandler(this.btnlistarsessao_Click);
            // 
            // btnmostrarlogin
            // 
            this.btnmostrarlogin.Location = new System.Drawing.Point(315, 294);
            this.btnmostrarlogin.Name = "btnmostrarlogin";
            this.btnmostrarlogin.Size = new System.Drawing.Size(166, 53);
            this.btnmostrarlogin.TabIndex = 2;
            this.btnmostrarlogin.Text = "Mostar Login";
            this.btnmostrarlogin.UseVisualStyleBackColor = true;
            // 
            // btnlistarespetaculos
            // 
            this.btnlistarespetaculos.Location = new System.Drawing.Point(315, 173);
            this.btnlistarespetaculos.Name = "btnlistarespetaculos";
            this.btnlistarespetaculos.Size = new System.Drawing.Size(166, 53);
            this.btnlistarespetaculos.TabIndex = 3;
            this.btnlistarespetaculos.Text = "Listar Espetáculos";
            this.btnlistarespetaculos.UseVisualStyleBackColor = true;
            // 
            // btnlistarbilhetes
            // 
            this.btnlistarbilhetes.Location = new System.Drawing.Point(315, 232);
            this.btnlistarbilhetes.Name = "btnlistarbilhetes";
            this.btnlistarbilhetes.Size = new System.Drawing.Size(166, 52);
            this.btnlistarbilhetes.TabIndex = 4;
            this.btnlistarbilhetes.Text = "Listar Bilhetes";
            this.btnlistarbilhetes.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(363, 374);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = global::AdminGrpc.Properties.Resources.sistemasdistribuidos;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlistarbilhetes);
            this.Controls.Add(this.btnlistarespetaculos);
            this.Controls.Add(this.btnmostrarlogin);
            this.Controls.Add(this.btnlistarsessao);
            this.Controls.Add(this.Btnlistarteatros);
            this.Name = "InicioAdmin";
            this.Text = "InicioAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnlistarteatros;
        private System.Windows.Forms.Button btnlistarsessao;
        private System.Windows.Forms.Button btnmostrarlogin;
        private System.Windows.Forms.Button btnlistarespetaculos;
        private System.Windows.Forms.Button btnlistarbilhetes;
        private System.Windows.Forms.Button btnsair;
    }
}