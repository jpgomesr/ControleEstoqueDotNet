using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Database;
using ControleEstoqueApp.Services;
using System;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class FrmControleDeEstoque : Form
    {
        private readonly ProdutoService _produtoService;

        public FrmControleDeEstoque()
        {
            InitializeComponent();
            _produtoService = new ProdutoService(new AppDbContext());
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = CriarProduto();

            if (txtId.Text == "")
            {
                _produtoService.Salvar(produto);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else
            {
                _produtoService.Editar(produto);
                MessageBox.Show("Produto editado com sucesso!");
            }

            CarregarProdutos();
            LimparCampos();
        }

        private void FrmControleDeEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            var produtos = _produtoService.ListarTodos();
            dtgEstoque.DataSource = produtos;
        }

        private void dtgEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEstoque.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgEstoque.SelectedRows[0];
                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtNome.Text = selectedRow.Cells["Nome"].Value.ToString();
                txtQuantidade.Text = selectedRow.Cells["Quantidade"].Value.ToString();
                txtPreco.Text = selectedRow.Cells["Preco"].Value.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                try
                {
                    _produtoService.Remover(int.Parse(txtId.Text));
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarProdutos();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
        }

        private Produto CriarProduto()
        {
            return new Produto
            {
                Id = string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                Preco = decimal.Parse(txtPreco.Text),
            };
        }
    }
}