﻿using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public required string Status { get; set; }

        // Foreign key to User
        public string UserId { get; set; }

        // Navigation property to User
        public User User { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

        public Order()
        {
            OrderProducts = new List<OrderProduct>();
        }
    }
}
