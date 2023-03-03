namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnCharNum = new System.Windows.Forms.Button();
            this.btnFirstWhiteChar = new System.Windows.Forms.Button();
            this.btnQtsCharsAlfab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(192, 74);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(432, 207);
            this.richTxtBox.TabIndex = 0;
            this.richTxtBox.Text = "";
            // 
            // btnCharNum
            // 
            this.btnCharNum.Location = new System.Drawing.Point(70, 325);
            this.btnCharNum.Name = "btnCharNum";
            this.btnCharNum.Size = new System.Drawing.Size(195, 112);
            this.btnCharNum.TabIndex = 2;
            this.btnCharNum.Text = "Quantos caracteres numéricos";
            this.btnCharNum.UseVisualStyleBackColor = true;
            this.btnCharNum.Click += new System.EventHandler(this.btnCharNum_Click);
            // 
            // btnFirstWhiteChar
            // 
            this.btnFirstWhiteChar.Location = new System.Drawing.Point(322, 325);
            this.btnFirstWhiteChar.Name = "btnFirstWhiteChar";
            this.btnFirstWhiteChar.Size = new System.Drawing.Size(195, 112);
            this.btnFirstWhiteChar.TabIndex = 3;
            this.btnFirstWhiteChar.Text = "Primeiro caracter branco";
            this.btnFirstWhiteChar.UseVisualStyleBackColor = true;
            this.btnFirstWhiteChar.Click += new System.EventHandler(this.btnFirstWhiteChar_Click);
            // 
            // btnQtsCharsAlfab
            // 
            this.btnQtsCharsAlfab.Location = new System.Drawing.Point(578, 325);
            this.btnQtsCharsAlfab.Name = "btnQtsCharsAlfab";
            this.btnQtsCharsAlfab.Size = new System.Drawing.Size(195, 112);
            this.btnQtsCharsAlfab.TabIndex = 4;
            this.btnQtsCharsAlfab.Text = "Quantos caracteres alfabéticos";
            this.btnQtsCharsAlfab.UseVisualStyleBackColor = true;
            this.btnQtsCharsAlfab.Click += new System.EventHandler(this.btnQtsCharsAlfab_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 494);
            this.Controls.Add(this.btnQtsCharsAlfab);
            this.Controls.Add(this.btnFirstWhiteChar);
            this.Controls.Add(this.btnCharNum);
            this.Controls.Add(this.richTxtBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.Button btnCharNum;
        private System.Windows.Forms.Button btnFirstWhiteChar;
        private System.Windows.Forms.Button btnQtsCharsAlfab;
    }
}