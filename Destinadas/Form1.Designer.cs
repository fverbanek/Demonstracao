namespace Destinadas
{
    partial class Destinadas
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.txtDtFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(436, 117);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(108, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(12, 33);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(325, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(346, 33);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(198, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(12, 78);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(532, 20);
            this.txtToken.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Token da Software House";
            // 
            // txtDtInicial
            // 
            this.txtDtInicial.Location = new System.Drawing.Point(12, 120);
            this.txtDtInicial.Mask = "00/00/0000";
            this.txtDtInicial.Name = "txtDtInicial";
            this.txtDtInicial.Size = new System.Drawing.Size(70, 20);
            this.txtDtInicial.TabIndex = 9;
            this.txtDtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.Location = new System.Drawing.Point(108, 120);
            this.txtDtFinal.Mask = "00/00/0000";
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Size = new System.Drawing.Size(70, 20);
            this.txtDtFinal.TabIndex = 10;
            this.txtDtFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data final";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(532, 214);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(366, 366);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(178, 31);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Buscar xml selecionado";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // txtXML
            // 
            this.txtXML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXML.Location = new System.Drawing.Point(4, 12);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(557, 399);
            this.txtXML.TabIndex = 15;
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(567, 12);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.Size = new System.Drawing.Size(434, 399);
            this.txtRetorno.TabIndex = 16;
            // 
            // Destinadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 422);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDtFinal);
            this.Controls.Add(this.txtDtInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtXML);
            this.Name = "Destinadas";
            this.Text = "Destinadas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDtInicial;
        private System.Windows.Forms.MaskedTextBox txtDtFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.TextBox txtRetorno;
    }
}

