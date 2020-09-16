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
        string binPath = Application.StartupPath + @"\highScores.txt";
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
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
