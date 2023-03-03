namespace PAtividade8
{
    partial class frmExercicio1
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
            this.richTxtBx = new System.Windows.Forms.RichTextBox();
            this.BtnWhiteSpaces = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnParDeLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtBx
            // 
            this.richTxtBx.Location = new System.Drawing.Point(195, 40);
            this.richTxtBx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTxtBx.Name = "richTxtBx";
            this.richTxtBx.Size = new System.Drawing.Size(427, 211);
            this.richTxtBx.TabIndex = 0;
            this.richTxtBx.Text = "";
            // 
            // BtnWhiteSpaces
            // 
            this.BtnWhiteSpaces.Location = new System.Drawing.Point(65, 294);
            this.BtnWhiteSpaces.Name = "BtnWhiteSpaces";
            this.BtnWhiteSpaces.Size = new System.Drawing.Size(179, 104);
            this.BtnWhiteSpaces.TabIndex = 1;
            this.BtnWhiteSpaces.Text = "Espaços em branco";
            this.BtnWhiteSpaces.UseVisualStyleBackColor = true;
            this.BtnWhiteSpaces.Click += new System.EventHandler(this.BtnWhiteSpaces_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(335, 294);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(179, 104);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Número de vezes letra R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnParDeLetras
            // 
            this.btnParDeLetras.Location = new System.Drawing.Point(597, 294);
            this.btnParDeLetras.Name = "btnParDeLetras";
            this.btnParDeLetras.Size = new System.Drawing.Size(179, 104);
            this.btnParDeLetras.TabIndex = 3;
            this.btnParDeLetras.Text = "Mesmo par de letras por frase";
            this.btnParDeLetras.UseVisualStyleBackColor = true;
            this.btnParDeLetras.Click += new System.EventHandler(this.btnParDeLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.btnParDeLetras);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.BtnWhiteSpaces);
            this.Controls.Add(this.richTxtBx);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBx;
        private System.Windows.Forms.Button BtnWhiteSpaces;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnParDeLetras;
    }
}