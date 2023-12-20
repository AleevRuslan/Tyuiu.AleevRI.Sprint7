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
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
        }

        private void buttonBack_ARI_Click(object sender, EventArgs e)
        {
            FormMain m = new FormMain();
            m.Show();
            Hide();
        }
    }
}
