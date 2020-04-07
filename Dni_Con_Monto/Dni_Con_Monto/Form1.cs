using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using System.Net.Sockets;

namespace Dni_Con_Monto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void limpiaLabel()
        {
            this.lblErrorDni.Text = "";
            this.lblErrorMonto.Text = "";
            this.lblCheckDni.Text = "";
            this.lblCheckMonto.Text = "";
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            limpiaLabel();

            string dni = this.inputDni.Text;
            string monto = this.inputMonto.Text;

            int dniInt = 0;
            int montoInt = 0;
            Validaciones val = new Validaciones();

            bool esDniValido = val.ValidarQueSeaDni(dni, out dniInt);
            if (esDniValido == true)
            {
                this.lblCheckDni.Text = "✓";
            }
            else
            {
                this.lblErrorDni.Text = "** Dni invalido **";
            }


            
            bool esMontoValido = val.ValidarQueSeaMonto(monto, out montoInt);
            if (esMontoValido == true)
            {
                this.lblCheckMonto.Text = "✓";
            }
            else
            {
                this.lblErrorMonto.Text = "** Monto invalido **";
            }


            //Cuando tengo esMontoValido y es DniValido ambos en true ahi deberia llamar al metodo que
            //me va a chupar la plata usando el proyecto de Pagos

            if(esMontoValido == true && esDniValido == true)
            {
                try
                {
                    txtPlataIngresada.Text = String.Empty;
                    //metroButton1.Enabled = false;
                    string msg = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?><payment><command>cash</command><amount>" + txtPlataIngresada.Text + "</amount><appId>12345678</appId><timeout>300</timeout></payment>";
                    Connect("127.0.0.1", msg);
                    //metroButton1.Enabled = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void Connect(String server, String message)
        {
            try
            {

                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 4040;
                TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                //Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                //data = new Byte[1000];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                // Console.WriteLine("Received: {0}", responseData);

                if (responseData.Contains("insertedAmount"))
                {
                    int inicio = responseData.IndexOf("<insertedAmount>") + "<insertedAmount>".Length;
                    int fin = responseData.IndexOf("</insertedAmount>");
                    txtPlataIngresada.Text = responseData.Substring(inicio, fin - inicio);
                }
                else
                {
                    txtPlataIngresada.Text = "Error ó Timeout";
                }

                // Close everything.
                stream.Close();
                client.Close();





            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);

            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }
    }
}
