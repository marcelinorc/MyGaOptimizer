using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MyOptimizer;

namespace WidgetsPlugins
{
  public class IntegerWidgetFactory : WidgetFactory
  {
    public IntegerWidgetFactory()
    {
      _valueType = typeof (int);
    }

    public override Control BuildControl()
    {
      NumericUpDown nud = new NumericUpDown();
      nud.Minimum = -100000;

      return nud;
    }

    public override object GetValuesFromControl(Control c)
    {
      return (int)((NumericUpDown)c).Value;
    }
  }
}
