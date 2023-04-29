using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Famille
    {
        #region variable
        private string id;
        private string libelle;

        #endregion

        #region accesseur
        public string Libelle { get => libelle; set => libelle = value; }
        public string Id { get => id; set => id = value; }

        #endregion

        #region controleur
        public Famille(string idFam, string libelle)
        {
            this.id = idFam;
            this.libelle = libelle;
        }

        #endregion
    }
}
