namespace assignment3.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Products { get; set; }  // JSON or CSV for simplicity
        public string Quantities { get; set; }  // JSON or CSV for simplicity
    }
}