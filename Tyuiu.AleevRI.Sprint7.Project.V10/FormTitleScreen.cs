using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    public partial class FormTitleScreen : Form
    {
        public FormTitleScreen()
        {
            InitializeComponent();
        }

        private void buttonToMainForm_ARI_Click(object sender, EventArgs e)
        {
            FormMain FormMain = new FormMain();
            FormMain.Show();
            Hide();
        }

        private void buttonAbout_ARI_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.Show();
        }

        private void buttonHelp_ARI_Click(object sender, EventArgs e)
        {
            FormHelp FormHelp = new FormHelp();
            FormHelp.Show();
        }
    }
}
