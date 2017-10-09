using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookComputing.XmlRpc;
using System.Net;
using System.IO;

namespace WoBookTest
{
    public partial class Form1 : Form
    {
        private IWooBook thisWooBook;

        public Form1()
        {
            InitializeComponent();
            //
            thisWooBook = XmlRpcProxyGen.Create<IWooBook>();
        }


        private string createWoBookCommand(string MethodName, string[] Params)
        {
            string command = "<?xml version='1.0'?>" +
                             "<methodCall>" +
                                $"<methodName>{MethodName}</methodName>";
            if (Params.Length > 0)
            {
                command += "<params>";
                foreach (string nextParam in Params)
                {
                    command += "<param>" +
                                    $"<value><string>{nextParam}</string></value>" +
                               "</param>";
                }
                command += "</params>";
            }
            command += "</methodCall>";
            //
            return command;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://wubook.net/xrws/");
            request.Method = "POST";
            string command = "<?xml version='1.0'?>" +
                                    "<methodCall>" +
                                      "<methodName>provider_info</methodName>" +
                                      "<params>" +
                                        "<param>" +
                                          "<value><string>123</string></value>" +
                                        "</param>" +
                                      "</params>" +
                                    "</methodCall> ";

            //<?xml version='1.0'?>
            //<methodCall>
            //  <methodName>acquire_token</methodName>
            //  <params>
            //      <param>
            //          <value><string>GV074</string></value>
            //      </param>
            //      <param>
            //          <value><string>59031</string></value>
            //      </param>
            //      <param>
            //          <value><string>1506091924</string></value>
            //      </param>
            //  </params>
            //</methodCall>

            byte[] bytes = Encoding.ASCII.GetBytes(command);
            request.ContentLength = bytes.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }

            using (var stream = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                // Вывод ответа от сервера на консоль.
                //Console.WriteLine(stream.ReadToEnd());
                MessageBox.Show(stream.ReadToEnd());
            }


            //thisWooBook.Url = txtUrl.Text;
            //Cursor = Cursors.WaitCursor;
            //try
            //{
            //    labResult.Text = "";
            //    string token = txtToken.Text;
            //    //string result = thisWooBook.is_token_valid(token);
            //    string result = thisWooBook.provider_info(token);
            //    lblToken.Text = result;
            //}
            //catch (Exception ex)
            //{
            //    HandleException(ex);
            //}
            //Cursor = Cursors.Default;
        }
               

        private void HandleException(Exception ex)
        {
            string msgBoxTitle = "Error";
            try
            {
                throw ex;
            }
            catch (XmlRpcFaultException fex)
            {
                MessageBox.Show("Fault Response: " + fex.FaultCode + " "
                    + fex.FaultString, msgBoxTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (WebException webEx)
            {
                MessageBox.Show("WebException: " + webEx.Message, msgBoxTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (webEx.Response != null)
                    webEx.Response.Close();
            }
            catch (XmlRpcServerException xmlRpcEx)
            {
                MessageBox.Show("XmlRpcServerException: " + xmlRpcEx.Message,
                    msgBoxTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception defEx)
            {
                MessageBox.Show("Exception: " + defEx.Message, msgBoxTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public interface IWooBook : IXmlRpcProxy
        {
            [XmlRpcMethod("is_token_valid")]
            string is_token_valid(string token);

            [XmlRpcMethod("release_token")]
            string release_token(string token);

            [XmlRpcMethod("provider_info")]
            string provider_info(string token);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAquireToken_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://wubook.net/xrws/");
            request.Method = "POST";
            string[] woBookParams = new string[] { txtUser.Text, txtPassword.Text, "" };
            string command = createWoBookCommand("acquire_token", woBookParams);

            byte[] bytes = Encoding.ASCII.GetBytes(command);
            request.ContentLength = bytes.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }

            using (var stream = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                // Вывод ответа от сервера на консоль.
                //Console.WriteLine(stream.ReadToEnd());
                string responce = stream.ReadToEnd();
                MessageBox.Show(responce);
            }

        }



    }


}
