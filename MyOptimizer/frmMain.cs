using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using TransparentBlue.GA;
using TransparentBlue.PluginFramework;

namespace MyOptimizer
{
  public partial class frmMain : Form
  {
    private Registry _registry;

    //GA Objective functions
    private List<ObjectiveFunction> _functions;

    //Parameter widgets factories
    private Dictionary<Type, WidgetFactory> _widgetFactories;

    //Created widgets
    private List<Control> _widget;

    private ParameterInfo[] _paramInfo;

    private FastMessyGAParams _gaParams;

    private bool _cancel = false;

    private FastMessyGA _fmga;

    public frmMain(Registry registry)
    {
      InitializeComponent();
      _registry = registry;
      _widgetFactories = new Dictionary<Type, WidgetFactory>();
      _widget =  new List<Control>();
      _gaParams = new FastMessyGAParams();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Get All objetive functions. Add them to the menu.
      _functions = _registry.GetServices<ObjectiveFunction>();
      foreach (ObjectiveFunction function in _functions) {
        cbxFunctions.Items.Add(function.Description);
      }
      
      //Get all widget paramethers
      List<WidgetFactory> w = _registry.GetServices<WidgetFactory>();
      foreach (WidgetFactory widget in w) {
        _widgetFactories[widget.ValueType] = widget;
      }
      cbxApproach.SelectedIndex = 1;
      cbxFunctions.SelectedIndex = 0;
    }

    private void cbxFunctions_SelectedIndexChanged(object sender, EventArgs e)
    {
      //Create automatically widgets from the functions paramethers.
      _paramInfo = _functions[cbxFunctions.SelectedIndex].GetParamethers();
      flwControls.Controls.Clear();
      _widget.Clear();
      foreach (ParameterInfo info in _paramInfo) {
        Control c = _widgetFactories[info.ParameterType].BuildControl();
        Label l = new Label();
        l.Text = info.Name + ":";
        flwControls.Controls.Add(l);
        flwControls.Controls.Add(c);
        _widget.Add(c);
      }
    }

    private void nudPopulationSize_ValueChanged(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Performs the calculation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCalculate_Click(object sender, EventArgs e)
    {
      //Pass the paramethers to the objetive function
      ObjectiveFunction objFunction = _functions[cbxFunctions.SelectedIndex];
      object[] values = new object[_widget.Count];
      for (int i = 0; i < _widget.Count; i++) {
        Control w = _widget[i];
        Type pt = _paramInfo[i].ParameterType;
        values[i] = _widgetFactories[pt].GetValuesFromControl(w);
      }
      //Set values from
      objFunction.SetValues(values);

      UpdateParameters();
      _gaParams.CromosomeSize = objFunction.CromosomeSize;
      _gaParams.InitIntervals = objFunction.InitialIntervals;
      _gaParams.FitnesFunction = objFunction;
      _cancel = false;

      //
      lstMessyOut.Items.Clear();
      btnCancel.Enabled = true;
      btnCalculate.Enabled = false;
      lstSolution.Items.Clear();
      lstMessyOut.Items.Clear();
      Thread t = new Thread(StartGA);
      t.Start();
    }

    private void StartGA()
    {
      //Setup the Genetic algorithm using the interface parameters
      _fmga = new FastMessyGA();
      _fmga.OnProgress += OnGAProgress;
      _fmga.Execute(_gaParams);
      if (_cancel == false) {
        Invoke(new GACompleted(OnGACompleted));
      }
    }

    private delegate void GAProgressReport(double newprogress, string operation, Cromosome[] result);

    private delegate void GACompleted();

    private void OnGACompleted()
    {
      MessageBox.Show("Calculations completed");
      btnCancel.Enabled = false;
      btnCalculate.Enabled = true;
    }

    private void OnGAProgress(double newprogress, string operation, out bool cancel)
    {
      object[] a = {newprogress, operation, _fmga.Result};
      try {
        cancel = _cancel;
        Invoke(new GAProgressReport(DoOnGAProgress), a);
      }
      catch( ObjectDisposedException ) {
        //The form is closing. Cancel processing and quit.
        cancel = true;
      }
    }

    private void DoOnGAProgress(double newprogress, string operation, Cromosome[] result)
    {
      if ( newprogress != 0 || operation.IndexOf("Template") != -1 ) {
        lstMessyOut.Items.Add(operation + " - " + newprogress);
        if (result != null) {
          lstSolution.Items.Clear();
          for (int i = 0; i < result.Length; i++) {
            lstSolution.Items.Add(result[i].ToString());
          }
          lblCurrentCromosome.Text = result[0].ToString();
        }
      }
    }

    private void UpdateParameters()
    {
      _gaParams.Eras = (int)nudMaximumEraNumber.Value;
      _gaParams.CutAndSpliceProbability = (double)nudCutProbability.Value;
      _gaParams.FitnessTolerance = (double)nudFitnessTolerance.Value;
      _gaParams.MutationProbability = (float)nudMutationProbability.Value;
      _gaParams.NonImprovementGenerations = (int)nudNonImprovementGenerations.Value;
      _gaParams.Betta = (double)nudPopulationSize.Value;
      _gaParams.SolutionsToKeep = (int)nudSolutionsToKeep.Value;
      _gaParams.Seed = (double)nudSeed.Value;
      _gaParams.Maximization = cbxApproach.SelectedIndex == 1;
    }

    private void nudMaximumEraNumber_ValueChanged(object sender, EventArgs e)
    {
      UpdateParameters();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      _cancel = true;
      btnCancel.Enabled = false;
      btnCalculate.Enabled = true;
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      _cancel = true;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      _gaParams.Maximization = cbxApproach.SelectedIndex == 1;
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }
  }


}