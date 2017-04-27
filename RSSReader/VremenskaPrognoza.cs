using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Xml;
using System.IO;

namespace RSSReader
{
    public partial class VremenskaPrognoza : Form
    {
        public VremenskaPrognoza()
        {
            InitializeComponent();
        }

        private const string API_KEY = "c0d65c472a9f9cb837000de7e2f31522";


        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "q=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "q=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;


        private void btnConditions_Click(object sender, EventArgs e)
        {

            string url = CurrentUrl.Replace("@LOC@", tbLokacija.Text);
            tbXML.Text = GetFormattedXml(url);
        }


        private void btnForecast_Click(object sender, EventArgs e)
        {

            string url = ForecastUrl.Replace("@LOC@", tbLokacija.Text);
            tbXML.Text = GetFormattedXml(url);
        }


        private string GetFormattedXml(string url)
        {

            using (WebClient client = new WebClient())
            {

                string xml = client.DownloadString(url);


                XmlDocument xml_document = new XmlDocument();
                xml_document.LoadXml(xml);


                using (StringWriter string_writer = new StringWriter())
                {
                    XmlTextWriter xml_text_writer = new XmlTextWriter(string_writer);
                    xml_text_writer.Formatting = Formatting.Indented;
                    xml_document.WriteTo(xml_text_writer);


                    return string_writer.ToString();
                }
            }
        }
    }
}
