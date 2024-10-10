using Swashbuckle.AspNetCore.Annotations;

namespace api.Dtos.Stock
{
    [SwaggerSchema(Description = "Represents stock details including company and market information")]
    public class StockDto
    {
        [SwaggerSchema(Description = "The unique identifier for the stock", ReadOnly = true)]
        public int Id { get; set; }

        [SwaggerSchema(Description = "The stock symbol of the company")]
        public string Symbol { get; set; } = string.Empty;

        [SwaggerSchema(Description = "The name of the company", Format = "string")]
        public string CompanyName { get; set; } = string.Empty;

        [SwaggerSchema(Description = "The purchase price of the stock", Format = "decimal")]
        public decimal Purchase { get; set; }

        [SwaggerSchema(Description = "The last dividend payout for the stock", Format = "decimal")]
        public decimal LastDiv { get; set; }

        [SwaggerSchema(Description = "The industry the company operates in")]
        public string Industry { get; set; } = string.Empty;

        [SwaggerSchema(Description = "The market capitalization of the company in USD", Format = "long")]
        public long MarketCap { get; set; }
    }
}
