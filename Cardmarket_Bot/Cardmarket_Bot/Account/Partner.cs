using System;

namespace Cardmarket_Bot.Account
{
    public class Partner
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public DateTime registrationDate { get; set; }
        public int isCommercial { get; set; }
        public bool isSeller { get; set; }
        public Name name { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string vat { get; set; }
        public string legalInformation { get; set; }
        public int riskGroup { get; set; }
        public string lossPercentage { get; set; }
        public int unsentShipments { get; set; }
        public int reputation { get; set; }
        public int shipsFast { get; set; }
        public int sellCount { get; set; }
        public int soldItems { get; set; }
        public int avgShippingTime { get; set; }
        public bool onVacation { get; set; }
    }

    public class Message
    {
        public string idMessage { get; set; }
        public bool isSending { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }
        public bool unread { get; set; }
    }
}
