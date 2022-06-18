namespace NovoCliente
{
    partial class SessoesDisponiveis
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
            this.sessoesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdSessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espetaculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sessao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acoes = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sessoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sessoesDataGridView
            // 
            this.sessoesDataGridView.AllowUserToAddRows = false;
            this.sessoesDataGridView.AllowUserToDeleteRows = false;
            this.sessoesDataGridView.AllowUserToResizeRows = false;
            this.sessoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSessao,
            this.teatro,
            this.espetaculo,
            this.Sessao,
            this.DataHora,
            this.Acoes});
            this.sessoesDataGridView.Location = new System.Drawing.Point(12, 147);
            this.sessoesDataGridView.Name = "sessoesDataGridView";
            this.sessoesDataGridView.RowHeadersWidth = 51;
            this.sessoesDataGridView.RowTemplate.Height = 29;
            this.sessoesDataGridView.Size = new System.Drawing.Size(803, 188);
            this.sessoesDataGridView.TabIndex = 0;
            // 
            // IdSessao
            // 
            this.IdSessao.DataPropertyName = "Id";
            this.IdSessao.HeaderText = "ID";
            this.IdSessao.MinimumWidth = 6;
            this.IdSessao.Name = "IdSessao";
            this.IdSessao.ReadOnly = true;
            this.IdSessao.Visible = false;
            this.IdSessao.Width = 125;
            // 
            // teatro
            // 
            this.teatro.DataPropertyName = "NomeTeatro";
            this.teatro.HeaderText = "Teatro";
            this.teatro.MinimumWidth = 6;
            this.teatro.Name = "teatro";
            this.teatro.ReadOnly = true;
            this.teatro.Width = 125;
            // 
            // espetaculo
            // 
            this.espetaculo.DataPropertyName = "NomeEspetaculo";
            this.espetaculo.HeaderText = "Espetáculo";
            this.espetaculo.MinimumWidth = 6;
            this.espetaculo.Name = "espetaculo";
            this.espetaculo.ReadOnly = true;
            this.espetaculo.Width = 125;
            // 
            // Sessao
            // 
            this.Sessao.DataPropertyName = "NomeSessao";
            this.Sessao.HeaderText = "Sessão";
            this.Sessao.MinimumWidth = 6;
            this.Sessao.Name = "Sessao";
            this.Sessao.ReadOnly = true;
            // 
            // DataHora
            // 
            this.DataHora.DataPropertyName = "DataHora";
            this.DataHora.HeaderText = "Data/Hora";
            this.DataHora.MinimumWidth = 6;
            this.DataHora.Name = "DataHora";
            this.DataHora.ReadOnly = true;
            this.DataHora.Width = 200;
            // 
            // Acoes
            // 
            this.Acoes.HeaderText = "Ações";
            this.Acoes.MinimumWidth = 6;
            this.Acoes.Name = "Acoes";
            this.Acoes.ReadOnly = true;
            this.Acoes.Text = "Reservar";
            this.Acoes.UseColumnTextForButtonValue = true;
            this.Acoes.Width = 150;
            // 
            // SessoesDisponiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.sessoesDataGridView);
            this.Name = "SessoesDisponiveis";
            this.Text = "SessoesDisponiveis";
            this.Load += new System.EventHandler(this.SessoesDisponiveis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessoesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sessoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn teatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn espetaculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewButtonColumn Acoes;
    }
}