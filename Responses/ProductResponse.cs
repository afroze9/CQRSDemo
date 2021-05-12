﻿using System;

namespace CQRSDemo.Responses
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime RealeaseDate { get; set; }
    }
}
