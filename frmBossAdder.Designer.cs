namespace Final_TerrariaBossInfo_AKG
{
    partial class frmBossAdder
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
            lblGame = new Label();
            cboGameList = new ComboBox();
            cboBossList = new ComboBox();
            lblBoss = new Label();
            cboDifficultyList = new ComboBox();
            lblDifficulty = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Location = new Point(12, 15);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(41, 15);
            lblGame.TabIndex = 0;
            lblGame.Text = "Game:";
            // 
            // cboGameList
            // 
            cboGameList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGameList.FormattingEnabled = true;
            cboGameList.Location = new Point(76, 12);
            cboGameList.Name = "cboGameList";
            cboGameList.Size = new Size(288, 23);
            cboGameList.TabIndex = 0;
            cboGameList.SelectedIndexChanged += cboGameList_IndexChange;
            // 
            // cboBossList
            // 
            cboBossList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBossList.FormattingEnabled = true;
            cboBossList.Location = new Point(76, 41);
            cboBossList.Name = "cboBossList";
            cboBossList.Size = new Size(288, 23);
            cboBossList.TabIndex = 1;
            // 
            // lblBoss
            // 
            lblBoss.AutoSize = true;
            lblBoss.Location = new Point(12, 44);
            lblBoss.Name = "lblBoss";
            lblBoss.Size = new Size(34, 15);
            lblBoss.TabIndex = 2;
            lblBoss.Text = "Boss:";
            // 
            // cboDifficultyList
            // 
            cboDifficultyList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDifficultyList.FormattingEnabled = true;
            cboDifficultyList.Location = new Point(76, 70);
            cboDifficultyList.Name = "cboDifficultyList";
            cboDifficultyList.Size = new Size(288, 23);
            cboDifficultyList.TabIndex = 2;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(12, 73);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(58, 15);
            lblDifficulty.TabIndex = 4;
            lblDifficulty.Text = "Difficulty:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(12, 99);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_clicked;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(289, 99);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmBossAdder
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(373, 134);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(cboDifficultyList);
            Controls.Add(lblDifficulty);
            Controls.Add(cboBossList);
            Controls.Add(lblBoss);
            Controls.Add(cboGameList);
            Controls.Add(lblGame);
            Name = "frmBossAdder";
            Text = "Add a boss";
            Load += frmBossAdder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGame;
        private ComboBox cboGameList;
        private ComboBox cboBossList;
        private Label lblBoss;
        private ComboBox cboDifficultyList;
        private Label lblDifficulty;
        private Button btnAccept;
        private Button btnCancel;
    }
}