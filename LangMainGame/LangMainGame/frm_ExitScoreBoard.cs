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
    public partial class frm_ExitScoreBoard : Form
    {
        
        double finalValue; // used to take in value from previous form.
        public frm_ExitScoreBoard(double finalValue) // constructor for score to passed to.
        {
            InitializeComponent();

            this.finalValue = finalValue;
        }

       
        private void Frm_ExitScoreBoard_Load(object sender, EventArgs e)
        {
            
            lblOutputScore.Text = GameGlobals.GameScore.ToString(); // calling final game score, from global value of the score

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // clear globals in the GameGlobals class
            int GameScore = 0;
            int QuestionNumber = 0;
            String UserLang = "";

            GameGlobals.GameScore = GameScore;
            GameGlobals.QuestionNumber = QuestionNumber;
            GameGlobals.UserLang = UserLang;

            frm_choiceMenu newgame = new frm_choiceMenu(); // restart the game by calling new instance of the game from Choice the menu.

            newgame.Show();
            this.Hide();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {// exits the application
            System.Environment.Exit(1);
        }

        private void TimerScore_Tick(object sender, EventArgs e)
        {
            // used to set the finalvalue to the progression bar and allow it to output as a percentage.
            //converts from a double to an int
            circularProgressBar1.Value = (int)finalValue;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();

        }
    }
    
}
