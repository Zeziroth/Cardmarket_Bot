using Cardmarket_Bot.General;
using System;
using System.Collections.Generic;

namespace Cardmarket_Bot.Expansion
{
    public class Expansion : Localized
    {
        public int idExpansion { get; set; }
        public string enName { get; set; }
        public string abbreviation { get; set; }
        public int icon { get; set; }
        public DateTime releaseDate { get; set; }
        public bool isReleased { get; set; }
        public int idGame { get; set; }
        public List<Link> links { get; set; }
    }
}
