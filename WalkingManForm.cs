using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Add Library to use sleep timer 
using System.Threading;

/*
 * Created by: Tolulope Adebayo
 * Created on: 26-March-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program creates a walking man when the user clicks on the start botton
*/

namespace WalkingManToluA
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare Variables and Constants 
            const Byte MAX_FRAMES = 10;
            int pictureFrameCounter = 0;
            while (pictureFrameCounter < MAX_FRAMES + 1) 
            {
                if ( pictureFrameCounter == 1)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk2;
                }
                else if ( pictureFrameCounter == 3)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk3;
                }
                else if ( pictureFrameCounter == 4)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk4;
                }
                else if ( pictureFrameCounter ==5)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk6;
                }
                else if ( pictureFrameCounter == 7)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk8;
                }
                else if ( pictureFrameCounter == 9)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk9;
                }
                else if ( pictureFrameCounter == 10)
                {
                    this.picWalkingMan.Image = Properties.Resources.walk10;
                }
                // increment counter by 1
                pictureFrameCounter = pictureFrameCounter + 1;
                // refrest the form
                this.Refresh();
                // pause loop for 100 milleseconds
                Thread.Sleep(100);
            }






        }
    }
}
