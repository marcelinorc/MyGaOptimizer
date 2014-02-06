using System.Collections.Generic;
using MyOptimizer;
using TransparentBlue.PluginFramework;
using TransparentBlue.PluginFramework.Attributes;

namespace Functions2
{
  /// <summary>
  /// A plugin that contributes to the MyOptimizer plugin
  /// </summary>
  [ContributesTo("MyOptimizer")]
  public class FunctionsPlugin : Plugin
  {
    private const string EpId = "myoptimizer.objectivefunctions";

    public override Dictionary<string, List<object>> GetExtensions()
    {
      //Creates a contribution simple without properties by simply adding an object
      GetExtensions(EpId).Add(new SimpleSumatory());
      GetExtensions(EpId).Add(new NonUniform());
      return Extensions;
    }
  }
}