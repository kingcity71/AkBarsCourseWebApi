using System;
using System.Collections.Generic;

namespace WebApi.Models{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public IEnumerable<Price> Prices { get; set; }
    }
}