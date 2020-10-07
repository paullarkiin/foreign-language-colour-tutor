namespace LangMainGame
{
    partial class frm_OpeningScreen
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
            this.panelLoader = new System.Windows.Forms.Panel();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.lbl_secondText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitleOne = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoader
            // 
            this.panelLoader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelLoader.Controls.Add(this.PanelSlide);
            this.panelLoader.Location = new System.Drawing.Point(231, 248);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(331, 11);
            this.panelLoader.TabIndex = 8;
            // 
            // PanelSlide
            // 
            this.PanelSlide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelSlide.BackColor = System.Drawing.Color.Orange;
            this.PanelSlide.Location = new System.Drawing.Point(237, 1);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelSlide.Size = new System.Drawing.Size(94, 10);
            this.PanelSlide.TabIndex = 5;
            // 
            // lbl_secondText
            // 
            this.lbl_secondText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_secondText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondText.ForeColor = System.Drawing.Color.White;
            this.lbl_secondText.Location = new System.Drawing.Point(350, 182);
            this.lbl_secondText.Name = "lbl_secondText";
            this.lbl_secondText.Size = new System.Drawing.Size(244, 23);
            this.lbl_secondText.TabIndex = 5;
            this.lbl_secondText.Text = "Foregin Language Colour Tutor";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(316, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 77);
            this.label2.TabIndex = 7;
            this.label2.Text = "|";
            // 
            // lblTitleOne
            // 
            this.lblTitleOne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitleOne.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOne.ForeColor = System.Drawing.Color.White;
            this.lblTitleOne.Location = new System.Drawing.Point(208, 149);
            this.lblTitleOne.Name = "lblTitleOne";
            this.lblTitleOne.Size = new System.Drawing.Size(136, 87);
            this.lblTitleOne.TabIndex = 6;
            this.lblTitleOne.Text = "FLCT";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frm_OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(825, 445);
            this.Controls.Add(this.panelLoader);
            this.Controls.Add(this.lbl_secondText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitleOne);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_OpeningScreen";
            this.Load += new System.EventHandler(this.Frm_OpeningScreen_Load);
            this.panelLoader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoader;
        private System.Windows.Forms.Panel PanelSlide;
        private System.Windows.Forms.Label lbl_secondText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleOne;
        private System.Windows.Forms.Timer timer1;
    }
}