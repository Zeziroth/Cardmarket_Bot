using System.Collections.Generic;
using Cardmarket_Bot.General;

namespace Cardmarket_Bot.Message
{
    public class MessageRoot
    {
        public List<Thread> thread { get; set; }
        public List<Link2> links { get; set; }
    }
}
