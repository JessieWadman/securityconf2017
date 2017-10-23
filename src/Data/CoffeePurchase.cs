using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlatPlanetCafe.Data
{
    [Table("CoffeeCups")]
    public class CoffeePurchase
    {
        [Key]
        [Required]
        [MaxLength(450)]
        public string UserId { get; set; }

        public int Purchases { get; set; }
    }
}
