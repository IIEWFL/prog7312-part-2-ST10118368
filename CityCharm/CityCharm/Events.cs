using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCharm
{
    internal class Events
    {
        public Events(string name, string location, string category, DateTime date)
        {
            this.name = name;
            this.location = location;
            this.category = category;
            this.date = date;
        }

        public string name { get; set; }
        public string location { get; set; }
        public string category { get; set; }
        public DateTime date { get; set; }

        public String GetEvent()
        {
            return name+ "\t\t\t" + location+ "\t\t\t\t" + category+ "\t\t\t\t" + date.ToShortDateString();
        }

    }
}
