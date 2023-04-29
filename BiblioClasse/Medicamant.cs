using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Medicamant : Famille
    {
        #region variable
        private string idMec;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreindiactions;

        #endregion

        #region accesseur
        public string IdMec { get => idMec; set => idMec = value; }
        public string NomCommercial { get => nomCommercial; set => nomCommercial = value; }
        public string Composition { get => composition; set => composition = value; }
        public string Effets { get => effets; set => effets = value; }
        public string Contreindiactions { get => contreindiactions; set => contreindiactions = value; }

        #endregion

        #region constructure

        public Medicamant(string idFam, string libelle)
            : base(idFam, libelle)
        {
            idMec = "";
            composition = "";
            nomCommercial = "";
            effets = "";
            contreindiactions = "";
        }


        public Medicamant(string idMec, string nomCommercial, string contreindiactions, string effets, string composition, string idFam, string libelle)
            : base(idFam, libelle)
        {
            this.idMec = idMec;
            this.composition = composition;
            this.nomCommercial = nomCommercial;
            this.effets = effets;
            this.contreindiactions = contreindiactions;
        }



        #endregion
    }
}
