using System;
using System.Collections.Generic;
using System.Text;
using MyOptimizer;
using TransparentBlue.GA;

namespace Functions2
{
  public class NonUniform : ObjectiveFunction 
  {
    private int _deceptiveBit1 = -1;
    private int _deceptiveBit2 = -1;
    private bool _invert = false;

    public NonUniform()
    {
      _description = "Kargupta non uniform function 1";
      CromosomeSize = 30;
      _interval = new Interval[CromosomeSize];
      for (int i = 0; i < _interval.Length; i++) {
        _interval[i].Min = 0;
        _interval[i].Max = 1;
        _interval[i].Step = 1;
      }
    }

    /// <summary>
    /// Parameters function
    /// </summary>
    /// <param name="deceptiveBit1">Deceiptive bit 1. This bit value adds nothing to the fitnes</param>
    /// <param name="deceptiveBit2">Deceiptive bit 2. This bit value adds twice to the fitnes</param>
    /// <param name="invert">Inverts the fitnes when true</param>
    public void SetParameters(int deceptiveBit1, int deceptiveBit2, bool invert)
    {
      //I do not do a thing
    }

    public override double GetMinimumBound() { return float.MinValue; }
    public override double GetMaximumBound()
    {
      return 149.7;
    }

    public override double Eval(Cromosome c)
    {
      double result = 0;
      int m = 0;
      int i = 0;
      while (i < c.Length) {
        int u = 0;
        for (int j = 0; j < 3; j++) {
          if (Math.Abs(c[i] - 1) < 0.000001) {
            u++;
          }
          i++;
        }
        double s = m < 3 ? 0.3 : 7;
        result += u == 3 ? 3 * s : (3 - 1 - u) * s;
        m++;
      }
      return result;
    }

  }
}
