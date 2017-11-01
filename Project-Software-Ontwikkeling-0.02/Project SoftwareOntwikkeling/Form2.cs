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
    public partial class Namen : Form
    {
        public Namen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naam1 = textBox1.Text;
            string naam2 = textBox2.Text;

            Memory mem = new Memory(naam1, naam2);
            mem.Show();
        }

    }
}
