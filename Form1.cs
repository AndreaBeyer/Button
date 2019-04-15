using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        bool gvd = true, hvb = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bonjour à toi aussi !...");

            goodbyeButton.Text = "Ne pars pas!";
            goodbyeButton.Visible = true;
            
            // Start vérifie les ressources auparavant.
            theTimer.Start();

        }

        private void theTimer_Tick(object sender, EventArgs e)
        {
            Point locationPoint = new Point();
            
            if (gvd)
            {
                locationPoint = new Point(goodbyeButton.Location.X + 10, goodbyeButton.Location.Y);
                goodbyeButton.Location = locationPoint;
                if(goodbyeButton.Location.X > (this.Width - goodbyeButton.Width  - 40))
                {
                    gvd = false;
                }
            }
            else
            {
                locationPoint = new Point(goodbyeButton.Location.X - 10, goodbyeButton.Location.Y);
                goodbyeButton.Location = locationPoint;
                if (goodbyeButton.Location.X < 10)
                {
                    gvd = true;
                }
            }
            if (hvb)
            {
                locationPoint = new Point(goodbyeButton.Location.X, goodbyeButton.Location.Y + 10);
                goodbyeButton.Location = locationPoint;
                if (goodbyeButton.Location.Y > (this.Height - goodbyeButton.Height - 50))
                {
                    hvb = false;
                }
            }
            else
            {
                locationPoint = new Point(goodbyeButton.Location.X, goodbyeButton.Location.Y - 10);
                goodbyeButton.Location = locationPoint;
                if (goodbyeButton.Location.Y < 10)
                {
                    hvb = true;
                }
            }





        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
