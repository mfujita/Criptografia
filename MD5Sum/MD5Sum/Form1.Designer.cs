namespace MD5Sum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnMD5Sum = new System.Windows.Forms.Button();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.gbCodificacao = new System.Windows.Forms.GroupBox();
            this.rbASCII = new System.Windows.Forms.RadioButton();
            this.rbUnicode = new System.Windows.Forms.RadioButton();
            this.rbUTF8 = new System.Windows.Forms.RadioButton();
            this.gbCodificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEntrada.Location = new System.Drawing.Point(12, 12);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntrada.Size = new System.Drawing.Size(641, 214);
            this.txtEntrada.TabIndex = 0;
            // 
            // btnMD5Sum
            // 
            this.btnMD5Sum.Location = new System.Drawing.Point(670, 168);
            this.btnMD5Sum.Name = "btnMD5Sum";
            this.btnMD5Sum.Size = new System.Drawing.Size(146, 58);
            this.btnMD5Sum.TabIndex = 1;
            this.btnMD5Sum.Text = "Gerar hash";
            this.btnMD5Sum.UseVisualStyleBackColor = true;
            this.btnMD5Sum.Click += new System.EventHandler(this.btnMD5Sum_Click);
            // 
            // txtSaida
            // 
            this.txtSaida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSaida.Location = new System.Drawing.Point(12, 243);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(804, 57);
            this.txtSaida.TabIndex = 2;
            // 
            // gbCodificacao
            // 
            this.gbCodificacao.Controls.Add(this.rbASCII);
            this.gbCodificacao.Controls.Add(this.rbUnicode);
            this.gbCodificacao.Controls.Add(this.rbUTF8);
            this.gbCodificacao.Location = new System.Drawing.Point(670, 12);
            this.gbCodificacao.Name = "gbCodificacao";
            this.gbCodificacao.Size = new System.Drawing.Size(146, 126);
            this.gbCodificacao.TabIndex = 3;
            this.gbCodificacao.TabStop = false;
            this.gbCodificacao.Text = "Codificação";
            // 
            // rbASCII
            // 
            this.rbASCII.AutoSize = true;
            this.rbASCII.Location = new System.Drawing.Point(6, 90);
            this.rbASCII.Name = "rbASCII";
            this.rbASCII.Size = new System.Drawing.Size(65, 25);
            this.rbASCII.TabIndex = 2;
            this.rbASCII.TabStop = true;
            this.rbASCII.Text = "ASCII";
            this.rbASCII.UseVisualStyleBackColor = true;
            // 
            // rbUnicode
            // 
            this.rbUnicode.AutoSize = true;
            this.rbUnicode.Location = new System.Drawing.Point(6, 59);
            this.rbUnicode.Name = "rbUnicode";
            this.rbUnicode.Size = new System.Drawing.Size(85, 25);
            this.rbUnicode.TabIndex = 1;
            this.rbUnicode.TabStop = true;
            this.rbUnicode.Text = "Unicode";
            this.rbUnicode.UseVisualStyleBackColor = true;
            // 
            // rbUTF8
            // 
            this.rbUTF8.AutoSize = true;
            this.rbUTF8.Location = new System.Drawing.Point(6, 28);
            this.rbUTF8.Name = "rbUTF8";
            this.rbUTF8.Size = new System.Drawing.Size(70, 25);
            this.rbUTF8.TabIndex = 0;
            this.rbUTF8.TabStop = true;
            this.rbUTF8.Text = "UTF-8";
            this.rbUTF8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(828, 312);
            this.Controls.Add(this.gbCodificacao);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.btnMD5Sum);
            this.Controls.Add(this.txtEntrada);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MD5Sum";
            this.gbCodificacao.ResumeLayout(false);
            this.gbCodificacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEntrada;
        private Button btnMD5Sum;
        private TextBox txtSaida;
        private GroupBox gbCodificacao;
        private RadioButton rbASCII;
        private RadioButton rbUnicode;
        private RadioButton rbUTF8;
    }
}