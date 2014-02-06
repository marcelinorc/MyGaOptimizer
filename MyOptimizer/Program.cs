using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TransparentBlue.PluginFramework;

namespace MyOptimizer
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //Load the plugins
      PluginLoader pl = new PluginLoader();
      pl.SearchPaths.Add(".");
      //Indicate assemblies we know for sure don't have plugins
      //so we can speed up loading
      pl.IgnoreAssemblies.Add("TransparentBlue.GA.dll");
      pl.IgnoreAssemblies.Add("TransparentBlue.PluginFramework.dll");
      //Indicate wich plugins we want to load
      //this avoid loading plugins of another applications
      pl.ApplicationToContributeTo = "MyOptimizer";
      Registry r = pl.Load();


      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmMain(r));
    }
  }
}