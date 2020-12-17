namespace Criptografia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.key = new System.Windows.Forms.TextBox();
            this.v_ini = new System.Windows.Forms.TextBox();
            this.text_cripto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_decripto = new System.Windows.Forms.TextBox();
            this.result_cripto = new System.Windows.Forms.TextBox();
            this.result_decripto = new System.Windows.Forms.TextBox();
            this.bt_cripto = new System.Windows.Forms.Button();
            this.bt_decripto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(38, 47);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(168, 20);
            this.key.TabIndex = 0;
            // 
            // v_ini
            // 
            this.v_ini.Location = new System.Drawing.Point(256, 47);
            this.v_ini.Name = "v_ini";
            this.v_ini.Size = new System.Drawing.Size(135, 20);
            this.v_ini.TabIndex = 1;
            // 
            // text_cripto
            // 
            this.text_cripto.Location = new System.Drawing.Point(38, 99);
            this.text_cripto.Name = "text_cripto";
            this.text_cripto.Size = new System.Drawing.Size(353, 20);
            this.text_cripto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vetor de Inicialização";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto Para Criptografar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Texto para Descriptografar";
            // 
            // text_decripto
            // 
            this.text_decripto.Location = new System.Drawing.Point(38, 175);
            this.text_decripto.Name = "text_decripto";
            this.text_decripto.Size = new System.Drawing.Size(353, 20);
            this.text_decripto.TabIndex = 7;
            // 
            // result_cripto
            // 
            this.result_cripto.Enabled = false;
            this.result_cripto.Location = new System.Drawing.Point(38, 125);
            this.result_cripto.Name = "result_cripto";
            this.result_cripto.Size = new System.Drawing.Size(353, 20);
            this.result_cripto.TabIndex = 8;
            // 
            // result_decripto
            // 
            this.result_decripto.Enabled = false;
            this.result_decripto.Location = new System.Drawing.Point(38, 201);
            this.result_decripto.Name = "result_decripto";
            this.result_decripto.Size = new System.Drawing.Size(353, 20);
            this.result_decripto.TabIndex = 9;
            // 
            // bt_cripto
            // 
            this.bt_cripto.Location = new System.Drawing.Point(122, 243);
            this.bt_cripto.Name = "bt_cripto";
            this.bt_cripto.Size = new System.Drawing.Size(75, 23);
            this.bt_cripto.TabIndex = 10;
            this.bt_cripto.Text = "Criptografar";
            this.bt_cripto.UseVisualStyleBackColor = true;
            this.bt_cripto.Click += new System.EventHandler(this.bt_cripto_Click);
            // 
            // bt_decripto
            // 
            this.bt_decripto.Location = new System.Drawing.Point(232, 243);
            this.bt_decripto.Name = "bt_decripto";
            this.bt_decripto.Size = new System.Drawing.Size(75, 23);
            this.bt_decripto.TabIndex = 11;
            this.bt_decripto.Text = "Descriptografar";
            this.bt_decripto.UseVisualStyleBackColor = true;
            this.bt_decripto.Click += new System.EventHandler(this.bt_decripto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 290);
            this.Controls.Add(this.bt_decripto);
            this.Controls.Add(this.bt_cripto);
            this.Controls.Add(this.result_decripto);
            this.Controls.Add(this.result_cripto);
            this.Controls.Add(this.text_decripto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_cripto);
            this.Controls.Add(this.v_ini);
            this.Controls.Add(this.key);
            this.Name = "Form1";
            this.Text = "Criptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.TextBox v_ini;
        private System.Windows.Forms.TextBox text_cripto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_decripto;
        private System.Windows.Forms.TextBox result_cripto;
        private System.Windows.Forms.TextBox result_decripto;
        private System.Windows.Forms.Button bt_cripto;
        private System.Windows.Forms.Button bt_decripto;
    }
}

