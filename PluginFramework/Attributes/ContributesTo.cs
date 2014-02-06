using System;

namespace TransparentBlue.PluginFramework.Attributes
{
  public sealed class ContributesTo : Attribute
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

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Name of the aplication to contributes to</param>
    public ContributesTo(string name)
    {
      _applicationToContribute = name;
    }
  }
}