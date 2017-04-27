using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader
{
    public class Vest
    {
        private string Title { set; get; }
        private string Text { set; get; }
        private string URI { set; get; }
        private DateTimeOffset Date {set; get; }

        public Vest(System.ServiceModel.Syndication.SyndicationItem ajtem)
        {
            Title = ajtem.Title.Text;
            Text = ajtem.Summary.Text;
            Date = ajtem.PublishDate;
            URI = ajtem.Links[0].Uri.AbsoluteUri;
        }


        public override string ToString()
        {
            return Title;
        }

        internal string getText()
        {
            return Text;
        }
    }
}
