using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWF
{
    public partial class frmCliente : MetroFramework.Forms.MetroForm
    {
        EstadoEntidade estadoEntidade = EstadoEntidade.Novo;
        static String titleMessageBox = "Teste de Ramiro Cardos | COMPT";
        static List<Cliente> listaCliente = new List<Cliente>();
        static String file = @"C:\Users\miros\Documents\visual studio 2013\Projects\TesteCompti\UIWF\bin\Debug\clientes.xlsx";

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
        private void initFormControls() {
            chxAnulado.Checked = false;
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtValorCredito.Text = "0";

            cbxCondicaoPagamento.SelectedItem = null;
            cbxCondicaoPagamento.Text = null;

            cbxModoPagamento.SelectedItem = null;
            cbxModoPagamento.Text = null;

            numTaxaIVA.Value = 0;
            numDesconto.Value = 0;
        }
        #endregion

        #region popular o gridview
        private void loadGridViewCliente() {
            var clientes = new Ganss.Excel.ExcelMapper(file).Fetch<Cliente>().ToList();

            listaCliente.AddRange(clientes);
            clienteBindingSource.DataSource = listaCliente;
        }
        #endregion

        #region preencher combox FormaPagamento e CondicaoPagamento com Enum
        private void loadFormaPagamento()
        {
            cbxModoPagamento.DataSource = EnumToList<ModoPagamento>();
        }

        private void loadCondicaoPagamento()
        {
            cbxCondicaoPagamento.DataSource = EnumToList<CondicaoPagamento>();
        }

        #endregion

        #region metodo para criar uma lista aprtir de enum
        public IList<T> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é um Enum");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }

            return list;
        }
        #endregion

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // TODO: soroudn with Try Catch
            initFormControls();
            estadoEntidade = EstadoEntidade.Adicionado;
            clienteBindingSource.Add(new Cliente());
            clienteBindingSource.MoveLast();
            pContainer.Enabled = true;
            txtCodigo.Focus();

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
            if (MetroFramework.MetroMessageBox.Show(this, "Tem a certeza que quer eliminar o cliente", titleMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cliente = clienteBindingSource.Current as Cliente;
                if (cliente != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Cliente Eliminado com sucesso", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clienteBindingSource.RemoveCurrent();
                    pContainer.Enabled = false;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Cliente não existe!", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            initForm();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // TODO: soroudn with Try Catch

            // Não permiti salvar cliente sem um codigo
            if ( String.IsNullOrEmpty(txtCodigo.Text) )
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe o código do cliente", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtNome.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe o Nome do cliente", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if (cbxCondicaoPagamento.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe a Condição de pagamento", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCondicaoPagamento.Focus();
            }
            else if (cbxModoPagamento.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Informe o Modo de pagamento", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxModoPagamento.Focus();
            }
            else
            {
                pContainer.Enabled = false;
                new Ganss.Excel.ExcelMapper().Save(file, listaCliente, "clientes");
                MetroFramework.MetroMessageBox.Show(this, "Cliente salvo com sucesso! ", titleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void chxAnulado_CheckStateChanged(object sender, EventArgs e)
        {
            if (chxAnulado.CheckState == CheckState.Checked)
            {
                chxAnulado.Text = "Ativo";
            }
            else
            {
                chxAnulado.Text = "Anulado";
            }
        }

        private Cliente pesquisarPeloCodigo( String codigo )
        {
            return listaCliente.Find( cliente => cliente.Codigo.Equals( codigo ) );
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

    }
}
