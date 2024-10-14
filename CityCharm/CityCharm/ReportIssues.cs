using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCharm
{
    internal class ReportIssues
    {
        public string location { get; set; }
        public string category { get; set; }
        public string date { get; set; }
        public byte[] attachment { get; set; }
        public string description { get; set; }

        public ReportIssues(string location, string category, string date, byte[] attachment, string description)
        {
            this.location = location;
            this.category = category;
            this.date = date;
            this.attachment = attachment;
            this.description = description;
        }
    }
}
