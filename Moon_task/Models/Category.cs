using System.Collections.Generic;

namespace Moon_task.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}
