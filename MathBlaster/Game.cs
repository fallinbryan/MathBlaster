using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MathBlaster
{
  public class Game
  {
    public GameState State { get; set; }
    public PictureBox GameBoard { get; set; }

    public string CurrentPlayerName { get; set; }

    public Player CurrentPlayer
    {
      get
      {
        if (State.Players.ContainsKey(CurrentPlayerName))
        {
          return State.Players[CurrentPlayerName];
        }
        else
        {
          State.Players.Add(CurrentPlayerName, new Player { Name = CurrentPlayerName });
          return State.Players[CurrentPlayerName];
        }
      }
    }

    public bool IsRunning { get; set; } = false;

    private List<MathProblem> ProblemList { get; set; }

    private Random randGen = new Random();
   

    public Game(GameState gameState, string currentPlayerName)
    {
      State = gameState;
      if(State.Players == null)
      {
        State.Players = new SerializableDictionary<string, Player>();
      }
      CurrentPlayerName = currentPlayerName;
      ProblemList = new List<MathProblem>();
    }

    public void StartGame()
    {
      ProblemList.Clear();
      List<ProblemType> validTypes = CurrentPlayer.GetValidProblemTypes();
      if(validTypes.Count == 0)
      {
        OnGameWin(EventArgs.Empty);
        return;
      }
      IsRunning = true;

      for (int i = 0; i < 20; i++)
      {
        int pIdx = randGen.Next(validTypes.Count);
        ProblemType problemType = validTypes[pIdx];

        MathProblem problem = new MathProblem(problemType, CurrentPlayer.ProblemTypeDifficulty[problemType], i * 100, GameBoard.ClientRectangle, randGen);

        if (randGen.Next(100) > 80)
        {
          problem.Speed = 4;
        }
        else
        {
          problem.Speed = 1;
        }
        ProblemList.Add(problem);

      }
    }

 

    public void StopGame()
    {
      IsRunning = false;
    }

    public void CheckPlayerInput(int number)
    {
      bool isHit = false;
      foreach (MathProblem mp in ProblemList)
      {
        if (!mp.AlreadSolved() && mp.isSolvedBy(number) && mp.Location.Y > 0)
        {
          FireLazerAt(mp);
          ScoreIncreaseEventArgs args = new ScoreIncreaseEventArgs();
          args.Increment = 10 * mp.Speed;
          OnScoreIncreased(args);
          isHit = true;
          break;
        }
      }

      if(!isHit)
      {
        OnTotalMiss(EventArgs.Empty);
      }
    }

    private void FireLazerAt(MathProblem mp)
    {
      mp.GetsLazer = true;
    }

    public void Step()
    {
      if (IsRunning)
      {

        foreach (MathProblem mp in ProblemList)
        {
          mp.Step();
        }
        Render();

        if (ProblemList.All(p => p.AlreadSolved()))
        {
          IsRunning = false;

          LevelUpPlayer();

          OnGameOver(EventArgs.Empty);
        }

      }
    }

    public void UpdateHighScore(int score)
    {
      if(State.HighScores == null)
      {
        State.HighScores = new List<HighScore>();
        State.HighScores.Add(new HighScore
        {
          PlayerName = CurrentPlayer.Name,
          Score = score,
          Date = DateTime.Now
        }) ;
      }
      else
      {
        State.HighScores.Add(new HighScore
        {
          PlayerName = CurrentPlayer.Name,
          Score = score,
          Date = DateTime.Now
        });


        State.HighScores.Sort((x, y) => { return x.Score.CompareTo(-y.Score); });

       
        if(State.HighScores.Count > 10)
        {
          State.HighScores.RemoveAt(10);
        }

      }
    }

    private void LevelUpPlayer()
    {
      float correct = ProblemList.Where(p => p.IsAnsweredCorrectly).Count() * 1.0f;
      float total = ProblemList.Count() * 1.0f;
      float ratio = correct / total;
      if (ratio > .84f)
      {
        CurrentPlayer.LevelUp(ProblemList);
        LevelUpEventArgs args = new LevelUpEventArgs();
        args.OldLevel = CurrentPlayer.Level;
        args.NewLevel = CurrentPlayer.Level + 1;
        args.GameRatio = ratio;
        OnLevelUp(args);
      }
    }



    public void Render()
    {
      if (IsRunning)
      {
        using (Graphics canvas = GameBoard.CreateGraphics())
        {
          canvas.Clear(Color.Black);
          foreach (MathProblem mp in ProblemList)
          {
            if (mp.GetsLazer)
            {
              canvas.DrawLine(Pens.Red, new Point(GameBoard.ClientRectangle.Width / 2, GameBoard.ClientRectangle.Height), mp.Location);
              mp.GetsLazer = false;
            }
            mp.Draw(canvas);
          }
        }
        //GameBoard.Invalidate();
      }
    }

    #region EventHandlers

    public event EventHandler GameOver;
    protected virtual void OnGameOver(EventArgs e)
    {
      EventHandler handler = GameOver;
      if (handler != null)
      {
        handler(this, e);
      }
    }

    public event EventHandler<LevelUpEventArgs> LevelUp;
    private void OnLevelUp(LevelUpEventArgs e)
    {
      EventHandler<LevelUpEventArgs> handler = LevelUp;
      if (handler != null)
      {
        handler(this, e);
      }
    }


    public event EventHandler<ScoreIncreaseEventArgs> ScoreIncreased;
    protected virtual void OnScoreIncreased(ScoreIncreaseEventArgs e)
    {
      EventHandler<ScoreIncreaseEventArgs> handler = ScoreIncreased;
      if (handler != null)
      {
        handler(this, e);
      }
    }

    public event EventHandler TotalMiss;
    protected virtual void OnTotalMiss(EventArgs e)
    {
      EventHandler handler = TotalMiss;
      if (handler != null)
      {
        handler(this, e);
      }
    }

    public event EventHandler GameWin;
    protected virtual void OnGameWin(EventArgs e)
    {
      EventHandler handler = GameWin;
      if (handler != null)
      {
        handler(this, e);
      }
    }

    internal void ChangePlayer(Player currentPlayer)
    {
      CurrentPlayerName = currentPlayer.Name;
    }

    #endregion

  }


  #region EventArgClasses

  public class ScoreIncreaseEventArgs : EventArgs
  {
    public int Increment { get; set; }

  }

  public class GameOverEventArgs : EventArgs
  {
    public float Score { get; set; }
  
  }


  public class LevelUpEventArgs : EventArgs
  {
    public int OldLevel { get; internal set; }
    public int NewLevel { get; internal set; }
    public float GameRatio { get; internal set; }
  }

  #endregion

}
