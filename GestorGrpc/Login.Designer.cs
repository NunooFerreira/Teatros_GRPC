namespace GestorGrpc
{
    partial class Login
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lpassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(335, 291);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(323, 139);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(121, 23);
            this.tbusername.TabIndex = 1;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(323, 248);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(121, 23);
            this.tbpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.Location = new System.Drawing.Point(354, 230);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(57, 15);
            this.lpassword.TabIndex = 4;
            this.lpassword.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnlogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lpassword;
    }
}