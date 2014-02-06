using System;
using System.Collections.Generic;
using System.Text;
using MyOptimizer;
using TransparentBlue.GA;

namespace Functions1
{
  public class ThirtyBit : ObjectiveFunction 
  {
    private int _deceptiveBit1 = -1;
    private int _deceptiveBit2 = -1;
    private bool _invert = false;

    public ThirtyBit()
    {
      _description = "Kargupta 30bit deceptive function";
      _cromosomeSize = 30;
      _interval = new Interval[30];
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
    /// <param name="invertFunctionValue">Inverts the fitnes value when true</param>
    public void SetParameters(int deceptiveBit1, int deceptiveBit2, bool invertFunctionValue)
    {
      _deceptiveBit1 = deceptiveBit1;
      _deceptiveBit2 = deceptiveBit2;
      _invert = invertFunctionValue;
    }

    public override double GetMinimumBound() { return float.MinValue; }
    public override double GetMaximumBound() { return float.MaxValue; }

    /// <summary>
    /// This is one of the deceiptive functions by Goldberg et al.
    /// </summary>
    /// <param name="c">Cromosome to eval</param>
    /// <returns>Cromosome fitnes</returns>
    public override double Eval(Cromosome c)
    {
      int result = 0;
      int i = 0;
      while ( i < c.Length ) {
        int u = 0;
        for ( int j = 0; j < 3; j++ ) {
          if ( Math.Abs(c[i] - 1) < 0.000001 ) {
            u++;
          }
          i++;
        }
        int f = u == 3 ? 3 : 3 - 1 - u;
        if ( i == _deceptiveBit1 ) { f = 0; } 
        else if ( i == _deceptiveBit2 ) { f *= 2; } 
        result += f;
      }
      if (_invert) { result *= -1; }
      
      return result; 
    }
  }
}
