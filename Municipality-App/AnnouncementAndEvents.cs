using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Municipality_App
{
    public partial class AnnouncementAndEvents : Form
    {
        private SortedDictionary<DateTime, List<MunicipalEvent>> events = new SortedDictionary<DateTime, List<MunicipalEvent>>();
        private Stack<SearchCriteria> searchHistory = new Stack<SearchCriteria>();
        private Queue<MunicipalEvent> upcomingEventsQueue = new Queue<MunicipalEvent>();
        private SortedSet<MunicipalEvent> priorityQueue = new SortedSet<MunicipalEvent>(new EventPriorityComparer());
        private Dictionary<string, int> categorySearchCount = new Dictionary<string, int>();
        private Dictionary<string, int> keywordSearchCount = new Dictionary<string, int>();

        public AnnouncementAndEvents()
        {
            InitializeComponent();
            PopulateEvents();
            LoadCategories();
            LoadEvents();
        }

        private void PopulateEvents()
        {
            var events = new List<MunicipalEvent>
    {
        new MunicipalEvent { Title = "Local Concert", Date = DateTime.Now.AddDays(2), Category = "Music", Description = "Enjoy live music.", Priority = 2 },
        new MunicipalEvent { Title = "Art Exhibition", Date = DateTime.Now.AddDays(3), Category = "Art", Description = "Explore local art.", Priority = 1 },
        new MunicipalEvent { Title = "Tech Conference", Date = DateTime.Now.AddDays(4), Category = "Tech", Description = "Latest tech trends.", Priority = 3 },
        new MunicipalEvent { Title = "Food Festival", Date = DateTime.Now.AddDays(5), Category = "Food", Description = "Taste various cuisines.", Priority = 2 },
        new MunicipalEvent { Title = "Business Expo", Date = DateTime.Now.AddDays(6), Category = "Business", Description = "Showcasing local businesses.", Priority = 1 },
        new MunicipalEvent { Title = "Film Screening", Date = DateTime.Now.AddDays(7), Category = "Film", Description = "Watch award-winning films.", Priority = 2 },
        new MunicipalEvent { Title = "Charity Run", Date = DateTime.Now.AddDays(8), Category = "Sports", Description = "Join us for a good cause.", Priority = 3 },
        new MunicipalEvent { Title = "Craft Fair", Date = DateTime.Now.AddDays(9), Category = "Arts & Crafts", Description = "Local artisans showcase their work.", Priority = 1 },
        new MunicipalEvent { Title = "Food Truck Rally", Date = DateTime.Now.AddDays(10), Category = "Food", Description = "Enjoy food from various trucks.", Priority = 2 },
        new MunicipalEvent { Title = "Community Yoga", Date = DateTime.Now.AddDays(11), Category = "Health", Description = "Free yoga session in the park.", Priority = 1 },
        new MunicipalEvent { Title = "Wine Tasting", Date = DateTime.Now.AddDays(12), Category = "Food & Drink", Description = "Sample local wines.", Priority = 2 },
        new MunicipalEvent { Title = "Book Fair", Date = DateTime.Now.AddDays(13), Category = "Literature", Description = "Meet local authors and buy books.", Priority = 1 },
        new MunicipalEvent { Title = "Halloween Party", Date = DateTime.Now.AddDays(14), Category = "Holiday", Description = "Spooky fun for everyone.", Priority = 3 },
        new MunicipalEvent { Title = "Local Theater Play", Date = DateTime.Now.AddDays(15), Category = "Theater", Description = "Watch a captivating local play.", Priority = 2 },
        new MunicipalEvent { Title = "Photography Workshop", Date = DateTime.Now.AddDays(16), Category = "Education", Description = "Improve your photography skills.", Priority = 1 },
        new MunicipalEvent { Title = "Music Festival", Date = DateTime.Now.AddDays(17), Category = "Music", Description = "Live music from various artists.", Priority = 3 },
        new MunicipalEvent { Title = "Pet Adoption Day", Date = DateTime.Now.AddDays(18), Category = "Community", Description = "Find your new furry friend.", Priority = 2 },
        new MunicipalEvent { Title = "Cultural Dance Showcase", Date = DateTime.Now.AddDays(19), Category = "Culture", Description = "Enjoy various dance performances.", Priority = 1 },
        new MunicipalEvent { Title = "Science Fair", Date = DateTime.Now.AddDays(20), Category = "Education", Description = "Explore innovative projects.", Priority = 2 },
        new MunicipalEvent { Title = "Brewery Tour", Date = DateTime.Now.AddDays(21), Category = "Food & Drink", Description = "Tour and taste local beers.", Priority = 1 },
        new MunicipalEvent { Title = "Annual Thanksgiving Feast", Date = DateTime.Now.AddDays(22), Category = "Holiday", Description = "Join us for a community feast.", Priority = 3 },
        new MunicipalEvent { Title = "Kids Science Workshop", Date = DateTime.Now.AddDays(23), Category = "Education", Description = "Fun science experiments for kids.", Priority = 2 },
        new MunicipalEvent { Title = "Football Match", Date = DateTime.Now.AddDays(24), Category = "Sports", Description = "Local teams face off.", Priority = 1 },
        new MunicipalEvent { Title = "Cooking Class", Date = DateTime.Now.AddDays(25), Category = "Food", Description = "Learn to cook new recipes.", Priority = 2 },
        new MunicipalEvent { Title = "Tech Hackathon", Date = DateTime.Now.AddDays(26), Category = "Tech", Description = "Join us for a 24-hour hackathon.", Priority = 3 },
        new MunicipalEvent { Title = "Community Garden Day", Date = DateTime.Now.AddDays(27), Category = "Community", Description = "Help beautify our community garden.", Priority = 2 },
        new MunicipalEvent { Title = "Seasonal Market", Date = DateTime.Now.AddDays(28), Category = "Market", Description = "Local vendors sell their goods.", Priority = 1 },
        new MunicipalEvent { Title = "Thanksgiving Parade", Date = DateTime.Now.AddDays(29), Category = "Holiday", Description = "Celebrate the season with a parade.", Priority = 3 },
        new MunicipalEvent { Title = "Christmas Crafting Workshop", Date = DateTime.Now.AddDays(30), Category = "Arts & Crafts", Description = "Create handmade holiday gifts.", Priority = 2 },
        new MunicipalEvent { Title = "New Year's Eve Celebration", Date = DateTime.Now.AddDays(31), Category = "Holiday", Description = "Ring in the new year with fireworks.", Priority = 1 },
        new MunicipalEvent { Title = "Local Band Night", Date = DateTime.Now.AddDays(32), Category = "Music", Description = "Support local bands.", Priority = 2 },
        new MunicipalEvent { Title = "Yoga Retreat", Date = DateTime.Now.AddDays(33), Category = "Health", Description = "Relax and rejuvenate.", Priority = 1 },
        new MunicipalEvent { Title = "Photography Exhibition", Date = DateTime.Now.AddDays(34), Category = "Art", Description = "Showcasing local photographers.", Priority = 2 },
        new MunicipalEvent { Title = "Outdoor Movie Night", Date = DateTime.Now.AddDays(35), Category = "Film", Description = "Enjoy a movie under the stars.", Priority = 3 },
        new MunicipalEvent { Title = "Sustainable Living Workshop", Date = DateTime.Now.AddDays(36), Category = "Education", Description = "Learn about sustainable practices.", Priority = 1 },
        new MunicipalEvent { Title = "Open Mic Night", Date = DateTime.Now.AddDays(37), Category = "Music", Description = "Showcase your talent!", Priority = 2 },
        new MunicipalEvent { Title = "Local Authors Reading", Date = DateTime.Now.AddDays(38), Category = "Literature", Description = "Meet local authors and hear their works.", Priority = 1 }
    };

            foreach (var ev in events)
            {
                AddEvent(ev);
            }
        }


        private void AddEvent(MunicipalEvent e)
        {
            if (!events.ContainsKey(e.Date.Date))
            {
                events[e.Date.Date] = new List<MunicipalEvent>();
            }
            events[e.Date.Date].Add(e);
            priorityQueue.Add(e);
        }

        private void LoadCategories()
        {
            HashSet<string> categories = new HashSet<string>();
            foreach (var eventList in events.Values)
            {
                foreach (var e in eventList)
                {
                    categories.Add(e.Category);
                }
            }
            comboBoxCategories.DataSource = categories.ToList();
        }

        private void LoadEvents()
        {
            var allEvents = events.SelectMany(kvp => kvp.Value).ToList();
            foreach (var ev in allEvents)
            {
                upcomingEventsQueue.Enqueue(ev);
            }
            dataGridView.DataSource = allEvents;
        }

        private void SearchEvents(string searchTerm, string selectedCategory, DateTime? selectedDate)
        {
            searchHistory.Push(new SearchCriteria
            {
                SearchTerm = searchTerm,
                SelectedCategory = selectedCategory,
                SelectedDate = selectedDate
            });

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                if (categorySearchCount.ContainsKey(selectedCategory))
                    categorySearchCount[selectedCategory]++;
                else
                    categorySearchCount[selectedCategory] = 1;
            }

            // if (!keywordSearchCount.ContainsKey(keyword)) { keywordSearchCount[keyword] = 0; }
            // keywordSearchCount[keyword]++;
            if (!string.IsNullOrEmpty(searchTerm))
            {
                if (keywordSearchCount.ContainsKey(searchTerm))
                    keywordSearchCount[searchTerm]++;
                else
                    keywordSearchCount[searchTerm] = 1;
            }

            var filteredEvents = events.SelectMany(kvp => kvp.Value)
                .Where(e =>
                    (string.IsNullOrEmpty(searchTerm) || e.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(selectedCategory) || e.Category == selectedCategory) &&
                    (!selectedDate.HasValue || e.Date.Date == selectedDate.Value.Date)
                ).ToList();

            dataGridView.DataSource = filteredEvents;

            if (filteredEvents.Count == 0)
            {
                MessageBox.Show("No events found matching your criteria.");
            }
           
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            string selectedCategory = comboBoxCategories.SelectedItem?.ToString();
            DateTime? selectedDate = checkBoxUseDate.Checked ? (DateTime?)dateTimePicker.Value.Date : null;
            SearchEvents(searchTerm, selectedCategory, selectedDate);
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxCategories.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Today;
            checkBoxUseDate.Checked = false;
            LoadEvents();
        }

        private void buttonUndoSearch_Click(object sender, EventArgs e)
        {
            if (searchHistory.Count > 0)
            {
                var lastSearch = searchHistory.Pop();
                textBoxSearch.Text = lastSearch.SearchTerm;
                comboBoxCategories.SelectedItem = lastSearch.SelectedCategory;
                if (lastSearch.SelectedDate.HasValue)
                {
                    dateTimePicker.Value = lastSearch.SelectedDate.Value;
                    checkBoxUseDate.Checked = true;
                }
                else
                {
                    dateTimePicker.Value = DateTime.Today;
                    checkBoxUseDate.Checked = false;
                }

                SearchEvents(lastSearch.SearchTerm, lastSearch.SelectedCategory, lastSearch.SelectedDate);
            }
        }

        private void buttonShowNextEvent_Click(object sender, EventArgs e)
        {
            if (upcomingEventsQueue.Count > 0)
            {
                var nextEvent = upcomingEventsQueue.Dequeue();
                MessageBox.Show($"Next Event: {nextEvent.Title} on {nextEvent.Date.ToShortDateString()}");
            }
            else
            {
                MessageBox.Show("No more upcoming events.");
            }
        }

        private void buttonShowTopPriorityEvent_Click(object sender, EventArgs e)
        {
            if (priorityQueue.Count > 0)
            {
                var topEvent = priorityQueue.First();
                MessageBox.Show($"Top Priority Event: {topEvent.Title} with priority {topEvent.Priority}");
            }
            else
            {
                MessageBox.Show("No events in priority queue.");
            }
        }

        private void Recommendation_button_Click(object sender, EventArgs e)
        {
            RecommendEvents();
        }

        private void RecommendEvents()
        {
            if (categorySearchCount.Count == 0 && keywordSearchCount.Count == 0)
            {
                MessageBox.Show("No search history available for recommendations.");
                return;
            }

            var topCategory = categorySearchCount.OrderByDescending(c => c.Value).FirstOrDefault().Key;
            var topKeyword = keywordSearchCount.OrderByDescending(k => k.Value).FirstOrDefault().Key;

            var recommendedEvents = events.SelectMany(kvp => kvp.Value)
                .Where(e => e.Category == topCategory || (topKeyword != null && e.Title.IndexOf(topKeyword, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();

            if (recommendedEvents.Count > 0)
            {
                string recommendations = string.Join("\n", recommendedEvents.Select(e => $"{e.Title} in Category: {e.Category} on {e.Date.ToShortDateString()}"));
                MessageBox.Show($"Recommended Events:\n{recommendations}");
            }
            else
            {
                MessageBox.Show("No recommendations available at this time.");
            }
        }
    }

    public class MunicipalEvent
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
    }

    public class EventPriorityComparer : IComparer<MunicipalEvent>
    {
        public int Compare(MunicipalEvent x, MunicipalEvent y)
        {
            int result = y.Priority.CompareTo(x.Priority);
            if (result == 0)
            {
                return x.Date.CompareTo(y.Date);
            }
            return result;
        }
    }

    public class SearchCriteria
    {
        public string SearchTerm { get; set; }
        public string SelectedCategory { get; set; }
        public DateTime? SelectedDate { get; set; }
    }
}
