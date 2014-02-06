using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using TransparentBlue.PluginFramework.Attributes;

namespace TransparentBlue.PluginFramework
{
  public delegate void LoadProgress(string msg);

  public delegate void CustomTypeDetected(Type t);


  /// <summary>
  /// Loader of all plugins. Stores the loaded extensions points and extensions in the Registry
  /// </summary>
  public class PluginLoader
  {
    /// <summary>
    /// Flying types detected
    /// </summary>
    protected class FlyingExtension
    {
      private string _extensionKey;

      private Type _flyingType;

      public FlyingExtension(string key, Type t)
      {
        _extensionKey = key;
        _flyingType = t;
      }

      public string ExtensionKey
      {
        get { return _extensionKey; }
        set { _extensionKey = value; }
      }

      public Type Type
      {
        get { return _flyingType; }
        set { _flyingType = value; }
      }
    }

    /// <summary>
    /// Flying types found
    /// </summary>
    private List<FlyingExtension> _flyings;

    private List<Type> _customTypesToDetect;


    private Collection<Type> _customTypesDetected;

    private List<string> _searchPaths;

    private List<string> _ignoreAssemblies;

    /// <summary>
    /// Report that detection progress is about to begin
    /// </summary>
    public event LoadProgress OnBeginDetection;

    /// <summary>
    /// Report that load progress is about to begin
    /// </summary>
    public event LoadProgress OnBeginLoading;

    /// <summary>
    /// Report that detection progress is complete
    /// </summary>
    public event LoadProgress OnAssemblyDetected;

    /// <summary>
    /// Report that detection progress is complete
    /// </summary>
    //public event LoadProgress OnDetectionComplete;

    /// <summary>
    /// Report that a custom type has been detected
    /// </summary>
    public event CustomTypeDetected OnCustomTypeDetected;

    /// <summary>
    /// Report that a service as been added
    /// </summary>
    public event LoadProgress OnServiceAdded;


    /// <summary>
    /// List of directories to search on
    /// </summary>
    public List<string> SearchPaths
    {
      get { return _searchPaths; }
      set { _searchPaths = value; }
    }

    /// <summary>
    /// Application that are loading the plugins
    /// </summary>
    public string ApplicationToContributeTo
    {
      get { return _applicationToContributeTo; }
      set { _applicationToContributeTo = value; }
    }

    /// <summary>
    /// List of assemblies that are going to be ignored
    /// </summary>
    public List<string> IgnoreAssemblies
    {
      get { return _ignoreAssemblies; }
      set { _ignoreAssemblies = value; }
    }

    /// <summary>
    /// Custom types to detect. 
    /// </summary>
    /// <remarks>The custom types are not handled by the plugin loader, instead an CustomTypeDetected event is raised and the type is added to the CustomTypesDetected list</remarks>
    public List<Type> CustomTypesToDetect
    {
      get { return _customTypesToDetect; }
      set { _customTypesToDetect = value; }
    }

    /// <summary>
    /// Custom types detected during the detection process
    /// </summary>
    public Collection<Type> CustomTypesDetected
    {
      get { return _customTypesDetected; }
      set { _customTypesDetected = value; }
    }

    private string _applicationToContributeTo;

    public PluginLoader()
    {
      _customTypesToDetect = new List<Type>();
      _searchPaths = new List<string>();
      _ignoreAssemblies = new List<string>();
      _customTypesDetected = new Collection<Type>();
      _flyings = new List<FlyingExtension>();
    }

    /// <summary>
    /// Detects plugins in the given directories
    /// </summary>
    /// <summary>
    /// Returns a list with the plugin types detected in the extensions paths
    /// </summary>
    public List<Type> Detect()
    {
      _customTypesDetected.Clear();

      List<Type> result = new List<Type>();

      foreach ( string path in _searchPaths ) {

        // Search in the given path all .dlls
        string[] files;
        try { // Path may be incorrect
          files = Directory.GetFiles(path, "*.dll");
        }
        catch (Exception e) {
          throw new IOException("Error when trying to detect plugins: ", e);
        }

        foreach ( string file in files ) {
          // load every .dll file containing and Assembly
          try {
            string assemblyFileName = Path.GetFileName(file);

            //Don't load ignorelist assemblies.
            //This is to speed up loading process ignoring assemblies we know
            //does not contain plugins, like, lets say... Microsoft.System.Forms
            if ( _ignoreAssemblies.Contains(assemblyFileName) ) continue;

            Assembly assembly = Assembly.LoadFrom(file);

            if ( OnAssemblyDetected != null ) { OnAssemblyDetected(assemblyFileName); }

            // Get all visible types in the assembly
            foreach ( Type type in assembly.GetExportedTypes() ) {
              // For each type, verify if it is a plugin
              if ( type.IsSubclassOf(typeof(Plugin)) ) {
                // Verify if contributes to this aplication,
                // We don't want plugins belonging to other apps
                try {
                  object[] obs = type.GetCustomAttributes(typeof (ContributesTo), false);
                  if ( obs == null || obs.Length == 0 ) continue;
                  ContributesTo at = (ContributesTo)obs[0];
                  if (  string.Compare(at.ApplicationToContribute,
                    _applicationToContributeTo, true) == 0) {
                    result.Add(type);
                  }
                }
                //Something wrong? Nevermind, just go with the flow... log it
                catch {
                  //TODO: Log the error.
                  continue;
                }
              }
              //Custom types are for back
              else if ( IsCustomType(type) ) {
                if ( OnCustomTypeDetected != null ) { OnCustomTypeDetected(type); }
                _customTypesDetected.Add(type);
              }
              else {
                //Detect flying types (Types marked with Extends)
                try {
                  object[] obs = type.GetCustomAttributes(typeof (Extends), false);
                  if ( obs == null || obs.Length == 0 ) continue;
                  Extends extends = (Extends)obs[0];
                  if ( string.Compare(extends.ApplicationToContribute,
                    _applicationToContributeTo, true) == 0 ) {
                    _flyings.Add(new FlyingExtension(extends.ExtensionPoint, type));
                  }
                }
                //Something wrong? Nevermind, just go with the flow... log it
                catch { 
                  //TODO: Log the error.
                  continue; 
                }
              }
            }
          }
          catch ( Exception e ) {
            //Logger.Write(e.Message);
          }
        }
      }

      return result;
    }

    /// <summary>
    /// Indicates if a type is a custom type of an inheritor
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    private bool IsCustomType(Type t)
    {
      foreach ( Type customType in _customTypesToDetect ) {
        if ( t.IsSubclassOf(customType) || t.Equals(customType) ) return true;
      }
      return false;
    }

    /// <summary>
    /// Reports the services loaded
    /// </summary>
    /// <param name="ext"></param>
    private void ReportServicesLoaded(Dictionary<string, List<object>> ext)
    {
      foreach ( KeyValuePair<string, List<object>> pair in ext ) {
        foreach ( object o in pair.Value ) {
          if ( OnServiceAdded != null ) {
            OnServiceAdded(o.ToString());
          }
        }
      }
    }

    /// <summary>
    /// Do the loading of the plugins
    /// </summary>
    /// <return> A registry with all plugins loaded </return>
    public Registry Load()
    {
      if ( OnBeginDetection != null ) { OnBeginDetection(""); }

      //Detect plugin types
      List<Type> types = Detect();

      if ( OnBeginLoading != null ) { OnBeginLoading(""); }

      Registry registry = new Registry();

      registry.Clear();

      //Creates a new instance of the plugin
      List<Plugin> ps = new List<Plugin>();
      foreach ( Type type in types ) {
        try {
          Plugin p = (Plugin)Activator.CreateInstance(type);
          ps.Add(p);
        }
        catch { continue; }
      }
      //Loads the extension points
      foreach ( Plugin plugin in ps ) {
        try {
          IList<ExtensionPoint> ep = plugin.GetExtensionPoints();
          if (ep != null) { registry.AddExtensionPoints(ep); }
        }
        catch { continue; }
      }

      //Load the extensions
      foreach ( Plugin plugin in ps ) {
        try {
          Dictionary<string, List<object>> ext = plugin.GetExtensions();
          if (ext != null) { registry.AddExtensions(ext); }
          ReportServicesLoaded(ext);
        }
        catch { continue; }
      }

      //Creates the flying extension dictionary
      Dictionary<string, List<object>> flyingExt = new Dictionary<string, List<object>>();
      foreach (FlyingExtension flying in _flyings) {
        try {
          if ( !flyingExt.ContainsKey(flying.ExtensionKey) ) {
            flyingExt[flying.ExtensionKey] = new List<object>();
          }
          flyingExt[flying.ExtensionKey].Add(Activator.CreateInstance(flying.Type));
        }
        catch { continue; }
      }

      //Add all the flying extensions
      registry.AddExtensions(flyingExt);
      ReportServicesLoaded(flyingExt);

      return registry;
    }
  }
}
