namespace Fujicrypt
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCriptografado = new System.Windows.Forms.TextBox();
            this.btnPlano2Cripto = new System.Windows.Forms.Button();
            this.txtChaveCriptografar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTplano = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLegivel = new System.Windows.Forms.TextBox();
            this.btnDecriptografar = new System.Windows.Forms.Button();
            this.btnSelecionaArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChaveDecriptografadora = new System.Windows.Forms.TextBox();
            this.txtSecreto = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCriptografado);
            this.tabPage1.Controls.Add(this.btnPlano2Cripto);
            this.tabPage1.Controls.Add(this.txtChaveCriptografar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTplano);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criptografar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCriptografado
            // 
            this.txtCriptografado.Location = new System.Drawing.Point(23, 293);
            this.txtCriptografado.Multiline = true;
            this.txtCriptografado.Name = "txtCriptografado";
            this.txtCriptografado.Size = new System.Drawing.Size(943, 197);
            this.txtCriptografado.TabIndex = 4;
            // 
            // btnPlano2Cripto
            // 
            this.btnPlano2Cripto.Location = new System.Drawing.Point(612, 242);
            this.btnPlano2Cripto.Name = "btnPlano2Cripto";
            this.btnPlano2Cripto.Size = new System.Drawing.Size(128, 29);
            this.btnPlano2Cripto.TabIndex = 3;
            this.btnPlano2Cripto.Text = "Criptografar";
            this.btnPlano2Cripto.UseVisualStyleBackColor = true;
            this.btnPlano2Cripto.Click += new System.EventHandler(this.btnPlano2Cripto_Click);
            // 
            // txtChaveCriptografar
            // 
            this.txtChaveCriptografar.Location = new System.Drawing.Point(172, 242);
            this.txtChaveCriptografar.Name = "txtChaveCriptografar";
            this.txtChaveCriptografar.Size = new System.Drawing.Size(141, 29);
            this.txtChaveCriptografar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a chave:";
            // 
            // txtTplano
            // 
            this.txtTplano.Location = new System.Drawing.Point(23, 17);
            this.txtTplano.Multiline = true;
            this.txtTplano.Name = "txtTplano";
            this.txtTplano.Size = new System.Drawing.Size(943, 205);
            this.txtTplano.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLegivel);
            this.tabPage2.Controls.Add(this.btnDecriptografar);
            this.tabPage2.Controls.Add(this.btnSelecionaArquivo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtChaveDecriptografadora);
            this.tabPage2.Controls.Add(this.txtSecreto);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decriptografar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLegivel
            // 
            this.txtLegivel.Location = new System.Drawing.Point(24, 306);
            this.txtLegivel.Multiline = true;
            this.txtLegivel.Name = "txtLegivel";
            this.txtLegivel.Size = new System.Drawing.Size(945, 237);
            this.txtLegivel.TabIndex = 5;
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.Location = new System.Drawing.Point(813, 253);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(141, 29);
            this.btnDecriptografar.TabIndex = 4;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = true;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // btnSelecionaArquivo
            // 
            this.btnSelecionaArquivo.Location = new System.Drawing.Point(24, 253);
            this.btnSelecionaArquivo.Name = "btnSelecionaArquivo";
            this.btnSelecionaArquivo.Size = new System.Drawing.Size(174, 29);
            this.btnSelecionaArquivo.TabIndex = 3;
            this.btnSelecionaArquivo.Text = "Seleciona Arquivo";
            this.btnSelecionaArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionaArquivo.Click += new System.EventHandler(this.btnSelecionaArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chave decriptadora";
            // 
            // txtChaveDecriptografadora
            // 
            this.txtChaveDecriptografadora.Location = new System.Drawing.Point(460, 253);
            this.txtChaveDecriptografadora.Name = "txtChaveDecriptografadora";
            this.txtChaveDecriptografadora.Size = new System.Drawing.Size(212, 29);
            this.txtChaveDecriptografadora.TabIndex = 1;
            // 
            // txtSecreto
            // 
            this.txtSecreto.Location = new System.Drawing.Point(24, 20);
            this.txtSecreto.Multiline = true;
            this.txtSecreto.Name = "txtSecreto";
            this.txtSecreto.Size = new System.Drawing.Size(945, 210);
            this.txtSecreto.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtCriptografado;
        private Button btnPlano2Cripto;
        private TextBox txtChaveCriptografar;
        private Label label1;
        private TextBox txtTplano;
        private TabPage tabPage2;
        private TextBox txtLegivel;
        private Button btnDecriptografar;
        private Button btnSelecionaArquivo;
        private Label label2;
        private TextBox txtChaveDecriptografadora;
        private TextBox txtSecreto;
        private OpenFileDialog openFileDialog1;
    }
}