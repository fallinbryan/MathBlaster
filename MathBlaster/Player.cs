using System;
using System.Collections.Generic;
using System.Linq;


namespace MathBlaster
{
  public class Player
  {
    public string Name { get; set; }
    public int HighScore { get; set; } = 0;
    public int MasteryThreshold { get; set; } = 15;
    public SerializableDictionary<ProblemType, int> ProblemTypeDifficulty { get; set; } = new SerializableDictionary<ProblemType, int> { 
      { ProblemType.Addition, 0 },
      { ProblemType.Subtraction, 0 },
      { ProblemType.Multiplication, 0 },
      { ProblemType.Division, 0 },
    };
    public int Level { get; set; } = 0;
    public byte ProblemMastery { get; set; } = 0;
    public void LevelUp(List<MathProblem> problemList)
    {

      foreach(ProblemType pt in (ProblemType[]) Enum.GetValues(typeof(ProblemType)))
      {
        CheckType(pt, problemList);
      }

      UpdateMasteries();
    }
    public void CheckType(ProblemType pt, List<MathProblem> problemList)
    {
      float numTotal = problemList.Where(p => p.ProblemType == pt).Count();
      float numCorrect = problemList.Where(p => p.IsAnsweredCorrectly && p.ProblemType == pt).Count();
      CheckScoreOnType(pt, numCorrect, numTotal);
    }
    public void CheckScoreOnType(ProblemType pt, float numCorrect, float numTotal)
    {
      if (numTotal > 0)
      {
        float score = numCorrect / numTotal;
        if (score > 0.90f)
        {
          int difficulty = ProblemTypeDifficulty[pt];
          ProblemTypeDifficulty[pt] = difficulty < MasteryThreshold ? difficulty + 1 : difficulty;
          UpdateLevel(pt, score);
        }
      }
    }
    private void UpdateLevel(ProblemType pt, float score)
    {
      if (ProblemTypeDifficulty[pt] > 12 && score > 0.84f)
      {
        switch (pt)
        {
          case ProblemType.Addition:
            if (Level == 0)
              Level++;
            break;
          case ProblemType.Subtraction:
            if (Level == 1)
              Level++;
            break;
          case ProblemType.Multiplication:
            if (Level == 2)
              Level++;
            break;
          case ProblemType.Division:
            if (Level == 3)
              Level++;
            break;
          default:
            break;
        }

      }
    }
    public void UpdateMasteries()
    {
      foreach (ProblemType pt in (ProblemType[])Enum.GetValues(typeof(ProblemType)))
      {
        if (ProblemTypeDifficulty[pt] == MasteryThreshold)
        {
          ProblemMastery = (byte)(ProblemMastery | (byte)pt);
        }
      }
    }

    public List<ProblemType> GetValidProblemTypes ()
    {
      List<ProblemType> rv = new List<ProblemType>();

      ProblemType[] pts = (ProblemType[])Enum.GetValues(typeof(ProblemType));
      for(int i = 0; i < pts.Length; i++)
      {
        if (Level >= i && (ProblemMastery & (byte)pts[i]) == 0)
        {
          rv.Add(pts[i]);
        }
      }

      return rv;
    }



    public override string ToString()
    {
      return Name;
    }


  }
}
