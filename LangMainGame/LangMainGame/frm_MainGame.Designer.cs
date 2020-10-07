namespace LangMainGame
{
    partial class frm_MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainGame));
            this.btn_EnterGuess = new System.Windows.Forms.Button();
            this.btn_Hint = new System.Windows.Forms.Button();
            this.btn_Pass = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtbox_Qanswer = new System.Windows.Forms.TextBox();
            this.lbl_Colour = new System.Windows.Forms.Label();
            this.lbl_HintText = new System.Windows.Forms.Label();
            this.lbl_translateThisTxt = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_ScoreText = new System.Windows.Forms.Label();
            this.lbl_ShowScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleOne = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EnterGuess
            // 
            this.btn_EnterGuess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_EnterGuess.FlatAppearance.BorderSize = 2;
            this.btn_EnterGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EnterGuess.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnterGuess.Location = new System.Drawing.Point(382, 390);
            this.btn_EnterGuess.Name = "btn_EnterGuess";
            this.btn_EnterGuess.Size = new System.Drawing.Size(75, 38);
            this.btn_EnterGuess.TabIndex = 0;
            this.btn_EnterGuess.Text = "Guess";
            this.btn_EnterGuess.UseVisualStyleBackColor = true;
            this.btn_EnterGuess.Click += new System.EventHandler(this.btn_EnterGuess_Click);
            // 
            // btn_Hint
            // 
            this.btn_Hint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hint.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hint.ForeColor = System.Drawing.Color.White;
            this.btn_Hint.Location = new System.Drawing.Point(31, 301);
            this.btn_Hint.Name = "btn_Hint";
            this.btn_Hint.Size = new System.Drawing.Size(75, 23);
            this.btn_Hint.TabIndex = 1;
            this.btn_Hint.Text = "Hint";
            this.btn_Hint.UseVisualStyleBackColor = true;
            this.btn_Hint.Click += new System.EventHandler(this.btn_Hint_Click);
            // 
            // btn_Pass
            // 
            this.btn_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pass.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pass.ForeColor = System.Drawing.Color.White;
            this.btn_Pass.Location = new System.Drawing.Point(31, 352);
            this.btn_Pass.Name = "btn_Pass";
            this.btn_Pass.Size = new System.Drawing.Size(75, 23);
            this.btn_Pass.TabIndex = 2;
            this.btn_Pass.Text = "Pass";
            this.btn_Pass.UseVisualStyleBackColor = true;
            this.btn_Pass.Click += new System.EventHandler(this.btn_Pass_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(31, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtbox_Qanswer
            // 
            this.txtbox_Qanswer.Location = new System.Drawing.Point(293, 354);
            this.txtbox_Qanswer.Name = "txtbox_Qanswer";
            this.txtbox_Qanswer.Size = new System.Drawing.Size(255, 20);
            this.txtbox_Qanswer.TabIndex = 5;
            this.txtbox_Qanswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_Qanswer_KeyPress);
            // 
            // lbl_Colour
            // 
            this.lbl_Colour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Colour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Colour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Colour.Location = new System.Drawing.Point(315, 79);
            this.lbl_Colour.Name = "lbl_Colour";
            this.lbl_Colour.Size = new System.Drawing.Size(211, 175);
            this.lbl_Colour.TabIndex = 6;
            // 
            // lbl_HintText
            // 
            this.lbl_HintText.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HintText.Location = new System.Drawing.Point(565, 102);
            this.lbl_HintText.Name = "lbl_HintText";
            this.lbl_HintText.Size = new System.Drawing.Size(142, 27);
            this.lbl_HintText.TabIndex = 7;
            // 
            // lbl_translateThisTxt
            // 
            this.lbl_translateThisTxt.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_translateThisTxt.Location = new System.Drawing.Point(286, 311);
            this.lbl_translateThisTxt.Name = "lbl_translateThisTxt";
            this.lbl_translateThisTxt.Size = new System.Drawing.Size(275, 26);
            this.lbl_translateThisTxt.TabIndex = 8;
            this.lbl_translateThisTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.Location = new System.Drawing.Point(277, 272);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(291, 39);
            this.lbl_Pass.TabIndex = 9;
            this.lbl_Pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ScoreText
            // 
            this.lbl_ScoreText.AutoSize = true;
            this.lbl_ScoreText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScoreText.ForeColor = System.Drawing.Color.White;
            this.lbl_ScoreText.Location = new System.Drawing.Point(27, 146);
            this.lbl_ScoreText.Name = "lbl_ScoreText";
            this.lbl_ScoreText.Size = new System.Drawing.Size(63, 23);
            this.lbl_ScoreText.TabIndex = 11;
            this.lbl_ScoreText.Text = "Score:";
            // 
            // lbl_ShowScore
            // 
            this.lbl_ShowScore.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowScore.ForeColor = System.Drawing.Color.White;
            this.lbl_ShowScore.Location = new System.Drawing.Point(27, 191);
            this.lbl_ShowScore.Name = "lbl_ShowScore";
            this.lbl_ShowScore.Size = new System.Drawing.Size(63, 28);
            this.lbl_ShowScore.TabIndex = 12;
            this.lbl_ShowScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lbl_ShowScore);
            this.panel1.Controls.Add(this.lblTitleOne);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.lbl_ScoreText);
            this.panel1.Controls.Add(this.btn_Hint);
            this.panel1.Controls.Add(this.btn_Pass);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 450);
            this.panel1.TabIndex = 13;
            // 
            // lblTitleOne
            // 
            this.lblTitleOne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitleOne.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleOne.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOne.ForeColor = System.Drawing.Color.White;
            this.lblTitleOne.Location = new System.Drawing.Point(43, 66);
            this.lblTitleOne.Name = "lblTitleOne";
            this.lblTitleOne.Size = new System.Drawing.Size(83, 50);
            this.lblTitleOne.TabIndex = 13;
            this.lblTitleOne.Text = "FLCT";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(21, 16);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(70, 68);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 15;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(129, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 13);
            this.panel2.TabIndex = 14;
            // 
            // frm_MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_translateThisTxt);
            this.Controls.Add(this.lbl_HintText);
            this.Controls.Add(this.lbl_Colour);
            this.Controls.Add(this.txtbox_Qanswer);
            this.Controls.Add(this.btn_EnterGuess);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_MainGame";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EnterGuess;
        private System.Windows.Forms.Button btn_Hint;
        private System.Windows.Forms.Button btn_Pass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtbox_Qanswer;
        private System.Windows.Forms.Label lbl_Colour;
        private System.Windows.Forms.Label lbl_HintText;
        private System.Windows.Forms.Label lbl_translateThisTxt;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_ScoreText;
        private System.Windows.Forms.Label lbl_ShowScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleOne;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

