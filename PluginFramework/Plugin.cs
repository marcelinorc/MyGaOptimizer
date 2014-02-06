
using System.Collections.Generic;

namespace TransparentBlue.PluginFramework
{
  /// <summary>
  /// Class representing a Plugin
  /// </summary>
  public abstract class Plugin
  {
    private List<ExtensionPoint> _extensionPoints;
    private Dictionary<string, List<object>> _extensions;

    protected Dictionary<string, List<object>> Extensions
    {
      get
      {
        if ( _extensions == null ) {
          _extensions = new Dictionary<string, List<object>>();
        }
        return _extensions;
      }
    }

    
    protected List<object> GetExtensions(string name)
    {
      if ( !Extensions.ContainsKey(name) ) {
        Extensions[name] = new List<object>();
      }
      return Extensions[name];
    }

    protected List<ExtensionPoint> ExtensionPoints
    {
      get
      {
        if ( _extensionPoints == null ) {
          _extensionPoints = new List<ExtensionPoint>();
        }
        return _extensionPoints;
      }
    }

    /// <summary>
    /// List of extensions points this plugins declares
    /// </summary>
    /// <returns>A list with all the extensions points this plugin declares</returns>
    public virtual IList<ExtensionPoint> GetExtensionPoints()
    {
      return new List<ExtensionPoint>();
    }

    /// <summary>
    /// List with all the extensions this plugins contributes to
    /// </summary>
    /// <returns>A dictionary who's keys are the names of the extensions that are being contributed and the objects are the extensions</returns>
    /// <remarks>The extension can be a type. 
    /// If so, if the Extension provided is not SINGLETON, the type must provide a default constructor and a constructor in the form "Constructor(object[] args)"
    /// This will allow to create new instances of that type by the Registry
    /// </remarks>
    public virtual Dictionary<string, List<object>> GetExtensions()
    {
      return new Dictionary<string, List<object>>();
    }
  }
}
