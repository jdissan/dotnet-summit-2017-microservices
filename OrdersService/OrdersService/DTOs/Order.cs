﻿using System;
using System.Collections.Generic;

namespace OrdersService.DTOs
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}