using System;
using System.Reflection;
using TransparentBlue.GA;

namespace MyOptimizer
{
  public abstract class ObjectiveFunction : FitnesFunction 
  {
    /// <summary>
    /// Description of the function
    /// </summary>
    protected string _description;

    protected int _cromosomeSize;
    protected Interval[] _interval;

    public string Description
    {
      get { return _description; }
    }

    public int CromosomeSize
    {
      get { return _cromosomeSize; }
      set { _cromosomeSize = value; }
    }

    public Interval[] InitialIntervals
    {
      get { return _interval; }
      set { _interval = value; }
    }


    /// <summary>
    /// Returns the paremethers needed for the function
    /// </summary>
    /// <returns></returns>
    public ParameterInfo[] GetParamethers()
    {
      Type t = this.GetType();
      MethodInfo m = t.GetMethod("SetParameters");
      //At this point it would be necesary to chech that the parameters
      //are given in a proper order of calling... I'll trust .NET for now...
      //Even when I shouldn't
      return m.GetParameters();
    }

    /// <summary>
    /// Sets generically the paremethers to the function using reflection.
    /// Is up to you to give the paramethers values in proper order and with the proper
    /// Type!!!
    /// </summary>
    /// <param name="values">values for the paramethers given</param>
    public void SetValues(object[] values)
    {
      Type t = this.GetType();
      MethodInfo m = t.GetMethod("SetParameters");
      m.Invoke(this, values);
    }
  }
}
