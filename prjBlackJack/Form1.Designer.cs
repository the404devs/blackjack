namespace prjBlackJack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCpuCard1 = new System.Windows.Forms.PictureBox();
            this.picUserCard1 = new System.Windows.Forms.PictureBox();
            this.picUserCard2 = new System.Windows.Forms.PictureBox();
            this.picUserCard3 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserMoney = new System.Windows.Forms.Label();
            this.lblCpuMoney = new System.Windows.Forms.Label();
            this.picUserCard4 = new System.Windows.Forms.PictureBox();
            this.picUserCard5 = new System.Windows.Forms.PictureBox();
            this.picCpuCard2 = new System.Windows.Forms.PictureBox();
            this.picCpuCard3 = new System.Windows.Forms.PictureBox();
            this.picCpuCard4 = new System.Windows.Forms.PictureBox();
            this.picCpuCard5 = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCpuScore = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeyDisplayString = "(F2)";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // picCpuCard1
            // 
            this.picCpuCard1.BackColor = System.Drawing.Color.Transparent;
            this.picCpuCard1.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picCpuCard1.Location = new System.Drawing.Point(25, 82);
            this.picCpuCard1.Name = "picCpuCard1";
            this.picCpuCard1.Size = new System.Drawing.Size(66, 90);
            this.picCpuCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpuCard1.TabIndex = 1;
            this.picCpuCard1.TabStop = false;
            // 
            // picUserCard1
            // 
            this.picUserCard1.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard1.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picUserCard1.Location = new System.Drawing.Point(25, 240);
            this.picUserCard1.Name = "picUserCard1";
            this.picUserCard1.Size = new System.Drawing.Size(78, 107);
            this.picUserCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard1.TabIndex = 2;
            this.picUserCard1.TabStop = false;
            // 
            // picUserCard2
            // 
            this.picUserCard2.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard2.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picUserCard2.Location = new System.Drawing.Point(109, 240);
            this.picUserCard2.Name = "picUserCard2";
            this.picUserCard2.Size = new System.Drawing.Size(78, 107);
            this.picUserCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard2.TabIndex = 3;
            this.picUserCard2.TabStop = false;
            // 
            // picUserCard3
            // 
            this.picUserCard3.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard3.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picUserCard3.Location = new System.Drawing.Point(193, 240);
            this.picUserCard3.Name = "picUserCard3";
            this.picUserCard3.Size = new System.Drawing.Size(78, 107);
            this.picUserCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard3.TabIndex = 4;
            this.picUserCard3.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Gabriola", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(297, 44);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Player\'s Hand";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer\'s Hand";
            // 
            // lblUserMoney
            // 
            this.lblUserMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblUserMoney.Font = new System.Drawing.Font("Gabriola", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMoney.Location = new System.Drawing.Point(309, 174);
            this.lblUserMoney.Name = "lblUserMoney";
            this.lblUserMoney.Size = new System.Drawing.Size(83, 44);
            this.lblUserMoney.TabIndex = 7;
            this.lblUserMoney.Text = "$0";
            // 
            // lblCpuMoney
            // 
            this.lblCpuMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuMoney.Font = new System.Drawing.Font("Gabriola", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuMoney.Location = new System.Drawing.Point(309, 23);
            this.lblCpuMoney.Name = "lblCpuMoney";
            this.lblCpuMoney.Size = new System.Drawing.Size(82, 44);
            this.lblCpuMoney.TabIndex = 8;
            this.lblCpuMoney.Text = "$0";
            // 
            // picUserCard4
            // 
            this.picUserCard4.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard4.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picUserCard4.Location = new System.Drawing.Point(277, 240);
            this.picUserCard4.Name = "picUserCard4";
            this.picUserCard4.Size = new System.Drawing.Size(78, 107);
            this.picUserCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard4.TabIndex = 9;
            this.picUserCard4.TabStop = false;
            // 
            // picUserCard5
            // 
            this.picUserCard5.BackColor = System.Drawing.Color.Transparent;
            this.picUserCard5.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picUserCard5.Location = new System.Drawing.Point(361, 240);
            this.picUserCard5.Name = "picUserCard5";
            this.picUserCard5.Size = new System.Drawing.Size(78, 107);
            this.picUserCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserCard5.TabIndex = 10;
            this.picUserCard5.TabStop = false;
            // 
            // picCpuCard2
            // 
            this.picCpuCard2.BackColor = System.Drawing.Color.Transparent;
            this.picCpuCard2.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picCpuCard2.Location = new System.Drawing.Point(97, 82);
            this.picCpuCard2.Name = "picCpuCard2";
            this.picCpuCard2.Size = new System.Drawing.Size(66, 90);
            this.picCpuCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpuCard2.TabIndex = 11;
            this.picCpuCard2.TabStop = false;
            // 
            // picCpuCard3
            // 
            this.picCpuCard3.BackColor = System.Drawing.Color.Transparent;
            this.picCpuCard3.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picCpuCard3.Location = new System.Drawing.Point(169, 82);
            this.picCpuCard3.Name = "picCpuCard3";
            this.picCpuCard3.Size = new System.Drawing.Size(66, 90);
            this.picCpuCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpuCard3.TabIndex = 12;
            this.picCpuCard3.TabStop = false;
            // 
            // picCpuCard4
            // 
            this.picCpuCard4.BackColor = System.Drawing.Color.Transparent;
            this.picCpuCard4.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picCpuCard4.Location = new System.Drawing.Point(241, 82);
            this.picCpuCard4.Name = "picCpuCard4";
            this.picCpuCard4.Size = new System.Drawing.Size(66, 90);
            this.picCpuCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpuCard4.TabIndex = 13;
            this.picCpuCard4.TabStop = false;
            // 
            // picCpuCard5
            // 
            this.picCpuCard5.BackColor = System.Drawing.Color.Transparent;
            this.picCpuCard5.Image = global::prjBlackJack.Properties.Resources.card55;
            this.picCpuCard5.Location = new System.Drawing.Point(313, 82);
            this.picCpuCard5.Name = "picCpuCard5";
            this.picCpuCard5.Size = new System.Drawing.Size(66, 90);
            this.picCpuCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpuCard5.TabIndex = 14;
            this.picCpuCard5.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(25, 365);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(116, 37);
            this.btnDeal.TabIndex = 15;
            this.btnDeal.Text = "DEAL";
            this.btnDeal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(147, 365);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(116, 37);
            this.btnHit.TabIndex = 16;
            this.btnHit.Text = "HIT";
            this.btnHit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(269, 365);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(116, 37);
            this.btnStay.TabIndex = 17;
            this.btnStay.Text = "STAY";
            this.btnStay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(465, 189);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(53, 37);
            this.btnBet.TabIndex = 18;
            this.btnBet.Text = "BET";
            this.btnBet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBet
            // 
            this.txtBet.AcceptsReturn = true;
            this.txtBet.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            this.txtBet.Location = new System.Drawing.Point(408, 189);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(51, 37);
            this.txtBet.TabIndex = 19;
            this.txtBet.TextChanged += new System.EventHandler(this.txtBet_TextChanged);
            this.txtBet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBet_KeyDown);
            this.txtBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBet_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(389, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 44);
            this.label5.TabIndex = 20;
            this.label5.Text = "$";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserScore
            // 
            this.lblUserScore.BackColor = System.Drawing.Color.Transparent;
            this.lblUserScore.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblUserScore.Location = new System.Drawing.Point(450, 284);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(66, 48);
            this.lblUserScore.TabIndex = 21;
            this.lblUserScore.Text = "-";
            this.lblUserScore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(444, 255);
            this.label8.MaximumSize = new System.Drawing.Size(0, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Your Score:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(443, 69);
            this.label7.MaximumSize = new System.Drawing.Size(100, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 60);
            this.label7.TabIndex = 25;
            this.label7.Text = "Computer\'s Score:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCpuScore
            // 
            this.lblCpuScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuScore.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblCpuScore.Location = new System.Drawing.Point(450, 129);
            this.lblCpuScore.Name = "lblCpuScore";
            this.lblCpuScore.Size = new System.Drawing.Size(66, 48);
            this.lblCpuScore.TabIndex = 24;
            this.lblCpuScore.Text = "-";
            this.lblCpuScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(18, 405);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(498, 44);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Place Bet...";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(391, 365);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 37);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "NEXT";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 455);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCpuScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.picCpuCard5);
            this.Controls.Add(this.picCpuCard4);
            this.Controls.Add(this.picCpuCard3);
            this.Controls.Add(this.picCpuCard2);
            this.Controls.Add(this.picUserCard5);
            this.Controls.Add(this.picUserCard4);
            this.Controls.Add(this.lblCpuMoney);
            this.Controls.Add(this.lblUserMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picUserCard1);
            this.Controls.Add(this.picCpuCard1);
            this.Controls.Add(this.picUserCard2);
            this.Controls.Add(this.picUserCard3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jack Black\'s BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpuCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.PictureBox picCpuCard1;
        private System.Windows.Forms.PictureBox picUserCard1;
        private System.Windows.Forms.PictureBox picUserCard2;
        private System.Windows.Forms.PictureBox picUserCard3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserMoney;
        private System.Windows.Forms.Label lblCpuMoney;
        private System.Windows.Forms.PictureBox picUserCard4;
        private System.Windows.Forms.PictureBox picUserCard5;
        private System.Windows.Forms.PictureBox picCpuCard2;
        private System.Windows.Forms.PictureBox picCpuCard3;
        private System.Windows.Forms.PictureBox picCpuCard4;
        private System.Windows.Forms.PictureBox picCpuCard5;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCpuScore;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNext;
    }
}

