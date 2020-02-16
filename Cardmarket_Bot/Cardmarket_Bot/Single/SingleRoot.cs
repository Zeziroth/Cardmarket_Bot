using Cardmarket_Bot.General;
using System.Collections.Generic;

namespace Cardmarket_Bot.Single
{
    public class SingleRoot
    {
        public Expansion.Expansion expansion { get; set; }
        public List<Single> single { get; set; }
        public List<Link2> links { get; set; }
    }
}
