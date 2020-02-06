using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace T.I_Local
{
    public partial class frmSAT : Form
    {
        protected StringBuilder strPingInfo = new StringBuilder(400);
        Timer refreshTimer = new Timer();
        public frmSAT()
        {
            InitializeComponent();
        }


        private void frmSAT_Load(object sender, EventArgs e)
        {
            
            refreshTimer.Interval = 10000;  //10 segundos em milisegundos
            refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            refreshTimer.Start();

        }

        private void refreshForm()
        {
            strPingInfo.Clear();
            string[] HostNames = File.ReadAllLines(@"C:\Users\USUARIO\Downloads\Imagens\sat.txt", Encoding.UTF8);
            foreach (string HostName in HostNames)
            {
                if (HostName != "")
                {
                    strPingInfo.Append(PingReply(HostName));
                    strPingInfo.Append("---------------------------------------------------\r\n\r\n");
                }
            }
            tbPingReply.Text = strPingInfo.ToString();
        }
        public string PingReply(string inHostName)
        {
            StringBuilder strReply = new StringBuilder(200);
            Ping p1 = new Ping();
            try
            {
                PingReply reply = p1.Send(inHostName);
                if (reply.Status == IPStatus.Success)
                {
                    strReply.AppendFormat("Hostname: {0} \r", inHostName);
                    strReply.AppendFormat("Endereço IP: {0} \r", reply.Address.ToString());
                    strReply.AppendFormat("Time: {0} ms \r", reply.RoundtripTime);
                    strReply.AppendFormat("TTL: {0} \r", reply.Options == null ? "" : reply.Options.Ttl.ToString());
                    strReply.AppendFormat("Don't fragment: {0} \r", reply.Options == null ? "" : reply.Options.DontFragment.ToString());
                    strReply.AppendFormat("Bytes: {0} \r\n", reply.Buffer.Length);
                    lblServ1.Text = "ON";
                    lblServ1.BackColor = Color.ForestGreen;
                }
                else if (reply.Status == IPStatus.TimedOut)
                {
                    strReply.AppendFormat("Hostname: {0} \r", inHostName);
                    strReply.Append("Notice: Request timed out \r");
                    lblServ1.Text = "OFF";
                    lblServ1.BackColor = Color.Red;
                }
            }
            
            catch (Exception ex)
            {
                strReply.Clear();
                strReply.AppendFormat("Hostname: {0} \r", inHostName);
                strReply.AppendFormat("Erro: {0} \r", ex.Message);
                lblServ1.Text = "OFF";
                lblServ1.BackColor = Color.Red;
            }

            return strReply.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            refreshForm();
        }
    }
}

