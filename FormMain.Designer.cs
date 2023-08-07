namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFetchLikePages = new System.Windows.Forms.Button();
            this.buttonFetchFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonFetchMyEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelMyEvents = new System.Windows.Forms.Label();
            this.buttonFetchTop5Pages = new System.Windows.Forms.Button();
            this.pictureBoxTop5Photos = new System.Windows.Forms.PictureBox();
            this.listBoxTop5Pages = new System.Windows.Forms.ListBox();
            this.labelTop5LikedPages = new System.Windows.Forms.Label();
            this.label1Sperate = new System.Windows.Forms.Label();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.checkBoxScheduledPost = new System.Windows.Forms.CheckBox();
            this.labelSpecialFeatures = new System.Windows.Forms.Label();
            this.pictureBoxFavoriteTeam = new System.Windows.Forms.PictureBox();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.labelFavoriteTeams = new System.Windows.Forms.Label();
            this.labelLikePages = new System.Windows.Forms.Label();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.labelMyAlbums = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxNewPost = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelMyPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop5Photos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1155, 649);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFetchPosts);
            this.tabPage1.Controls.Add(this.buttonFetchAlbums);
            this.tabPage1.Controls.Add(this.buttonFetchLikePages);
            this.tabPage1.Controls.Add(this.buttonFetchFavoriteTeams);
            this.tabPage1.Controls.Add(this.buttonFetchMyEvents);
            this.tabPage1.Controls.Add(this.listBoxEvents);
            this.tabPage1.Controls.Add(this.labelMyEvents);
            this.tabPage1.Controls.Add(this.buttonFetchTop5Pages);
            this.tabPage1.Controls.Add(this.pictureBoxTop5Photos);
            this.tabPage1.Controls.Add(this.listBoxTop5Pages);
            this.tabPage1.Controls.Add(this.labelTop5LikedPages);
            this.tabPage1.Controls.Add(this.label1Sperate);
            this.tabPage1.Controls.Add(this.numericUpDownMinute);
            this.tabPage1.Controls.Add(this.numericUpDownHour);
            this.tabPage1.Controls.Add(this.labelTime);
            this.tabPage1.Controls.Add(this.labelDate);
            this.tabPage1.Controls.Add(this.numericUpDownYear);
            this.tabPage1.Controls.Add(this.numericUpDownMonth);
            this.tabPage1.Controls.Add(this.numericUpDownDay);
            this.tabPage1.Controls.Add(this.checkBoxScheduledPost);
            this.tabPage1.Controls.Add(this.labelSpecialFeatures);
            this.tabPage1.Controls.Add(this.pictureBoxFavoriteTeam);
            this.tabPage1.Controls.Add(this.listBoxFavoriteTeams);
            this.tabPage1.Controls.Add(this.labelFavoriteTeams);
            this.tabPage1.Controls.Add(this.labelLikePages);
            this.tabPage1.Controls.Add(this.listBoxLikePages);
            this.tabPage1.Controls.Add(this.pictureBoxAlbum);
            this.tabPage1.Controls.Add(this.labelMyAlbums);
            this.tabPage1.Controls.Add(this.listBoxAlbums);
            this.tabPage1.Controls.Add(this.buttonPost);
            this.tabPage1.Controls.Add(this.textBoxNewPost);
            this.tabPage1.Controls.Add(this.labelPost);
            this.tabPage1.Controls.Add(this.labelMyPosts);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFetchLikePages
            // 
            this.buttonFetchLikePages.Location = new System.Drawing.Point(702, 206);
            this.buttonFetchLikePages.Name = "buttonFetchLikePages";
            this.buttonFetchLikePages.Size = new System.Drawing.Size(99, 23);
            this.buttonFetchLikePages.TabIndex = 83;
            this.buttonFetchLikePages.Text = "Fetch";
            this.buttonFetchLikePages.UseVisualStyleBackColor = true;
            this.buttonFetchLikePages.Click += new System.EventHandler(this.buttonFetchLikePages_Click);
            // 
            // buttonFetchFavoriteTeams
            // 
            this.buttonFetchFavoriteTeams.Location = new System.Drawing.Point(977, 207);
            this.buttonFetchFavoriteTeams.Name = "buttonFetchFavoriteTeams";
            this.buttonFetchFavoriteTeams.Size = new System.Drawing.Size(99, 23);
            this.buttonFetchFavoriteTeams.TabIndex = 25;
            this.buttonFetchFavoriteTeams.Text = "Fetch";
            this.buttonFetchFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavoriteTeams.Click += new System.EventHandler(this.buttonFetchFavoriteTeams_Click);
            // 
            // buttonFetchMyEvents
            // 
            this.buttonFetchMyEvents.Location = new System.Drawing.Point(977, 412);
            this.buttonFetchMyEvents.Name = "buttonFetchMyEvents";
            this.buttonFetchMyEvents.Size = new System.Drawing.Size(99, 23);
            this.buttonFetchMyEvents.TabIndex = 28;
            this.buttonFetchMyEvents.Text = "Fetch";
            this.buttonFetchMyEvents.UseVisualStyleBackColor = true;
            this.buttonFetchMyEvents.Click += new System.EventHandler(this.buttonFetchMyEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 18;
            this.listBoxEvents.Location = new System.Drawing.Point(869, 436);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(207, 166);
            this.listBoxEvents.TabIndex = 29;
            // 
            // labelMyEvents
            // 
            this.labelMyEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMyEvents.AutoSize = true;
            this.labelMyEvents.Location = new System.Drawing.Point(866, 412);
            this.labelMyEvents.Name = "labelMyEvents";
            this.labelMyEvents.Size = new System.Drawing.Size(53, 18);
            this.labelMyEvents.TabIndex = 27;
            this.labelMyEvents.Text = "Events";
            // 
            // buttonFetchTop5Pages
            // 
            this.buttonFetchTop5Pages.Location = new System.Drawing.Point(977, 42);
            this.buttonFetchTop5Pages.Name = "buttonFetchTop5Pages";
            this.buttonFetchTop5Pages.Size = new System.Drawing.Size(99, 23);
            this.buttonFetchTop5Pages.TabIndex = 16;
            this.buttonFetchTop5Pages.Text = "Fetch";
            this.buttonFetchTop5Pages.UseVisualStyleBackColor = true;
            this.buttonFetchTop5Pages.Click += new System.EventHandler(this.buttonFetchTop5Pages_Click);
            // 
            // pictureBoxTop5Photos
            // 
            this.pictureBoxTop5Photos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTop5Photos.Location = new System.Drawing.Point(977, 65);
            this.pictureBoxTop5Photos.Name = "pictureBoxTop5Photos";
            this.pictureBoxTop5Photos.Size = new System.Drawing.Size(99, 79);
            this.pictureBoxTop5Photos.TabIndex = 82;
            this.pictureBoxTop5Photos.TabStop = false;
            // 
            // listBoxTop5Pages
            // 
            this.listBoxTop5Pages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTop5Pages.FormattingEnabled = true;
            this.listBoxTop5Pages.ItemHeight = 18;
            this.listBoxTop5Pages.Location = new System.Drawing.Point(698, 66);
            this.listBoxTop5Pages.Name = "listBoxTop5Pages";
            this.listBoxTop5Pages.Size = new System.Drawing.Size(378, 112);
            this.listBoxTop5Pages.TabIndex = 17;
            this.listBoxTop5Pages.SelectedIndexChanged += new System.EventHandler(this.listBoxTop5Pages_SelectedIndexChanged);
            // 
            // labelTop5LikedPages
            // 
            this.labelTop5LikedPages.AutoSize = true;
            this.labelTop5LikedPages.Location = new System.Drawing.Point(695, 44);
            this.labelTop5LikedPages.Name = "labelTop5LikedPages";
            this.labelTop5LikedPages.Size = new System.Drawing.Size(124, 18);
            this.labelTop5LikedPages.TabIndex = 15;
            this.labelTop5LikedPages.Text = "Top 5 liked pages";
            // 
            // label1Sperate
            // 
            this.label1Sperate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1Sperate.AutoSize = true;
            this.label1Sperate.Location = new System.Drawing.Point(586, 128);
            this.label1Sperate.Name = "label1Sperate";
            this.label1Sperate.Size = new System.Drawing.Size(12, 18);
            this.label1Sperate.TabIndex = 79;
            this.label1Sperate.Text = ":";
            this.label1Sperate.Visible = false;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(600, 126);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(35, 24);
            this.numericUpDownMinute.TabIndex = 14;
            this.numericUpDownMinute.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinute.Visible = false;
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(548, 126);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(35, 24);
            this.numericUpDownHour.TabIndex = 13;
            this.numericUpDownHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHour.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(503, 126);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 18);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "Time:";
            this.labelTime.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(312, 126);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(43, 18);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date:";
            this.labelDate.Visible = false;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(440, 124);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(62, 24);
            this.numericUpDownYear.TabIndex = 11;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownYear.Visible = false;
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(399, 124);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(35, 24);
            this.numericUpDownMonth.TabIndex = 10;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Visible = false;
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(361, 124);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(32, 24);
            this.numericUpDownDay.TabIndex = 9;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Visible = false;
            // 
            // checkBoxScheduledPost
            // 
            this.checkBoxScheduledPost.AutoSize = true;
            this.checkBoxScheduledPost.Location = new System.Drawing.Point(315, 96);
            this.checkBoxScheduledPost.Name = "checkBoxScheduledPost";
            this.checkBoxScheduledPost.Size = new System.Drawing.Size(131, 22);
            this.checkBoxScheduledPost.TabIndex = 7;
            this.checkBoxScheduledPost.Text = "Scheduled Post";
            this.checkBoxScheduledPost.UseVisualStyleBackColor = true;
            this.checkBoxScheduledPost.CheckedChanged += new System.EventHandler(this.checkBoxScheduledPost_CheckedChanged);
            // 
            // labelSpecialFeatures
            // 
            this.labelSpecialFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpecialFeatures.AutoSize = true;
            this.labelSpecialFeatures.Location = new System.Drawing.Point(312, 17);
            this.labelSpecialFeatures.Name = "labelSpecialFeatures";
            this.labelSpecialFeatures.Size = new System.Drawing.Size(118, 18);
            this.labelSpecialFeatures.TabIndex = 3;
            this.labelSpecialFeatures.Text = "Special Features";
            // 
            // pictureBoxFavoriteTeam
            // 
            this.pictureBoxFavoriteTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFavoriteTeam.Location = new System.Drawing.Point(977, 252);
            this.pictureBoxFavoriteTeam.Name = "pictureBoxFavoriteTeam";
            this.pictureBoxFavoriteTeam.Size = new System.Drawing.Size(99, 61);
            this.pictureBoxFavoriteTeam.TabIndex = 69;
            this.pictureBoxFavoriteTeam.TabStop = false;
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 18;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(869, 230);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(207, 166);
            this.listBoxFavoriteTeams.TabIndex = 26;
            // 
            // labelFavoriteTeams
            // 
            this.labelFavoriteTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFavoriteTeams.AutoSize = true;
            this.labelFavoriteTeams.Location = new System.Drawing.Point(866, 206);
            this.labelFavoriteTeams.Name = "labelFavoriteTeams";
            this.labelFavoriteTeams.Size = new System.Drawing.Size(111, 18);
            this.labelFavoriteTeams.TabIndex = 24;
            this.labelFavoriteTeams.Text = "Favorite Teams";
            // 
            // labelLikePages
            // 
            this.labelLikePages.AutoSize = true;
            this.labelLikePages.Location = new System.Drawing.Point(597, 209);
            this.labelLikePages.Name = "labelLikePages";
            this.labelLikePages.Size = new System.Drawing.Size(81, 18);
            this.labelLikePages.TabIndex = 22;
            this.labelLikePages.Text = "Like Pages";
            this.labelLikePages.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 18;
            this.listBoxLikePages.Location = new System.Drawing.Point(600, 230);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(201, 382);
            this.listBoxLikePages.TabIndex = 23;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAlbum.Location = new System.Drawing.Point(440, 230);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(94, 61);
            this.pictureBoxAlbum.TabIndex = 64;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // labelMyAlbums
            // 
            this.labelMyAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMyAlbums.AutoSize = true;
            this.labelMyAlbums.Location = new System.Drawing.Point(312, 209);
            this.labelMyAlbums.Name = "labelMyAlbums";
            this.labelMyAlbums.Size = new System.Drawing.Size(57, 18);
            this.labelMyAlbums.TabIndex = 20;
            this.labelMyAlbums.Text = "Albums";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 18;
            this.listBoxAlbums.Location = new System.Drawing.Point(315, 230);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(219, 382);
            this.listBoxAlbums.TabIndex = 21;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(589, 66);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxNewPost
            // 
            this.textBoxNewPost.Location = new System.Drawing.Point(315, 65);
            this.textBoxNewPost.Name = "textBoxNewPost";
            this.textBoxNewPost.Size = new System.Drawing.Size(268, 24);
            this.textBoxNewPost.TabIndex = 5;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(312, 44);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(128, 18);
            this.labelPost.TabIndex = 4;
            this.labelPost.Text = "Post a new Status";
            // 
            // labelMyPosts
            // 
            this.labelMyPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMyPosts.AutoSize = true;
            this.labelMyPosts.Location = new System.Drawing.Point(15, 209);
            this.labelMyPosts.Name = "labelMyPosts";
            this.labelMyPosts.Size = new System.Drawing.Size(77, 18);
            this.labelMyPosts.TabIndex = 18;
            this.labelMyPosts.Text = "Last posts";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(18, 230);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(234, 382);
            this.listBoxPosts.TabIndex = 19;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(435, 206);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(99, 23);
            this.buttonFetchAlbums.TabIndex = 84;
            this.buttonFetchAlbums.Text = "Fetch";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(153, 206);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(99, 23);
            this.buttonFetchPosts.TabIndex = 85;
            this.buttonFetchPosts.Text = "Fetch";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 649);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop5Photos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelMyPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBoxNewPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelMyAlbums;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.PictureBox pictureBoxFavoriteTeam;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.Label labelFavoriteTeams;
        private System.Windows.Forms.Label labelLikePages;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.Label labelSpecialFeatures;
        private System.Windows.Forms.CheckBox checkBoxScheduledPost;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label1Sperate;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBoxTop5Photos;
        private System.Windows.Forms.ListBox listBoxTop5Pages;
        private System.Windows.Forms.Label labelTop5LikedPages;
        private System.Windows.Forms.Button buttonFetchTop5Pages;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelMyEvents;
        private System.Windows.Forms.Button buttonFetchMyEvents;
        private System.Windows.Forms.Button buttonFetchFavoriteTeams;
        private System.Windows.Forms.Button buttonFetchLikePages;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Button buttonFetchPosts;
    }
}

