namespace PSalario
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.mskBxSalario = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBxNome = new System.Windows.Forms.TextBox();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbBxFilho = new System.Windows.Forms.ComboBox();
            this.grpBxSexo = new System.Windows.Forms.GroupBox();
            this.rdioBtnF = new System.Windows.Forms.RadioButton();
            this.rdioBtnM = new System.Windows.Forms.RadioButton();
            this.chkBxCasado = new System.Windows.Forms.CheckBox();
            this.lblNSS = new System.Windows.Forms.Label();
            this.lblIRRF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRRF = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskBxAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskBxAliqIRRF = new System.Windows.Forms.MaskedTextBox();
            this.mskBxSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskBxSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskBxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskBxDescIRRF = new System.Windows.Forms.MaskedTextBox();
            this.grpBxSexo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(44, 99);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(68, 24);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salario";
            // 
            // mskBxSalario
            // 
            this.mskBxSalario.Location = new System.Drawing.Point(162, 96);
            this.mskBxSalario.Mask = "99000.00";
            this.mskBxSalario.Name = "mskBxSalario";
            this.mskBxSalario.Size = new System.Drawing.Size(202, 30);
            this.mskBxSalario.TabIndex = 1;
            this.mskBxSalario.Validated += new System.EventHandler(this.mskBoxSalario_Validated);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 53);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtBxNome
            // 
            this.txtBxNome.Location = new System.Drawing.Point(162, 47);
            this.txtBxNome.Name = "txtBxNome";
            this.txtBxNome.Size = new System.Drawing.Size(202, 30);
            this.txtBxNome.TabIndex = 3;
            this.txtBxNome.Validated += new System.EventHandler(this.txtBxNome_Validated);
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(44, 144);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(97, 24);
            this.lblFilhos.TabIndex = 4;
            this.lblFilhos.Text = "Qtd Filhos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(146, 209);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(237, 73);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbBxFilho
            // 
            this.cmbBxFilho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxFilho.FormattingEnabled = true;
            this.cmbBxFilho.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbBxFilho.Location = new System.Drawing.Point(162, 144);
            this.cmbBxFilho.Name = "cmbBxFilho";
            this.cmbBxFilho.Size = new System.Drawing.Size(202, 32);
            this.cmbBxFilho.TabIndex = 7;
            // 
            // grpBxSexo
            // 
            this.grpBxSexo.Controls.Add(this.rdioBtnF);
            this.grpBxSexo.Controls.Add(this.rdioBtnM);
            this.grpBxSexo.Location = new System.Drawing.Point(516, 47);
            this.grpBxSexo.Name = "grpBxSexo";
            this.grpBxSexo.Size = new System.Drawing.Size(242, 145);
            this.grpBxSexo.TabIndex = 8;
            this.grpBxSexo.TabStop = false;
            this.grpBxSexo.Text = "Sexo";
            // 
            // rdioBtnF
            // 
            this.rdioBtnF.AutoSize = true;
            this.rdioBtnF.Location = new System.Drawing.Point(34, 93);
            this.rdioBtnF.Name = "rdioBtnF";
            this.rdioBtnF.Size = new System.Drawing.Size(104, 28);
            this.rdioBtnF.TabIndex = 10;
            this.rdioBtnF.Text = "Feminino";
            this.rdioBtnF.UseVisualStyleBackColor = true;
            // 
            // rdioBtnM
            // 
            this.rdioBtnM.AutoSize = true;
            this.rdioBtnM.Checked = true;
            this.rdioBtnM.Location = new System.Drawing.Point(34, 48);
            this.rdioBtnM.Name = "rdioBtnM";
            this.rdioBtnM.Size = new System.Drawing.Size(110, 28);
            this.rdioBtnM.TabIndex = 9;
            this.rdioBtnM.TabStop = true;
            this.rdioBtnM.Text = "Masculino";
            this.rdioBtnM.UseVisualStyleBackColor = true;
            // 
            // chkBxCasado
            // 
            this.chkBxCasado.AutoSize = true;
            this.chkBxCasado.Location = new System.Drawing.Point(34, 33);
            this.chkBxCasado.Name = "chkBxCasado";
            this.chkBxCasado.Size = new System.Drawing.Size(89, 28);
            this.chkBxCasado.TabIndex = 9;
            this.chkBxCasado.Text = "Casado";
            this.chkBxCasado.UseVisualStyleBackColor = true;
            // 
            // lblNSS
            // 
            this.lblNSS.AutoSize = true;
            this.lblNSS.Location = new System.Drawing.Point(54, 376);
            this.lblNSS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNSS.Name = "lblNSS";
            this.lblNSS.Size = new System.Drawing.Size(124, 24);
            this.lblNSS.TabIndex = 10;
            this.lblNSS.Text = "Alíquota INSS";
            // 
            // lblIRRF
            // 
            this.lblIRRF.AutoSize = true;
            this.lblIRRF.Location = new System.Drawing.Point(54, 436);
            this.lblIRRF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIRRF.Name = "lblIRRF";
            this.lblIRRF.Size = new System.Drawing.Size(124, 24);
            this.lblIRRF.TabIndex = 11;
            this.lblIRRF.Text = "Alíquota IRRF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(54, 494);
            this.lblSalFamilia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(136, 24);
            this.lblSalFamilia.TabIndex = 12;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(54, 551);
            this.lblSalLiq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(136, 24);
            this.lblSalLiq.TabIndex = 13;
            this.lblSalLiq.Text = "Salário Líquido";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(433, 387);
            this.lblDescINSS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(130, 24);
            this.lblDescINSS.TabIndex = 14;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRRF
            // 
            this.lblDescIRRF.AutoSize = true;
            this.lblDescIRRF.Location = new System.Drawing.Point(433, 497);
            this.lblDescIRRF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescIRRF.Name = "lblDescIRRF";
            this.lblDescIRRF.Size = new System.Drawing.Size(130, 24);
            this.lblDescIRRF.TabIndex = 15;
            this.lblDescIRRF.Text = "Desconto IRRF";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(44, 326);
            this.lblDados.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(139, 22);
            this.lblDados.TabIndex = 16;
            this.lblDados.Text = "Aguardando Dados";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(693, 521);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 84);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(693, 406);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 84);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskBxAliqINSS
            // 
            this.mskBxAliqINSS.Enabled = false;
            this.mskBxAliqINSS.Location = new System.Drawing.Point(206, 373);
            this.mskBxAliqINSS.Name = "mskBxAliqINSS";
            this.mskBxAliqINSS.Size = new System.Drawing.Size(188, 30);
            this.mskBxAliqINSS.TabIndex = 25;
            // 
            // mskBxAliqIRRF
            // 
            this.mskBxAliqIRRF.Enabled = false;
            this.mskBxAliqIRRF.Location = new System.Drawing.Point(206, 430);
            this.mskBxAliqIRRF.Name = "mskBxAliqIRRF";
            this.mskBxAliqIRRF.Size = new System.Drawing.Size(188, 30);
            this.mskBxAliqIRRF.TabIndex = 26;
            // 
            // mskBxSalFamilia
            // 
            this.mskBxSalFamilia.Enabled = false;
            this.mskBxSalFamilia.Location = new System.Drawing.Point(206, 488);
            this.mskBxSalFamilia.Name = "mskBxSalFamilia";
            this.mskBxSalFamilia.Size = new System.Drawing.Size(188, 30);
            this.mskBxSalFamilia.TabIndex = 27;
            // 
            // mskBxSalLiq
            // 
            this.mskBxSalLiq.Enabled = false;
            this.mskBxSalLiq.Location = new System.Drawing.Point(206, 548);
            this.mskBxSalLiq.Name = "mskBxSalLiq";
            this.mskBxSalLiq.Size = new System.Drawing.Size(188, 30);
            this.mskBxSalLiq.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBxCasado);
            this.panel1.Location = new System.Drawing.Point(558, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 29;
            // 
            // mskBxDescINSS
            // 
            this.mskBxDescINSS.Enabled = false;
            this.mskBxDescINSS.Location = new System.Drawing.Point(466, 430);
            this.mskBxDescINSS.Name = "mskBxDescINSS";
            this.mskBxDescINSS.Size = new System.Drawing.Size(188, 30);
            this.mskBxDescINSS.TabIndex = 30;
            // 
            // mskBxDescIRRF
            // 
            this.mskBxDescIRRF.Enabled = false;
            this.mskBxDescIRRF.Location = new System.Drawing.Point(466, 536);
            this.mskBxDescIRRF.Name = "mskBxDescIRRF";
            this.mskBxDescIRRF.Size = new System.Drawing.Size(188, 30);
            this.mskBxDescIRRF.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(817, 629);
            this.Controls.Add(this.mskBxDescIRRF);
            this.Controls.Add(this.mskBxDescINSS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mskBxSalLiq);
            this.Controls.Add(this.mskBxSalFamilia);
            this.Controls.Add(this.mskBxAliqIRRF);
            this.Controls.Add(this.mskBxAliqINSS);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblDescIRRF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblIRRF);
            this.Controls.Add(this.lblNSS);
            this.Controls.Add(this.grpBxSexo);
            this.Controls.Add(this.cmbBxFilho);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.txtBxNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mskBxSalario);
            this.Controls.Add(this.lblSalario);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "PSalario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxSexo.ResumeLayout(false);
            this.grpBxSexo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.MaskedTextBox mskBxSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBxNome;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbBxFilho;
        private System.Windows.Forms.GroupBox grpBxSexo;
        private System.Windows.Forms.RadioButton rdioBtnF;
        private System.Windows.Forms.RadioButton rdioBtnM;
        private System.Windows.Forms.CheckBox chkBxCasado;
        private System.Windows.Forms.Label lblNSS;
        private System.Windows.Forms.Label lblIRRF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRRF;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskBxAliqINSS;
        private System.Windows.Forms.MaskedTextBox mskBxAliqIRRF;
        private System.Windows.Forms.MaskedTextBox mskBxSalFamilia;
        private System.Windows.Forms.MaskedTextBox mskBxSalLiq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mskBxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskBxDescIRRF;
    }
}

