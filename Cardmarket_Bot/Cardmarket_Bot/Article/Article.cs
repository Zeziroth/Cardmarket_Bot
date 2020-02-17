using Cardmarket_Bot.Account;
using Cardmarket_Bot.General;
using System;
using System.Collections.Generic;

namespace Cardmarket_Bot.Article
{
    public class Article
    {
        public int idArticle { get; set; }
        public int idProduct { get; set; }
        public Language language { get; set; }
        public string comments { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public bool inShoppingCart { get; set; }
        public Seller seller { get; set; }
        public string condition { get; set; }
        public bool isFoil { get; set; }
        public bool isSigned { get; set; }
        public bool isFirstEd { get; set; }
        public bool isPlayset { get; set; }
        public bool isAltered { get; set; }
        public List<Link> links { get; set; }

        public string ToString()
        {
            return String.Format("{1} // {2} // ⭐: {3} // 1.Ed: {4} // {5}", seller.username, language.languageName ,condition, isFoil, isFirstEd, String.Format("{0:0.00}", price));
        }
    }
}
