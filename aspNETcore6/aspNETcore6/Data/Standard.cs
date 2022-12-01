using System.ComponentModel.DataAnnotations;

namespace aspNETcore6.Data
{
    public class Standard
    {
        public int Id { get; set; }
        public int StandardId { get; set; }
        public int StandardBId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Boss> Bosss { get; set; }
    }
}
