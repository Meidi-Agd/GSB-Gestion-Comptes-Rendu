using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBConnectSpace
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        //Constructeur
        public DBConnect(string srv, string DB, string ID, string MDP)
        {
            server = srv;
            database = DB;
            uid = ID;
            password = MDP;
            Initialize();
        }
        //Initialisation des valeurs
        private void Initialize()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public + NbVisiteur()
        {
            string countquery = "SELECT COUNT(nom) FROM visiteur";
            MySqlCommand countcmd = new MySqlCommand(countquery, connection);            
            return countcmd;
        }

        public string[,] VisiteurTab(int Nbv)
        {
            string query = "SELECT * FROM visiteur";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            string[,] TabVisiteur = new string[Nbv,10];

            int i = 0;            
            while(reader.Read())
            {
                //int x = 0;           
                TabVisiteur[i,0] = reader["nom"].ToString();
                TabVisiteur[i, 1] = reader["prenom"].ToString();
                i++;
            }

            return TabVisiteur;
        }

        //Ouverture de la connexion à la BD
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;                
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Connexion au serveur impossible ! Contactez l'administrateur");
                        break;
                    case 0:
                        MessageBox.Show("Login et/ou mot de passe invalide(s). Réessayez");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Méthode de conversion SQL <-> C# (les formats sont différents)
        public String Convert2MySQL(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private DateTime Convert2C(String sqlDate)
        {
            return DateTime.Parse(sqlDate);
        }

    }
}
