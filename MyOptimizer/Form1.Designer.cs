namespace MyOptimizer
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.nudMaximumEraNumber = new System.Windows.Forms.NumericUpDown();
      this.nudFitnessTolerance = new System.Windows.Forms.NumericUpDown();
      this.nudNonImprovementGenerations = new System.Windows.Forms.NumericUpDown();
      this.nudSolutionsToKeep = new System.Windows.Forms.NumericUpDown();
      this.nudPopulationSize = new System.Windows.Forms.NumericUpDown();
      this.nudCutProbability = new System.Windows.Forms.NumericUpDown();
      this.nudMutationProbability = new System.Windows.Forms.NumericUpDown();
      this.nudSeed = new System.Windows.Forms.NumericUpDown();
      this.label20 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.flwControls = new System.Windows.Forms.FlowLayoutPanel();
      this.cbxFunctions = new System.Windows.Forms.ComboBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lstMessyOut = new System.Windows.Forms.ListBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lstSolution = new System.Windows.Forms.ListBox();
      this.lblCurentSol = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cbxApproach = new System.Windows.Forms.ComboBox();
      this.lblCurrentCromosome = new System.Windows.Forms.Label();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaximumEraNumber)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudFitnessTolerance)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNonImprovementGenerations)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSolutionsToKeep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPopulationSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudCutProbability)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMutationProbability)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      this.splitContainer1.Panel1.Controls.Add(this.btnCalculate);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
      this.splitContainer1.Size = new System.Drawing.Size(786, 504);
      this.splitContainer1.SplitterDistance = 260;
      this.splitContainer1.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.cbxApproach);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Controls.Add(this.nudMaximumEraNumber);
      this.groupBox3.Controls.Add(this.nudFitnessTolerance);
      this.groupBox3.Controls.Add(this.nudNonImprovementGenerations);
      this.groupBox3.Controls.Add(this.nudSolutionsToKeep);
      this.groupBox3.Controls.Add(this.nudPopulationSize);
      this.groupBox3.Controls.Add(this.nudCutProbability);
      this.groupBox3.Controls.Add(this.nudMutationProbability);
      this.groupBox3.Controls.Add(this.nudSeed);
      this.groupBox3.Controls.Add(this.label20);
      this.groupBox3.Controls.Add(this.label19);
      this.groupBox3.Controls.Add(this.label17);
      this.groupBox3.Controls.Add(this.label16);
      this.groupBox3.Controls.Add(this.label14);
      this.groupBox3.Controls.Add(this.label12);
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Controls.Add(this.label9);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(3, 202);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(255, 257);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Algorithm";
      // 
      // nudMaximumEraNumber
      // 
      this.nudMaximumEraNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudMaximumEraNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudMaximumEraNumber.Location = new System.Drawing.Point(147, 21);
      this.nudMaximumEraNumber.Name = "nudMaximumEraNumber";
      this.nudMaximumEraNumber.Size = new System.Drawing.Size(104, 20);
      this.nudMaximumEraNumber.TabIndex = 53;
      this.nudMaximumEraNumber.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // nudFitnessTolerance
      // 
      this.nudFitnessTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudFitnessTolerance.DecimalPlaces = 3;
      this.nudFitnessTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudFitnessTolerance.Location = new System.Drawing.Point(147, 47);
      this.nudFitnessTolerance.Name = "nudFitnessTolerance";
      this.nudFitnessTolerance.Size = new System.Drawing.Size(104, 20);
      this.nudFitnessTolerance.TabIndex = 54;
      this.nudFitnessTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
      this.nudFitnessTolerance.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // nudNonImprovementGenerations
      // 
      this.nudNonImprovementGenerations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudNonImprovementGenerations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudNonImprovementGenerations.Location = new System.Drawing.Point(147, 73);
      this.nudNonImprovementGenerations.Name = "nudNonImprovementGenerations";
      this.nudNonImprovementGenerations.Size = new System.Drawing.Size(104, 20);
      this.nudNonImprovementGenerations.TabIndex = 55;
      this.nudNonImprovementGenerations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nudNonImprovementGenerations.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // nudSolutionsToKeep
      // 
      this.nudSolutionsToKeep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudSolutionsToKeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudSolutionsToKeep.Location = new System.Drawing.Point(147, 99);
      this.nudSolutionsToKeep.Name = "nudSolutionsToKeep";
      this.nudSolutionsToKeep.Size = new System.Drawing.Size(104, 20);
      this.nudSolutionsToKeep.TabIndex = 56;
      this.nudSolutionsToKeep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.nudSolutionsToKeep.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // nudPopulationSize
      // 
      this.nudPopulationSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudPopulationSize.DecimalPlaces = 3;
      this.nudPopulationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudPopulationSize.Location = new System.Drawing.Point(147, 125);
      this.nudPopulationSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nudPopulationSize.Name = "nudPopulationSize";
      this.nudPopulationSize.Size = new System.Drawing.Size(104, 20);
      this.nudPopulationSize.TabIndex = 57;
      this.nudPopulationSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudPopulationSize.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // nudCutProbability
      // 
      this.nudCutProbability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudCutProbability.DecimalPlaces = 3;
      this.nudCutProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudCutProbability.Location = new System.Drawing.Point(147, 151);
      this.nudCutProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudCutProbability.Name = "nudCutProbability";
      this.nudCutProbability.Size = new System.Drawing.Size(104, 20);
      this.nudCutProbability.TabIndex = 58;
      this.nudCutProbability.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
      this.nudCutProbability.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // nudMutationProbability
      // 
      this.nudMutationProbability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudMutationProbability.DecimalPlaces = 3;
      this.nudMutationProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudMutationProbability.Location = new System.Drawing.Point(147, 177);
      this.nudMutationProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudMutationProbability.Name = "nudMutationProbability";
      this.nudMutationProbability.Size = new System.Drawing.Size(104, 20);
      this.nudMutationProbability.TabIndex = 59;
      this.nudMutationProbability.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
      this.nudMutationProbability.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // nudSeed
      // 
      this.nudSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.nudSeed.DecimalPlaces = 3;
      this.nudSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nudSeed.Location = new System.Drawing.Point(147, 203);
      this.nudSeed.Name = "nudSeed";
      this.nudSeed.Size = new System.Drawing.Size(104, 20);
      this.nudSeed.TabIndex = 60;
      this.nudSeed.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
      this.nudSeed.ValueChanged += new System.EventHandler(this.nudMaximumEraNumber_ValueChanged);
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label20.Location = new System.Drawing.Point(3, 205);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(76, 13);
      this.label20.TabIndex = 68;
      this.label20.Text = "Random seed:";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label19.Location = new System.Drawing.Point(3, 179);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(101, 13);
      this.label19.TabIndex = 67;
      this.label19.Text = "Mutation probability:";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label17.Location = new System.Drawing.Point(3, 153);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(73, 13);
      this.label17.TabIndex = 66;
      this.label17.Text = "Cut probability";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label16.Location = new System.Drawing.Point(3, 127);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(130, 13);
      this.label16.TabIndex = 65;
      this.label16.Text = "Betta population multiplier:";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label14.Location = new System.Drawing.Point(2, 24);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(103, 13);
      this.label14.TabIndex = 64;
      this.label14.Text = "Max number of eras:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label12.Location = new System.Drawing.Point(3, 101);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(89, 13);
      this.label12.TabIndex = 63;
      this.label12.Text = "Solutions to keep";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label11.Location = new System.Drawing.Point(2, 75);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(145, 13);
      this.label11.TabIndex = 62;
      this.label11.Text = "Generations no improvement:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label9.Location = new System.Drawing.Point(2, 49);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(90, 13);
      this.label9.TabIndex = 61;
      this.label9.Text = "Fitness tolerance:";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.flwControls);
      this.groupBox1.Controls.Add(this.cbxFunctions);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(255, 196);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Function";
      // 
      // flwControls
      // 
      this.flwControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.flwControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flwControls.Location = new System.Drawing.Point(6, 47);
      this.flwControls.Name = "flwControls";
      this.flwControls.Size = new System.Drawing.Size(246, 143);
      this.flwControls.TabIndex = 1;
      // 
      // cbxFunctions
      // 
      this.cbxFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cbxFunctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxFunctions.FormattingEnabled = true;
      this.cbxFunctions.Location = new System.Drawing.Point(6, 20);
      this.cbxFunctions.Name = "cbxFunctions";
      this.cbxFunctions.Size = new System.Drawing.Size(244, 21);
      this.cbxFunctions.TabIndex = 0;
      this.cbxFunctions.SelectedIndexChanged += new System.EventHandler(this.cbxFunctions_SelectedIndexChanged);
      // 
      // btnCalculate
      // 
      this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCalculate.Location = new System.Drawing.Point(0, 465);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(260, 39);
      this.btnCalculate.TabIndex = 0;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lblCurrentCromosome);
      this.groupBox2.Controls.Add(this.lblCurentSol);
      this.groupBox2.Controls.Add(this.lstSolution);
      this.groupBox2.Controls.Add(this.btnCancel);
      this.groupBox2.Controls.Add(this.lstMessyOut);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
      this.groupBox2.Size = new System.Drawing.Size(522, 504);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Fast Messy Output";
      this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
      // 
      // lstMessyOut
      // 
      this.lstMessyOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lstMessyOut.FormattingEnabled = true;
      this.lstMessyOut.ItemHeight = 15;
      this.lstMessyOut.Location = new System.Drawing.Point(8, 22);
      this.lstMessyOut.Name = "lstMessyOut";
      this.lstMessyOut.Size = new System.Drawing.Size(506, 229);
      this.lstMessyOut.TabIndex = 0;
      this.lstMessyOut.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Enabled = false;
      this.btnCancel.Location = new System.Drawing.Point(358, 257);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(156, 28);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Stop!";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // lstSolution
      // 
      this.lstSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lstSolution.FormattingEnabled = true;
      this.lstSolution.ItemHeight = 15;
      this.lstSolution.Location = new System.Drawing.Point(8, 317);
      this.lstSolution.Name = "lstSolution";
      this.lstSolution.Size = new System.Drawing.Size(506, 169);
      this.lstSolution.TabIndex = 3;
      // 
      // lblCurentSol
      // 
      this.lblCurentSol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lblCurentSol.AutoSize = true;
      this.lblCurentSol.Location = new System.Drawing.Point(5, 299);
      this.lblCurentSol.Name = "lblCurentSol";
      this.lblCurentSol.Size = new System.Drawing.Size(113, 15);
      this.lblCurentSol.TabIndex = 4;
      this.lblCurentSol.Text = "Current solution:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label2.Location = new System.Drawing.Point(3, 229);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 71;
      this.label2.Text = "Aproach:";
      // 
      // cbxApproach
      // 
      this.cbxApproach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cbxApproach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxApproach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxApproach.FormattingEnabled = true;
      this.cbxApproach.Items.AddRange(new object[] {
            "Minimization",
            "Maximization"});
      this.cbxApproach.Location = new System.Drawing.Point(147, 228);
      this.cbxApproach.Name = "cbxApproach";
      this.cbxApproach.Size = new System.Drawing.Size(104, 21);
      this.cbxApproach.TabIndex = 72;
      this.cbxApproach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // lblCurrentCromosome
      // 
      this.lblCurrentCromosome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lblCurrentCromosome.AutoSize = true;
      this.lblCurrentCromosome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCurrentCromosome.Location = new System.Drawing.Point(124, 301);
      this.lblCurrentCromosome.Name = "lblCurrentCromosome";
      this.lblCurrentCromosome.Size = new System.Drawing.Size(10, 13);
      this.lblCurrentCromosome.TabIndex = 5;
      this.lblCurrentCromosome.Text = "-";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(786, 504);
      this.Controls.Add(this.splitContainer1);
      this.Name = "frmMain";
      this.Text = "My Optimizer ";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaximumEraNumber)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudFitnessTolerance)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudNonImprovementGenerations)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSolutionsToKeep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudPopulationSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudCutProbability)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMutationProbability)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox lstMessyOut;
    private System.Windows.Forms.GroupBox groupBox3;
    protected internal System.Windows.Forms.NumericUpDown nudMaximumEraNumber;
    protected internal System.Windows.Forms.NumericUpDown nudFitnessTolerance;
    protected internal System.Windows.Forms.NumericUpDown nudNonImprovementGenerations;
    protected internal System.Windows.Forms.NumericUpDown nudSolutionsToKeep;
    protected internal System.Windows.Forms.NumericUpDown nudPopulationSize;
    protected internal System.Windows.Forms.NumericUpDown nudCutProbability;
    protected internal System.Windows.Forms.NumericUpDown nudMutationProbability;
    protected internal System.Windows.Forms.NumericUpDown nudSeed;
    protected System.Windows.Forms.Label label20;
    protected System.Windows.Forms.Label label19;
    protected System.Windows.Forms.Label label17;
    protected System.Windows.Forms.Label label16;
    protected System.Windows.Forms.Label label14;
    protected System.Windows.Forms.Label label12;
    protected System.Windows.Forms.Label label11;
    protected System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cbxFunctions;
    private System.Windows.Forms.FlowLayoutPanel flwControls;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblCurentSol;
    private System.Windows.Forms.ListBox lstSolution;
    protected System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbxApproach;
    private System.Windows.Forms.Label lblCurrentCromosome;
  }
}

