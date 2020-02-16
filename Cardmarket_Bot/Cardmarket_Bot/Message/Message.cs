using System;

namespace Cardmarket_Bot.Message
{
    public class Message
    {
        public string idMessage { get; set; }
        public bool isSending { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }
        public bool unread { get; set; }
    }
}
