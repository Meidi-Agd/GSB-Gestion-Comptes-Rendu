using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindows
{
    public partial class PopAjoutsMedecin : Form
    {
        public PopAjoutsMedecin()
        {
            InitializeComponent();
        }

        private void bt_Ajouter_Click(object sender, EventArgs e)
        {      

        }

        private void bt_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_NomDoc_TextChanged(object sender, EventArgs e)
        {
            string nomDoc = TB_NomDoc.Text;
        }

        private void TB_PrenomDoc_TextChanged(object sender, EventArgs e)
        {
            string prenomDoc = TB_PrenomDoc.Text;
        }

        private void TB_TelDoc_TextChanged(object sender, EventArgs e)
        {
            string telDoc = TB_TelDoc.Text;
        }

        private void TB_AdresseDoc_TextChanged(object sender, EventArgs e)
        {
            string adrDoc = TB_AdresseDoc.Text;
        }

        private void TB_DepartDoc_TextChanged(object sender, EventArgs e)
        {
            string departDoc = TB_DepartDoc.Text;
        }
    }
}
