using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yacell.StoreAPIs.Data.Entities
{
    public class OrderEntity
    {

        [Column("OrderID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption
    .Identity)]
        [Required]
        public int OrderID { get; set; }

        [Column("OrderDate")]
        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int CustomerID { get; set; }
    }
}
