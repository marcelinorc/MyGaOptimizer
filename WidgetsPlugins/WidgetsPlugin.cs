using System.Collections.Generic;
using MyOptimizer;
using TransparentBlue.PluginFramework;
using TransparentBlue.PluginFramework.Attributes;

namespace WidgetsPlugins
{
  /// <summary>
  /// A plugin that contributes to the MyOptimizer plugin
  /// </summary>
  [ContributesTo("MyOptimizer")]
  public class FunctionsPlugin : Plugin
  {
    public const string EpId = "myoptimizer.widgetsfactory";

    /// <summary>
    /// Provide the Objective functions Extension Point.
    /// </summary>
    /// <returns></returns>
    public override IList<ExtensionPoint> GetExtensionPoints()
    {
      //Add one extensions point
      ExtensionPoints.Add(new ExtensionPoint(EpId, typeof(WidgetFactory)));
      return ExtensionPoints;
    }

    public override Dictionary<string, List<object>> GetExtensions()
    {
      //Creates a contribution simple without properties by simply adding an object
      GetExtensions(EpId).Add(new FloatWidgetFactory());
      GetExtensions(EpId).Add(new StringWidgetFactory());
      GetExtensions(EpId).Add(new IntegerWidgetFactory());

      //There is two ways of declaring an extension for a plugin,
      //declaring it in this method or decorate it with the "Extends" attribute.
      //As a demonstration, BoolWidgetFactory is declared as extension the later way
      //GetExtensions(EpId).Add(new BoolWidgetFactory());

      return Extensions;
    }
  }

}