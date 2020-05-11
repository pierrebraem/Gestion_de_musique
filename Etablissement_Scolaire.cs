using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_musique
{
    class Etablissement_Scolaire:Residence
    {
        private static Int32 leMaxId = 1;

        public Etablissement_Scolaire() : base(leMaxId)
        {
            SetMaxId(leMaxId + 1);
        }

        public Etablissement_Scolaire(Int32 unId) : base(unId)
        {
            SetMaxId(unId + 1);
        }

        public Etablissement_Scolaire(Int32 unId, string unLibelle) : base(unId, unLibelle)
        {
            SetMaxId(unId + 1);
        }

        public Etablissement_Scolaire(string unLibelle) : base(leMaxId, unLibelle)
        {
            SetMaxId(leMaxId + 1);
        }

        public Etablissement_Scolaire(string unLibelle, string uneAdresse) : base(leMaxId, unLibelle, uneAdresse)
        {
            SetMaxId(leMaxId + 1);
        }

        public Etablissement_Scolaire(Int32 unID, string unLibelle, string uneAdresse) : base(unID, unLibelle, uneAdresse)
        {
            SetMaxId(unID + 1);
        }

        public void SetMaxId(Int32 unMaxId)
        {
            if (unMaxId > leMaxId)
                leMaxId = unMaxId;
        }
    }
}
