using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityCharm
{
    public partial class EventsAnnouncementForm : Form
    {
        //Creating Queues
        Queue<Events> eventsQueue = new Queue<Events>();
        Queue<Announcements> announcementsQueue = new Queue<Announcements>();

        //Create a HashSet for categories
        HashSet<string> categories = new HashSet<string>();
        //Create a HashSet for dates
        HashSet<DateTime> uniqueDates = new HashSet<DateTime>();

        //Create a HashSet for populating Events
        Hashtable hashEventsTable = new Hashtable();
        //Create a HashSet for populating Announcements
        Hashtable hashAnnouncementsTable = new Hashtable();

        public EventsAnnouncementForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<SearchQuery> queries = eventLogger.GetSearchQueries();
            SearchAnalyzer analyzer = new SearchAnalyzer();
            var frequencies = analyzer.GetSearchFrequencies(queries);

            String recommend = "";

            //Reccomended Events and Announcements
            foreach (var searches in frequencies)
            {
                MessageBox.Show($"Recommend Events and Announcements: \n{searches.Key}", "Recommendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //recommend = recommend + $"\n{searches.Key}";
                //Console.WriteLine($"{searches.Key}: {searches.Value}");
            }


            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        //Declearing Event variables
        Events event1;
        Events event2;
        Events event3;
        Events event4;

        //Declearing Announcement variables
        Announcements announcement1;
        Announcements announcement2;
        Announcements announcement3;

        private void EventsAnnouncementForm_Load(object sender, EventArgs e)
        {
            //Adding categories
            categories.Add("Sport");
            categories.Add("Arts");
            categories.Add("Sanitation");
            categories.Add("Roads");
            categories.Add("Utilities");

            // Adding dates
            uniqueDates.Add(new DateTime(2024, 10, 14));
            uniqueDates.Add(new DateTime(2024, 10, 15));
            uniqueDates.Add(new DateTime(2024, 10, 19));
            uniqueDates.Add(new DateTime(2024, 10, 18));
            uniqueDates.Add(new DateTime(2024, 10, 26));
            uniqueDates.Add(new DateTime(2024, 11, 02));

            //Create Event
            event1 = new Events("Tswane 5km run", "Hatfield", categories.ElementAtOrDefault(0), uniqueDates.ElementAtOrDefault(3));
            event2 = new Events("Fund raiser", "Lynnwood", categories.ElementAtOrDefault(1), uniqueDates.ElementAtOrDefault(2));
            event3 = new Events("Night Market", "Hazelwood", categories.ElementAtOrDefault(1), uniqueDates.ElementAtOrDefault(4));
            event4 = new Events("East Marathon", "Menlyn", categories.First(), uniqueDates.First());

            //Create Announcement
            announcement1 = new Announcements("Low water pressure in Sunny Side & nearby", categories.Last(), uniqueDates.ElementAtOrDefault(0));
            announcement2 = new Announcements("Garbage truck late due to strike (Menlo Park)", categories.ElementAtOrDefault(2), uniqueDates.First());
            announcement3 = new Announcements("Road works @ Steve Biko Rd (PTA Central)", categories.ElementAtOrDefault(3), uniqueDates.Last());
            
            //Enqueue events onto the queue
            eventsQueue.Enqueue(event1);
            eventsQueue.Enqueue(event2);
            eventsQueue.Enqueue(event3);
            eventsQueue.Enqueue(event4);

            //Enqueue announcements onto the queue
            announcementsQueue.Enqueue(announcement1);
            announcementsQueue.Enqueue(announcement2);
            announcementsQueue.Enqueue(announcement3);

            //Adding events into hashtable
            hashEventsTable.Add("Event1", eventsQueue.Dequeue().GetEvent());
            hashEventsTable.Add("Event2", eventsQueue.Dequeue().GetEvent());
            hashEventsTable.Add("Event3", eventsQueue.Dequeue().GetEvent());
            hashEventsTable.Add("Event4", eventsQueue.Dequeue().GetEvent());

            //Adding announcements into hashtable
            hashAnnouncementsTable.Add("Announcement1", announcementsQueue.Dequeue().GetAnnouncement());
            hashAnnouncementsTable.Add("Announcement2", announcementsQueue.Dequeue().GetAnnouncement());
            hashAnnouncementsTable.Add("Announcement3", announcementsQueue.Dequeue().GetAnnouncement());

            //Populating Events list
            lstEvents.Items.Add("Name \t\t\t\tLocation \t\t\t\tCategory \t\t\t\tDate");
            lstEvents.Items.Add("==================================================================================================================================");
            try
            {
                foreach (DictionaryEntry entry in hashEventsTable)
                {
                    //Console.WriteLine($"{entry.Key}: {entry.Value}");
                    lstEvents.Items.Add(entry.Value);
                }
                //lstEvents.Items.Add(eventsQueue.Dequeue().GetEvent());
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex);
            }

            //Populating Announcements list
            lstAnnouncements.Items.Add("Description \t\t\t\t\t\t\tCategory \t\t\t\tDate");
            lstAnnouncements.Items.Add("==================================================================================================================================");
            try
            {
                foreach (DictionaryEntry entry in hashAnnouncementsTable)
                {
                    //Console.WriteLine($"{entry.Key}: {entry.Value}");
                    lstAnnouncements.Items.Add(entry.Value);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            List<SearchQuery> queries = eventLogger.GetSearchQueries();
            SearchAnalyzer analyzer = new SearchAnalyzer();
            var frequencies = analyzer.GetSearchFrequencies(queries);

            String recommend = "";

            //Reccomended Events and Announcements
            foreach (var searches in frequencies)
            {
                MessageBox.Show($"Recommend Events and Announcements: \n{searches.Key}", "Recommendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            this.Close();
        }

        SearchLogger eventLogger = new SearchLogger();

        private void btnEventSearch_Click(object sender, EventArgs e)
        {

            hashEventsTable.Clear();

            eventLogger.LogSearchQuery("user1", cmbEventSearch.Text);
            eventLogger.LogSearchQuery("user1", dpEventSearch.Value.ToShortDateString());

            List<SearchQuery> queries = eventLogger.GetSearchQueries();
            SearchAnalyzer analyzer = new SearchAnalyzer();
            var eventFrequencies = analyzer.GetSearchFrequencies(queries);

            //Fetching events searched by category
            if (event1.category.Contains(cmbEventSearch.Text))
            {
                eventsQueue.Enqueue(event1);
                hashEventsTable.Add("Event1", eventsQueue.Dequeue().GetEvent());
            }
            if (event2.category == cmbEventSearch.Text)
            {
                eventsQueue.Enqueue(event2);
                hashEventsTable.Add("Event2", eventsQueue.Dequeue().GetEvent());
            }
            if (event3.category == cmbEventSearch.Text)
            {
                eventsQueue.Enqueue(event3);
                hashEventsTable.Add("Event3", eventsQueue.Dequeue().GetEvent());
            }
            if (event4.category == cmbEventSearch.Text)
            {
                eventsQueue.Enqueue(event4);
                hashEventsTable.Add("Event4", eventsQueue.Dequeue().GetEvent());
            }

            //Fetching events searched by category
            if (event1.date.Equals(dpEventSearch))
            {
                eventsQueue.Enqueue(event1);
                hashEventsTable.Add("Event1", eventsQueue.Dequeue().GetEvent());
            }
            if (event2.date.Equals(dpEventSearch))
            {
                eventsQueue.Enqueue(event2);
                hashEventsTable.Add("Event2", eventsQueue.Dequeue().GetEvent());
            }
            if (event3.date.Equals(dpEventSearch))
            {
                eventsQueue.Enqueue(event3);
                hashEventsTable.Add("Event3", eventsQueue.Dequeue().GetEvent());
            }
            if (event4.date.Equals(dpEventSearch))
            {
                eventsQueue.Enqueue(event4);
                hashEventsTable.Add("Event4", eventsQueue.Dequeue().GetEvent());
            }

            if (hashEventsTable.Count > 0) 
            {
                //Populating searched Events list
                lstEvents.Items.Clear();
                lstEvents.Items.Add("Name \t\t\t\tLocation \t\t\t\tCategory \t\t\t\tDate");
                lstEvents.Items.Add("==================================================================================================================================");
                try
                {
                    foreach (DictionaryEntry entry in hashEventsTable)
                    {
                        lstEvents.Items.Add(entry.Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

        }

        private void btnAnnouncementSearch_Click(object sender, EventArgs e)
        {
            hashAnnouncementsTable.Clear();

            eventLogger.LogSearchQuery("user1", cmbAnnouncementSearch.Text);
            eventLogger.LogSearchQuery("user1", dpAnnouncementSearch.Value.ToShortDateString());

            List<SearchQuery> queries = eventLogger.GetSearchQueries();
            SearchAnalyzer analyzer = new SearchAnalyzer();
            var announcementFrequencies = analyzer.GetSearchFrequencies(queries);

            //Fetching announcements searched by category
            if (announcement1.category == cmbAnnouncementSearch.Text)
            {
                announcementsQueue.Enqueue(announcement1);
                hashAnnouncementsTable.Add("Announcement1", announcementsQueue.Dequeue().GetAnnouncement());
            }
            if (announcement2.category == cmbAnnouncementSearch.Text)
            {
                announcementsQueue.Enqueue(announcement2);
                hashAnnouncementsTable.Add("Announcement2", announcementsQueue.Dequeue().GetAnnouncement());
            }
            if (announcement3.category == cmbAnnouncementSearch.Text)
            {
                announcementsQueue.Enqueue(announcement3);
                hashAnnouncementsTable.Add("Announcement3", announcementsQueue.Dequeue().GetAnnouncement());
            }

            //Fetching announcement searched by date
            if (announcement1.date.Equals(dpAnnouncementSearch))
            {
                announcementsQueue.Enqueue(announcement1);
                hashAnnouncementsTable.Add("Announcement1", announcementsQueue.Dequeue().GetAnnouncement());
            }
            if (announcement2.date.Equals(dpAnnouncementSearch))
            {
                announcementsQueue.Enqueue(announcement2);
                hashAnnouncementsTable.Add("Announcement2", announcementsQueue.Dequeue().GetAnnouncement());
            }
            if (announcement3.date.Equals(dpAnnouncementSearch))
            {
                announcementsQueue.Enqueue(announcement3);
                hashAnnouncementsTable.Add("Announcement3", announcementsQueue.Dequeue().GetAnnouncement());
            }

            if (hashAnnouncementsTable.Count > 0)
            {
                //Populating searched Announcements list
                lstAnnouncements.Items.Clear();
                lstAnnouncements.Items.Add("Description \t\t\t\t\t\t\tCategory \t\t\t\tDate");
                lstAnnouncements.Items.Add("==================================================================================================================================");
                try
                {
                    foreach (DictionaryEntry entry in hashAnnouncementsTable)
                    {
                        lstAnnouncements.Items.Add(entry.Value);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }
    }
}
