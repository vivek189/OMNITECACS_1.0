
using CASSDPWORLD.UTILITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CASSDPWORLD
{
    class IOModuleClientrequest
    {
       
            TcpClient _clientSocket;
            NetworkStream _networkStream = null;
            public static FRMMAIN FMP;
            public IOModuleClientrequest(TcpClient clientConnected)
            {
                this._clientSocket = clientConnected;
            }
            public void StartClient()
            {
                _networkStream = _clientSocket.GetStream();
                WaitForRequest();
            }
            public void WaitForRequest()
            {
                if (_clientSocket.Connected)
                {
                    try
                    {
                        byte[] Buffer = new Byte[_clientSocket.ReceiveBufferSize];
                        _networkStream.BeginRead(Buffer, 0, Buffer.Length, new AsyncCallback(ReadCallback), Buffer);
                    }
                    catch { }
                }
                else
                {
                     globalAccess.tcpClientsListReader.Remove(_clientSocket);
                    _clientSocket.Close();
                    _networkStream.Close();
                }
            }
            public void ReadCallback(IAsyncResult result)
            {
                NetworkStream networkStream = _clientSocket.GetStream();
                try
                {
                    int read = networkStream.EndRead(result);
                    if (read == 0)
                    {
                        _networkStream.Close();
                        _clientSocket.Close();
                        globalAccess.tcpClientsListReader.Remove(_clientSocket);
                        return;
                    }

                    byte[] buffer = result.AsyncState as byte[];
                    string data = Encoding.Default.GetString(buffer, 0, read);

                    if (data.Contains(">"))
                    {
                        Byte[] sendBytes = GetData(data);
                        if (sendBytes != null && sendBytes.Length > 0)
                        {
                            networkStream.Write(sendBytes, 0, sendBytes.Length);
                            networkStream.Flush();
                        }
                    }

                }
                catch (Exception ex)
                {
                     globalAccess.tcpClientsListReader.Remove(_clientSocket);
                    _clientSocket.Close();
                    _networkStream.Close();
                }

                this.WaitForRequest();
            }
            public void BroadCast(byte[] BytesSend)
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


            public byte[] GetData(string szData)
            {
                byte[] CompleteByte = null;
                string CompleteString = string.Empty;
                try
                {
                    string ReceivedData = szData.Replace(">", "");
                    string[] lines = ReceivedData.Split('.');
                    string CommandType = lines[0];
                    if (CommandType=="CARD")
                    {
                        string CARDNUMBER= lines[1];
                        FMP.UPDATEUICONTROL(CARDNUMBER);

                    }
                    else if(CommandType=="RESET")
                    {
                        FMP.RESETALLCONTROL();
                    }
                }
                catch (Exception ex) { }
                return CompleteByte;
            }




            


        
    }
}
