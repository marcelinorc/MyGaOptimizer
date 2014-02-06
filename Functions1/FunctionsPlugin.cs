using System.Collections.Generic;
using MyOptimizer;
using TransparentBlue.PluginFramework;
using TransparentBlue.PluginFramework.Attributes;

namespace Functions1
{
  /// <summary>
  /// A plugin that contributes to the MyOptimizer plugin
  /// </summary>
  [ContributesTo("MyOptimizer")]
  public class FunctionsPlugin : Plugin
  {
    private const string EpId = "myoptimizer.objectivefunctions";

    /// <summary>
    /// Provide the Objective functions Extension Point.
    /// </summary>
    /// <returns></returns>
    public override IList<ExtensionPoint> GetExtensionPoints()
    {
      //Add one extensions point
      ExtensionPoints.Add(new ExtensionPoint(EpId, typeof(ObjectiveFunction)));
      return ExtensionPoints;
    }

    public override Dictionary<string, List<object>> GetExtensions()
    {
      //Creates a contribution simple without properties by simply adding an object
      GetExtensions(EpId).Add(new ThirtyBit());
      return Extensions;
    }
  }
}