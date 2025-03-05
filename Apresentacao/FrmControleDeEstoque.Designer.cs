namespace ControleEstoqueApp
{
    partial class FrmControleDeEstoque
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
            txtPreco = new TextBox();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dtgEstoque = new DataGridView();
            lblEstoque = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(103, 366);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(260, 23);
            txtPreco.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(103, 113);
            txtId.Name = "txtId";
            txtId.Size = new Size(260, 23);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(103, 198);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(103, 279);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(260, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Ink Free", 9F);
            lblId.Location = new Point(103, 95);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Ink Free", 9F);
            lblNome.Location = new Point(103, 180);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(35, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Ink Free", 9F);
            lblQuantidade.Location = new Point(103, 261);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(66, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Ink Free", 9F);
            lblPreco.Location = new Point(103, 348);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(34, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preço";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Gray;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.Lime;
            btnSalvar.Location = new Point(126, 436);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 43);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.Window;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.Red;
            btnExcluir.Location = new Point(233, 436);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 43);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtgEstoque
            // 
            dtgEstoque.AllowUserToAddRows = false;
            dtgEstoque.AllowUserToDeleteRows = false;
            dtgEstoque.AllowUserToOrderColumns = true;
            dtgEstoque.AllowUserToResizeColumns = false;
            dtgEstoque.AllowUserToResizeRows = false;
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Location = new Point(499, 12);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.ReadOnly = true;
            dtgEstoque.Size = new Size(482, 503);
            dtgEstoque.TabIndex = 10;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("BankGothic Lt BT", 26.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(159, 32);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(171, 36);
            lblEstoque.TabIndex = 11;
            lblEstoque.Text = "Estoque";
            // 
            // FrmControleDeEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(993, 527);
            Controls.Add(lblEstoque);
            Controls.Add(dtgEstoque);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(txtPreco);
            Name = "FrmControleDeEstoque";
            Text = "Controle de Estoque";
            Load += FrmControleDeEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPreco;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private Label lblId;
        private Label lblNome;
        private Label lblQuantidade;
        private Label lblPreco;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dtgEstoque;
        private Label lblEstoque;
    }
}
