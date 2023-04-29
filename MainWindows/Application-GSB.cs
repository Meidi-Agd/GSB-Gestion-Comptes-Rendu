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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            frmAccueil  newMDIChild = new frmAccueil();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Fichier newMDIChild = new frm_Fichier();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void fraisForfaitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisiteurs newMDIChild = new frmVisiteurs();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void médicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicaments newMDIChild = new frmMedicaments();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            
        }

        private void médecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedecin newMDIChild = new frmMedecin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            
        }
    }
}
