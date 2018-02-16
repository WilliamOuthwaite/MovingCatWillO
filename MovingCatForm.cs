/*
 * Created by:William Outhwaite
 * Created on: 16, February, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program displays cats in different poses. 
*/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatWillO
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void picCat_Click(object sender, EventArgs e)
        {

        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
