using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TiendaAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]

        [Column(TypeName = "int")]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? SurName { get; set; }


    }
}
