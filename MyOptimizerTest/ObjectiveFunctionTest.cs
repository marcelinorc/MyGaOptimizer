using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MyOptimizer;
using NUnit.Framework;
using TransparentBlue.GA;

namespace MyOptimizerTest
{
  [TestFixture]
  public class ObjectiveFunctionTest
  {
    private class MyObjectiveFunction : ObjectiveFunction
    {
      public void SetParameters(int a, float b, string c) 
      {
        //I do not do a thing
      } 

      public override double Eval(Cromosome c)
      {
        throw new Exception("The method or operation is not implemented.");
      }
    }

    [Test]
    public void GetParametherTest()
    {
      MyObjectiveFunction f = new MyObjectiveFunction();
      ParameterInfo[] info = f.GetParamethers();
      Assert.AreEqual(3, info.Length);
      Assert.AreEqual(typeof(int), info[0].ParameterType);
    }
  }
}
