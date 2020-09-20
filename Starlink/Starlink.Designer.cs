namespace Starlink
{
    partial class frmStarlink
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Scoring = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.LblHealth = new System.Windows.Forms.Label();
            this.menuStarlink = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSoundOn = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSoundOff = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrSatellite = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.tmrLaser = new System.Windows.Forms.Timer(this.components);
            this.PnlStarlink = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.menuStarlink.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(475, 42);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "The Starlink Saga";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(569, 120);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(65, 24);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(550, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // Scoring
            // 
            this.Scoring.AutoSize = true;
            this.Scoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoring.Location = new System.Drawing.Point(574, 210);
            this.Scoring.Name = "Scoring";
            this.Scoring.Size = new System.Drawing.Size(65, 24);
            this.Scoring.TabIndex = 3;
            this.Scoring.Text = "Score";
            // 
            // LblScore
            // 
            this.LblScore.BackColor = System.Drawing.Color.White;
            this.LblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(585, 234);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(40, 20);
            this.LblScore.TabIndex = 4;
            this.LblScore.Text = "0";
            this.LblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHealth
            // 
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.Location = new System.Drawing.Point(585, 329);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(40, 20);
            this.txtHealth.TabIndex = 5;
            this.txtHealth.Text = "1000";
            this.txtHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblHealth
            // 
            this.LblHealth.AutoSize = true;
            this.LblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHealth.Location = new System.Drawing.Point(569, 302);
            this.LblHealth.Name = "LblHealth";
            this.LblHealth.Size = new System.Drawing.Size(70, 24);
            this.LblHealth.TabIndex = 6;
            this.LblHealth.Text = "Health";
            // 
            // menuStarlink
            // 
            this.menuStarlink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStarlink.Location = new System.Drawing.Point(0, 0);
            this.menuStarlink.Name = "menuStarlink";
            this.menuStarlink.Size = new System.Drawing.Size(684, 24);
            this.menuStarlink.TabIndex = 7;
            this.menuStarlink.Text = "GameMenu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop,
            this.btnQuit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(98, 22);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(98, 22);
            this.MnuStop.Text = "Stop";
            // 
            // btnQuit
            // 
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 22);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSoundOn,
            this.MnuSoundOff});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // MnuSoundOn
            // 
            this.MnuSoundOn.Name = "MnuSoundOn";
            this.MnuSoundOn.Size = new System.Drawing.Size(126, 22);
            this.MnuSoundOn.Text = "Sound on";
            // 
            // MnuSoundOff
            // 
            this.MnuSoundOff.Name = "MnuSoundOff";
            this.MnuSoundOff.Size = new System.Drawing.Size(126, 22);
            this.MnuSoundOff.Text = "Sound off";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuInstructions});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MnuInstructions
            // 
            this.MnuInstructions.Name = "MnuInstructions";
            this.MnuInstructions.Size = new System.Drawing.Size(136, 22);
            this.MnuInstructions.Text = "Instructions";
            // 
            // tmrSatellite
            // 
            this.tmrSatellite.Enabled = true;
            this.tmrSatellite.Tick += new System.EventHandler(this.tmrSatellite_Tick);
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Enabled = true;
            this.tmrPlayer.Interval = 20;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // tmrLaser
            // 
            this.tmrLaser.Enabled = true;
            this.tmrLaser.Tick += new System.EventHandler(this.tmrLaser_Tick);
            // 
            // PnlStarlink
            // 
            this.PnlStarlink.BackColor = System.Drawing.Color.Silver;
            this.PnlStarlink.BackgroundImage = global::Starlink.Properties.Resources.earth1;
            this.PnlStarlink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlStarlink.Location = new System.Drawing.Point(12, 70);
            this.PnlStarlink.Name = "PnlStarlink";
            this.PnlStarlink.Size = new System.Drawing.Size(504, 412);
            this.PnlStarlink.TabIndex = 1;
            this.PnlStarlink.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlStarlink_Paint);
            this.PnlStarlink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlStarlink_MouseDown);
            this.PnlStarlink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlStarlink_MouseMove);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(550, 364);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 20);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "View Highscores";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmStarlink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 490);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.LblHealth);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.Scoring);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.PnlStarlink);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.menuStarlink);
            this.KeyPreview = true;
            this.Name = "frmStarlink";
            this.Text = "Starlink Saga";
            this.Load += new System.EventHandler(this.frmStarlink_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStarlink_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmStarlink_KeyUp);
            this.menuStarlink.ResumeLayout(false);
            this.menuStarlink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlStarlink;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Scoring;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.Label LblHealth;
        private System.Windows.Forms.MenuStrip menuStarlink;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuSoundOn;
        private System.Windows.Forms.ToolStripMenuItem MnuSoundOff;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuInstructions;
        private System.Windows.Forms.Timer tmrSatellite;
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.Timer tmrLaser;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ToolStripMenuItem btnQuit;
    }
}

