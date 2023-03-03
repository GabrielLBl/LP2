namespace PAtividade8
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
            this.txtBxNumeroN = new System.Windows.Forms.TextBox();
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.btnGerarNumeroH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxNumeroN
            // 
            this.txtBxNumeroN.Location = new System.Drawing.Point(207, 121);
            this.txtBxNumeroN.Name = "txtBxNumeroN";
            this.txtBxNumeroN.Size = new System.Drawing.Size(378, 33);
            this.txtBxNumeroN.TabIndex = 0;
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Location = new System.Drawing.Point(321, 77);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(164, 25);
            this.lblNumeroN.TabIndex = 1;
            this.lblNumeroN.Text = "Insira o número N";
            // 
            // btnGerarNumeroH
            // 
            this.btnGerarNumeroH.Location = new System.Drawing.Point(243, 198);
            this.btnGerarNumeroH.Name = "btnGerarNumeroH";
            this.btnGerarNumeroH.Size = new System.Drawing.Size(306, 82);
            this.btnGerarNumeroH.TabIndex = 2;
            this.btnGerarNumeroH.Text = "Gerar Número H";
            this.btnGerarNumeroH.UseVisualStyleBackColor = true;
            this.btnGerarNumeroH.Click += new System.EventHandler(this.btnGerarNumeroH_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 358);
            this.Controls.Add(this.btnGerarNumeroH);
            this.Controls.Add(this.lblNumeroN);
            this.Controls.Add(this.txtBxNumeroN);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNumeroN;
        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.Button btnGerarNumeroH;
    }
}