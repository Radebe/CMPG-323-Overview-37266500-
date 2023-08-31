using System;
using System.Collections.Generic;

namespace Cmpg323_Project_2.Models;

public partial class Order
{
    public short OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public short CustomerId { get; set; }

    public string? DeliveryAddress { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
