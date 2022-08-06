using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core;
using Services;

namespace UIWF
{
    public partial class frmCliente : MetroFramework.Forms.MetroForm
    {
        EstadoEntidade estadoEntidade = EstadoEntidade.Novo;
        static String titleMessageBox = "Teste de Ramiro Cardos | COMPTI";
        static List<Cliente> listaCliente = new List<Cliente>();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            initForm();
        }

        #region inicializa os dados e limpa os componentes
        private void initForm()
        {
            loadFormaPagamento();
            loadCondicaoPagamento();
            loadGridViewCliente();
        }
        #endregion

        #region inicializa as controls do formulario
        private void initFormControls()
        {

            pContainer.Enabled = false;
            chxAnulado.Checked = false;
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            numValorCredito.Value = 0;
            numTaxaIVA.Value = 0;
            numDesconto.Value = 0;

        }
        #endregion

        #region popular o gridview
        private void loadGridViewCliente()
        {
            var clientes = ClienteService.GetAll();

            listaCliente.AddRange(clientes);
            clienteBindingSource.DataSource = listaCliente;
        }
        #endregion

        #region preencher combox FormaPagamento e CondicaoPagamento com Enum
        private void loadFormaPagamento()
        {
            cbxModoPagamento.DataSource = EnumToList.getListEnum<ModoPagamento>();
        }

        private void loadCondicaoPagamento()
        {
            cbxCondicaoPagamento.DataSource = EnumToList.getListEnum<CondicaoPagamento>();
        }

        #endregion

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                initFormControls();
                estadoEntidade = EstadoEntidade.Adicionado;
                clienteBindingSource.Add(new Cliente());
                clienteBindingSource.MoveLast();
                pContainer.Enabled = true;
                txtCodigo.Focus();
                cbxCondicaoPagamento.SelectedItem = null;
                cbxCondicaoPagamento.Text = null;

                cbxModoPagamento.SelectedItem = null;
                cbxModoPagamento.Text = null;
            }
            catch { }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estadoEntidade = EstadoEntidade.Editado;
            pContainer.Enabled = true;
            txtCodigo.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            estadoEntidade = EstadoEntidade.Eliminado;
            if (MetroFramework.MetroMessageBox.Show(this, "Tens a certeza que pretendes Eliminar clientes sem movimento ?", titleMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // foram eliminados os clientes sem movimento
                if (eliminarClientesSemMovimento())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Clientes Eliminados com sucesso", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Não tem cliente sem movimento
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Não tem clientes sem movimento", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            initForm();
            pContainer.Enabled = false;
        }

        #region verifica se os controls estao validados
        private bool isValidoCOntrols()
        {
            // Não permiti salvar cliente sem um codigo
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe o código do cliente", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtNome.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe o Nome do cliente", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }
            else if (cbxCondicaoPagamento.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe a Condição de pagamento", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCondicaoPagamento.Focus();
                return false;
            }
            else if (cbxModoPagamento.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe o Modo de pagamento", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxModoPagamento.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidoCOntrols())
                {
                    pContainer.Enabled = false;

                    var cliente = clienteBindingSource.Current as Cliente;
                    cliente.Facturacao = ClienteService.alterarEstadoFacturacao(numValorCredito.Value).ToString();

                    salvarClientes();

                    MetroFramework.MetroMessageBox.Show(this, "Cliente salvo com sucesso! ", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chxAnulado_CheckStateChanged(object sender, EventArgs e)
        {
            if (chxAnulado.CheckState == CheckState.Checked)
            {
                chxAnulado.Text = "Anulado";
            }
            else
            {
                chxAnulado.Text = "Activo";
            }
        }

        private Cliente pesquisarPeloCodigo(String codigo)
        {
            return listaCliente.Find(cliente => cliente.Codigo.Equals(codigo));
        }

        private void btnPesquisarPeloCodigo_Click(object sender, EventArgs e)
        {
            // Não permiti pesquisar cliente sem um codigo
            if (String.IsNullOrEmpty(txtCodigoPesquisa.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe o código do cliente", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoPesquisa.Focus();
                return;
            }
            else
            {
                var clienteResult = pesquisarPeloCodigo(txtCodigoPesquisa.Text);
                if (clienteResult == null)
                {

                    MetroFramework.MetroMessageBox.Show(this, "Nenhum resultado encontrado com esse código", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    clienteBindingSource.DataSource = clienteResult;
                }
            }
        }

        private void salvarClientes()
        {
            ClienteService.SaveAll(listaCliente);
        }

        private bool eliminarClientesSemMovimento()
        {
            var count = listaCliente.Where(cliente => cliente.ValorCredito == 0).Count();

            if (count > 0)
            {
                listaCliente.RemoveAll(cliente => cliente.ValorCredito == 0);
                clienteBindingSource.DataSource = listaCliente;
                salvarClientes();
                //loadGridViewCliente();
                return true;
            }
            else
            {
                return false;
            }

        }

        private void gridCliente_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

    }
}