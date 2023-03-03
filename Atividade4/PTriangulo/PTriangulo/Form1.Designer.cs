namespace PTriangulo
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
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.lblValorC = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskBxValorA = new System.Windows.Forms.MaskedTextBox();
            this.mskBxValorB = new System.Windows.Forms.MaskedTextBox();
            this.mskBxValorC = new System.Windows.Forms.MaskedTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(78, 48);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(84, 22);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A:";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(78, 110);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(82, 22);
            this.lblValorB.TabIndex = 1;
            this.lblValorB.Text = "Valor B:";
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.Location = new System.Drawing.Point(78, 171);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(84, 22);
            this.lblValorC.TabIndex = 2;
            this.lblValorC.Text = "Valor C:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(219, 238);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(318, 67);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(577, 238);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 67);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskBxValorA
            // 
            this.mskBxValorA.Location = new System.Drawing.Point(179, 45);
            this.mskBxValorA.Mask = "999.00";
            this.mskBxValorA.Name = "mskBxValorA";
            this.mskBxValorA.Size = new System.Drawing.Size(276, 30);
            this.mskBxValorA.TabIndex = 8;
            this.mskBxValorA.Validated += new System.EventHandler(this.mskBxValorA_Validated);
            // 
            // mskBxValorB
            // 
            this.mskBxValorB.Location = new System.Drawing.Point(179, 107);
            this.mskBxValorB.Mask = "999.00";
            this.mskBxValorB.Name = "mskBxValorB";
            this.mskBxValorB.Size = new System.Drawing.Size(276, 30);
            this.mskBxValorB.TabIndex = 9;
            this.mskBxValorB.Validated += new System.EventHandler(this.mskBxValorB_Validated);
            // 
            // mskBxValorC
            // 
            this.mskBxValorC.Location = new System.Drawing.Point(179, 168);
            this.mskBxValorC.Mask = "999.00";
            this.mskBxValorC.Name = "mskBxValorC";
            this.mskBxValorC.Size = new System.Drawing.Size(276, 30);
            this.mskBxValorC.TabIndex = 10;
            this.mskBxValorC.Validated += new System.EventHandler(this.mskBxValorC_Validated);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(594, 31);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(125, 121);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 333);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.mskBxValorC);
            this.Controls.Add(this.mskBxValorB);
            this.Controls.Add(this.mskBxValorA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "PTriangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskBxValorA;
        private System.Windows.Forms.MaskedTextBox mskBxValorB;
        private System.Windows.Forms.MaskedTextBox mskBxValorC;
        private System.Windows.Forms.Button btnFechar;
    }
}

