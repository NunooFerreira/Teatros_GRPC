namespace NovoCliente
{
    partial class ComprarBCliente
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
            this.sessaoDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfimar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sessaoDataGridView
            // 
            this.sessaoDataGridView.AllowUserToAddRows = false;
            this.sessaoDataGridView.AllowUserToDeleteRows = false;
            this.sessaoDataGridView.AllowUserToResizeRows = false;
            this.sessaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.value});
            this.sessaoDataGridView.Location = new System.Drawing.Point(29, 27);
            this.sessaoDataGridView.Name = "sessaoDataGridView";
            this.sessaoDataGridView.RowHeadersWidth = 51;
            this.sessaoDataGridView.RowTemplate.Height = 29;
            this.sessaoDataGridView.Size = new System.Drawing.Size(335, 294);
            this.sessaoDataGridView.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "Key";
            this.name.HeaderText = "Nome";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // value
            // 
            this.value.DataPropertyName = "Value";
            this.value.HeaderText = "Valor";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 125;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(129, 486);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfimar
            // 
            this.buttonConfimar.Location = new System.Drawing.Point(29, 486);
            this.buttonConfimar.Name = "buttonConfimar";
            this.buttonConfimar.Size = new System.Drawing.Size(94, 29);
            this.buttonConfimar.TabIndex = 9;
            this.buttonConfimar.Text = "Confirmar";
            this.buttonConfimar.UseVisualStyleBackColor = true;
            this.buttonConfimar.Click += new System.EventHandler(this.buttonConfimar_Click);
            // 
            // ComprarBCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NovoCliente.Properties.Resources.bilhete__1_;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfimar);
            this.Controls.Add(this.sessaoDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComprarBCliente";
            this.Text = "ComprarB";
            this.Load += new System.EventHandler(this.ComprarBCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessaoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sessaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfimar;
    }
}