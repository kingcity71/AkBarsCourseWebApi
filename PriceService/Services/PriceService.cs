using System;
using System.Collections.Generic;
using System.Linq;
using PriceService.Interfaces;

using WebApi.Models;

namespace PriceService.Services
{
    public class PriceService : IPriceService
    {
        private IEnumerable<Price> _prices = new[]
        {
                new Price
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{1B46B06C-98F9-4AC5-858B-9F5534A9C1CE}"),
                    ActualPrice = 11,
                    SalePercent = 11
                },
                new Price
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{1B46B06C-98F9-4AC5-858B-9F5534A9C1CE}"),
                    ActualPrice = 12,
                    SalePercent = 21
                },

                new Price
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{4715926E-E117-459F-9DA9-DF3F10EC4B2D}"),
                    ActualPrice = 21,
                    SalePercent = 12
                },
                new Price
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{4715926E-E117-459F-9DA9-DF3F10EC4B2D}"),
                    ActualPrice = 22,
                    SalePercent = 22
                },

                new Price
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{5641954D-BD76-45FE-8CA5-07734ADD66DD}"),
                    ActualPrice = 31,
                    SalePercent = 13
                },
                new Price
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.Parse("{5641954D-BD76-45FE-8CA5-07734ADD66DD}"),
                    ActualPrice = 32,
                    SalePercent = 23

                }
        };
        public IEnumerable<Price> GetAll()
            => _prices;
        public IEnumerable<Price> GetPricesByProductId(Guid productId)
            => _prices
                .Where(price => price.ProductId == productId)
                .ToList();
    }
}