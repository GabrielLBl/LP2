namespace pFerramentas
{
    partial class frmFerramenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFerramenta));
            this.bnvFerramenta = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbFerramenta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFerramenta = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdFerramenta = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDistribuicao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDtCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtSiteOficial = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxDistribuicao = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnvFerramenta)).BeginInit();
            this.bnvFerramenta.SuspendLayout();
            this.tbFerramenta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnvFerramenta
            // 
            this.bnvFerramenta.AddNewItem = null;
            this.bnvFerramenta.CountItem = this.bindingNavigatorCountItem;
            this.bnvFerramenta.DeleteItem = null;
            this.bnvFerramenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvFerramenta.Location = new System.Drawing.Point(0, 0);
            this.bnvFerramenta.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvFerramenta.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvFerramenta.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvFerramenta.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvFerramenta.Name = "bnvFerramenta";
            this.bnvFerramenta.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnvFerramenta.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvFerramenta.Size = new System.Drawing.Size(1276, 25);
            this.bnvFerramenta.TabIndex = 0;
            this.bnvFerramenta.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbFerramenta
            // 
            this.tbFerramenta.Controls.Add(this.tabPage1);
            this.tbFerramenta.Controls.Add(this.tabPage2);
            this.tbFerramenta.Location = new System.Drawing.Point(35, 66);
            this.tbFerramenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFerramenta.Name = "tbFerramenta";
            this.tbFerramenta.SelectedIndex = 0;
            this.tbFerramenta.Size = new System.Drawing.Size(1210, 614);
            this.tbFerramenta.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFerramenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1202, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.cbxCategoria);
            this.tabPage2.Controls.Add(this.lblCategoria);
            this.tabPage2.Controls.Add(this.lblSite);
            this.tabPage2.Controls.Add(this.txtSiteOficial);
            this.tabPage2.Controls.Add(this.dtpDtCadastro);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblDistribuicao);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbxDistribuicao);
            this.tabPage2.Controls.Add(this.txtFornecedor);
            this.tabPage2.Controls.Add(this.lblFornecedor);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Controls.Add(this.txtIdFerramenta);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1202, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFerramenta
            // 
            this.dgvFerramenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramenta.Location = new System.Drawing.Point(7, 4);
            this.dgvFerramenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFerramenta.Name = "dgvFerramenta";
            this.dgvFerramenta.ReadOnly = true;
            this.dgvFerramenta.Size = new System.Drawing.Size(1187, 569);
            this.dgvFerramenta.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(166, 94);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(298, 148);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 29);
            this.txtNome.TabIndex = 1;
            // 
            // txtIdFerramenta
            // 
            this.txtIdFerramenta.Enabled = false;
            this.txtIdFerramenta.Location = new System.Drawing.Point(298, 91);
            this.txtIdFerramenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdFerramenta.Name = "txtIdFerramenta";
            this.txtIdFerramenta.Size = new System.Drawing.Size(116, 29);
            this.txtIdFerramenta.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(166, 148);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 21);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(166, 209);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(89, 21);
            this.lblFornecedor.TabIndex = 4;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(298, 206);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFornecedor.MaxLength = 20;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(116, 29);
            this.txtFornecedor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "1-Grátis 2-Paga 3-Parceria 4-Outros";
            // 
            // lblDistribuicao
            // 
            this.lblDistribuicao.AutoSize = true;
            this.lblDistribuicao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistribuicao.Location = new System.Drawing.Point(166, 274);
            this.lblDistribuicao.Name = "lblDistribuicao";
            this.lblDistribuicao.Size = new System.Drawing.Size(93, 21);
            this.lblDistribuicao.TabIndex = 8;
            this.lblDistribuicao.Text = "Distribuição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data de cadastro";
            // 
            // dtpDtCadastro
            // 
            this.dtpDtCadastro.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDtCadastro.Enabled = false;
            this.dtpDtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDtCadastro.Location = new System.Drawing.Point(298, 332);
            this.dtpDtCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDtCadastro.Name = "dtpDtCadastro";
            this.dtpDtCadastro.Size = new System.Drawing.Size(259, 29);
            this.dtpDtCadastro.TabIndex = 10;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(166, 391);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(84, 21);
            this.lblSite.TabIndex = 12;
            this.lblSite.Text = "Site Oficial";
            // 
            // txtSiteOficial
            // 
            this.txtSiteOficial.Enabled = false;
            this.txtSiteOficial.Location = new System.Drawing.Point(298, 383);
            this.txtSiteOficial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSiteOficial.MaxLength = 100;
            this.txtSiteOficial.Name = "txtSiteOficial";
            this.txtSiteOficial.Size = new System.Drawing.Size(116, 29);
            this.txtSiteOficial.TabIndex = 11;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(166, 444);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 21);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(298, 441);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(141, 29);
            this.cbxCategoria.TabIndex = 14;
            // 
            // cbxDistribuicao
            // 
            this.cbxDistribuicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDistribuicao.Enabled = false;
            this.cbxDistribuicao.FormattingEnabled = true;
            this.cbxDistribuicao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxDistribuicao.Location = new System.Drawing.Point(298, 271);
            this.cbxDistribuicao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxDistribuicao.Name = "cbxDistribuicao";
            this.cbxDistribuicao.Size = new System.Drawing.Size(141, 29);
            this.cbxDistribuicao.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(619, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 428);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmFerramenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 750);
            this.Controls.Add(this.tbFerramenta);
            this.Controls.Add(this.bnvFerramenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFerramenta";
            this.Text = "frmFerramenta";
            this.Load += new System.EventHandler(this.frmFerramenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvFerramenta)).EndInit();
            this.bnvFerramenta.ResumeLayout(false);
            this.bnvFerramenta.PerformLayout();
            this.tbFerramenta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvFerramenta;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.TabControl tbFerramenta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFerramenta;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIdFerramenta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSiteOficial;
        private System.Windows.Forms.DateTimePicker dtpDtCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDistribuicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDistribuicao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}