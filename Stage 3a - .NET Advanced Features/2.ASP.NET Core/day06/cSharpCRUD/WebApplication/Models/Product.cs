﻿using System;
namespace ProductCrudList.Models
{
    public class Product
    {
        public Product()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
