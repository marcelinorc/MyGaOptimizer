using System;
using System.Collections.Generic;
using TransparentBlue.PluginFramework.Exceptions;

namespace TransparentBlue.PluginFramework
{
  /// <summary>
  /// The registry is where all extension points an extensions are held
  /// </summary>
  public class Registry
  {
    /// <summary>
    /// Extension points
    /// </summary>
    private List<ExtensionPoint> _extensionPoints;

    /// <summary>
    /// Detected extensions
    /// </summary>
    private Dictionary<string, List<Extension>> _extensions;

    public Registry()
    {
      _extensionPoints = new List<ExtensionPoint>();
      _extensions = new Dictionary<string, List<Extension>>();
    }

    /// <summary>
    /// Returns all the extensions points
    /// </summary>
    /// <returns>A list with all the extensions points</returns>
    public List<ExtensionPoint> GetExtensionPoints()
    {
      return _extensionPoints;
    }

    //public abstract object BuildNew(string extensionPointName, Predicate<object> predicate, object[] args);


    /*
    /// <summary>
    /// Builds a new 
    /// </summary>
    /// <param name="extensionPointName"></param>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public static object BuildNew(string extensionPointName, Predicate<object> predicate, object[] args)
    {
      return null;
    }


    public static object BuildNew(string extensionPointName, string propertyName, object propertyValue, object[] args)
    {
      return null;
    }*/

    /// <summary>
    /// Returns all services of a given extension point
    /// </summary>
    /// <param name="extensionPointName">Name of the extension point</param>
    /// <returns>A list with all extensions of a given extension poing</returns>
    public List<object> GetServices(string extensionPointName)
    {
      List<object> result = new List<object>();

      foreach ( Extension extension in _extensions[extensionPointName] ) {
        result.Add(extension.Service);
      }
      return result;
    }

    /// <summary>
    /// Querys for services of a given extension point with a property who's value is given in property value
    /// </summary>
    /// <param name="extensionPointName">Extension name</param>
    /// <param name="propertyName">PRoperty name</param>
    /// <param name="propertyValue">Value of the property to query for</param>
    /// <returns>The services if found any</returns>
    public List<object> GetServices(string extensionPointName, string propertyName, object propertyValue)
    {
      List<object> result = new List<object>();

      foreach ( Extension extension in _extensions[extensionPointName] ) {
        if ( extension.Properties[propertyName].Equals(propertyValue) ) {
          result.Add(extension.Service);
        }
      }
      return result;
    }

    /// <summary>
    /// Querys for an extension that cumply a given predicated
    /// </summary>
    /// <param name="extensionPointName">Extension name</param>
    /// <param name="predicate">Predicate to find extension</param>
    /// <returns>The services if found any</returns>
    public List<object> GetServices(string extensionPointName, Predicate<object> predicate)
    {
      List<object> result = new List<object>();

      foreach ( Extension extension in _extensions[extensionPointName] ) {
        if ( predicate(extension.Service) ) {
          result.Add(extension);
        }
      }
      return result;
    }

    /// <summary>
    /// Gets all the services of a given type
    /// </summary>
    /// <typeparam name="T">Type of the service</param>
    /// <returns>Services found if any</returns>
    public List<T> GetServices<T>()
    {
      List<object> objs = GetServices(typeof(T), delegate { return true; });
      List<T> result = new List<T>();

      foreach (object o in objs) { result.Add((T)o); }
      return result;
    }

    /// <summary>
    /// Gets all the services of a given type
    /// </summary>
    /// <typeparam name="T">Type of the service</param>
    /// <param name="predicate">Predicate to search for</param>
    /// <returns>Services found if any</returns>
    public List<T> GetServices<T>(Predicate<T> predicate)
    {
      List<object> objs = GetServices(typeof(T));
      List<T> result = new List<T>();
      foreach ( object o in objs ) { if ( predicate((T)o) ) result.Add((T)o); }
      return result;
    }

    /// <summary>
    /// Querys for all the services of a given type with a property with some valie
    /// </summary>
    /// <typeparam name="T">Type of the service</param>
    /// <param name="propertyName">Name of the property</param>
    /// <param name="value">Value of the property</param>
    /// <returns>Services found if any</returns>
    public List<T> GetServices<T>(string propertyName, object value)
    {
      List<object> objs = GetServices(typeof(T), propertyName, value);
      List<T> result = new List<T>();
      foreach ( object o in objs ) { result.Add((T)o); }
      return result;
    }

    /// <summary>
    /// Gets all the services of a given type
    /// </summary>
    /// <param name="type">Type of the service</param>
    /// <returns></returns>
    public List<object> GetServices(Type type)
    {
      return GetServices(type, delegate { return true; });
    }

    /// <summary>
    /// Gets all the services of a given type
    /// </summary>
    /// <param name="type">Type of the service</param>
    /// <param name="predicate">Predicate to search for</param>
    /// <returns>Services found if any</returns>
    public List<object> GetServices(Type type, Predicate<object> predicate)
    {
      List<object> result = new List<object>();

      foreach ( List<Extension> list in _extensions.Values ) {
        foreach ( Extension extension in list ) {
          object service = extension.Service;
          Type t = service.GetType();
          if ( t.IsSubclassOf(type) || t.Equals(type) && predicate(service) ) {
            result.Add(service);
          }
        }
      }

      return result;
    }

    /// <summary>
    /// Querys for all the services of a given type with a property with some valie
    /// </summary>
    /// <param name="type">Type of the service</param>
    /// <param name="propertyName">Name of the property</param>
    /// <param name="value">Value of the property</param>
    /// <returns>Services found if any</returns>
    public List<object> GetServices(Type type, string propertyName, object value)
    {
      List<object> result = new List<object>();

      foreach ( List<Extension> list in _extensions.Values ) {
        foreach ( Extension extension in list ) {
          object service = extension.Service;
          Type t = service.GetType();
          
          if ( ( t.IsSubclassOf(type) || t.Equals(type) ) && 
            extension.Properties.ContainsKey(propertyName) &&
            extension.Properties[propertyName].Equals(value) ) {

            result.Add(service);
          
          }
        }
      }

      return result;
    }

    /// <summary>
    /// Returns an extension point given its name
    /// </summary>
    /// <param name="name">Name of the extension point to find</param>
    /// <returns>An ExtensionPoint</returns>
    public ExtensionPoint GetExtensionPoint(string name)
    {
      return _extensionPoints.Find(
        delegate(ExtensionPoint ep)
        {
          return ep.Name == name;
        });
    }

    /// <summary>
    /// Add a range of extension points
    /// </summary>
    /// <param name="collection">Collection of extension points</param>
    public void AddExtensionPoints(IEnumerable<ExtensionPoint> collection)
    {
      foreach ( ExtensionPoint point in collection ) {
        AddExtensionPoint(point);
      }
    }

    /// <summary>
    /// Add a single extension point
    /// </summary>
    /// <param name="point">Extension point to add</param>
    public void AddExtensionPoint(ExtensionPoint point)
    {
      if ( GetExtensionPoint(point.Name) == null ) {
        _extensionPoints.Add(point);
      }
    }

    /// <summary>
    /// Indicates whether an extension implements all interfaces of the extension point
    /// </summary>
    /// <param name="obj">Extension</param>
    /// <param name="interfaces">Extension point</param>
    /// <returns>True if implements them all, false otherwise</returns>
    private bool ImplementInterfaces(object obj, IEnumerable<Type> interfaces)
    {
      Type t = obj.GetType();
      if ( obj.GetType() == typeof(Extension) ) { t = ((Extension)obj).Service.GetType(); }

      foreach ( Type i in interfaces ) {
        if ( !(t.Equals(i) || t.IsSubclassOf(i) || t.GetInterface(i.FullName, true) != null) ) {
          return false;
        }
      }
      return true;
    }

    /// <summary>
    /// Add a range of extension points
    /// </summary>
    /// <param name="extensions">Dictionary of extension who's keys are the name of the extension points</param>
    public void AddExtensions(Dictionary<string, List<object>> extensions)
    {
      foreach ( KeyValuePair<string, List<object>> pair in extensions ) {

        ExtensionPoint ep = GetExtensionPoint(pair.Key);
        if ( ep == null ) continue;

        //Creates the extension list if not created yet
        if ( !_extensions.ContainsKey(pair.Key) ) {
          _extensions[pair.Key] = new List<Extension>();
        }
        foreach ( object o in pair.Value ) {
          //If the extension cumply with all declared interfaces, then add the extension
          if ( ImplementInterfaces(o, ep.Interfaces) ) {
            if ( o.GetType().Equals(typeof(Extension)) ) {
              _extensions[pair.Key].Add((Extension)o);
            }
            else { _extensions[pair.Key].Add(new Extension(o)); }
          }
        }
      }
    }

    public void Clear()
    {
      _extensionPoints.Clear();
      _extensions.Clear();
    }


  }
}
