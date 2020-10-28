using System;

namespace WebApi.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Base64 { get; set; }
    }
}