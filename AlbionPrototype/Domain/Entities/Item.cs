using Refit;

namespace Domain.Entities
{
    public class Item
    {
        [AliasAs("item_id")]
        public string ItemId { get; set; }

        [AliasAs("city")]
        public string City { get; set; }

        [AliasAs("quality")]
        public int Quality { get; set; }

        [AliasAs("sell_price_min")]
        public int SellPriceMin { get; set; }

        [AliasAs("sell_price_min_date")]
        public DateTime SellPriceMinDate { get; set; }

        [AliasAs("sell_price_max")]
        public int SellPriceMax { get; set; }

        [AliasAs("sell_price_max_date")]
        public DateTime SellPriceMaxDate { get; set; }

        [AliasAs("buy_price_min")]
        public int BuyPriceMin { get; set; }

        [AliasAs("buy_price_min_date")]
        public DateTime BuyPriceMinDate { get; set; }

        [AliasAs("buy_price_max")]
        public int BuyPriceMax { get; set; }

        [AliasAs("buy_price_max_date")]
        public DateTime BuyPriceMaxDate { get; set; }
    }
}
