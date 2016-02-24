using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using Utils;
using System.Drawing;

namespace SlackBot_Controller
{
    public partial class frmMain : Form
    {
        string _defIcon = "https://slack-assets2.s3-us-west-2.amazonaws.com/10068/img/slackbot_48.png";
        string _slackbotToken = "qwznV8JqU2kHW6feuFgQKgHr";

        public frmMain()
        {
            InitializeComponent();
            //this.Icon = GetIconFromUrl(_defIcon);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SlackClientAPI client = new SlackClientAPI();

            Arguments p = new Arguments();
            p.Channel = txtChannel.Text;
            p.As_User = chkAsUser.Checked ? "true" : "false";
            p.Username = txtUsername.Text;
            p.Text = txtData.Text;
            p.Token = txtToken.Text;
            p.UnfurlLinks = chkUnfurlLinks.Checked ? "true" : "false";
            p.UnfurlMedia = chkUnfurlMedia.Checked ? "true" : "false";
            if (IsValidUri(txtIcon.Text, false))
            {
                p.IconUrl = txtIcon.Text;
                this.Icon = GetIconFromUrl(txtIcon.Text);
            }
            
            //Attachment a = new Attachment();
            //a.Fallback = "some text";
            //a.Pretext = "some other text";
            //a.Color = "danger";

            //AttachmentFields af = new AttachmentFields();
            //af.Title = "Field 1";
            //af.Value = "Value 1";
            //af.Short = true;
            //a.Fields.Add(af);

            //AttachmentFields af2 = new AttachmentFields();
            //af2.Title = "Field 2";
            //af2.Value = "Value 2";
            //af2.Short = true;
            //a.Fields.Add(af2);

            //p.Attachments.Add(a);

            Response r = client.PostMessage(p);

            if (!r.Ok)
            {
                txtResponse.Text = r.Error;
            }
            else
            {
                txtResponse.Text = "ok";
            }
        }

        private void chkAsUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAsUser.Checked)
            {
                txtUsername.ReadOnly = true;
            }
            else
            {
                txtUsername.ReadOnly = false;
            }            
        }

        private void lnkToken_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.slack.com/web");
        }

        bool IsValidUri(string uriName, bool Https)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult);
            if (result && Https)
            {
                result = uriResult.Scheme == Uri.UriSchemeHttps;
            }
            return result;
        }

        private Icon GetIconFromUrl(string URL)
        {
            Bitmap bmp;
            WebClient Client = new WebClient();

            var imageData = Client.DownloadData(URL);
            using (var ms = new MemoryStream(imageData))
            {
                bmp = new Bitmap(ms);
            }
            return Icon.FromHandle(bmp.GetHicon());
        }

        private void btnIconReset_Click(object sender, EventArgs e)
        {
            txtIcon.Text = _defIcon;
        }

        private void btnSendSlackbot_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var url = string.Format("https://{0}.slack.com/services/hooks/slackbot?token={1}&channel={2}",
                    txtTeam.Text, _slackbotToken, txtChannel.Text.Replace("#","%23"));
                var response = client.UploadString(url, "POST", txtData.Text);
            }
        }

        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnSend.PerformClick();
            }
        }
    }
}
