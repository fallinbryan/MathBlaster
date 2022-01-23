using System;
using System.Drawing;


namespace MathBlaster
{

  public enum ProblemType : byte
  {
    Addition = 2,
    Subtraction = 4,
    Multiplication = 16,
    Division = 32
  }


  public class MathProblem
  {
    public Point Location { get; set; }
    public ProblemType ProblemType { get; set; }
    public int ProblemValue
    {
      get
      {
        int val = 0;
        switch (ProblemType)
        {
          case ProblemType.Addition:
            val = LeftOperand + RightOperand;
            break;
          case ProblemType.Subtraction:
            val = LeftOperand - RightOperand;
            break;
          case ProblemType.Multiplication:
            val = RightOperand * LeftOperand;
            break;
          case ProblemType.Division:
            val = LeftOperand / RightOperand;
            break;
          default:
            break;
        }
        return val;
      }
    }

    private bool _isSolved = false;
    public bool IsAnsweredCorrectly { get; set; } = false;

    public int LeftOperand { get; set; }
    public int RightOperand { get; set; }
    public int Difficulty { get; set; }
    public char Operator  { get; set; }

    public int Speed { get; set; } = 1;
    public Random RandGen { get;  set; }
    public bool GetsLazer { get; internal set; }

    private Rectangle _bounds;

    private Font font = new Font(FontFamily.GenericSansSerif, 20.0f, FontStyle.Regular);
    private Brush brush = Brushes.White;
    public MathProblem(ProblemType problemType, int difficutly, int yOffset, Rectangle Screen, Random gen)
    {
      RandGen = gen;
      int x = RandGen.Next(0, Screen.Width - 100);
      int y = -yOffset;
      Location = new Point(x, y);
      _bounds = Screen;

      this.ProblemType = problemType;
      this.Difficulty = difficutly;
      switch (problemType)
      {
        case ProblemType.Addition:
          this.Operator = '+';
          break;
        case ProblemType.Subtraction:
          this.Operator = '-';
          break;
        case ProblemType.Multiplication:
          this.Operator = '\u00D7';
          break;
        case ProblemType.Division:
          this.Operator = '\u00F7';
          break;
        default:
          break;
      }

      LeftOperand = RandGen.Next(1, 12);

      if(problemType == ProblemType.Addition || problemType == ProblemType.Multiplication)
      {
        if (difficutly == 0)
        {
          RightOperand = RandGen.Next(0, difficutly + 1);
        }
        else if (difficutly < 12)
        {
          RightOperand = RandGen.Next(1, difficutly + 1);
        }
        else
        {
          RightOperand = RandGen.Next(1, 12);
        }
      }

      else if(problemType == ProblemType.Subtraction)
      {
        if (difficutly == 0)
        {
          RightOperand = RandGen.Next(0, difficutly + 1);
        }
        if (difficutly < 12)
        {
          do
          {
            LeftOperand = RandGen.Next(2, difficutly + 2);
            RightOperand = RandGen.Next(1, difficutly + 1);
          }
          while (LeftOperand - RightOperand < 0);
        }
        else
        {
          do
          {
            
            RightOperand = RandGen.Next(1, 12);
          }
          while(LeftOperand - RightOperand < 0);
        }
      }

      else if (problemType == ProblemType.Division)
      {
        if (difficutly == 0)
        {
          RightOperand = 1;
        }
        else if (difficutly < 12)
        {
          do
          {
            LeftOperand = RandGen.Next(1, 12);
            RightOperand = RandGen.Next(1, difficutly + 1);
            int res = LeftOperand * RightOperand;
            LeftOperand = res;
          }
          while (LeftOperand % RightOperand != 0);
        }
        else
        {
          do
          {
            LeftOperand = RandGen.Next(1, 12);
            RightOperand = RandGen.Next(1, 12);
            int res = LeftOperand * RightOperand;
            LeftOperand = res;
          }
          while (LeftOperand % RightOperand != 0);
        }

      }



    }

    public Point Step()
    {
      if (Location.Y > _bounds.Height)
        _isSolved = true;
      
      if(!_isSolved)
        Location = new Point(Location.X, Location.Y + Speed);

      return Location; 
    }

    public void Draw(Graphics g)
    {
     if(!_isSolved)
        g.DrawString(this.ToString(), font, brush, Location);
    }

    public bool isSolvedBy(int number)
    {
     
      _isSolved = number == ProblemValue;
      IsAnsweredCorrectly = _isSolved;
    
      return _isSolved;
      
    }

    public bool AlreadSolved()
    {
      return _isSolved; 
    }

    public override string ToString()
    {
      return $"{LeftOperand} {Operator} {RightOperand}";
    }
  }
}
