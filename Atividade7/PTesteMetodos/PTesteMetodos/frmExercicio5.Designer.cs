namespace PTesteMetodos
{
    partial class frmExercicio5
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.txtSorteio = new System.Windows.Forms.TextBox();
            this.lblNumSorteado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(199, 72);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(510, 33);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(199, 136);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(510, 33);
            this.txtNumero2.TabIndex = 1;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(71, 72);
            this.lblNumero1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(96, 25);
            this.lblNumero1.TabIndex = 2;
            this.lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(71, 139);
            this.lblNumero2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(96, 25);
            this.lblNumero2.TabIndex = 3;
            this.lblNumero2.Text = "Numero 2";
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(258, 208);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(370, 82);
            this.btnSortear.TabIndex = 4;
            this.btnSortear.Text = "Sortear um número";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // txtSorteio
            // 
            this.txtSorteio.Location = new System.Drawing.Point(199, 334);
            this.txtSorteio.Margin = new System.Windows.Forms.Padding(6);
            this.txtSorteio.Name = "txtSorteio";
            this.txtSorteio.Size = new System.Drawing.Size(510, 33);
            this.txtSorteio.TabIndex = 5;
            // 
            // lblNumSorteado
            // 
            this.lblNumSorteado.AutoSize = true;
            this.lblNumSorteado.Location = new System.Drawing.Point(25, 337);
            this.lblNumSorteado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumSorteado.Name = "lblNumSorteado";
            this.lblNumSorteado.Size = new System.Drawing.Size(162, 25);
            this.lblNumSorteado.TabIndex = 6;
            this.lblNumSorteado.Text = "Numero Sorteado";
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 468);
            this.Controls.Add(this.lblNumSorteado);
            this.Controls.Add(this.txtSorteio);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.TextBox txtSorteio;
        private System.Windows.Forms.Label lblNumSorteado;
    }
}