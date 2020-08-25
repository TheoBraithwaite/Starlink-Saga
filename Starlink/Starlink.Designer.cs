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
            this.PnlStarlink = new System.Windows.Forms.Panel();
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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrSatellite = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.menuStarlink.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.Font = new System.Drawing.Font("OCR A Std", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(475, 42);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "The Starlink Saga";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlStarlink
            // 
            this.PnlStarlink.BackColor = System.Drawing.Color.Silver;
            this.PnlStarlink.Location = new System.Drawing.Point(12, 70);
            this.PnlStarlink.Name = "PnlStarlink";
            this.PnlStarlink.Size = new System.Drawing.Size(504, 412);
            this.PnlStarlink.TabIndex = 1;
            this.PnlStarlink.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlStarlink_Paint);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("OCR A Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(569, 120);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(65, 20);
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
            this.Scoring.Font = new System.Drawing.Font("OCR A Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoring.Location = new System.Drawing.Point(564, 214);
            this.Scoring.Name = "Scoring";
            this.Scoring.Size = new System.Drawing.Size(79, 20);
            this.Scoring.TabIndex = 3;
            this.Scoring.Text = "Score";
            // 
            // LblScore
            // 
            this.LblScore.BackColor = System.Drawing.Color.White;
            this.LblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblScore.Font = new System.Drawing.Font("OCR A Std", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(585, 234);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(40, 20);
            this.LblScore.TabIndex = 4;
            this.LblScore.Text = "0";
            this.LblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHealth
            // 
            this.txtHealth.Font = new System.Drawing.Font("OCR A Std", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.Location = new System.Drawing.Point(585, 329);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(40, 21);
            this.txtHealth.TabIndex = 5;
            this.txtHealth.Text = "3";
            this.txtHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblHealth
            // 
            this.LblHealth.AutoSize = true;
            this.LblHealth.Font = new System.Drawing.Font("OCR A Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHealth.Location = new System.Drawing.Point(557, 306);
            this.LblHealth.Name = "LblHealth";
            this.LblHealth.Size = new System.Drawing.Size(93, 20);
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
            this.MnuStop});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(180, 22);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(180, 22);
            this.MnuStop.Text = "Stop";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundOnToolStripMenuItem,
            this.soundOffToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // soundOnToolStripMenuItem
            // 
            this.soundOnToolStripMenuItem.Name = "soundOnToolStripMenuItem";
            this.soundOnToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.soundOnToolStripMenuItem.Text = "Sound on";
            // 
            // soundOffToolStripMenuItem
            // 
            this.soundOffToolStripMenuItem.Name = "soundOffToolStripMenuItem";
            this.soundOffToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.soundOffToolStripMenuItem.Text = "Sound off";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // tmrSatellite
            // 
            this.tmrSatellite.Enabled = true;
            this.tmrSatellite.Tick += new System.EventHandler(this.tmrSatellite_Tick);
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Enabled = true;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // frmStarlink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 490);
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
        private System.Windows.Forms.ToolStripMenuItem soundOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Timer tmrSatellite;
        private System.Windows.Forms.Timer tmrPlayer;
    }
}

