﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Dal.Entites;

public class Cart
{
    [Key]
    public long CartId { get; set; }
    public long CustomerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public Customer Customer { get; set; }
    public List<CartProduct> CartProducts { get; set; }
}
