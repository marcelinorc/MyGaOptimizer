using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MyOptimizer;

namespace WidgetsPlugins
{
  public class StringWidgetFactory : WidgetFactory
  {

    public StringWidgetFactory()
    {
      _valueType = typeof(string);
    }

    public override Control BuildControl()
    {
      return new TextBox();
    }

    public override object GetValuesFromControl(Control c)
    {
      return c.Text;
    }
  }
}
