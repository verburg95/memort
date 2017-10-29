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
    public partial class Memory : Form
    {
        #region variabelen
        int scorespeler1 = 0;
        int scorespeler2 = 0;
        int beurt = 1;
        public string naam1, naam2;
        
        Random locatie = new Random(); //Kiest een willekeurig getal van de X en Y lijsten en geeft zo aan de kaarten een locatie
        List<Point> locaties = new List<Point>(); // Lijst die gevuld word door VulLijst() met locaties van pictureboxes
        PictureBox Opslagbox1, Opslagbox2; // Opslag voor kaarten die open moeten blijven
        #endregion

        public Memory()
        {
            InitializeComponent();
        }
        #region timers
        private void timer1_Tick(object sender, EventArgs e)
        {
        
        timer1.Stop(); //Stopt timer1 zodat de foreach loop niet constant door uitgevoerd word
            foreach (PictureBox picture in pnl_CardHolder.Controls)
            { 
                picture.Cursor = Cursors.Hand; // Verandert voor elke kaart de cursos in een hand
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e) 
        {
           
        }
        private void timer3_Tick(object sender, EventArgs e) // Timer die start bij een match van 2 kaarten.
        {
            timer3.Stop();
            Opslagbox1.Image = Properties.Resources.Cover2;//Verandert de images weer naar de cover als ze niet geli 
            Opslagbox2.Image = Properties.Resources.Cover2;
            Opslagbox1 = null;
            Opslagbox2 = null;
            beurt = -beurt; //verandert de beurt
            if (beurt == 1)
            {
                labelBeurt.Text = "Speler 1 is aan de beurt";
            }
            else if (beurt == -1)
            {
                labelBeurt.Text = "Speler 2 is aan de beurt";
            }

        }
#endregion
        #region Kaarten
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources.Card1;
            if(Opslagbox1 == null)
            {
                Opslagbox1 = Card1;
            }
            else if(Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card1;
            }
            if(Opslagbox1 != null && Opslagbox2 != null)
            {
                if(Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
               
            }
        }

        private void DupCard1_Click(object sender, EventArgs e)
        {
            DupCard1.Image = Properties.Resources.Card1;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard1;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard1;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.Card2;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = Card2;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card2;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            DupCard2.Image = Properties.Resources.Card2;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard2;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard2;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.Card3;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = Card3;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card3;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            DupCard3.Image = Properties.Resources.Card3;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard3;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard3;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.Card4;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = Card4;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card4;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            DupCard4.Image = Properties.Resources.Card4;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard4;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard4;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.Card5;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = Card5;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card5;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            DupCard5.Image = Properties.Resources.Card5;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard5;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard5;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.Card6;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = Card6;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card6;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            DupCard6.Image = Properties.Resources.Card6;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard6;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard6;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.Card7;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = Card7;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card7;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            DupCard7.Image = Properties.Resources.Card7;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard7;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard7;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.Card8;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = Card8;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = Card8;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }
        }

       
        private void DupCard8_Click(object sender, EventArgs e)
        {
            DupCard8.Image = Properties.Resources.Card8;
            if (Opslagbox1 == null)
            {
                Opslagbox1 = DupCard8;
            }
            else if (Opslagbox1 != null && Opslagbox2 == null)
            {
                Opslagbox2 = DupCard8;
            }
            if (Opslagbox1 != null && Opslagbox2 != null)
            {
                if (Opslagbox1.Tag == Opslagbox2.Tag)
                {
                    Opslagbox1 = null;
                    Opslagbox2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    if (beurt == 1)
                    {
                        scorespeler1++;
                        lbl_scorecounter1.Text = Convert.ToString(scorespeler1);
                    }
                    else if (beurt == -1)
                    {
                        scorespeler2++;
                        lbl_scorecounter2.Text = Convert.ToString(scorespeler2);
                    }
                }
                else
                {
                    timer3.Start();
                }
            }

        }
        #endregion
        //Click events voor de kaarten

        private void Memory_Load(object sender, EventArgs e)
        {
           
            VulLijst(); //Roept de methode VulLijst
            ShuffleKaarten();//Roept de methode ShuffleKaarten()
            foreach (PictureBox picture in pnl_CardHolder.Controls)
            {
                picture.Cursor = Cursors.Hand; // Verandert voor elke kaart de cursos in een hand

            }

            timer2.Start(); //Start timer2
            timer1.Start(); //Start timer1

            Card1.Image = Properties.Resources.Cover2;
            DupCard1.Image = Properties.Resources.Cover2;
            Card2.Image = Properties.Resources.Cover2;
            DupCard2.Image = Properties.Resources.Cover2;
            Card3.Image = Properties.Resources.Cover2;
            DupCard3.Image = Properties.Resources.Cover2;
            Card4.Image = Properties.Resources.Cover2;
            DupCard4.Image = Properties.Resources.Cover2;
            Card5.Image = Properties.Resources.Cover2;
            DupCard5.Image = Properties.Resources.Cover2;
            Card6.Image = Properties.Resources.Cover2;
            DupCard6.Image = Properties.Resources.Cover2;
            Card7.Image = Properties.Resources.Cover2;
            DupCard7.Image = Properties.Resources.Cover2;
            Card8.Image = Properties.Resources.Cover2;
            DupCard8.Image = Properties.Resources.Cover2;
            //Wijst elke picturebox en zijn duplicaat de image van de cover toe.

        }
        #region buttons
        private void resetknop_Click(object sender, EventArgs e)
        {
            Memory reset = new Memory();
            reset.Show();
            this.Dispose(false);
        }

        private void btn_savemenu_Click(object sender, EventArgs e)
        {
            Savegame SaveMenu = new Savegame();
            SaveMenu.Show();
        }
        #endregion
        #region methods
        private void VulLijst()
        {
            foreach (PictureBox picture in pnl_CardHolder.Controls) //Gaat alle pictureboxes in het panel bij langs en voegt hun huidige locaties toe aan onze lijst met punten.
            {
                locaties.Add(picture.Location);
            }
        }
        private void ShuffleKaarten()
        {
            foreach (PictureBox picture in pnl_CardHolder.Controls) // Wijst aan alle pictureboxes een random locatie toe uit onze lijst van locaties
            {
                int next = locatie.Next(locaties.Count);
                Point punt1 = locaties[next];
                picture.Location = punt1;
                locaties.Remove(punt1);
            }
        }
        #endregion
    }
}
