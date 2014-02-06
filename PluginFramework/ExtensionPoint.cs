using System;
using System.Collections.Generic;

namespace TransparentBlue.PluginFramework
{
  /// <summary>
  /// Class representing an extension point
  /// </summary>
  public class ExtensionPoint
  {
    private List<Type> _interfaces;

    private string _name;

    public ExtensionPoint()
    {
      _interfaces = new List<Type>();
    }

    public ExtensionPoint(string name, Type type)
    {
      _name = name;
      _interfaces = new List<Type>();
      _interfaces.Add(type);
    }

    /// <summary>
    /// The name of the Extension point. This name must be unique
    /// </summary>
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    /// <summary>
    /// Interfaces that the extensions of this extension point must cumply
    /// </summary>
    public List<Type> Interfaces
    {
      get { return _interfaces; }
      set { _interfaces = value; }
    }
  }
}