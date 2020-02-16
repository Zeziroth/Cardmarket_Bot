using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardmarket_Bot.General
{
    public class Localized
    {
        public List<Localization> localization { get; set; }
        public Localization GetLocalByName(string localName)
        {
            foreach (Localization loc in localization)
            {
                if (loc.languageName.ToLower() == localName.ToLower())
                {
                    return GetLocalById(loc.idLanguage);
                }
            }

            return null;
        }

        public Localization GetLocalById(int localID)
        {
            foreach (Localization loc in localization)
            {
                if (loc.idLanguage == localID)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
