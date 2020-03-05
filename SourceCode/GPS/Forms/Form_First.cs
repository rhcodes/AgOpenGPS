﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class Form_First : Form
    {
        public Form_First()
        {
            InitializeComponent();
        }

        private void LinkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void LinkLabelCombineForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Form_About_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Application.ProductVersion.ToString(CultureInfo.InvariantCulture);

            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link { LinkData = "https://github.com/farmerbriantee/AgOpenGPS" };
            linkLabelGit.Links.Add(link);

            // Add a link to the LinkLabel.
            LinkLabel.Link linkCf = new LinkLabel.Link
            {
                LinkData = "https://agopengps.discourse.group/"
            };
            linkLabelCombineForum.Links.Add(linkCf);

            cboxStart.Checked = Properties.Settings.Default.setDisplay_isTermsOn;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsOn = cboxStart.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setDisplay_isTermsOn = true;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}