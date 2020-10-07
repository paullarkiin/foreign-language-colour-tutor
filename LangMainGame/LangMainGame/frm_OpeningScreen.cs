using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangMainGame
{
    public partial class frm_OpeningScreen : Form
    {
        int move = 0;
        public frm_OpeningScreen()
        {
            InitializeComponent();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            // logic for loading bar
            // if the slider is greater than the location size of the track element, reset from left. 
            // which create a loading bar effect.
            PanelSlide.Left += 2;

            if (PanelSlide.Left > 250) // location size is 248 
            {
                PanelSlide.Left = 0;
            }

            if (PanelSlide.Left < 0)
            {
                move = 2;
            }
        }

        private void Frm_OpeningScreen_Load(object sender, EventArgs e)
        {// starts the load time for opening the next window.
            timer1.Start();
        }
    }
}
