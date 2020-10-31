using System;

namespace WebApi.Models
{
    public class Price
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public decimal ActualPrice { get; set; }
        public int SalePercent { get; set; }
    }
}