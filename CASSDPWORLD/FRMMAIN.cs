using CASSDPWORLD.UTILITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using ZXing.Common;
using ZXing;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;

namespace CASSDPWORLD
{
    public partial class FRMMAIN : Form
    {
        public FRMMAIN()
        {
            InitializeComponent();
            IOModuleClientrequest.FMP = this;
            InitializeConfigurationProperties();
            StartServerReaderodule(PCIP, 5001);
            RESETALLCONTROL();
        }

        /********** INITIALIZE CONFIGURATION PROPERTIES ***********/

        #region
        string PCIP = "127.0.0.1";
        string ARHIP = "172.16.100.45";
        #endregion
        private void InitializeConfigurationProperties()
        {
            try
            {
                PCIP = ConfigurationManager.AppSettings["PCIP"].ToString();
            }
            catch(Exception ex) 
            {
                WriteToFile("InitializeConfigurationProperties :" + ex.Message);
            }
        }

        /******************************************* Server Initialization for REDAER **************************************************/
        #region
        int CoderPort = 0;
        private static TcpListener _listenerCoder;
        #endregion
        public static void StartServerReaderodule(string IP, int Port)
        {
            System.Net.IPAddress localIPAddress = System.Net.IPAddress.Parse(IP);
            IPEndPoint ipLocal = new IPEndPoint(localIPAddress, Port);
            _listenerCoder = new TcpListener(ipLocal);
            _listenerCoder.Start();
            WaitForClientConnectCoder();

        }
        private static void WaitForClientConnectCoder()
        {
            object obj = new object();
            _listenerCoder.BeginAcceptTcpClient(new System.AsyncCallback(OnClientConnectCoder), obj);
        }
        private static void OnClientConnectCoder(IAsyncResult asyn)
        {
            try
            {
                TcpClient clientSocket = default(TcpClient);
                clientSocket = _listenerCoder.EndAcceptTcpClient(asyn);
                IOModuleClientrequest clientReq = new IOModuleClientrequest(clientSocket);
                globalAccess.tcpClientsListReader.Add(clientSocket);
                clientReq.StartClient();
            }
            catch (Exception se)
            {
                throw;
            }

            WaitForClientConnectCoder();
        }
        public void BroadCastToIO(byte[] BytesSend)
        {
            try
            {
                foreach (TcpClient client in globalAccess.tcpClientsListReader)
                {
                    NetworkStream networkStream = client.GetStream();
                    networkStream.Write(BytesSend, 0, BytesSend.Length);
                    networkStream.Flush();
                }
            }
            catch (Exception ex) { }
        }


        /********** GENERATE QR CODE *********************/
        private void GenerateQRCODE(string text)
        {
            try
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                barcodeWriter.Options = new EncodingOptions()
                {
                    Width = 180,
                    Height = 180,
                    Margin = 0
                };
                this.QRCODEBOX.Image = (System.Drawing. Image)barcodeWriter.Write(text);
            }
            catch (Exception ex) { }
        }





        /************************ NUMBER PLATE READING ******************/

        private string FETCHLASTLPN()
        {
            string LASTLPN = string.Empty;
            try
            {
                WebClient client = new WebClient();
                string resultfirst = client.DownloadString("http://"+ ARHIP + "/lpr/cff?cmd=getdata&id=last");
                Result result = DeserializeXml<Result>(resultfirst);
                LASTLPN = FindElementValue((System.Xml.XmlNode[])result.ANPR, "text");
            }
            catch (Exception ex) { }
            return LASTLPN;
        }
        static T DeserializeXml<T>(string xmlData)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xmlData))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
        static string FindElementValue(XmlNode[] nodes, string elementName)
        {
            foreach (XmlNode node in nodes)
            {
                if (node.Name == elementName)
                {
                    return node.Attributes["value"].Value;
                }
            }
            return null;
        }




        /***************** RESET THE UI CONTROLS *************/
        public void RESETALLCONTROL()
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    LblTRUCKID.Text = "XX";
                    LBLTAG.Text = "XX";
                    LblTRUCKID.Text = "XX";
                    QRCODEBOX.Image = (System.Drawing.Image)null;
                    PnlVehicle.Visible = false;
                });
            }
            catch (Exception ex) { }
        }

        public void UPDATEUICONTROL(string TAG)
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    string LPN = FETCHLASTLPN();
                    LblTRUCKID.Text = "12345";
                    LBLTAG.Text = TAG;
                    LblLPN.Text = LPN;
                    GenerateQRCODE(TAG);
                    PnlVehicle.Visible = true;

                    Splasher.Show(typeof(frmSplash));
                    Thread.Sleep(5000);
                    Splasher.Close();
                });
            }
            catch (Exception ex) { }

        }




        /*************** LOG THE ERRORS AND EXCEPTIONS *****************/
        public static void WriteToFile(string Text)
        {
            try
            {
                Text = DateTime.Now.ToString() + "  :  " + Text;
                using (StreamWriter writer = new StreamWriter("C:\\ERRORLOG.txt", true))
                {
                    writer.WriteLine(string.Format(Text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")));
                    writer.Close();
                }
            }
            catch (Exception ex) { }
        }
    }
}
