using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Medecin : Personne
    {
        #region variable
        private string tel;
        private int departement;
        private Specialite laSpecialite;

        #endregion

        #region accesseur
        public string Tel { get => tel; set => tel = value; }
        public int Departement { get => departement; set => departement = value; }

        #endregion

        #region controleur
        public Medecin(string tel, int departement, string id, string nom, string prenom, string adresse)
            : base(id, nom, prenom, adresse)
        {
            this.tel = tel;
            this.departement = departement;
        }

        #endregion
    }
}
