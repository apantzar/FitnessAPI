namespace FitnessAPI.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } // Foreign key reference
        public string Type { get; set; }
        public double Distance { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
