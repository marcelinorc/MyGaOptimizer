using System;
using System.Collections.Generic;

namespace TransparentBlue.PluginFramework
{

  
  public enum ExtenstionKind
  {
    TypeExtension,
    InstanceExtension
  } ;

  /// <summary>
  /// Class representing and extension
  /// </summary>
  public class Extension
  {
    private object _service;

    /// <summary>
    /// Object that actually does the work
    /// </summary>
    public object Service
    {
      get { return _service; }
      set { _service = value; }
    }

    private Dictionary<string, object> _properties;

    public Extension(object value)
    {
      _service = value;
      _properties = new Dictionary<string, object>();
    }

    public Extension(object service, string propertyName, object value)
    {
      _service = service;
      _properties = new Dictionary<string, object>();
      _properties[propertyName] = value;
    }

    /// <summary>
    /// Services properties
    /// </summary>
    public Dictionary<string, object> Properties
    {
      get { return _properties; }
      set { _properties = value; }
    }

  }
}
