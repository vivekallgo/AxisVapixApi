using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using RestSharp;
using RestSharp.Authenticators;

//Reference: http://hifni.blogspot.com/2017/05/digest-authentication-with-restsharp.html

namespace ListParameters
{
    public partial class Form1 : Form
    {
        DigestAuthenticator globalAuth;
        public Form1()
        {
            InitializeComponent();
            string username = textBoxUserName.Text;
            string pass = textBoxPassword.Text;
            globalAuth = new DigestAuthenticator(username, pass);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear the rich text box every time the user clicks the Get Param button.
            
            richTextBox1.Text = "";
            string Response_Info = GetDetailsBasicCSharp(textBoxVapix.Text,textBoxUserName.Text,textBoxPassword.Text);
            richTextBox1.Text += String.Format("{0}", Response_Info);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear the rich text box every time the user clicks the Get Param button.

            richTextBox1.Text = "";
            string Response_Info = GetDetailsBasicCSharp(textBoxVapix2.Text, textBoxUserName.Text, textBoxPassword.Text);
            richTextBox1.Text += String.Format("{0}", Response_Info);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear the rich text box every time the user clicks the Get Param button.

            richTextBox1.Text = "";
            string Response_Info = GetDetailsBasicCSharp(textBoxVapix3.Text, textBoxUserName.Text, textBoxPassword.Text);
            richTextBox1.Text += String.Format("{0}", Response_Info);

        }

        private string GetDetailsBasicCSharp(string url_details,string Username,string Password)
        {
            //Create a string. The string will be used to pass the VAPIX(R) command to the Axis product.
            string ParamList;
            string ResponseTemp = String.Empty;
            try
            {

                //Enter the VAPIX command. Here we use param.cgi with the list action. 192.168.0.90 is the IP address of the Axis product.
                ParamList = url_details;

                // Enter the user name and password for the Axis product.

                NetworkCredential networkCredential = new NetworkCredential(Username, Password);


                //Associate the 'NetworkCredential' object with the 'WebRequest' object.
                //Read more about WebRequest at
                //http://msdn.microsoft.com/en-us/library/system.net.webrequest.credentials(v=vs.71).aspx



                WebRequest request = WebRequest.Create(ParamList);
                request.Credentials = networkCredential;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                //Read Parameter List and display the response in the rich text box.
                //Read more about the HaveResponse property at
                //http://msdn.microsoft.com/en-us/library/system.net.httpwebrequest.haveresponse(v=vs.110).aspx


                Stream streamResponse = response.GetResponseStream();
                StreamReader streamRead = new StreamReader(streamResponse);
                Char[] readBuff = new Char[256000];
                int count = streamRead.Read(readBuff, 0, 256000);
                ResponseTemp += String.Format("\nAXIS PARAMETER LIST:\n");
                while (count > 0)
                {
                    String outputData = new String(readBuff, 0, count);
                    ResponseTemp += String.Format("{0}", outputData);
                    count = streamRead.Read(readBuff, 0, 256000);
                }


                // Close and release the response.
                streamRead.Close();
                streamResponse.Close();
                response.Close();

            }

            catch (Exception es)
            {
                MessageBox.Show(es.ToString(), "\nError Message");
            }

            return ResponseTemp;
        }


        private void Button1_Rest_Click(object sender, EventArgs e)
        {
            string response_info = string.Empty;
            response_info = GetDetailsRestSharp(textBoxVapix.Text, textBoxUserName.Text, textBoxPassword.Text);
            richTextBox1.Text += String.Format("{0}", response_info);
        }

        private void Button2_Rest_Click(object sender, EventArgs e)
        {
            string response_info = string.Empty;
            response_info = GetDetailsRestSharp(textBoxVapix2.Text, textBoxUserName.Text, textBoxPassword.Text);
            richTextBox1.Text += String.Format("{0}", response_info);
        }


        private void Button3_Rest_Click(object sender, EventArgs e)
        {
            string response_info = string.Empty;
            response_info = GetDetailsRestSharp(textBoxVapix3.Text,textBoxUserName.Text,textBoxPassword.Text);
            richTextBox1.Text += String.Format("{0}", response_info);
        }


        private string GetDetailsRestSharp(string text1, string username, string pass)
        {
            var client = new RestClient(text1);
            var request = new RestRequest(Method.GET);            
            request.AddHeader("Content-Type", "text/xml");
            globalAuth.Authenticate(client,request);
            IRestResponse response = client.Execute(request);
            string result = response.Content;           
            return result;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

      
    }
}
