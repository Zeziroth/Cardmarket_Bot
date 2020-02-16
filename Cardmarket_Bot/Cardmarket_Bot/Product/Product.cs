using Cardmarket_Bot.General;
using System.Collections.Generic;

namespace Cardmarket_Bot.Product
{
    public class Product
    {
        public int idProduct { get; set; }
        public int idMetaproduct { get; set; }
        public int countReprints { get; set; }
        public string enName { get; set; }
        public string locName { get; set; }
        public List<Localization> localization { get; set; }
        public string website { get; set; }
        public string image { get; set; }
        public string gameName { get; set; }
        public string categoryName { get; set; }
        public int idGame { get; set; }
        public string number { get; set; }
        public string rarity { get; set; }
        public Expansion.Expansion expansion { get; set; }
        public PriceGuide priceGuide { get; set; }
        public int countArticles { get; set; }
        public int countFoils { get; set; }
        public List<Link> links { get; set; }
    }
}
