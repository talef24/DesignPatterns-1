namespace AppUI
{
    public partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonFriends = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.comboBoxPageColor = new System.Windows.Forms.ComboBox();
            this.comboBoxButtonsColor = new System.Windows.Forms.ComboBox();
            this.comboBoxNameColor = new System.Windows.Forms.ComboBox();
            this.comboBoxMotto = new System.Windows.Forms.ComboBox();
            this.labelMotto = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelHomeTown = new System.Windows.Forms.Label();
            this.labelRelationshipStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHomeTown = new System.Windows.Forms.PictureBox();
            this.pictureBoxBirthday = new System.Windows.Forms.PictureBox();
            this.pictureBoxLocation = new System.Windows.Forms.PictureBox();
            this.pictureBoxSetting = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonFriends.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFriends.Location = new System.Drawing.Point(941, 431);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(138, 36);
            this.buttonFriends.TabIndex = 2;
            this.buttonFriends.Text = "Fetch Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(7, 399);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(384, 224);
            this.listBoxPosts.TabIndex = 3;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(520, 247);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(106, 37);
            this.labelUserName.TabIndex = 8;
            this.labelUserName.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(2, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Posts";
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonEvents.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEvents.Location = new System.Drawing.Point(941, 249);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(138, 34);
            this.buttonEvents.TabIndex = 13;
            this.buttonEvents.Text = "Fetch Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(941, 473);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(138, 144);
            this.listBoxFriends.TabIndex = 14;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(945, 297);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(134, 124);
            this.listBoxEvents.TabIndex = 15;
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonGroups.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGroups.Location = new System.Drawing.Point(1099, 249);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(134, 35);
            this.buttonGroups.TabIndex = 16;
            this.buttonGroups.Text = "Fetch Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(1099, 297);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(136, 124);
            this.listBoxGroups.TabIndex = 17;
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAlbums.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAlbums.Location = new System.Drawing.Point(160, 110);
            this.buttonAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(138, 37);
            this.buttonAlbums.TabIndex = 18;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(466, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Info";
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCheckIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCheckIn.Location = new System.Drawing.Point(1099, 431);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(136, 36);
            this.buttonCheckIn.TabIndex = 21;
            this.buttonCheckIn.Text = "Fetch check-in";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.ItemHeight = 20;
            this.listBoxCheckIn.Location = new System.Drawing.Point(1099, 477);
            this.listBoxCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(134, 144);
            this.listBoxCheckIn.TabIndex = 22;
            // 
            // comboBoxPageColor
            // 
            this.comboBoxPageColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxPageColor.FormattingEnabled = true;
            this.comboBoxPageColor.Items.AddRange(new object[] {
            "White",
            "Pink",
            "Green"});
            this.comboBoxPageColor.Location = new System.Drawing.Point(966, 85);
            this.comboBoxPageColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPageColor.Name = "comboBoxPageColor";
            this.comboBoxPageColor.Size = new System.Drawing.Size(212, 28);
            this.comboBoxPageColor.TabIndex = 24;
            this.comboBoxPageColor.Text = "          Page Color";
            this.comboBoxPageColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageColor_SelectedIndexChanged);
            // 
            // comboBoxButtonsColor
            // 
            this.comboBoxButtonsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxButtonsColor.FormattingEnabled = true;
            this.comboBoxButtonsColor.Items.AddRange(new object[] {
            "Blue",
            "Black"});
            this.comboBoxButtonsColor.Location = new System.Drawing.Point(966, 123);
            this.comboBoxButtonsColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxButtonsColor.Name = "comboBoxButtonsColor";
            this.comboBoxButtonsColor.Size = new System.Drawing.Size(212, 28);
            this.comboBoxButtonsColor.TabIndex = 25;
            this.comboBoxButtonsColor.Text = "          Buttons Color";
            this.comboBoxButtonsColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxButtonsColor_SelectedIndexChanged);
            // 
            // comboBoxNameColor
            // 
            this.comboBoxNameColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxNameColor.FormattingEnabled = true;
            this.comboBoxNameColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Yellow"});
            this.comboBoxNameColor.Location = new System.Drawing.Point(966, 161);
            this.comboBoxNameColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNameColor.Name = "comboBoxNameColor";
            this.comboBoxNameColor.Size = new System.Drawing.Size(212, 28);
            this.comboBoxNameColor.TabIndex = 26;
            this.comboBoxNameColor.Text = "          Name Color";
            this.comboBoxNameColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameColor_SelectedIndexChanged);
            // 
            // comboBoxMotto
            // 
            this.comboBoxMotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxMotto.FormattingEnabled = true;
            this.comboBoxMotto.Items.AddRange(new object[] {
            "None",
            "\"YOU ONLY LIVE ONCE\"",
            "\"If you can dream it, you can do it!!!\" "});
            this.comboBoxMotto.Location = new System.Drawing.Point(966, 199);
            this.comboBoxMotto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMotto.Name = "comboBoxMotto";
            this.comboBoxMotto.Size = new System.Drawing.Size(212, 28);
            this.comboBoxMotto.TabIndex = 28;
            this.comboBoxMotto.Text = "          Add Motto";
            this.comboBoxMotto.SelectedIndexChanged += new System.EventHandler(this.comboBoxMotto_SelectedIndexChanged);
            // 
            // labelMotto
            // 
            this.labelMotto.AutoSize = true;
            this.labelMotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMotto.Location = new System.Drawing.Point(522, 285);
            this.labelMotto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMotto.Name = "labelMotto";
            this.labelMotto.Size = new System.Drawing.Size(70, 25);
            this.labelMotto.TabIndex = 29;
            this.labelMotto.Text = "label1";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(7, 81);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(140, 24);
            this.checkBoxRememberMe.TabIndex = 30;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCalendar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCalendar.Location = new System.Drawing.Point(7, 111);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(140, 36);
            this.buttonCalendar.TabIndex = 31;
            this.buttonCalendar.Text = "My Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = false;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(513, 399);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(74, 20);
            this.labelLocation.TabIndex = 35;
            this.labelLocation.Text = "Location:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(513, 494);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(71, 20);
            this.labelBirthday.TabIndex = 36;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelHomeTown
            // 
            this.labelHomeTown.AutoSize = true;
            this.labelHomeTown.Location = new System.Drawing.Point(513, 447);
            this.labelHomeTown.Name = "labelHomeTown";
            this.labelHomeTown.Size = new System.Drawing.Size(98, 20);
            this.labelHomeTown.TabIndex = 39;
            this.labelHomeTown.Text = "Home Town:";
            // 
            // labelRelationshipStatus
            // 
            this.labelRelationshipStatus.AutoSize = true;
            this.labelRelationshipStatus.Location = new System.Drawing.Point(513, 541);
            this.labelRelationshipStatus.Name = "labelRelationshipStatus";
            this.labelRelationshipStatus.Size = new System.Drawing.Size(152, 20);
            this.labelRelationshipStatus.TabIndex = 41;
            this.labelRelationshipStatus.Text = "Relationship Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.heartSymbol1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(471, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxHomeTown
            // 
            this.pictureBoxHomeTown.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.homeSymbol1;
            this.pictureBoxHomeTown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHomeTown.Location = new System.Drawing.Point(471, 427);
            this.pictureBoxHomeTown.Name = "pictureBoxHomeTown";
            this.pictureBoxHomeTown.Size = new System.Drawing.Size(39, 45);
            this.pictureBoxHomeTown.TabIndex = 34;
            this.pictureBoxHomeTown.TabStop = false;
            // 
            // pictureBoxBirthday
            // 
            this.pictureBoxBirthday.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.birthdaySymbol1;
            this.pictureBoxBirthday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBirthday.Location = new System.Drawing.Point(471, 478);
            this.pictureBoxBirthday.Name = "pictureBoxBirthday";
            this.pictureBoxBirthday.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxBirthday.TabIndex = 33;
            this.pictureBoxBirthday.TabStop = false;
            // 
            // pictureBoxLocation
            // 
            this.pictureBoxLocation.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.locationSymbol1;
            this.pictureBoxLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLocation.Location = new System.Drawing.Point(471, 382);
            this.pictureBoxLocation.Name = "pictureBoxLocation";
            this.pictureBoxLocation.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxLocation.TabIndex = 32;
            this.pictureBoxLocation.TabStop = false;
            // 
            // pictureBoxSetting
            // 
            this.pictureBoxSetting.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.Setting1;
            this.pictureBoxSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSetting.Location = new System.Drawing.Point(1186, 85);
            this.pictureBoxSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxSetting.Name = "pictureBoxSetting";
            this.pictureBoxSetting.Size = new System.Drawing.Size(65, 66);
            this.pictureBoxSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSetting.TabIndex = 23;
            this.pictureBoxSetting.TabStop = false;
            this.pictureBoxSetting.Click += new System.EventHandler(this.pictureBoxSetting_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(524, 77);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(190, 165);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 7;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.FacebookTitle2;
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Location = new System.Drawing.Point(2, 0);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(1255, 67);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 6;
            this.pictureBoxCover.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1258, 634);
            this.Controls.Add(this.labelRelationshipStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHomeTown);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.pictureBoxHomeTown);
            this.Controls.Add(this.pictureBoxBirthday);
            this.Controls.Add(this.pictureBoxLocation);
            this.Controls.Add(this.buttonCalendar);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.labelMotto);
            this.Controls.Add(this.comboBoxMotto);
            this.Controls.Add(this.comboBoxNameColor);
            this.Controls.Add(this.comboBoxButtonsColor);
            this.Controls.Add(this.comboBoxPageColor);
            this.Controls.Add(this.pictureBoxSetting);
            this.Controls.Add(this.listBoxCheckIn);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonFriends);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1280, 690);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.ListBox listBoxCheckIn;
        private System.Windows.Forms.PictureBox pictureBoxSetting;
        private System.Windows.Forms.ComboBox comboBoxPageColor;
        private System.Windows.Forms.ComboBox comboBoxButtonsColor;
        private System.Windows.Forms.ComboBox comboBoxNameColor;
        private System.Windows.Forms.Label labelMotto;
        private System.Windows.Forms.ComboBox comboBoxMotto;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.PictureBox pictureBoxLocation;
        private System.Windows.Forms.PictureBox pictureBoxBirthday;
        private System.Windows.Forms.PictureBox pictureBoxHomeTown;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelHomeTown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRelationshipStatus;
    }
}