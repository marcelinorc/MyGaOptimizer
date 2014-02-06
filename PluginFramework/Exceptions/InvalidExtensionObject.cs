using System;

namespace TransparentBlue.PluginFramework.Exceptions
{
  /// <summary>
  /// Exception raised when an extension is invalid
  /// </summary>
  public class InvalidExtensionObject : Exception
  {
    public InvalidExtensionObject(string msg) : base(msg)
    {
      
    }
  }
}