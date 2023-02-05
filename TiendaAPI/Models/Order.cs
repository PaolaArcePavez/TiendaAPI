using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TiendaAPI.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        public int UserId { get; set; }

        [Column(TypeName = "int")]
        public int PrductId { get; set; }

        [Column(TypeName = "int")]
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }


        public virtual ICollection<Product>? Products { get; set; }

        public virtual ICollection<User>? Users { get; set; }
    }
}
