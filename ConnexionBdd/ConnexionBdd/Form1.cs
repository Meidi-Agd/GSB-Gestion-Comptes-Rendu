using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBConnectSpace;
using MySql.Data.MySqlClient;


namespace ConnexionBdd
{
    public partial class FormCnxBdd : Form
    {
        public FormCnxBdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            string srv = txtHost.Text;
            string DB = txtDB.Text;
            string ID = txtID.Text;
            string MDP = txtMDP.Text;
            DBConnect cnx = new DBConnect(srv, DB, ID, MDP);
            if (cnx.OpenConnection())
            {
                MessageBox.Show("CONNEXION REUSSIE !!!!!", "Avertissement", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                string strNbVisiteur = cnx.NbVisiteur();
                int Nb = int.Parse(strNbVisiteur);
                string[,] visiteur = cnx.VisiteurTab(Nb);

                MessageBox.Show(visiteur[0,0] + " " + visiteur[0,1], "Avertissement", MessageBoxButtons.OK);

                for (int i = 0; i < Nb; i++)
                {
                    comboBox.Items.Add(visiteur[i, 0] + " " + visiteur[i, 1]);
                }
            }

            
            //if (cnx.OpenConnection() == 1)
            //{
            //    MessageBox.Show("Connexion au serveur impossible ! Contactez l'administrateur");
            //}

            //if (cnx.OpenConnection() == 2)
            //{
            //    MessageBox.Show("Login et/ou mot de passe invalide(s). Réessayez");
            //}

            //if (cnx.OpenConnection() == 2)
            //{
            //    MessageBox.Show("Erreur inconnue ! Réessayez");
            //}

        }

        private void tableauPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
