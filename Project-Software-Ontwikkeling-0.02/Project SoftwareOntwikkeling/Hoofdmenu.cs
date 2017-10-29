using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SoftwareOntwikkeling
{
    public partial class Hoofdmenu : Form
    {
        public Hoofdmenu()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Memory mem = new Memory();
            mem.Show();
            this.Hide();
        }
    }
}
