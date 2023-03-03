namespace PTesteMetodos
{
    partial class frmExercicio3
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnRemoveOco = new System.Windows.Forms.Button();
            this.btnRemoveOcoRepl = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(268, 104);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(329, 33);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(268, 205);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(329, 33);
            this.txtPalavra2.TabIndex = 1;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(124, 107);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(88, 25);
            this.lblPalavra1.TabIndex = 2;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(124, 208);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(88, 25);
            this.lblPalavra2.TabIndex = 3;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnRemoveOco
            // 
            this.btnRemoveOco.Location = new System.Drawing.Point(109, 296);
            this.btnRemoveOco.Name = "btnRemoveOco";
            this.btnRemoveOco.Size = new System.Drawing.Size(161, 111);
            this.btnRemoveOco.TabIndex = 4;
            this.btnRemoveOco.Text = "Remover Ocorrências";
            this.btnRemoveOco.UseVisualStyleBackColor = true;
            this.btnRemoveOco.Click += new System.EventHandler(this.btnRemoveOco_Click);
            // 
            // btnRemoveOcoRepl
            // 
            this.btnRemoveOcoRepl.Location = new System.Drawing.Point(340, 296);
            this.btnRemoveOcoRepl.Name = "btnRemoveOcoRepl";
            this.btnRemoveOcoRepl.Size = new System.Drawing.Size(161, 111);
            this.btnRemoveOcoRepl.TabIndex = 5;
            this.btnRemoveOcoRepl.Text = "Remover Ocorrências (replace)";
            this.btnRemoveOcoRepl.UseVisualStyleBackColor = true;
            this.btnRemoveOcoRepl.Click += new System.EventHandler(this.btnRemoveOcoRepl_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(579, 296);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(161, 111);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.Text = "Inverte (Reverse)";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 476);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnRemoveOcoRepl);
            this.Controls.Add(this.btnRemoveOco);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnRemoveOco;
        private System.Windows.Forms.Button btnRemoveOcoRepl;
        private System.Windows.Forms.Button btnReverse;
    }
}