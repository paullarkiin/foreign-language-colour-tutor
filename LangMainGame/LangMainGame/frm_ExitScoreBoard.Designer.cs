namespace LangMainGame
{
    partial class frm_ExitScoreBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Scoreboard = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.lblOutputScore = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.timerScore = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Scoreboard
            // 
            this.lbl_Scoreboard.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Scoreboard.Location = new System.Drawing.Point(136, 9);
            this.lbl_Scoreboard.Name = "lbl_Scoreboard";
            this.lbl_Scoreboard.Size = new System.Drawing.Size(178, 33);
            this.lbl_Scoreboard.TabIndex = 0;
            this.lbl_Scoreboard.Text = "Scoreboard";
            this.lbl_Scoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 2;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(291, 369);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(98, 49);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.FlatAppearance.BorderSize = 2;
            this.btn_PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Bahnschrift", 8.55F);
            this.btn_PlayAgain.Location = new System.Drawing.Point(61, 370);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(98, 49);
            this.btn_PlayAgain.TabIndex = 2;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            this.btn_PlayAgain.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblOutputScore
            // 
            this.lblOutputScore.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputScore.Location = new System.Drawing.Point(257, 69);
            this.lblOutputScore.Name = "lblOutputScore";
            this.lblOutputScore.Size = new System.Drawing.Size(76, 43);
            this.lblOutputScore.TabIndex = 7;
            this.lblOutputScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(136, 78);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(109, 23);
            this.lblFinalScore.TabIndex = 6;
            this.lblFinalScore.Text = "Final Score:";
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularProgressBar1.Font = new System.Drawing.Font("Bahnschrift", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(140, 131);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Orange;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(172, 176);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.DarkOrange;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "%";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // timerScore
            // 
            this.timerScore.Enabled = true;
            this.timerScore.Tick += new System.EventHandler(this.TimerScore_Tick);
            // 
            // frm_ExitScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.lblOutputScore);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Scoreboard);
            this.Name = "frm_ExitScoreBoard";
            this.Load += new System.EventHandler(this.Frm_ExitScoreBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Scoreboard;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Label lblOutputScore;
        private System.Windows.Forms.Label lblFinalScore;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timerScore;
    }
}