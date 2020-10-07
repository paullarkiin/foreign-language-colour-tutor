namespace LangMainGame
{
    partial class frm_choiceMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_choiceMenu));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Num = new System.Windows.Forms.TextBox();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GetStarted = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxFlags = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblWelcome.Location = new System.Drawing.Point(326, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(172, 42);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.label2.Location = new System.Drawing.Point(45, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please choose your number of questions between 1 and 11";
            // 
            // txtBox_Num
            // 
            this.txtBox_Num.Location = new System.Drawing.Point(414, 219);
            this.txtBox_Num.Name = "txtBox_Num";
            this.txtBox_Num.Size = new System.Drawing.Size(129, 20);
            this.txtBox_Num.TabIndex = 2;
            this.txtBox_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_Num_KeyPress);
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            "Spanish",
            "Dutch",
            "Swedish"});
            this.comboBoxLang.Location = new System.Drawing.Point(414, 274);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLang.TabIndex = 3;
            this.comboBoxLang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxLang_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.25F);
            this.label3.Location = new System.Drawing.Point(146, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "What language would you like to learn?";
            // 
            // btn_GetStarted
            // 
            this.btn_GetStarted.BackColor = System.Drawing.SystemColors.Window;
            this.btn_GetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GetStarted.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_GetStarted.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_GetStarted.FlatAppearance.BorderSize = 2;
            this.btn_GetStarted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_GetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetStarted.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetStarted.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_GetStarted.Location = new System.Drawing.Point(333, 351);
            this.btn_GetStarted.Name = "btn_GetStarted";
            this.btn_GetStarted.Size = new System.Drawing.Size(124, 44);
            this.btn_GetStarted.TabIndex = 5;
            this.btn_GetStarted.Text = "Get Started!";
            this.btn_GetStarted.UseVisualStyleBackColor = false;
            this.btn_GetStarted.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 6;
            // 
            // pictureBoxFlags
            // 
            this.pictureBoxFlags.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlags.Image")));
            this.pictureBoxFlags.Location = new System.Drawing.Point(97, 23);
            this.pictureBoxFlags.Name = "pictureBoxFlags";
            this.pictureBoxFlags.Size = new System.Drawing.Size(616, 281);
            this.pictureBoxFlags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlags.TabIndex = 7;
            this.pictureBoxFlags.TabStop = false;
            // 
            // frm_choiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_GetStarted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLang);
            this.Controls.Add(this.txtBox_Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxFlags);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_choiceMenu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Num;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GetStarted;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxFlags;
    }
}