using Moon_task.Models;
using System.Collections.Generic;

namespace Moon_task.ViewModel
{
    public class HomeViewModel
    {
        public Jumborton jumborton { get; set; }
        public List<Counter> counter { get; set; }
        public List<WhoWeAre> whoWeAre { get; set; }
        public List<Feature> features { get; set; }
        public List<SocialMedia> socialMedias { get; set; }
        public List<News> news { get; set; }
        public List<Portfolio> portfolios { get; set; }
        public List<Category> categories { get; set; }
        public List<Pricing> pricings { get; set; }
        public List<Client> clients { get; set; }
    }
}
