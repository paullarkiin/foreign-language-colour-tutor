using System;
using System.Threading;
using System.Windows.Forms;

namespace LangMainGame
{
    public partial class frm_choiceMenu : Form
    {
        public frm_choiceMenu()
        {
            // code for loading from previous screen
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(5000); // time before opening 
            InitializeComponent();
            trd.Abort();
        }
        private void formRun()
        {
            Application.Run(new frm_OpeningScreen());
        }


        // Get Started! button code
        //btn_GetStarted - never got renamed in the system.
        private void Button1_Click(object sender, EventArgs e)
        {
            // passing user input from textbox to a string.
            string questionNumber = txtBox_Num.Text;
            GameGlobals.QuestionNumber = Convert.ToInt32(questionNumber); // convert from string to int and saves to GameGlobals class get / set method


            string userLang = comboBoxLang.GetItemText(comboBoxLang.SelectedItem);
            GameGlobals.UserLang = userLang;

            
            frm_MainGame form = new frm_MainGame();
            form.Show();
            this.Hide();
        }


        private void TxtBox_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows for user to enter numbers and use special/control keys.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComboBoxLang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows for user to enter characters and use special/control keys.
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
               
        }
    }
}
