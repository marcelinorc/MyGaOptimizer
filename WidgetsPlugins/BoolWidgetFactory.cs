using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MyOptimizer;
using TransparentBlue.PluginFramework.Attributes;

namespace WidgetsPlugins
{
  [Extends("MyOptimizer", FunctionsPlugin.EpId)]
  public class BoolWidgetFactory : WidgetFactory
  {
    public BoolWidgetFactory()
    {
      _valueType = typeof (bool);
    }

    public override Control BuildControl()
    {
      CheckBox chk = new CheckBox();
      return chk;
    }

    public override object GetValuesFromControl(Control c)
    {
      return ((CheckBox)c).Checked;
    }
  }
}
