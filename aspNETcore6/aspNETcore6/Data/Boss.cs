using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspNETcore6.Data
{
    public class Boss
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentID { get; set; }
        public int DiemSo { get; set; }

        [ForeignKey("Standard")]
        public int StandardBId { get; set; }
        public Standard Standard { get; set; }
    }
}
