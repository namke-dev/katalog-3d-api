using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace katalog_3d_api.entities
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("OfferedService")]
        public int OfferedServiceId { get; set; }
        public OfferedService? OfferedService { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}