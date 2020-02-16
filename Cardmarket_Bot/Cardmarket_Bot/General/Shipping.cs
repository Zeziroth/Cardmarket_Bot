using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardmarket_Bot.General
{
    public class Shipping
    {
        public int MaxCount { get; private set; }
        public double MaxPrice { get; private set; }
        public double Price { get; private set; }
        public bool HasTracking { get; private set; }

        public Shipping(int _maxCount, double _maxPrice, double _price, bool _hasTracking)
        {
            MaxCount = _maxCount;
            MaxPrice = _maxPrice;
            Price = _price;
            HasTracking = _hasTracking;
        }

        private static readonly Dictionary<string, Shipping> ShippingList = new Dictionary<string, Shipping>()
        {
            { "Standardbrief", new Shipping(4, 25d, 1.1d, false) },
            { "Kompaktbrief", new Shipping(17, 25d, 1.25d, false) },
            { "Grossbrief", new Shipping(170, 25d, 2.05d, false) },
            { "Kompaktbrief + PRIO", new Shipping(17, 100d, 2.45d, true) },
            { "Grossbrief + PRIO", new Shipping(170, 100d, 3.05d, true) },
            { "Maxibrief", new Shipping(170, 25d, 3.20d, false) },
            { "Kompaktbrief + WERT National (Sachwert)", new Shipping(17, 500d, 5.75d, true) },
            { "Grossbrief + WERT National (Sachwert)", new Shipping(170, 500d, 6.35d, true) },
            { "DHL Päckchen S", new Shipping(800, 25d, 4.79d, false) },
            { "DHL Päckchen M", new Shipping(800, 25d, 5.79d, false) },
            { "DHL Paket Online 2KG", new Shipping(800, 500d, 6.49d, true) },
            { "DHL Paket Online 5KG", new Shipping(2000, 500d, 7.49d, true) },
            { "DHL Paket Online 10KG", new Shipping(4000, 500d, 10.49d, true) },
            { "DHL Paket Online 5KG + Versicherung 2.500 €", new Shipping(2000, 2500d, 14.49d, true) },
            { "DHL Paket Online 10KG + Versicherung 2.500 €", new Shipping(4000, 2500d, 17.49d, true) },
            { "DHL Paket Online 31,5KG", new Shipping(12500, 500d, 18.49d, true) },
            { "DHL Paket Online 31,5KG + Versicherung 2.500 €	", new Shipping(12500, 2500d, 25.49d, true) },
            { "DHL Paket Online 5KG + Versicherung 25.000 €", new Shipping(2000, 25000d, 25.49d, true) },
            { "DHL Paket Online 10KG + Versicherung 25.000 €", new Shipping(4000, 25000d, 28.49d, true) },
            { "DHL Paket Online 31,5KG + Versicherung 25.000 €", new Shipping(12500, 25000d, 36.49d, true) },
            { "Courrier Parcel with Full Insurance (Flat Fee) 50k", new Shipping(8000, 50000d, 100d, true) },
            { "Courrier Parcel with Full Insurance (Flat Fee) 100k", new Shipping(8000, 100000d, 200d, true) }
        };
    }
}
