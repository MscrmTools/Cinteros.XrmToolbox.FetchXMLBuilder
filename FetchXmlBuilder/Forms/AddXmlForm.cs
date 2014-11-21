﻿// PROJECT : MsCrmTools.SiteMapEditor
// This project was developed by Tanguy Touzard
// CODEPLEX: http://xrmtoolbox.codeplex.com
// BLOG: http://mscrmtools.blogspot.com

using System;
using System.Windows.Forms;
using System.Xml;

namespace Cinteros.Xrm.FetchXmlBuilder.Forms
{
    public partial class AddXmlForm : Form
    {
        public XmlNode AddedXmlNode { get; set; }

        public AddXmlForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(textBox1.Text);

                AddedXmlNode = doc.DocumentElement;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Error while parsing Xml: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddedXmlNode = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}