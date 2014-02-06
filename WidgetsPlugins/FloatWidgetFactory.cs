using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MyOptimizer;

namespace WidgetsPlugins
{
  public class FloatWidgetFactory : WidgetFactory 
  {
    public FloatWidgetFactory()
    {
      _valueType = typeof (float);
    }

    public override Control BuildControl()
    {
      NumericUpDown nud = new NumericUpDown();
      nud.DecimalPlaces = 5;
      nud.Minimum = -100000;
      return nud;
    }

    public override object GetValuesFromControl(Control c)
    {
      return (float) ((NumericUpDown) c).Value;
    }
  }
}
