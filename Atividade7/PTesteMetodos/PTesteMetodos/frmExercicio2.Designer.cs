namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.txtBxTexto1 = new System.Windows.Forms.TextBox();
            this.txtBxTexto2 = new System.Windows.Forms.TextBox();
            this.btnTestarIguais = new System.Windows.Forms.Button();
            this.btnInserir1no2 = new System.Windows.Forms.Button();
            this.btnInserirAsteriscos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(75, 113);
            this.lblTexto1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(71, 25);
            this.lblTexto1.TabIndex = 0;
            this.lblTexto1.Text = "Texto 1";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(75, 187);
            this.lblTexto2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(71, 25);
            this.lblTexto2.TabIndex = 1;
            this.lblTexto2.Text = "Texto 2";
            // 
            // txtBxTexto1
            // 
            this.txtBxTexto1.Location = new System.Drawing.Point(231, 108);
            this.txtBxTexto1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBxTexto1.Name = "txtBxTexto1";
            this.txtBxTexto1.Size = new System.Drawing.Size(448, 33);
            this.txtBxTexto1.TabIndex = 2;
            // 
            // txtBxTexto2
            // 
            this.txtBxTexto2.Location = new System.Drawing.Point(231, 181);
            this.txtBxTexto2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBxTexto2.Name = "txtBxTexto2";
            this.txtBxTexto2.Size = new System.Drawing.Size(448, 33);
            this.txtBxTexto2.TabIndex = 3;
            // 
            // btnTestarIguais
            // 
            this.btnTestarIguais.Location = new System.Drawing.Point(116, 262);
            this.btnTestarIguais.Name = "btnTestarIguais";
            this.btnTestarIguais.Size = new System.Drawing.Size(174, 85);
            this.btnTestarIguais.TabIndex = 4;
            this.btnTestarIguais.Text = "Testar Iguais";
            this.btnTestarIguais.UseVisualStyleBackColor = true;
            this.btnTestarIguais.Click += new System.EventHandler(this.btnTestarIguais_Click);
            // 
            // btnInserir1no2
            // 
            this.btnInserir1no2.Location = new System.Drawing.Point(355, 262);
            this.btnInserir1no2.Name = "btnInserir1no2";
            this.btnInserir1no2.Size = new System.Drawing.Size(174, 85);
            this.btnInserir1no2.TabIndex = 5;
            this.btnInserir1no2.Text = "Inserir Texto 1 no Texto 2";
            this.btnInserir1no2.UseVisualStyleBackColor = true;
            this.btnInserir1no2.Click += new System.EventHandler(this.btnInserir1no2_Click);
            // 
            // btnInserirAsteriscos
            // 
            this.btnInserirAsteriscos.Location = new System.Drawing.Point(585, 262);
            this.btnInserirAsteriscos.Name = "btnInserirAsteriscos";
            this.btnInserirAsteriscos.Size = new System.Drawing.Size(174, 85);
            this.btnInserirAsteriscos.TabIndex = 6;
            this.btnInserirAsteriscos.Text = "Inserir Asteriscos no Texto 1";
            this.btnInserirAsteriscos.UseVisualStyleBackColor = true;
            this.btnInserirAsteriscos.Click += new System.EventHandler(this.btnInserirAsteriscos_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 470);
            this.Controls.Add(this.btnInserirAsteriscos);
            this.Controls.Add(this.btnInserir1no2);
            this.Controls.Add(this.btnTestarIguais);
            this.Controls.Add(this.txtBxTexto2);
            this.Controls.Add(this.txtBxTexto1);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.TextBox txtBxTexto1;
        private System.Windows.Forms.TextBox txtBxTexto2;
        private System.Windows.Forms.Button btnTestarIguais;
        private System.Windows.Forms.Button btnInserir1no2;
        private System.Windows.Forms.Button btnInserirAsteriscos;
    }
}