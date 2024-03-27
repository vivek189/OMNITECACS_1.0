using CASSDPWORLD.UTILITY;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CASSDPWORLD.APICLASS
{
    class SoapClient
    {
        public string GETTOKENDETAILS(string regPlace, string rfIdNo, string truckNo, string terminalId, string username, string password)
        {
            string PostRequestStr = string.Empty;
            try
            {

                string URL = "http://jxodevap.dpworld.ae:7780/gasws/GateAutomationServiceSoapHttpPort";
                string xmlTemplate = @"
<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
    <soap:Body xmlns:ns1=""http://service.gasws.dpw.com/"">
        <ns1:getTokenDetails>
            <ns1:tokenReqType>
                <ns1:regPlace>{0}</ns1:regPlace>
                <ns1:rfIdNo>{1}</ns1:rfIdNo>
                <ns1:truckNo>{2}</ns1:truckNo>
                <ns1:terminalId>{3}</ns1:terminalId>
                <ns1:userCredentials>
                    <ns1:password>{4}</ns1:password>
                    <ns1:username>{5}</ns1:username>
                </ns1:userCredentials>
            </ns1:tokenReqType>
        </ns1:getTokenDetails>
    </soap:Body>
</soap:Envelope>";

                string requestXml = string.Format(xmlTemplate, regPlace, rfIdNo, truckNo, terminalId, password, username);
                var client = new RestClient();
                var request = new RestRequest(URL, Method.Post);
                request.AddHeader("Content-Type", "text/xml");
                request.Timeout = 10000;
                request.AddParameter("text/xml", requestXml, ParameterType.RequestBody);
                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    PostRequestStr = Convert.ToString(response.Content);
                    if (response.StatusCode == HttpStatusCode.Accepted)
                    {
                        PostRequestStr = "CASSACCEPTED";
                    }
                }
                else if (response.StatusCode == HttpStatusCode.Accepted)
                {
                    PostRequestStr = "CASSACCEPTED";
                }
                else
                {
                    PostRequestStr = "CASSERROR";

                }
            }
            catch (Exception ex)
            {
                //ERRORLOG EL = new ERRORLOG();
                //EL.WriteToFile("GETTOKENDETAILS :" + ex.Message);
            }
            return PostRequestStr;
        }
    }
}
