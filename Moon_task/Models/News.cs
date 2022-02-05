using System;

namespace Moon_task.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Comments { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
    }
}
