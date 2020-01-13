using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Duration { get; set; }
        public double Cost { get; set; }
        public string Service { get; set; }

        [ForeignKey("TourId")]
        public virtual ClientContract ClientContract { get; set; }
    }
}