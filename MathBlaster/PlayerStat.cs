using System.Windows.Forms;

namespace MathBlaster
{
  public partial class PlayerStat : Form
  {
    public PlayerStat(Player player, bool withCongrats)
    {
      InitializeComponent();

      if(withCongrats)
      {
        playerNameLabel.Text = $" Congrats {player.Name}, you Advanced Your Skill!";
        playerNameLabel.Left = 50;
      }
        
      else
        playerNameLabel.Text = player.Name;

      additionProgress.Maximum = player.MasteryThreshold;
      subtractionProgress.Maximum = player.MasteryThreshold;
      multiplicationProgress.Maximum = player.MasteryThreshold;
      divisionProgress.Maximum = player.MasteryThreshold;

      additionProgress.Value = player.ProblemTypeDifficulty[ProblemType.Addition];
      subtractionProgress.Value = player.ProblemTypeDifficulty[ProblemType.Subtraction];
      multiplicationProgress.Value = player.ProblemTypeDifficulty[ProblemType.Multiplication];
      divisionProgress.Value = player.ProblemTypeDifficulty[ProblemType.Division];

    }
  }
}
