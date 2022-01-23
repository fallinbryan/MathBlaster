using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MathBlaster
{
  public partial class ScoreBoard : Form
  {
    public ScoreBoard(List<HighScore> highScores)
    {
      InitializeComponent();
      scoreBoardText.Text = "";
      if(highScores != null)
      {
        //highScores.Sort((x,y) => { return -x.Score.CompareTo(-y.Score); });
        var showScores = highScores.OrderByDescending(s => s.Score).ToList();

        showScores.ForEach(highScore => {
          scoreBoardText.Text += $"{highScore.PlayerName}\t{highScore.Score}\t{highScore.Date.ToString("MM/dd/yyyy")}\n";
        });
      }
    }
  }
}
