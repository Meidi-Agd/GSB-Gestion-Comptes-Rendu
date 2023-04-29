using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Specialite
    {
        #region variable
        private string idSpe;
        private string specialites;
        #endregion

        #region accesseur
        public string IdSpe { get => idSpe; set => idSpe = value; }
        public string Specialites { get => specialites; set => specialites = value; }

        #endregion

        #region controleur
        public Specialite(string idSpe, string specia)
        {
            this.idSpe = idSpe;
            this.specialites = specia;
        }

        //controleur vide
        public Specialite()
        { }

        #endregion
    }
}
