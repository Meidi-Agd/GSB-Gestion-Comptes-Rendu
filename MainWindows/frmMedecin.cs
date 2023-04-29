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
    public partial class frmMedecin : Form
    {
        public frmMedecin()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            PopAjoutsMedecin fp = new PopAjoutsMedecin();
            fp.Show();
        }
    }
}
