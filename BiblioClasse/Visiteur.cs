using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    public class Visiteur : Personne
    {
        #region variable
        private string login;
        private string mdp;
        private string cp;
        private string ville;
        private DateTime dateEmbauche;

        #endregion

        #region accesseur
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }

        #endregion

        #region controleur
        public Visiteur(string login, string mdp, string cp, string ville, DateTime dateEmbauche, string id, string nom, string prenom, string adresse)
            : base(id, nom, prenom, adresse)
        {
            this.login = login;
            this.mdp = mdp;
            this.cp = cp;
            this.ville = ville;
        }

        #endregion

        #region controleur vide
        public Visiteur()
        { }

        #endregion
    }
}
