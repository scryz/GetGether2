namespace GetGether2.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string YearOfBirth { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
