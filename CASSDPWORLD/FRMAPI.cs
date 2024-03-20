using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASSDPWORLD
{
    public partial class FRMAPI : Form
    {
        public FRMAPI()
        {
            InitializeComponent();
        }



        public void GETTOKEN(string regPlace,string truckNo,string terminalId)
        {
            try
            {
                Splasher.Show(typeof(frmSplash));
                Thread.Sleep(1000);
                var client = new RestClient("http://jxodevap.dpworld.ae:7780");
                var request = new RestRequest("/gasws/GateAutomationServiceSoapHttpPort/getTokenDetails", Method.Get);
                request.Timeout = 10000;
                request.AddQueryParameter("regPlace", regPlace);
                request.AddQueryParameter("truckNo", truckNo);
                request.AddQueryParameter("terminalId", terminalId);
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    TxtResponse.Text = response.Content;
                }
                else
                {
                    TxtResponse.Text = response.ErrorMessage;
                }
            }
            catch(Exception ex)
            {
                Splasher.Close();
                MessageBox.Show(ex.Message, "CASS");
            }
            finally
            {
                Splasher.Close();
            }
        }


        public void GETEIRLOCATIONDETAILS(string regPlace, string laneId, string truckNo, string portCode, string containerNo, string tokenNo)
        {
            try
            {
                Splasher.Show(typeof(frmSplash));
                Thread.Sleep(1000);
                var client = new RestClient("http://jxodevap.dpworld.ae:7780");
                var request = new RestRequest("/gasws/GateAutomationServiceSoapHttpPort/getEirLocationDetails", Method.Get);
                request.Timeout = 10000;
                request.AddQueryParameter("regPlace", regPlace);
                request.AddQueryParameter("laneId", laneId);
                request.AddQueryParameter("truckNo", truckNo);
                request.AddQueryParameter("portCode", portCode);
                request.AddQueryParameter("containerNo", containerNo);
                request.AddQueryParameter("tokenNo", tokenNo);
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    TxtResponse.Text = response.Content;
                }
                else
                {
                    TxtResponse.Text = response.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                Splasher.Close();
                MessageBox.Show(ex.Message, "CASS");
            }
            finally
            {
                Splasher.Close();
            }
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void BtngetToken_Click(object sender, EventArgs e)
        {
            GETTOKEN(txtRegPlace.Text, txttruckNo.Text, txtterminalID.Text);
        }

        private void BtnGetEIRLocation_Click(object sender, EventArgs e)
        {
            GETEIRLOCATIONDETAILS(TxtEIRregPlace.Text, TxtEILaneID.Text, TxtEITRUCKNO.Text, TxtEIPortCode.Text, TxtEIPortCode.Text, TxtEITokenNo.Text);
        }
    }
}
