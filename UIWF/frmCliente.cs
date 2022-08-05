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
            chxAnulado.Checked = true;
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtValorCredito.Text = "0";
            cbxCondicaoPagamento.SelectedItem = null;
            cbxModoPagamento.SelectedItem = null;
            numTaxaIVA.Value = 0;
            numDesconto.Value = 0;
            pContainer.Enabled = false;
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

        }

    }
}
