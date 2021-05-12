﻿using System;

namespace CQRSDemo.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime RealeaseDate { get; set; }
    }
}
