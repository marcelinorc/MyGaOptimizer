using System;

namespace TransparentBlue.PluginFramework.Attributes
{

  public sealed class Extends : Attribute
  {
    private string _applicationToContribute;

    /// <summary>
    /// Name of the application to contribute to
    /// </summary>
    public string ApplicationToContribute
    {
      get { return _applicationToContribute; }
      set { _applicationToContribute = value; }
    }

    private string _extensionPoint;

    /// <summary>
    /// Name of the extension point to contribute to
    /// </summary>
    public string ExtensionPoint
    {
      get { return _extensionPoint; }
      set { _extensionPoint = value; }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="appName">Name of aplication to contributes to</param>
    /// <param name="extensionPointName">Name of the extension to contributes to</param>
    public Extends(string appName, string extensionPointName)
    {
      _extensionPoint = extensionPointName;
      _applicationToContribute = appName;
    }
  }
}