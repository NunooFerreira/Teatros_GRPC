
namespace adminSorteio
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
            this.lbUserKey = new System.Windows.Forms.ListBox();
            this.btGetBets = new System.Windows.Forms.Button();
            this.btArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserKey
            // 
            this.lbUserKey.FormattingEnabled = true;
            this.lbUserKey.ItemHeight = 20;
            this.lbUserKey.Location = new System.Drawing.Point(43, 89);
            this.lbUserKey.Name = "lbUserKey";
            this.lbUserKey.Size = new System.Drawing.Size(501, 264);
            this.lbUserKey.TabIndex = 0;
            // 
            // btGetBets
            // 
            this.btGetBets.Location = new System.Drawing.Point(585, 98);
            this.btGetBets.Name = "btGetBets";
            this.btGetBets.Size = new System.Drawing.Size(136, 29);
            this.btGetBets.TabIndex = 1;
            this.btGetBets.Text = "Get all bets";
            this.btGetBets.UseVisualStyleBackColor = true;
            this.btGetBets.Click += new System.EventHandler(this.btGetBets_ClickAsync);
            // 
            // btArchive
            // 
            this.btArchive.Location = new System.Drawing.Point(585, 142);
            this.btArchive.Name = "btArchive";
            this.btArchive.Size = new System.Drawing.Size(136, 29);
            this.btArchive.TabIndex = 2;
            this.btArchive.Text = "Archive bets";
            this.btArchive.UseVisualStyleBackColor = true;
            this.btArchive.Click += new System.EventHandler(this.btArchive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btArchive);
            this.Controls.Add(this.btGetBets);
            this.Controls.Add(this.lbUserKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserKey;
        private System.Windows.Forms.Button btGetBets;
        private System.Windows.Forms.Button btArchive;
    }
}

