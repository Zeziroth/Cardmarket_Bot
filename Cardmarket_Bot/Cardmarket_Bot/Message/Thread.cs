using Cardmarket_Bot.Account;
using Cardmarket_Bot.General;
using System.Collections.Generic;

namespace Cardmarket_Bot.Message
{
    public class Thread
    {
        public Partner partner { get; set; }
        public Message message { get; set; }
        public int unreadMessages { get; set; }
        public List<Link> links { get; set; }
    }
}
