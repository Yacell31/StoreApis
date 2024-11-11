using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yacell.StoreAPIs.Data.Entities
{
    [Table("Customers")]
    public class CustomerEntity
    {
        [Column("CustomerID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption
    .Identity)]
        [Required]
        public int CustomerID { get; set; }

        [Column("CustomerName")]
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

     
        public virtual List<OrderEntity> Orders { get; set; } 
    }
}
