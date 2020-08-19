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
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlStarlink = new System.Windows.Forms.Panel();
            this.LblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Scoring = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.LblHealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.Font = new System.Drawing.Font("OCR A Std", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 3);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(504, 31);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "The Starlink Saga";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlStarlink
            // 
            this.PnlStarlink.BackColor = System.Drawing.Color.Black;
            this.PnlStarlink.Location = new System.Drawing.Point(12, 37);
            this.PnlStarlink.Name = "PnlStarlink";
            this.PnlStarlink.Size = new System.Drawing.Size(504, 412);
            this.PnlStarlink.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("OCR A Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(568, 120);
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
            this.txtHealth.Text = "100";
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
            // frmStarlink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.LblHealth);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.Scoring);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.PnlStarlink);
            this.Controls.Add(this.LblTitle);
            this.Name = "frmStarlink";
            this.Text = "Starlink Saga";
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
    }
}

