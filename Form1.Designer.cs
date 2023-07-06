namespace BatePapo
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
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.buttonEnviarMsg = new System.Windows.Forms.Button();
            this.textBoxPortaContato = new System.Windows.Forms.TextBox();
            this.textBoxIpContato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMsgEnviar = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMsg = new System.Windows.Forms.RichTextBox();
            this.textBoxMeuNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxConfServidor = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPortaServ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMsg.SuspendLayout();
            this.groupBoxConfServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.buttonEnviarMsg);
            this.groupBoxMsg.Controls.Add(this.textBoxPortaContato);
            this.groupBoxMsg.Controls.Add(this.textBoxIpContato);
            this.groupBoxMsg.Controls.Add(this.label4);
            this.groupBoxMsg.Controls.Add(this.label3);
            this.groupBoxMsg.Controls.Add(this.label2);
            this.groupBoxMsg.Controls.Add(this.richTextBoxMsgEnviar);
            this.groupBoxMsg.Controls.Add(this.richTextBoxMsg);
            this.groupBoxMsg.Controls.Add(this.textBoxMeuNome);
            this.groupBoxMsg.Controls.Add(this.label1);
            this.groupBoxMsg.Location = new System.Drawing.Point(6, 12);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(418, 371);
            this.groupBoxMsg.TabIndex = 0;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "Mensagens";
            // 
            // buttonEnviarMsg
            // 
            this.buttonEnviarMsg.Location = new System.Drawing.Point(6, 325);
            this.buttonEnviarMsg.Name = "buttonEnviarMsg";
            this.buttonEnviarMsg.Size = new System.Drawing.Size(406, 28);
            this.buttonEnviarMsg.TabIndex = 9;
            this.buttonEnviarMsg.Text = "Enviar";
            this.buttonEnviarMsg.UseVisualStyleBackColor = true;
            this.buttonEnviarMsg.Click += new System.EventHandler(this.buttonEnviarMsg_Click);
            // 
            // textBoxPortaContato
            // 
            this.textBoxPortaContato.Location = new System.Drawing.Point(304, 299);
            this.textBoxPortaContato.Name = "textBoxPortaContato";
            this.textBoxPortaContato.Size = new System.Drawing.Size(65, 20);
            this.textBoxPortaContato.TabIndex = 8;
            // 
            // textBoxIpContato
            // 
            this.textBoxIpContato.Location = new System.Drawing.Point(74, 299);
            this.textBoxIpContato.Name = "textBoxIpContato";
            this.textBoxIpContato.Size = new System.Drawing.Size(117, 20);
            this.textBoxIpContato.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porta do Contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP do contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensagens para enviar:";
            // 
            // richTextBoxMsgEnviar
            // 
            this.richTextBoxMsgEnviar.Location = new System.Drawing.Point(133, 207);
            this.richTextBoxMsgEnviar.Name = "richTextBoxMsgEnviar";
            this.richTextBoxMsgEnviar.Size = new System.Drawing.Size(279, 86);
            this.richTextBoxMsgEnviar.TabIndex = 3;
            this.richTextBoxMsgEnviar.Text = "";
            // 
            // richTextBoxMsg
            // 
            this.richTextBoxMsg.Location = new System.Drawing.Point(6, 52);
            this.richTextBoxMsg.Name = "richTextBoxMsg";
            this.richTextBoxMsg.Size = new System.Drawing.Size(406, 149);
            this.richTextBoxMsg.TabIndex = 2;
            this.richTextBoxMsg.Text = "";
            // 
            // textBoxMeuNome
            // 
            this.textBoxMeuNome.Location = new System.Drawing.Point(74, 26);
            this.textBoxMeuNome.Name = "textBoxMeuNome";
            this.textBoxMeuNome.Size = new System.Drawing.Size(135, 20);
            this.textBoxMeuNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meu Nome:";
            // 
            // groupBoxConfServidor
            // 
            this.groupBoxConfServidor.Controls.Add(this.button1);
            this.groupBoxConfServidor.Controls.Add(this.textBoxPortaServ);
            this.groupBoxConfServidor.Controls.Add(this.label5);
            this.groupBoxConfServidor.Location = new System.Drawing.Point(6, 389);
            this.groupBoxConfServidor.Name = "groupBoxConfServidor";
            this.groupBoxConfServidor.Size = new System.Drawing.Size(418, 121);
            this.groupBoxConfServidor.TabIndex = 1;
            this.groupBoxConfServidor.TabStop = false;
            this.groupBoxConfServidor.Text = "Configurações do Servidor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aplicar Configurações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPortaServ
            // 
            this.textBoxPortaServ.Location = new System.Drawing.Point(104, 19);
            this.textBoxPortaServ.Name = "textBoxPortaServ";
            this.textBoxPortaServ.Size = new System.Drawing.Size(135, 20);
            this.textBoxPortaServ.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Porta do Servidor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 522);
            this.Controls.Add(this.groupBoxConfServidor);
            this.Controls.Add(this.groupBoxMsg);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 561);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 561);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBoxMsg.PerformLayout();
            this.groupBoxConfServidor.ResumeLayout(false);
            this.groupBoxConfServidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.GroupBox groupBoxConfServidor;
        private System.Windows.Forms.TextBox textBoxMeuNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxMsgEnviar;
        private System.Windows.Forms.RichTextBox richTextBoxMsg;
        private System.Windows.Forms.TextBox textBoxPortaContato;
        private System.Windows.Forms.TextBox textBoxIpContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnviarMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPortaServ;
        private System.Windows.Forms.Label label5;
    }
}

