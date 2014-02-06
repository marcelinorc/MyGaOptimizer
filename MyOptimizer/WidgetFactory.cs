
using System;
using System.Windows.Forms;

namespace MyOptimizer
{
  public abstract class WidgetFactory
  {
    protected Type _valueType;

    /// <summary>
    /// Type of the paramether value
    /// </summary>
    public Type ValueType
    {
      get { return _valueType; }
    }

    /// <summary>
    /// Builds the control
    /// </summary>
    public abstract Control BuildControl();

    /// <summary>
    /// Returns the value from the control. 
    /// </summary>
    /// <param name="c">Control to return parameter value from</param>
    /// <returns>The parameter value</returns>
    public abstract object GetValuesFromControl(Control c);
  }
}
