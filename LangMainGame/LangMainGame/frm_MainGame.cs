using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LangMainGame
{

    public partial class frm_MainGame : Form
  {

        List<String> ColListEng = new List<String>() { "red", "yellow", "green", "blue", "black", "orange", "white", "purple", "brown", "pink", "grey" };
        List<String> ColListDutch = new List<String>() { "rood", "geel", "groen", "blauw", "zwart", "oranje", "wit","paars", "bruin", "roze", "grijs" };
        List<String> ColListSpanish = new List<String>() { "rojo", "amarillo", "verde", "azel", "negro", "naranja", "blanco", "purpura", "marron", "rosa", "gris"  };
        List<String> ColListSwedish = new List<String>() { "rod", "gul", "gron", "bla", "svart", "orange", "vit", "lila", "brun", "rosa","gra"};
        List<Color> ColorList = new List<Color>() { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Black, Color.Orange, Color.White, Color.Purple, Color.Brown, Color.Pink, Color.Gray };

        static Random rnd = new Random();
        static int guess = rnd.Next(0, 11); // picks a index to quiz on
        static int QuestionsRemaining = GameGlobals.QuestionNumber; 


        public frm_MainGame()
        {
            InitializeComponent();

            // initializes colour and userlang to the screen on loading
            lbl_Colour.BackColor = ColorList[guess];
            lbl_translateThisTxt.Text = "Translate this colour in " + GameGlobals.UserLang.ToString();
     
        }

        private void btn_EnterGuess_Click(object sender, EventArgs e)
        {
            
            double maxTotal;
            double finalValue;
            string userAnswer = txtbox_Qanswer.Text;
            lbl_Pass.Text = "";

            // checked the user input again, the array index of guess on each of the arrays.
            if (ColListDutch[guess] == userAnswer || ColListSpanish[guess] == userAnswer || ColListSwedish[guess] == userAnswer)
            {
                // counter to remove one everytime the user get answer right from questionsRemaining.
                QuestionsRemaining--; 
                
                GameGlobals.GameScore = GameGlobals.GameScore + 2;
                MessageBox.Show("Correct! \n");
                txtbox_Qanswer.Clear();
                txtbox_Qanswer.Focus();
                guess = rnd.Next(0, 10);
                lbl_Colour.BackColor = ColorList[guess]; // calls a new colour 
                lbl_HintText.Text = "";
                lbl_Pass.Text = ""; 
            }
            else 
                {
                // call colour name from array to a string, then trim out single brackets or both and save to new string.
                string colour = ColorList[guess].ToString();
                char[] toBeTrimed = { '[', ']' };
                string trimmedColourName = colour.Trim(toBeTrimed); // removes brackets from output [red]

                if(GameGlobals.UserLang == "Spanish")
                {
                  // sub string 7 calls chars after . in Colour.Red 
                 lbl_Pass.Text = lbl_Pass.Text + trimmedColourName.Substring(7) + " in Spanish is " + ColListSpanish[guess].ToString();
                }
                else if(GameGlobals.UserLang == "Dutch")
                {
                    lbl_Pass.Text = lbl_Pass.Text + trimmedColourName.Substring(7) + " in Dutch is " + ColListDutch[guess].ToString();
                }
                else if(GameGlobals.UserLang == "Swedish")
                {
                    lbl_Pass.Text = lbl_Pass.Text + trimmedColourName.Substring(7) + " in Swedish is " + ColListSwedish[guess].ToString();
                }
                // decrease the amount of questions the user has selected 
                QuestionsRemaining--;
               
                MessageBox.Show("That was incorrect");

                // calls game if loop to work out how to update score
                ScoreManagement();

                txtbox_Qanswer.Clear();
                txtbox_Qanswer.Focus();
                guess = rnd.Next(0, 10);
                lbl_Colour.BackColor = ColorList[guess];
                lbl_Pass.Text = "";
                lbl_HintText.Text = "";
                   
                }
            
             // displays score
             lbl_ShowScore.Text = GameGlobals.GameScore.ToString();

             // calulate the percentage 
             maxTotal = GameGlobals.QuestionNumber * 2;
             finalValue = (GameGlobals.GameScore / maxTotal) * 100;
 

            
            if (QuestionsRemaining == 0)
            {// exits to next screen when 0 and passes caluated value to frm_ExitScoreBoard constructor.
                frm_ExitScoreBoard nextform = new frm_ExitScoreBoard(finalValue);
                nextform.Show();
                this.Hide();
            }
            
        } 


        private void btn_Hint_Click(object sender, EventArgs e)
        {// outputs the first letter of the array index with substring.
            lbl_Pass.Text = "";
            string hint = "";

            if (GameGlobals.UserLang == "Spanish")
            {
                hint = ColListSpanish[guess].ToString();
                lbl_HintText.Text = lbl_HintText.Text + "First Letter is: " + hint.Substring(0, 1);
              
            }
            else if (GameGlobals.UserLang == "Dutch")
            {
                hint = ColListDutch[guess].ToString();
                lbl_HintText.Text = lbl_HintText.Text + "First Letter is: " + hint.Substring(0, 1);
               
            }
            else if (GameGlobals.UserLang == "Swedish")
            {
                hint = ColListSwedish[guess].ToString();
                lbl_HintText.Text = lbl_HintText.Text + "First Letter is: " + hint.Substring(0, 1);
                
            }
            
            ScoreManagement();
            lbl_ShowScore.Text = GameGlobals.GameScore.ToString();
        }


        // exit button, never changed with rename
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Your Score is: " + GameGlobals.GameScore + "\n \nAre you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Pass_Click(object sender, EventArgs e)
        {
            string ans = "";
           
            // works out the correct answer and passes outputs to form.
            if (GameGlobals.UserLang == "Dutch")
            {
                ans = ColListDutch[guess].ToString();
                lbl_Pass.Text = ans.ToString() + " was the answer";
                
            }
            else if (GameGlobals.UserLang == "Spanish")
            {
                ans = ColListSpanish[guess].ToString();
                lbl_Pass.Text = ans.ToString() + " was the answer";
               
            }
            else if (GameGlobals.UserLang == "Swedish")
            {
                ans = ColListSwedish[guess].ToString();
                lbl_Pass.Text = ans.ToString() + " was the answer";
                
            }
            
            txtbox_Qanswer.Clear();
            guess = rnd.Next(0, 10);
            lbl_Colour.BackColor = ColorList[guess];
            lbl_HintText.Text = "";

            //update score
            ScoreManagement();
            lbl_ShowScore.Text = GameGlobals.GameScore.ToString();
        }


        public void ScoreManagement() // score controler to reduce code, reduce the score and keep the score above 0 
        {
            if (GameGlobals.GameScore == 0)
            {
                GameGlobals.GameScore = GameGlobals.GameScore;
            }
            else
            {
                GameGlobals.GameScore = GameGlobals.GameScore - 1;
            }
        }

        private void Txtbox_Qanswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validates that the textbox only takes characters / Alphabet and control keys such as backspace.

            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

