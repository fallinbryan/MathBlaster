using System;
using System.Collections.Generic;

namespace MathBlaster
{
  public class HighScore
  {
    public string PlayerName { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }
  }

  public class GameState
  {
    public SerializableDictionary<string, Player> Players { get; set; }
    public List<HighScore> HighScores { get; set; }
    
  }
}
