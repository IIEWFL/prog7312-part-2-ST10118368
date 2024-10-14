using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CityCharm
{
    internal class Announcements
    {
        public Announcements(string description, string category, DateTime date)
        {
            this.description = description;
            this.category = category;
            this.date = date;
        }

        public string description { get; set; }
        public string category { get; set; }
        public DateTime date { get; set; }

        public String GetAnnouncement()
        {
            return description + "\t\t\t" + category + "\t\t\t\t" + date.ToShortDateString();
        }
    }
}
