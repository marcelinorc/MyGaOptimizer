using System;
using System.Collections.Generic;
using System.Text;
using MyOptimizer;
using TransparentBlue.GA;

namespace Functions2
{
  public class SimpleSumatory : ObjectiveFunction 
  {
    private float _multiplier = 1;


    public SimpleSumatory()
    {
      _description = "A Simple function of 20 bits using a divider";
      _cromosomeSize = 20;
      _interval = new Interval[20];
      for (int i = 0; i < _interval.Length; i++) {
        _interval[i].Min = 0;
        _interval[i].Max = 1;
        _interval[i].Step = 1;
      }
    }



    /// <summary>
    /// Parameters function
    /// </summary>
    public void SetParameters(float divider, string logFile)
    {
      if (divider != 0) { _multiplier = divider; }
      //The log file is only to show the string factory
    }

    public override double GetMinimumBound() { return float.MinValue; }
    public override double GetMaximumBound() { return 20; }

    public override double Eval(Cromosome c)
    {
      double result = 0;

      for (int i = 0; i < c.Length; i++) {
        result += (c[i] + 1) * _multiplier;
      }

      //if (result == 0) { result = double.MaxValue; }
      //else { result = 1 / result; }

      if (double.IsNaN(result)) { throw new Exception(c.ToString()); }

      return 100 / result;
    }
  }
}
