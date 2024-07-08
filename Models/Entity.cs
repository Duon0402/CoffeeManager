using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeManager.Models
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CreateId { get; set; }
        public DateTime CreateAt { get; set; }

        public int? UpdateId { get; set; }
        public DateTime? UpdateAt { get; set; }

        public int? DeleteId { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
