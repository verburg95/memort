using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_SoftwareOntwikkeling
{
    public partial class Savegame : Form
   {
        public Savegame()
        {
            InitializeComponent();
        }

     public void Savegame_Load(object sender, EventArgs e)
     {
            
     }

        private void btn_save_Click(object sender, EventArgs e) //Wat er gebeurt wanneer op de opslaan knop gedrukt word
        {
            Opslaandialog.ShowDialog(); //Laat aan de gebruiker het browsevenster voor saven zien.
        }

        private void btn_load_Click(object sender, EventArgs e)// Wat er gebeurt wanneer op de laden knop gedrukt word
        {
            Ladendialog.ShowDialog();
        }

        private void Opslaandialog_FileOk(object sender, CancelEventArgs e) => File.WriteAllText(Opslaandialog.FileName, txtbox_savegame.Text);
    }
}
