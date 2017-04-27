using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Net;
using System.IO;

namespace RSSReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*String url = "https://mercury.postlight.com/parser?url=http://www.time.mk/rss/all";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers["x-api-key"] = "10VfA3wcfsGHIwTQbzpS0LzNE6WX6AOQqPx0rO4S";

            request.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            richTextBox1.Text = reader.ReadToEnd();

            /*HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);*/
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String url = this.textBox1.Text;
            //List<SyndicationItem> lista = new List<SyndicationItem>();
            using (XmlReader reader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                //richTextBox1.Text = String.Format("Title: {0} \nURL: {1}\n", feed.Title.Text, feed.Links[0].Uri);
                //richTextBox1.Text += feed.Description + "\n";
                SyndicationItem item = feed.Items.ElementAt(0);
                foreach (SyndicationItem ajtem in feed.Items)
                {
                    listBox1.Items.Add(new Vest(ajtem));
                    //richTextBox1.Text += item.Title.Text + "\n";
                    //this.webBrowser1.DocumentText = item.Summary.Text;
                }
                
                /*sb.Append("Authors:" + elem.Authors + "\n");
                sb.Append("BaseUri:" + elem.BaseUri + "\n");
                sb.Append("Categories:" + elem.Categories + "\n");
                sb.Append("Content:" + elem.Content + "\n");
                sb.Append("Contributors:" + elem.Contributors + "\n");
                sb.Append("Links:" + elem.Links + "\n");
                sb.Append("SourceFeed:" + elem.SourceFeed + "\n");
                sb.Append("Categories:" + elem.Categories + "\n");
                sb.Append("LastUpdated:" + elem.LastUpdatedTime + "\n");
                sb.Append("PublishDate:" + elem.PublishDate + "\n");*/
                //richTextBox1.Text = sb.ToString();
                
                //webBrowser1.Navigate(elem.BaseUri.AbsoluteUri);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Vest i = (Vest) listBox1.Items[index];
            this.webBrowser1.DocumentText = i.getText();
        }
    }
}
