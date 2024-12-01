namespace eDziennik.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Value { get; set; }
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }
    }
}
