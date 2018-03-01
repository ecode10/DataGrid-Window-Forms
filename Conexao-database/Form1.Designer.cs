namespace Conexao_database
{
    partial class Form1
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
            this.dtProduto = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProduto
            // 
            this.dtProduto.AllowUserToAddRows = false;
            this.dtProduto.AllowUserToDeleteRows = false;
            this.dtProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Valores});
            this.dtProduto.Location = new System.Drawing.Point(12, 142);
            this.dtProduto.Name = "dtProduto";
            this.dtProduto.ReadOnly = true;
            this.dtProduto.RowTemplate.Height = 33;
            this.dtProduto.Size = new System.Drawing.Size(1039, 393);
            this.dtProduto.TabIndex = 0;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 350;
            // 
            // Valores
            // 
            this.Valores.DataPropertyName = "Valores";
            this.Valores.HeaderText = "Valores";
            this.Valores.Name = "Valores";
            this.Valores.ReadOnly = true;
            this.Valores.Width = 250;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(12, 542);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(193, 25);
            this.lblTotalRegistros.TabIndex = 1;
            this.lblTotalRegistros.Text = "Total de Registros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 656);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.dtProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valores;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label label2;
    }
}

