﻿namespace NovoCliente
{
    partial class LoginC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnentrar = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lcriarconta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnentrar
            // 
            this.btnentrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnentrar.Location = new System.Drawing.Point(347, 281);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(101, 40);
            this.btnentrar.TabIndex = 0;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(226, 222);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(345, 23);
            this.tbpassword.TabIndex = 1;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(226, 135);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(345, 23);
            this.tbusername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(364, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(226, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(226, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // lcriarconta
            // 
            this.lcriarconta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lcriarconta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lcriarconta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lcriarconta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lcriarconta.Location = new System.Drawing.Point(328, 363);
            this.lcriarconta.Name = "lcriarconta";
            this.lcriarconta.Size = new System.Drawing.Size(138, 18);
            this.lcriarconta.TabIndex = 6;
            this.lcriarconta.Text = "Criar uma nova conta";
            this.lcriarconta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lcriarconta.Click += new System.EventHandler(this.lcriarconta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(328, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Esqueci-me da Password";
            // 
            // LabelCliente
            // 
            this.LabelCliente.AutoSize = true;
            this.LabelCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LabelCliente.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCliente.Location = new System.Drawing.Point(347, 9);
            this.LabelCliente.Name = "LabelCliente";
            this.LabelCliente.Size = new System.Drawing.Size(123, 45);
            this.LabelCliente.TabIndex = 18;
            this.LabelCliente.Text = "Cliente";
            // 
            // LoginC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NovoCliente.Properties.Resources.registologin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lcriarconta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.btnentrar);
            this.Name = "LoginC";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lcriarconta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelCliente;
    }
}
