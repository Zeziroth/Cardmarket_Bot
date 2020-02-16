using Cardmarket_Bot.General;
using System.Collections.Generic;

namespace Cardmarket_Bot.Game
{
    public class Game
    {
        public int idGame { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        public List<Link> links { get; set; }
    }

}
