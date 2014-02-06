using System;
using System.Collections.Generic;
using System.Text;

namespace TransparentBlue.PluginFramework.Attributes
{
  /// <summary>
  /// Extension property used to describe the extension.
  /// 
  /// This allows to search for extensions with certain properties.
  /// 
  /// The properties values are compared used the Object.Equals method
  /// </summary>
  public sealed class ExtensionAttribute : Attribute
  {
    private string _name;

    private object _value;

    /// <summary>
    /// Property Name
    /// </summary>
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    /// <summary>
    /// Property value.
    /// </summary>
    public object Value
    {
      get { return _value; }
      set { _value = value; }
    }

    /// <summary>
    /// Attribute constructor
    /// </summary>
    /// <param name="name">Property name</param>
    /// <param name="value">Property value</param>
    public ExtensionAttribute(string name, object value)
    {
      _name = name;
      _value = value;
    }
  }
}