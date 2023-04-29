using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioClasse;

namespace MainWindows
{
    public partial class frmMedicaments : Form
    {
        public static List<Medicamant> medoc = new List<Medicamant>();
        
        public frmMedicaments()
        {
            InitializeComponent();
            insertion();
            for (int i = 1; i < (medoc.Count); i++)
            {
                comboBox2.Items.Add(medoc[i].NomCommercial);
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicamant unMedoc = new Medicamant("", "");
            unMedoc = Affichage(medoc);
            tbContreIndic.Text = unMedoc.Contreindiactions;
            tbCompo.Text = unMedoc.Composition;
            tbEffet.Text = unMedoc.Effets;
        }

        public static void insertion()
        {
            
            medoc.Add(new Medicamant("*00", "ERREUR", "Aucune valeur trouver", "Aucune valeur trouver", "Aucune valeur trouver", "no", "no"));
            medoc.Add(new Medicamant("A01", "Doliprane", "Ce médicament ne doit pas être utilisé dans les cas suivants : \n  -maladie grave du foie \n  -inflammation ou saignement du rectum (suppositoires) \n  -intolérance au gluten (comprimé sécable à 500 mg).", "Ce médicament est un antalgique et un antipyrétique qui contient du paracétamol. \n Il est utilisé pour faire baisser la fièvre et dans le traitement des affections douloureuses. Les formes orales dosées à 1000 mg sont également indiquées dans le traitement des douleurs de l'arthrose.", "- Sorbitol \n -Maltitol \n -Sucres \n -Sodium", "F01", "Paracétamol"));
        }

        public Medicamant Affichage(List<Medicamant> medoc)
        {
            Medicamant leMedoc = medoc[0];

            for  (int i = 1; i < (medoc.Count) ; i++)
            {
                string test = comboBox2.Text;

                if (test == medoc[i].NomCommercial)
                {
                    leMedoc = medoc[i];
                }
            }

            return leMedoc;
        }
    }
}
