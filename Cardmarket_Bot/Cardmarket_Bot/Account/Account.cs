using System;

namespace Cardmarket_Bot.Account
{
    public class Account
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public string country { get; set; }
        public int isCommercial { get; set; }
        public bool maySell { get; set; }
        public int sellerActivation { get; set; }
        public int riskGroup { get; set; }
        public string lossPercentage { get; set; }
        public int reputation { get; set; }
        public int shipsFast { get; set; }
        public int sellCount { get; set; }
        public int soldItems { get; set; }
        public int avgShippingTime { get; set; }
        public bool onVacation { get; set; }
        public int idDisplayLanguage { get; set; }
        public Name name { get; set; }
        public HomeAddress homeAddress { get; set; }
        public string email { get; set; }
        public object phoneNumber { get; set; }
        public object vat { get; set; }
        public string legalInformation { get; set; }
        public DateTime registerDate { get; set; }
        public bool isActivated { get; set; }
        public MoneyDetails moneyDetails { get; set; }
        public BankAccount bankAccount { get; set; }
        public int articlesInShoppingCart { get; set; }
        public int unreadMessages { get; set; }
    }
}
