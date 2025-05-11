namespace Final_TerrariaBossInfo_AKG
{
    partial class frmBossLibrary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddBoss = new Button();
            grpBoss1 = new GroupBox();
            lblBossDifficulty1 = new Label();
            lblBossName1 = new Label();
            lblGame1 = new Label();
            grpBoss2 = new GroupBox();
            lblBossDifficulty2 = new Label();
            lblBossName2 = new Label();
            lblGame2 = new Label();
            btnRemoveBoss1 = new Button();
            btnRemoveBoss2 = new Button();
            btnLoadStats = new Button();
            btnExit = new Button();
            grpBoss1.SuspendLayout();
            grpBoss2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddBoss
            // 
            btnAddBoss.Location = new Point(12, 12);
            btnAddBoss.Name = "btnAddBoss";
            btnAddBoss.Size = new Size(75, 23);
            btnAddBoss.TabIndex = 0;
            btnAddBoss.Text = "&Add boss";
            btnAddBoss.UseVisualStyleBackColor = true;
            btnAddBoss.Click += btnAddBoss_Click;
            // 
            // grpBoss1
            // 
            grpBoss1.Controls.Add(lblBossDifficulty1);
            grpBoss1.Controls.Add(lblBossName1);
            grpBoss1.Controls.Add(lblGame1);
            grpBoss1.Location = new Point(12, 41);
            grpBoss1.Name = "grpBoss1";
            grpBoss1.Size = new Size(320, 71);
            grpBoss1.TabIndex = 1;
            grpBoss1.TabStop = false;
            grpBoss1.Text = "Boss 1";
            // 
            // lblBossDifficulty1
            // 
            lblBossDifficulty1.AutoSize = true;
            lblBossDifficulty1.Location = new Point(6, 49);
            lblBossDifficulty1.Name = "lblBossDifficulty1";
            lblBossDifficulty1.Size = new Size(58, 15);
            lblBossDifficulty1.TabIndex = 4;
            lblBossDifficulty1.Text = "Difficulty:";
            // 
            // lblBossName1
            // 
            lblBossName1.AutoSize = true;
            lblBossName1.Location = new Point(6, 34);
            lblBossName1.Name = "lblBossName1";
            lblBossName1.Size = new Size(34, 15);
            lblBossName1.TabIndex = 3;
            lblBossName1.Text = "Boss:";
            // 
            // lblGame1
            // 
            lblGame1.AutoSize = true;
            lblGame1.Location = new Point(6, 19);
            lblGame1.Name = "lblGame1";
            lblGame1.Size = new Size(41, 15);
            lblGame1.TabIndex = 2;
            lblGame1.Text = "Game:";
            // 
            // grpBoss2
            // 
            grpBoss2.Controls.Add(lblBossDifficulty2);
            grpBoss2.Controls.Add(lblBossName2);
            grpBoss2.Controls.Add(lblGame2);
            grpBoss2.Location = new Point(338, 41);
            grpBoss2.Name = "grpBoss2";
            grpBoss2.Size = new Size(320, 71);
            grpBoss2.TabIndex = 5;
            grpBoss2.TabStop = false;
            grpBoss2.Text = "Boss 2";
            // 
            // lblBossDifficulty2
            // 
            lblBossDifficulty2.AutoSize = true;
            lblBossDifficulty2.Location = new Point(6, 49);
            lblBossDifficulty2.Name = "lblBossDifficulty2";
            lblBossDifficulty2.Size = new Size(58, 15);
            lblBossDifficulty2.TabIndex = 4;
            lblBossDifficulty2.Text = "Difficulty:";
            // 
            // lblBossName2
            // 
            lblBossName2.AutoSize = true;
            lblBossName2.Location = new Point(6, 34);
            lblBossName2.Name = "lblBossName2";
            lblBossName2.Size = new Size(34, 15);
            lblBossName2.TabIndex = 3;
            lblBossName2.Text = "Boss:";
            // 
            // lblGame2
            // 
            lblGame2.AutoSize = true;
            lblGame2.Location = new Point(6, 19);
            lblGame2.Name = "lblGame2";
            lblGame2.Size = new Size(41, 15);
            lblGame2.TabIndex = 2;
            lblGame2.Text = "Game:";
            // 
            // btnRemoveBoss1
            // 
            btnRemoveBoss1.Location = new Point(12, 118);
            btnRemoveBoss1.Name = "btnRemoveBoss1";
            btnRemoveBoss1.Size = new Size(94, 23);
            btnRemoveBoss1.TabIndex = 1;
            btnRemoveBoss1.Text = "&Remove boss 1";
            btnRemoveBoss1.UseVisualStyleBackColor = true;
            btnRemoveBoss1.Click += btnRemoveBoss1_Click;
            // 
            // btnRemoveBoss2
            // 
            btnRemoveBoss2.Location = new Point(338, 118);
            btnRemoveBoss2.Name = "btnRemoveBoss2";
            btnRemoveBoss2.Size = new Size(94, 23);
            btnRemoveBoss2.TabIndex = 2;
            btnRemoveBoss2.Text = "&Remove boss 2";
            btnRemoveBoss2.UseVisualStyleBackColor = true;
            btnRemoveBoss2.Click += btnRemoveBoss2_Click;
            // 
            // btnLoadStats
            // 
            btnLoadStats.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoadStats.Location = new Point(12, 186);
            btnLoadStats.Name = "btnLoadStats";
            btnLoadStats.Size = new Size(75, 23);
            btnLoadStats.TabIndex = 3;
            btnLoadStats.Text = "&Load stats";
            btnLoadStats.UseVisualStyleBackColor = true;
            btnLoadStats.Click += btnLoadStats_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(605, 186);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBossLibrary
            // 
            AcceptButton = btnLoadStats;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(693, 221);
            Controls.Add(btnExit);
            Controls.Add(btnLoadStats);
            Controls.Add(btnRemoveBoss2);
            Controls.Add(btnRemoveBoss1);
            Controls.Add(grpBoss2);
            Controls.Add(grpBoss1);
            Controls.Add(btnAddBoss);
            MinimumSize = new Size(709, 260);
            Name = "frmBossLibrary";
            Text = "Terraria Boss Information";
            Load += frmBossLibrary_Load;
            grpBoss1.ResumeLayout(false);
            grpBoss1.PerformLayout();
            grpBoss2.ResumeLayout(false);
            grpBoss2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddBoss;
        private Button btnRemoveBoss1;
        private Button btnRemoveBoss2;
        private Button btnLoadStats;
        private Button btnExit;
        public Label lblGame1;
        public GroupBox grpBoss1;
        public Label lblBossDifficulty1;
        public Label lblBossName1;
        public GroupBox grpBoss2;
        public Label lblBossDifficulty2;
        public Label lblBossName2;
        public Label lblGame2;
    }
}
