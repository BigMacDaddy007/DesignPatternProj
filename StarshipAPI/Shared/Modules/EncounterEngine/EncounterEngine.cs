using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Shared.Modules.EncounterEngine
{
    public sealed class EncounterEngine
    {

        private static readonly EncounterEngine instance = new EncounterEngine();
        static EncounterEngine() {}
        private EncounterEngine() {}
        public static EncounterEngine Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
