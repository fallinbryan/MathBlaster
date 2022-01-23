using System;
using System.IO;
using System.Drawing;
using System.Xml.Serialization;
//using System.Threading;
using System.Windows.Forms;


namespace MathBlaster
{
  public partial class Form1 : Form
  {
    private string FILE_DIR = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MathBlaster");
    private const string FILE_NAME = "GameState.xml";
    public Graphics Canvas { get; set; }

    private Game MathGame { get; set; }
    private Timer GameTimer { get; set; }

    public string CurrentInput { get; set; } = "";


    private object _lockobject = new object();

    public Form1()
    {
      InitializeComponent();

      GameState gameState = LoadGameSate();
      Player CurrentPlayer = null;
      while (CurrentPlayer == null)
      {
        using (PlayerSelectDialog getPlayer = new PlayerSelectDialog(gameState.Players))
        {
          DialogResult dg = getPlayer.ShowDialog();
          if (dg == DialogResult.OK)
          {
            CurrentPlayer = getPlayer.SelectedPlayer;
          }
        }
      }

      MathGame = new Game(gameState, CurrentPlayer.ToString());

      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

      DoubleBuffered = true;

      MathGame.GameBoard = GameBoard;

      MathGame.ScoreIncreased += GameOnScore;
      MathGame.GameOver += GameOnGameOver;
      MathGame.LevelUp += GameOnLevelUp;
      MathGame.GameWin += GameOnGameIsWon;
      MathGame.TotalMiss += GameOnTotalMiss;

      this.KeyPreview = true;

      this.KeyPress += new KeyPressEventHandler(this.Form1_KeyPress);
      this.KeyUp += new KeyEventHandler(this.Form1_KeyUp);
      this.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
      PlayButton.TabStop = false;


      GameTimer = new Timer();
      GameTimer.Interval = (1000 / 30); // 30 fps 
      GameTimer.Tick += OnTimerTick;



    }

    private void GameOnTotalMiss(object sender, EventArgs e)
    {
      int score = int.Parse(ScoreBoard.Text);
      score -= 10;
      ScoreBoard.Text = score.ToString();
    }

    private void GameOnGameIsWon(object sender, EventArgs e)
    {
      MessageBox.Show("You Won the GAME!!!!");
    }

    private void GameOnLevelUp(object sender, LevelUpEventArgs e)
    {
      using(PlayerStat ps = new PlayerStat(MathGame.CurrentPlayer, true))
      {
        ps.ShowDialog();
      }
    }

    private void OnTimerTick(object sender, EventArgs e)
    {
      MathGame.Step();
    }

    private void GameOnGameOver(object sender, EventArgs e)
    {
      Game game = (Game)sender;
      GameTimer.Stop();
      PlayButton.Enabled = true;
      SaveGameState(game.State);
    }

    private void SaveGameState(GameState gameState)
    {
      lock(_lockobject)
      {

        string filepath = Path.Combine(FILE_DIR, FILE_NAME);
        XmlSerializer serializer = new XmlSerializer(typeof(GameState));
        using (Stream reader = new FileStream(filepath, FileMode.OpenOrCreate))
        {
          serializer.Serialize(reader, gameState);
        }
      }
      return;
    }

    private void GameOnScore(object sender, ScoreIncreaseEventArgs e)
    {
      int score = int.Parse(ScoreBoard.Text);
      score += e.Increment;
      ScoreBoard.Text = score.ToString();
    }

    private GameState LoadGameSate()
    {
      XmlSerializer serializer = new XmlSerializer(typeof(GameState));
      GameState gameState;

      if(!Directory.Exists(FILE_DIR))
      {
        Directory.CreateDirectory(FILE_DIR);
      }
      string filepath = Path.Combine(FILE_DIR, FILE_NAME);
      if (File.Exists(filepath))
      {

        using (Stream reader = new FileStream(filepath, FileMode.OpenOrCreate))
        {
          gameState = (GameState)serializer.Deserialize(reader);
        }
      }
      else
      {
        gameState = new GameState();

      }
      return gameState;
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
      if (MathGame.IsRunning)
      {
        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
        {
          int number = -1;
          Int32.TryParse(CurrentInput, out number);
          MathGame.CheckPlayerInput(number);
          CurrentInput = "";
          PlayerKeyPress.Text = CurrentInput;
          e.Handled = true;
        }
      }
    }


    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (MathGame.IsRunning)
        return;
      int score = int.Parse(ScoreBoard.Text);
      MathGame.StopGame();
      MathGame.UpdateHighScore(score);
      GameTimer.Stop();
      SaveGameState(MathGame.State);
    }

    void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {

      if (MathGame.IsRunning)
      {
        switch (e.KeyChar)
        {
          case '1':
          case '2':
          case '3':
          case '4':
          case '5':
          case '6':
          case '7':
          case '8':
          case '9':
          case '0':
            {

              CurrentInput += e.KeyChar;
              PlayerKeyPress.Text = CurrentInput;
              e.Handled = true;
              break;
            }


          default:
            break;
        }


      }



    }

    private void PlayButton_Click(object sender, EventArgs e)
    {
      PlayButton.Enabled = false;
      MathGame.StartGame();
      GameTimer.Start();

      this.Focus();
    }

    private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (ScoreBoard sb = new ScoreBoard(MathGame.State.HighScores))
      {
        sb.ShowDialog();
      }
    }

    private void myProgressToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using(PlayerStat ps = new PlayerStat(MathGame.CurrentPlayer, false))
      {
        ps.ShowDialog();
      }
    }

    private void changePlayerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int score = int.Parse(ScoreBoard.Text);
      MathGame.UpdateHighScore(score);
      ScoreBoard.Text = "0";

      Player CurrentPlayer = null;
      while (CurrentPlayer == null)
      {
        using (PlayerSelectDialog getPlayer = new PlayerSelectDialog(MathGame.State.Players))
        {
          DialogResult dg = getPlayer.ShowDialog();
          if (dg == DialogResult.OK)
          {
            CurrentPlayer = getPlayer.SelectedPlayer;
          }
        }
      }

      MathGame.ChangePlayer(CurrentPlayer);

    }
  }
}
