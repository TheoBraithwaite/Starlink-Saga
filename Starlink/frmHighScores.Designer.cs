namespace Starlink
{
    partial class frmHighScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPilotName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPilotScore = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxPilot = new System.Windows.Forms.ListBox();
            this.listBoxScore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pilot\'s name";
            // 
            // lblPilotName
            // 
            this.lblPilotName.AutoSize = true;
            this.lblPilotName.Location = new System.Drawing.Point(110, 211);
            this.lblPilotName.Name = "lblPilotName";
            this.lblPilotName.Size = new System.Drawing.Size(35, 13);
            this.lblPilotName.TabIndex = 3;
            this.lblPilotName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pilot\'s score";
            // 
            // lblPilotScore
            // 
            this.lblPilotScore.AutoSize = true;
            this.lblPilotScore.Location = new System.Drawing.Point(110, 284);
            this.lblPilotScore.Name = "lblPilotScore";
            this.lblPilotScore.Size = new System.Drawing.Size(35, 13);
            this.lblPilotScore.TabIndex = 5;
            this.lblPilotScore.Text = "Score";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(14, 309);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(39, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "(blank)";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(162, 279);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return to Starlink";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Score";
            // 
            // listBoxPilot
            // 
            this.listBoxPilot.FormattingEnabled = true;
            this.listBoxPilot.Location = new System.Drawing.Point(15, 29);
            this.listBoxPilot.Name = "listBoxPilot";
            this.listBoxPilot.Size = new System.Drawing.Size(71, 173);
            this.listBoxPilot.TabIndex = 9;
            // 
            // listBoxScore
            // 
            this.listBoxScore.FormattingEnabled = true;
            this.listBoxScore.Location = new System.Drawing.Point(86, 29);
            this.listBoxScore.Name = "listBoxScore";
            this.listBoxScore.Size = new System.Drawing.Size(71, 173);
            this.listBoxScore.TabIndex = 10;
            // 
            // frmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.listBoxScore);
            this.Controls.Add(this.listBoxPilot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPilotScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPilotName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmHighScores";
            this.Text = "frmHighScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPilotName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPilotScore;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxPilot;
        private System.Windows.Forms.ListBox listBoxScore;
    }
}