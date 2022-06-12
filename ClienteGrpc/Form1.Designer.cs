namespace ClienteGrpc
{
    partial class Form1
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(117, 258);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(105, 229);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(100, 23);
            this.tbpassword.TabIndex = 1;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(105, 176);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(100, 23);
            this.tbusername.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbusername;
    }
}
