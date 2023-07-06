using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace BatePapo
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener;
        TcpClient tcpClient;
        Thread servidorThread;
        bool podePararThreadServidor;
        public Form1()
        {
            InitializeComponent();
            tcpListener = null;
            tcpClient = null;
            servidorThread = null;
            podePararThreadServidor = false;

        }

        private void buttonEnviarMsg_Click(object sender, EventArgs e)
        {
            try
            {   //Criar cliente para se conectar
                TcpClient tcpClient = new TcpClient(textBoxIpContato.Text, Convert.ToInt32(textBoxPortaContato.Text));
                NetworkStream ns = tcpClient.GetStream();

                //Enviando mensagem
                string msg = textBoxMeuNome.Text + ": " + richTextBoxMsgEnviar.Text;
                byte[] msgBytes = Encoding.ASCII.GetBytes(msg);
                ns.Write(msgBytes, 0, msgBytes.Length);

                //Fechando conexão
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paraServidor();
            servidorThread = new Thread(() => 
            {
                tcpListener = new TcpListener(IPAddress.Any, Convert.ToInt32(textBoxPortaServ.Text));
                tcpListener.Start();

                do
                {
                    try
                    {
                        tcpClient = tcpListener.AcceptTcpClient();
                        NetworkStream ns = tcpClient.GetStream();

                        byte[] bufferMensagemRecebida = new byte[1024];
                        int bytesRecebidos = ns.Read(bufferMensagemRecebida, 0, bufferMensagemRecebida.Length);
                        string msgRecebidasStr = Encoding.ASCII.GetString(bufferMensagemRecebida, 0, bytesRecebidos);

                        atualizaRichTextBox("\r\n" + msgRecebidasStr);
                    }
                    catch (SocketException ex)
                    {
                        if ((SocketError)ex.ErrorCode != SocketError.Interrupted)
                        {
                            MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }while (podePararThreadServidor == false);
            });
            servidorThread.Start();
        }

        public void atualizaRichTextBox(string pMsg)
        {
            if (richTextBoxMsg.InvokeRequired)
            {
                richTextBoxMsg.Invoke((MethodInvoker)(() => atualizaRichTextBox(pMsg)));
            }
            else
                richTextBoxMsg.Text += pMsg;
        }

        public void paraServidor()
        {
            try
            {
                podePararThreadServidor = true;
                if(tcpListener != null)
                {
                    tcpListener.Stop();
                    tcpListener = null;
                }
                if(tcpClient != null)
                {
                    tcpClient.Close();
                    tcpClient = null;
                }
                if(servidorThread != null)
                {
                    servidorThread.Join();
                }
                podePararThreadServidor= false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
