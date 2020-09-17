using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starlink
{
    public partial class frmHighScores : Form
    {
        string binPath = Application.StartupPath + @"\highScores1.txt";
        List<HighScores> highScores = new List<HighScores>();
        public frmHighScores(string pilotName, string pilotScore)
        {
            InitializeComponent();
            //Get the pilot's (player's) name and score from frmGame and show in lblPilotName and lblPilotScore
            lblPilotName.Text = pilotName;
            lblPilotScore.Text = pilotScore;
            var reader = new StreamReader(binPath);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));
            }
            reader.Close();
        }
        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                listBoxPilot.Items.Add(s.Name);
                listBoxScore.Items.Add(s.Score);

            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            SaveHighScores();
            frmStarlink FrmGame = new frmStarlink();
            Hide();
            FrmGame.ShowDialog();
        }
        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }

        private void frmHighScores_Load(object sender, EventArgs e)
        {
            //Get the lowest score from the last element in the highscores list
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            //If the pilot's score is higher than the lowest score in the list of scores
            if (int.Parse(lblPilotScore.Text) > lowest_score)
            {
                //Tell the player that they have made the top 10 highest scores
                lblMessage.Text = "You have made the Top Ten! Well Done!";
                //Then parse the name and score to the list of highscores
                highScores.Add(new HighScores(lblPilotName.Text, int.Parse(lblPilotScore.Text)));
            }
            else  //If the pilot's score is lower than the lowest score in the list of scores
            {
                //Tell the player that they have not made the top 10 highest scores
                lblMessage.Text = "Keep trying to make the top ten!";
            }
            //Sort the highscores from highest to lowest
            SortHighScores();
            //Them display the name and the list of scores in the relevant listboxes
            DisplayHighScores();
        }
        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }

    }
}
