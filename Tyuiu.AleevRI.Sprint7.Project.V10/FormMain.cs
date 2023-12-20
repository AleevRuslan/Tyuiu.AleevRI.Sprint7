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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonAddOrder_ARI_Click(object sender, EventArgs e)
        {
            FormAddOrder A = new FormAddOrder();
            A.Show();
            Hide();
        }

        private void buttonEditOrder_ARI_Click(object sender, EventArgs e)
        {
            FormEditOrder E = new FormEditOrder();
            E.Show();
            Hide();
        }
    }
}
