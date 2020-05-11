using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_musique
{
    class Instrument:Nommage
    {
        private static Int32 leMaxId = 1;

        public Instrument() : base(leMaxId)
        {
            SetMaxId(leMaxId + 1);
        }

        public Instrument(Int32 unId) : base(unId)
        {
            SetMaxId(unId + 1);
        }

        public Instrument(Int32 unId, string unLibelle) : base(unId, unLibelle)
        {
            SetMaxId(unId + 1);
        }

        public Instrument(string unLibelle) : base(leMaxId, unLibelle)
        {
            SetMaxId(leMaxId + 1);
        }

        public void SetMaxId(Int32 unMaxId)
        {
            if (unMaxId > leMaxId)
                leMaxId = unMaxId;
        }

        public Int32 getMaxId()
        {
            return leMaxId;
        }
    }
}
