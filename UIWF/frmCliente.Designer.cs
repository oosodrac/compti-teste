namespace UIWF
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCliente = new MetroFramework.Controls.MetroGrid();
            this.pContainer = new MetroFramework.Controls.MetroPanel();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.numTaxaIVA = new System.Windows.Forms.NumericUpDown();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.chxAnulado = new MetroFramework.Controls.MetroCheckBox();
            this.cbxModoPagamento = new MetroFramework.Controls.MetroComboBox();
            this.txtValorCredito = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbxCondicaoPagamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnRemover = new MetroFramework.Controls.MetroButton();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnPesquisarPeloCodigo = new MetroFramework.Controls.MetroButton();
            this.txtCodigoPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicaoPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modoPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anuladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxaIVA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCliente
            // 
            this.gridCliente.AllowUserToResizeRows = false;
            this.gridCliente.AutoGenerateColumns = false;
            this.gridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.condicaoPagamentoDataGridViewTextBoxColumn,
            this.modoPagamentoDataGridViewTextBoxColumn,
            this.valorCreditoDataGridViewTextBoxColumn,
            this.facturacaoDataGridViewTextBoxColumn,
            this.anuladoDataGridViewCheckBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn});
            this.gridCliente.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCliente.EnableHeadersVisualStyles = false;
            this.gridCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCliente.Location = new System.Drawing.Point(41, 135);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCliente.Size = new System.Drawing.Size(567, 464);
            this.gridCliente.TabIndex = 0;
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContainer.Controls.Add(this.numDesconto);
            this.pContainer.Controls.Add(this.numTaxaIVA);
            this.pContainer.Controls.Add(this.metroLabel9);
            this.pContainer.Controls.Add(this.chxAnulado);
            this.pContainer.Controls.Add(this.cbxModoPagamento);
            this.pContainer.Controls.Add(this.txtValorCredito);
            this.pContainer.Controls.Add(this.metroLabel7);
            this.pContainer.Controls.Add(this.metroLabel6);
            this.pContainer.Controls.Add(this.metroLabel5);
            this.pContainer.Controls.Add(this.cbxCondicaoPagamento);
            this.pContainer.Controls.Add(this.metroLabel4);
            this.pContainer.Controls.Add(this.metroLabel3);
            this.pContainer.Controls.Add(this.txtNome);
            this.pContainer.Controls.Add(this.metroLabel2);
            this.pContainer.Controls.Add(this.txtCodigo);
            this.pContainer.Controls.Add(this.metroLabel1);
            this.pContainer.Enabled = false;
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(619, 135);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(483, 464);
            this.pContainer.TabIndex = 1;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // numDesconto
            // 
            this.numDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "Desconto", true));
            this.numDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDesconto.Location = new System.Drawing.Point(210, 160);
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(120, 26);
            this.numDesconto.TabIndex = 19;
            // 
            // numTaxaIVA
            // 
            this.numTaxaIVA.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "Iva", true));
            this.numTaxaIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTaxaIVA.Location = new System.Drawing.Point(34, 160);
            this.numTaxaIVA.Name = "numTaxaIVA";
            this.numTaxaIVA.Size = new System.Drawing.Size(120, 26);
            this.numTaxaIVA.TabIndex = 18;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(34, 387);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Situação";
            // 
            // chxAnulado
            // 
            this.chxAnulado.AutoSize = true;
            this.chxAnulado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.clienteBindingSource, "Anulado", true));
            this.chxAnulado.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clienteBindingSource, "Anulado", true));
            this.chxAnulado.Location = new System.Drawing.Point(38, 413);
            this.chxAnulado.Name = "chxAnulado";
            this.chxAnulado.Size = new System.Drawing.Size(57, 15);
            this.chxAnulado.TabIndex = 16;
            this.chxAnulado.Text = "Activo";
            this.chxAnulado.UseSelectable = true;
            this.chxAnulado.CheckStateChanged += new System.EventHandler(this.chxAnulado_CheckStateChanged);
            // 
            // cbxModoPagamento
            // 
            this.cbxModoPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ModoPagamento", true));
            this.cbxModoPagamento.FormattingEnabled = true;
            this.cbxModoPagamento.ItemHeight = 23;
            this.cbxModoPagamento.Items.AddRange(new object[] {
            ""});
            this.cbxModoPagamento.Location = new System.Drawing.Point(34, 289);
            this.cbxModoPagamento.Name = "cbxModoPagamento";
            this.cbxModoPagamento.Size = new System.Drawing.Size(339, 29);
            this.cbxModoPagamento.TabIndex = 14;
            this.cbxModoPagamento.UseSelectable = true;
            // 
            // txtValorCredito
            // 
            // 
            // 
            // 
            this.txtValorCredito.CustomButton.Image = null;
            this.txtValorCredito.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtValorCredito.CustomButton.Name = "";
            this.txtValorCredito.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorCredito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorCredito.CustomButton.TabIndex = 1;
            this.txtValorCredito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorCredito.CustomButton.UseSelectable = true;
            this.txtValorCredito.CustomButton.Visible = false;
            this.txtValorCredito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ValorCredito", true));
            this.txtValorCredito.Lines = new string[0];
            this.txtValorCredito.Location = new System.Drawing.Point(34, 348);
            this.txtValorCredito.MaxLength = 32767;
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.PasswordChar = '\0';
            this.txtValorCredito.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorCredito.SelectedText = "";
            this.txtValorCredito.SelectionLength = 0;
            this.txtValorCredito.SelectionStart = 0;
            this.txtValorCredito.ShortcutsEnabled = true;
            this.txtValorCredito.Size = new System.Drawing.Size(163, 23);
            this.txtValorCredito.TabIndex = 13;
            this.txtValorCredito.UseSelectable = true;
            this.txtValorCredito.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorCredito.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(29, 326);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Valor de crédito";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(29, 267);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(151, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Modo de pagamento";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(29, 202);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(174, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Condição de pagamento";
            // 
            // cbxCondicaoPagamento
            // 
            this.cbxCondicaoPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CondicaoPagamento", true));
            this.cbxCondicaoPagamento.FormattingEnabled = true;
            this.cbxCondicaoPagamento.ItemHeight = 23;
            this.cbxCondicaoPagamento.Items.AddRange(new object[] {
            ""});
            this.cbxCondicaoPagamento.Location = new System.Drawing.Point(34, 224);
            this.cbxCondicaoPagamento.Name = "cbxCondicaoPagamento";
            this.cbxCondicaoPagamento.Size = new System.Drawing.Size(339, 29);
            this.cbxCondicaoPagamento.TabIndex = 9;
            this.cbxCondicaoPagamento.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(210, 138);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Desconto (%)";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(34, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Taxa IVA (%)";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(34, 103);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(339, 23);
            this.txtNome.TabIndex = 5;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(29, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nome";
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Codigo", true));
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(34, 47);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(154, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(29, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Código";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(619, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(376, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(107, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 34);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(288, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(200, 8);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(82, 34);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Eliminar";
            this.btnRemover.UseSelectable = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(19, 8);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 34);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(619, 62);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Código";
            // 
            // btnPesquisarPeloCodigo
            // 
            this.btnPesquisarPeloCodigo.Location = new System.Drawing.Point(848, 59);
            this.btnPesquisarPeloCodigo.Name = "btnPesquisarPeloCodigo";
            this.btnPesquisarPeloCodigo.Size = new System.Drawing.Size(254, 34);
            this.btnPesquisarPeloCodigo.TabIndex = 5;
            this.btnPesquisarPeloCodigo.Text = "Pesquisar";
            this.btnPesquisarPeloCodigo.UseSelectable = true;
            this.btnPesquisarPeloCodigo.Click += new System.EventHandler(this.btnPesquisarPeloCodigo_Click);
            // 
            // txtCodigoPesquisa
            // 
            // 
            // 
            // 
            this.txtCodigoPesquisa.CustomButton.Image = null;
            this.txtCodigoPesquisa.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtCodigoPesquisa.CustomButton.Name = "";
            this.txtCodigoPesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigoPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoPesquisa.CustomButton.TabIndex = 1;
            this.txtCodigoPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoPesquisa.CustomButton.UseSelectable = true;
            this.txtCodigoPesquisa.CustomButton.Visible = false;
            this.txtCodigoPesquisa.Lines = new string[0];
            this.txtCodigoPesquisa.Location = new System.Drawing.Point(691, 63);
            this.txtCodigoPesquisa.MaxLength = 32767;
            this.txtCodigoPesquisa.Name = "txtCodigoPesquisa";
            this.txtCodigoPesquisa.PasswordChar = '\0';
            this.txtCodigoPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoPesquisa.SelectedText = "";
            this.txtCodigoPesquisa.SelectionLength = 0;
            this.txtCodigoPesquisa.SelectionStart = 0;
            this.txtCodigoPesquisa.ShortcutsEnabled = true;
            this.txtCodigoPesquisa.Size = new System.Drawing.Size(151, 23);
            this.txtCodigoPesquisa.TabIndex = 6;
            this.txtCodigoPesquisa.UseSelectable = true;
            this.txtCodigoPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(UIWF.Cliente);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "Iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            // 
            // condicaoPagamentoDataGridViewTextBoxColumn
            // 
            this.condicaoPagamentoDataGridViewTextBoxColumn.DataPropertyName = "CondicaoPagamento";
            this.condicaoPagamentoDataGridViewTextBoxColumn.HeaderText = "CondicaoPagamento";
            this.condicaoPagamentoDataGridViewTextBoxColumn.Name = "condicaoPagamentoDataGridViewTextBoxColumn";
            // 
            // modoPagamentoDataGridViewTextBoxColumn
            // 
            this.modoPagamentoDataGridViewTextBoxColumn.DataPropertyName = "ModoPagamento";
            this.modoPagamentoDataGridViewTextBoxColumn.HeaderText = "ModoPagamento";
            this.modoPagamentoDataGridViewTextBoxColumn.Name = "modoPagamentoDataGridViewTextBoxColumn";
            // 
            // valorCreditoDataGridViewTextBoxColumn
            // 
            this.valorCreditoDataGridViewTextBoxColumn.DataPropertyName = "ValorCredito";
            this.valorCreditoDataGridViewTextBoxColumn.HeaderText = "ValorCredito";
            this.valorCreditoDataGridViewTextBoxColumn.Name = "valorCreditoDataGridViewTextBoxColumn";
            // 
            // facturacaoDataGridViewTextBoxColumn
            // 
            this.facturacaoDataGridViewTextBoxColumn.DataPropertyName = "Facturacao";
            this.facturacaoDataGridViewTextBoxColumn.HeaderText = "Facturacao";
            this.facturacaoDataGridViewTextBoxColumn.Name = "facturacaoDataGridViewTextBoxColumn";
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            this.anuladoDataGridViewCheckBoxColumn.DataPropertyName = "Anulado";
            this.anuladoDataGridViewCheckBoxColumn.HeaderText = "Anulado";
            this.anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 753);
            this.Controls.Add(this.txtCodigoPesquisa);
            this.Controls.Add(this.btnPesquisarPeloCodigo);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.gridCliente);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxaIVA)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridCliente;
        private MetroFramework.Controls.MetroPanel pContainer;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnRemover;
        private MetroFramework.Controls.MetroButton btnNovo;
        private MetroFramework.Controls.MetroComboBox cbxModoPagamento;
        private MetroFramework.Controls.MetroTextBox txtValorCredito;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbxCondicaoPagamento;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroCheckBox chxAnulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicaoPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modoPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.NumericUpDown numTaxaIVA;
        private MetroFramework.Controls.MetroButton btnPesquisarPeloCodigo;
        private MetroFramework.Controls.MetroTextBox txtCodigoPesquisa;
    }
}