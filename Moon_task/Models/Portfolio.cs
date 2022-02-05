namespace Moon_task.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
