namespace SlackBot_Controller
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.chkUnfurlLinks = new System.Windows.Forms.CheckBox();
            this.chkUnfurlMedia = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkAsUser = new System.Windows.Forms.CheckBox();
            this.lnkToken = new System.Windows.Forms.LinkLabel();
            this.btnSendSlackbot = new System.Windows.Forms.Button();
            this.btnIconReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTeam
            // 
            this.txtTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeam.Location = new System.Drawing.Point(76, 12);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(202, 20);
            this.txtTeam.TabIndex = 6;
            this.txtTeam.Text = "brocreed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team:";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(12, 41);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(41, 13);
            this.lblToken.TabIndex = 3;
            this.lblToken.Text = "Token:";
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Location = new System.Drawing.Point(76, 38);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(183, 20);
            this.txtToken.TabIndex = 7;
            this.txtToken.Text = "xoxp-8554073252-8553925216-9839542439-9a379c";
            this.txtToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 144);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(203, 263);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(76, 265);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(121, 20);
            this.txtResponse.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Response:";
            // 
            // txtChannel
            // 
            this.txtChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannel.Location = new System.Drawing.Point(76, 64);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(202, 20);
            this.txtChannel.TabIndex = 9;
            this.txtChannel.Text = "#the-bro-creed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Channel:";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Location = new System.Drawing.Point(76, 142);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(202, 94);
            this.txtData.TabIndex = 0;
            this.txtData.Text = "";
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Icon:";
            // 
            // txtIcon
            // 
            this.txtIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIcon.Location = new System.Drawing.Point(76, 90);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(150, 20);
            this.txtIcon.TabIndex = 10;
            this.txtIcon.Text = "https://cdn2.iconfinder.com/data/icons/botcons/100/android-bot-round-mag-ghost-vi" +
    "rus-light-48.png";
            // 
            // chkUnfurlLinks
            // 
            this.chkUnfurlLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUnfurlLinks.AutoSize = true;
            this.chkUnfurlLinks.Checked = true;
            this.chkUnfurlLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnfurlLinks.Location = new System.Drawing.Point(76, 242);
            this.chkUnfurlLinks.Name = "chkUnfurlLinks";
            this.chkUnfurlLinks.Size = new System.Drawing.Size(51, 17);
            this.chkUnfurlLinks.TabIndex = 1;
            this.chkUnfurlLinks.Text = "Links";
            this.chkUnfurlLinks.UseVisualStyleBackColor = true;
            // 
            // chkUnfurlMedia
            // 
            this.chkUnfurlMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUnfurlMedia.AutoSize = true;
            this.chkUnfurlMedia.Location = new System.Drawing.Point(133, 242);
            this.chkUnfurlMedia.Name = "chkUnfurlMedia";
            this.chkUnfurlMedia.Size = new System.Drawing.Size(55, 17);
            this.chkUnfurlMedia.TabIndex = 2;
            this.chkUnfurlMedia.Text = "Media";
            this.chkUnfurlMedia.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Unfurl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(76, 116);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(138, 20);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Text = "GhostBot";
            // 
            // chkAsUser
            // 
            this.chkAsUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAsUser.AutoSize = true;
            this.chkAsUser.Location = new System.Drawing.Point(220, 118);
            this.chkAsUser.Name = "chkAsUser";
            this.chkAsUser.Size = new System.Drawing.Size(63, 17);
            this.chkAsUser.TabIndex = 13;
            this.chkAsUser.Text = "As User";
            this.chkAsUser.UseVisualStyleBackColor = true;
            this.chkAsUser.CheckedChanged += new System.EventHandler(this.chkAsUser_CheckedChanged);
            // 
            // lnkToken
            // 
            this.lnkToken.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkToken.AutoSize = true;
            this.lnkToken.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkToken.LinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkToken.Location = new System.Drawing.Point(265, 41);
            this.lnkToken.Name = "lnkToken";
            this.lnkToken.Size = new System.Drawing.Size(13, 13);
            this.lnkToken.TabIndex = 8;
            this.lnkToken.TabStop = true;
            this.lnkToken.Text = "?";
            this.lnkToken.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.lnkToken.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkToken_LinkClicked);
            // 
            // btnSendSlackbot
            // 
            this.btnSendSlackbot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendSlackbot.Location = new System.Drawing.Point(203, 238);
            this.btnSendSlackbot.Name = "btnSendSlackbot";
            this.btnSendSlackbot.Size = new System.Drawing.Size(75, 23);
            this.btnSendSlackbot.TabIndex = 3;
            this.btnSendSlackbot.Text = "Slackbot";
            this.btnSendSlackbot.UseVisualStyleBackColor = true;
            this.btnSendSlackbot.Click += new System.EventHandler(this.btnSendSlackbot_Click);
            // 
            // btnIconReset
            // 
            this.btnIconReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconReset.Location = new System.Drawing.Point(232, 89);
            this.btnIconReset.Name = "btnIconReset";
            this.btnIconReset.Size = new System.Drawing.Size(46, 23);
            this.btnIconReset.TabIndex = 11;
            this.btnIconReset.Text = "Reset";
            this.btnIconReset.UseVisualStyleBackColor = true;
            this.btnIconReset.Click += new System.EventHandler(this.btnIconReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 292);
            this.Controls.Add(this.btnSendSlackbot);
            this.Controls.Add(this.btnIconReset);
            this.Controls.Add(this.lnkToken);
            this.Controls.Add(this.chkAsUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkUnfurlMedia);
            this.Controls.Add(this.chkUnfurlLinks);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SlackBot Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.CheckBox chkUnfurlLinks;
        private System.Windows.Forms.CheckBox chkUnfurlMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkAsUser;
        private System.Windows.Forms.LinkLabel lnkToken;
        private System.Windows.Forms.Button btnSendSlackbot;
        private System.Windows.Forms.Button btnIconReset;
    }
}

