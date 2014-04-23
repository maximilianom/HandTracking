namespace HandTrack
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
          this.components = new System.ComponentModel.Container();
          this.ibOriginal = new Emgu.CV.UI.ImageBox();
          this.ibProcessed = new Emgu.CV.UI.ImageBox();
          this.btmPauseOrResume = new System.Windows.Forms.Button();
          this.txtXYRadius = new System.Windows.Forms.TextBox();
          this.CrMin = new System.Windows.Forms.NumericUpDown();
          this.Ymin = new System.Windows.Forms.NumericUpDown();
          this.CbMin = new System.Windows.Forms.NumericUpDown();
          this.checkGaussian = new System.Windows.Forms.CheckBox();
          this.label1 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.label3 = new System.Windows.Forms.Label();
          this.Ymax = new System.Windows.Forms.NumericUpDown();
          this.CrMax = new System.Windows.Forms.NumericUpDown();
          this.CbMax = new System.Windows.Forms.NumericUpDown();
          this.label4 = new System.Windows.Forms.Label();
          this.label5 = new System.Windows.Forms.Label();
          this.tabColorTolerance = new System.Windows.Forms.TabControl();
          this.tabYCrCb = new System.Windows.Forms.TabPage();
          this.tabRGB = new System.Windows.Forms.TabPage();
          this.label10 = new System.Windows.Forms.Label();
          this.label9 = new System.Windows.Forms.Label();
          this.label8 = new System.Windows.Forms.Label();
          this.label7 = new System.Windows.Forms.Label();
          this.label6 = new System.Windows.Forms.Label();
          this.BMax = new System.Windows.Forms.NumericUpDown();
          this.RMax = new System.Windows.Forms.NumericUpDown();
          this.GMax = new System.Windows.Forms.NumericUpDown();
          this.GMin = new System.Windows.Forms.NumericUpDown();
          this.RMin = new System.Windows.Forms.NumericUpDown();
          this.BMin = new System.Windows.Forms.NumericUpDown();
          this.tabHSV = new System.Windows.Forms.TabPage();
          this.HMax = new System.Windows.Forms.NumericUpDown();
          this.SMin = new System.Windows.Forms.NumericUpDown();
          this.label11 = new System.Windows.Forms.Label();
          this.label15 = new System.Windows.Forms.Label();
          this.label12 = new System.Windows.Forms.Label();
          this.label14 = new System.Windows.Forms.Label();
          this.HMin = new System.Windows.Forms.NumericUpDown();
          this.VMin = new System.Windows.Forms.NumericUpDown();
          this.label13 = new System.Windows.Forms.Label();
          this.SMax = new System.Windows.Forms.NumericUpDown();
          this.VMax = new System.Windows.Forms.NumericUpDown();
          this.checkErosion = new System.Windows.Forms.CheckBox();
          this.checkDilation = new System.Windows.Forms.CheckBox();
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.label16 = new System.Windows.Forms.Label();
          this.numPerimeterApprox = new System.Windows.Forms.NumericUpDown();
          this.check = new System.ComponentModel.BackgroundWorker();
          this.checkCamera = new System.Windows.Forms.CheckBox();
          ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.CrMin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.Ymin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.CbMin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.Ymax)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.CrMax)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.CbMax)).BeginInit();
          this.tabColorTolerance.SuspendLayout();
          this.tabYCrCb.SuspendLayout();
          this.tabRGB.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.BMax)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.RMax)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.GMax)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.GMin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.RMin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.BMin)).BeginInit();
          this.tabHSV.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.HMax)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.SMin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.HMin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.VMin)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.SMax)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.VMax)).BeginInit();
          this.groupBox1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numPerimeterApprox)).BeginInit();
          this.SuspendLayout();
          // 
          // ibOriginal
          // 
          this.ibOriginal.Location = new System.Drawing.Point(12, 115);
          this.ibOriginal.Name = "ibOriginal";
          this.ibOriginal.Size = new System.Drawing.Size(640, 480);
          this.ibOriginal.TabIndex = 2;
          this.ibOriginal.TabStop = false;
          // 
          // ibProcessed
          // 
          this.ibProcessed.Location = new System.Drawing.Point(669, 115);
          this.ibProcessed.Name = "ibProcessed";
          this.ibProcessed.Size = new System.Drawing.Size(640, 480);
          this.ibProcessed.TabIndex = 2;
          this.ibProcessed.TabStop = false;
          // 
          // btmPauseOrResume
          // 
          this.btmPauseOrResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btmPauseOrResume.Location = new System.Drawing.Point(37, 568);
          this.btmPauseOrResume.Name = "btmPauseOrResume";
          this.btmPauseOrResume.Size = new System.Drawing.Size(130, 45);
          this.btmPauseOrResume.TabIndex = 3;
          this.btmPauseOrResume.Text = "pause";
          this.btmPauseOrResume.UseVisualStyleBackColor = true;
          this.btmPauseOrResume.Click += new System.EventHandler(this.btmPauseOrResume_Click);
          // 
          // txtXYRadius
          // 
          this.txtXYRadius.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.txtXYRadius.Location = new System.Drawing.Point(210, 568);
          this.txtXYRadius.Multiline = true;
          this.txtXYRadius.Name = "txtXYRadius";
          this.txtXYRadius.ReadOnly = true;
          this.txtXYRadius.Size = new System.Drawing.Size(952, 83);
          this.txtXYRadius.TabIndex = 4;
          // 
          // CrMin
          // 
          this.CrMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.CrMin.Location = new System.Drawing.Point(132, 19);
          this.CrMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.CrMin.Name = "CrMin";
          this.CrMin.Size = new System.Drawing.Size(120, 20);
          this.CrMin.TabIndex = 5;
          this.CrMin.Value = new decimal(new int[] {
            131,
            0,
            0,
            0});
          // 
          // Ymin
          // 
          this.Ymin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.Ymin.Location = new System.Drawing.Point(6, 19);
          this.Ymin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.Ymin.Name = "Ymin";
          this.Ymin.Size = new System.Drawing.Size(120, 20);
          this.Ymin.TabIndex = 6;
          // 
          // CbMin
          // 
          this.CbMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.CbMin.Location = new System.Drawing.Point(258, 19);
          this.CbMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.CbMin.Name = "CbMin";
          this.CbMin.Size = new System.Drawing.Size(120, 20);
          this.CbMin.TabIndex = 7;
          this.CbMin.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
          // 
          // checkGaussian
          // 
          this.checkGaussian.AutoSize = true;
          this.checkGaussian.Location = new System.Drawing.Point(6, 31);
          this.checkGaussian.Name = "checkGaussian";
          this.checkGaussian.Size = new System.Drawing.Size(68, 17);
          this.checkGaussian.TabIndex = 8;
          this.checkGaussian.Text = "gaussian";
          this.checkGaussian.UseVisualStyleBackColor = true;
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(6, 3);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(14, 13);
          this.label1.TabIndex = 9;
          this.label1.Text = "Y";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(255, 3);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(20, 13);
          this.label2.TabIndex = 10;
          this.label2.Text = "Cb";
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(129, 3);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(17, 13);
          this.label3.TabIndex = 11;
          this.label3.Text = "Cr";
          // 
          // Ymax
          // 
          this.Ymax.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.Ymax.Location = new System.Drawing.Point(6, 45);
          this.Ymax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.Ymax.Name = "Ymax";
          this.Ymax.Size = new System.Drawing.Size(120, 20);
          this.Ymax.TabIndex = 12;
          this.Ymax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
          // 
          // CrMax
          // 
          this.CrMax.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.CrMax.Location = new System.Drawing.Point(132, 45);
          this.CrMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.CrMax.Name = "CrMax";
          this.CrMax.Size = new System.Drawing.Size(120, 20);
          this.CrMax.TabIndex = 13;
          this.CrMax.Value = new decimal(new int[] {
            185,
            0,
            0,
            0});
          // 
          // CbMax
          // 
          this.CbMax.Location = new System.Drawing.Point(258, 45);
          this.CbMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.CbMax.Name = "CbMax";
          this.CbMax.Size = new System.Drawing.Size(120, 20);
          this.CbMax.TabIndex = 14;
          this.CbMax.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(384, 26);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(24, 13);
          this.label4.TabIndex = 15;
          this.label4.Text = "Min";
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Location = new System.Drawing.Point(384, 52);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(27, 13);
          this.label5.TabIndex = 16;
          this.label5.Text = "Max";
          // 
          // tabColorTolerance
          // 
          this.tabColorTolerance.Controls.Add(this.tabYCrCb);
          this.tabColorTolerance.Controls.Add(this.tabRGB);
          this.tabColorTolerance.Controls.Add(this.tabHSV);
          this.tabColorTolerance.Location = new System.Drawing.Point(630, 4);
          this.tabColorTolerance.Name = "tabColorTolerance";
          this.tabColorTolerance.SelectedIndex = 0;
          this.tabColorTolerance.Size = new System.Drawing.Size(425, 105);
          this.tabColorTolerance.TabIndex = 17;
          this.tabColorTolerance.SelectedIndexChanged += new System.EventHandler(this.tabColorTolerance_SelectedIndexChanged);
          // 
          // tabYCrCb
          // 
          this.tabYCrCb.Controls.Add(this.Ymax);
          this.tabYCrCb.Controls.Add(this.label4);
          this.tabYCrCb.Controls.Add(this.label5);
          this.tabYCrCb.Controls.Add(this.Ymin);
          this.tabYCrCb.Controls.Add(this.label1);
          this.tabYCrCb.Controls.Add(this.CbMax);
          this.tabYCrCb.Controls.Add(this.CrMin);
          this.tabYCrCb.Controls.Add(this.CrMax);
          this.tabYCrCb.Controls.Add(this.CbMin);
          this.tabYCrCb.Controls.Add(this.label3);
          this.tabYCrCb.Controls.Add(this.label2);
          this.tabYCrCb.Location = new System.Drawing.Point(4, 22);
          this.tabYCrCb.Name = "tabYCrCb";
          this.tabYCrCb.Padding = new System.Windows.Forms.Padding(3);
          this.tabYCrCb.Size = new System.Drawing.Size(417, 79);
          this.tabYCrCb.TabIndex = 0;
          this.tabYCrCb.Text = "Y Cr Cb";
          this.tabYCrCb.UseVisualStyleBackColor = true;
          // 
          // tabRGB
          // 
          this.tabRGB.Controls.Add(this.label10);
          this.tabRGB.Controls.Add(this.label9);
          this.tabRGB.Controls.Add(this.label8);
          this.tabRGB.Controls.Add(this.label7);
          this.tabRGB.Controls.Add(this.label6);
          this.tabRGB.Controls.Add(this.BMax);
          this.tabRGB.Controls.Add(this.RMax);
          this.tabRGB.Controls.Add(this.GMax);
          this.tabRGB.Controls.Add(this.GMin);
          this.tabRGB.Controls.Add(this.RMin);
          this.tabRGB.Controls.Add(this.BMin);
          this.tabRGB.Location = new System.Drawing.Point(4, 22);
          this.tabRGB.Name = "tabRGB";
          this.tabRGB.Padding = new System.Windows.Forms.Padding(3);
          this.tabRGB.Size = new System.Drawing.Size(417, 79);
          this.tabRGB.TabIndex = 1;
          this.tabRGB.Text = "RGB";
          this.tabRGB.UseVisualStyleBackColor = true;
          // 
          // label10
          // 
          this.label10.AutoSize = true;
          this.label10.Location = new System.Drawing.Point(384, 26);
          this.label10.Name = "label10";
          this.label10.Size = new System.Drawing.Size(24, 13);
          this.label10.TabIndex = 27;
          this.label10.Text = "Min";
          // 
          // label9
          // 
          this.label9.AutoSize = true;
          this.label9.Location = new System.Drawing.Point(384, 52);
          this.label9.Name = "label9";
          this.label9.Size = new System.Drawing.Size(27, 13);
          this.label9.TabIndex = 26;
          this.label9.Text = "Max";
          // 
          // label8
          // 
          this.label8.AutoSize = true;
          this.label8.Location = new System.Drawing.Point(255, 3);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(15, 13);
          this.label8.TabIndex = 25;
          this.label8.Text = "R";
          // 
          // label7
          // 
          this.label7.AutoSize = true;
          this.label7.Location = new System.Drawing.Point(129, 3);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(15, 13);
          this.label7.TabIndex = 24;
          this.label7.Text = "G";
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Location = new System.Drawing.Point(3, 3);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(14, 13);
          this.label6.TabIndex = 23;
          this.label6.Text = "B";
          // 
          // BMax
          // 
          this.BMax.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.BMax.Location = new System.Drawing.Point(6, 45);
          this.BMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.BMax.Name = "BMax";
          this.BMax.Size = new System.Drawing.Size(120, 20);
          this.BMax.TabIndex = 22;
          this.BMax.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
          // 
          // RMax
          // 
          this.RMax.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.RMax.Location = new System.Drawing.Point(258, 45);
          this.RMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.RMax.Name = "RMax";
          this.RMax.Size = new System.Drawing.Size(120, 20);
          this.RMax.TabIndex = 21;
          this.RMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
          // 
          // GMax
          // 
          this.GMax.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.GMax.Location = new System.Drawing.Point(132, 45);
          this.GMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.GMax.Name = "GMax";
          this.GMax.Size = new System.Drawing.Size(120, 20);
          this.GMax.TabIndex = 20;
          this.GMax.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
          // 
          // GMin
          // 
          this.GMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.GMin.Location = new System.Drawing.Point(132, 19);
          this.GMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.GMin.Name = "GMin";
          this.GMin.Size = new System.Drawing.Size(120, 20);
          this.GMin.TabIndex = 19;
          this.GMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
          // 
          // RMin
          // 
          this.RMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.RMin.Location = new System.Drawing.Point(258, 19);
          this.RMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.RMin.Name = "RMin";
          this.RMin.Size = new System.Drawing.Size(120, 20);
          this.RMin.TabIndex = 18;
          this.RMin.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
          // 
          // BMin
          // 
          this.BMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.BMin.Location = new System.Drawing.Point(6, 19);
          this.BMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.BMin.Name = "BMin";
          this.BMin.Size = new System.Drawing.Size(120, 20);
          this.BMin.TabIndex = 17;
          // 
          // tabHSV
          // 
          this.tabHSV.Controls.Add(this.HMax);
          this.tabHSV.Controls.Add(this.SMin);
          this.tabHSV.Controls.Add(this.label11);
          this.tabHSV.Controls.Add(this.label15);
          this.tabHSV.Controls.Add(this.label12);
          this.tabHSV.Controls.Add(this.label14);
          this.tabHSV.Controls.Add(this.HMin);
          this.tabHSV.Controls.Add(this.VMin);
          this.tabHSV.Controls.Add(this.label13);
          this.tabHSV.Controls.Add(this.SMax);
          this.tabHSV.Controls.Add(this.VMax);
          this.tabHSV.Location = new System.Drawing.Point(4, 22);
          this.tabHSV.Name = "tabHSV";
          this.tabHSV.Padding = new System.Windows.Forms.Padding(3);
          this.tabHSV.Size = new System.Drawing.Size(417, 79);
          this.tabHSV.TabIndex = 2;
          this.tabHSV.Text = "HSV";
          this.tabHSV.UseVisualStyleBackColor = true;
          // 
          // HMax
          // 
          this.HMax.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.HMax.Location = new System.Drawing.Point(3, 46);
          this.HMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.HMax.Name = "HMax";
          this.HMax.Size = new System.Drawing.Size(120, 20);
          this.HMax.TabIndex = 24;
          this.HMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
          // 
          // SMin
          // 
          this.SMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.SMin.Location = new System.Drawing.Point(129, 19);
          this.SMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.SMin.Name = "SMin";
          this.SMin.Size = new System.Drawing.Size(120, 20);
          this.SMin.TabIndex = 18;
          this.SMin.Value = new decimal(new int[] {
            131,
            0,
            0,
            0});
          // 
          // label11
          // 
          this.label11.AutoSize = true;
          this.label11.Location = new System.Drawing.Point(381, 26);
          this.label11.Name = "label11";
          this.label11.Size = new System.Drawing.Size(24, 13);
          this.label11.TabIndex = 27;
          this.label11.Text = "Min";
          // 
          // label15
          // 
          this.label15.AutoSize = true;
          this.label15.Location = new System.Drawing.Point(256, 3);
          this.label15.Name = "label15";
          this.label15.Size = new System.Drawing.Size(14, 13);
          this.label15.TabIndex = 22;
          this.label15.Text = "V";
          // 
          // label12
          // 
          this.label12.AutoSize = true;
          this.label12.Location = new System.Drawing.Point(378, 52);
          this.label12.Name = "label12";
          this.label12.Size = new System.Drawing.Size(27, 13);
          this.label12.TabIndex = 28;
          this.label12.Text = "Max";
          // 
          // label14
          // 
          this.label14.AutoSize = true;
          this.label14.Location = new System.Drawing.Point(126, 3);
          this.label14.Name = "label14";
          this.label14.Size = new System.Drawing.Size(14, 13);
          this.label14.TabIndex = 23;
          this.label14.Text = "S";
          // 
          // HMin
          // 
          this.HMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.HMin.Location = new System.Drawing.Point(3, 20);
          this.HMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.HMin.Name = "HMin";
          this.HMin.Size = new System.Drawing.Size(120, 20);
          this.HMin.TabIndex = 19;
          // 
          // VMin
          // 
          this.VMin.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.VMin.Location = new System.Drawing.Point(255, 19);
          this.VMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.VMin.Name = "VMin";
          this.VMin.Size = new System.Drawing.Size(120, 20);
          this.VMin.TabIndex = 20;
          this.VMin.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
          // 
          // label13
          // 
          this.label13.AutoSize = true;
          this.label13.Location = new System.Drawing.Point(3, 4);
          this.label13.Name = "label13";
          this.label13.Size = new System.Drawing.Size(15, 13);
          this.label13.TabIndex = 21;
          this.label13.Text = "H";
          // 
          // SMax
          // 
          this.SMax.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
          this.SMax.Location = new System.Drawing.Point(129, 45);
          this.SMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.SMax.Name = "SMax";
          this.SMax.Size = new System.Drawing.Size(120, 20);
          this.SMax.TabIndex = 25;
          this.SMax.Value = new decimal(new int[] {
            185,
            0,
            0,
            0});
          // 
          // VMax
          // 
          this.VMax.Location = new System.Drawing.Point(255, 45);
          this.VMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.VMax.Name = "VMax";
          this.VMax.Size = new System.Drawing.Size(120, 20);
          this.VMax.TabIndex = 26;
          this.VMax.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
          // 
          // checkErosion
          // 
          this.checkErosion.AutoSize = true;
          this.checkErosion.Location = new System.Drawing.Point(6, 54);
          this.checkErosion.Name = "checkErosion";
          this.checkErosion.Size = new System.Drawing.Size(60, 17);
          this.checkErosion.TabIndex = 18;
          this.checkErosion.Text = "erosion";
          this.checkErosion.UseVisualStyleBackColor = true;
          // 
          // checkDilation
          // 
          this.checkDilation.AutoSize = true;
          this.checkDilation.Location = new System.Drawing.Point(6, 77);
          this.checkDilation.Name = "checkDilation";
          this.checkDilation.Size = new System.Drawing.Size(59, 17);
          this.checkDilation.TabIndex = 19;
          this.checkDilation.Text = "dilation";
          this.checkDilation.UseVisualStyleBackColor = true;
          // 
          // groupBox1
          // 
          this.groupBox1.Controls.Add(this.label16);
          this.groupBox1.Controls.Add(this.numPerimeterApprox);
          this.groupBox1.Controls.Add(this.checkGaussian);
          this.groupBox1.Controls.Add(this.checkDilation);
          this.groupBox1.Controls.Add(this.checkErosion);
          this.groupBox1.Location = new System.Drawing.Point(1071, 12);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Size = new System.Drawing.Size(200, 100);
          this.groupBox1.TabIndex = 20;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "groupBox1";
          // 
          // label16
          // 
          this.label16.AutoSize = true;
          this.label16.Location = new System.Drawing.Point(73, 54);
          this.label16.Name = "label16";
          this.label16.Size = new System.Drawing.Size(119, 13);
          this.label16.TabIndex = 29;
          this.label16.Text = "Perimeter approximation";
          // 
          // numPerimeterApprox
          // 
          this.numPerimeterApprox.Location = new System.Drawing.Point(74, 74);
          this.numPerimeterApprox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
          this.numPerimeterApprox.Name = "numPerimeterApprox";
          this.numPerimeterApprox.Size = new System.Drawing.Size(120, 20);
          this.numPerimeterApprox.TabIndex = 29;
          this.numPerimeterApprox.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
          // 
          // checkCamera
          // 
          this.checkCamera.AutoSize = true;
          this.checkCamera.Location = new System.Drawing.Point(12, 4);
          this.checkCamera.Name = "checkCamera";
          this.checkCamera.Size = new System.Drawing.Size(61, 17);
          this.checkCamera.TabIndex = 21;
          this.checkCamera.Text = "camera";
          this.checkCamera.UseVisualStyleBackColor = true;
          this.checkCamera.CheckedChanged += new System.EventHandler(this.checkCamera_CheckedChanged);
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(1321, 713);
          this.Controls.Add(this.checkCamera);
          this.Controls.Add(this.groupBox1);
          this.Controls.Add(this.tabColorTolerance);
          this.Controls.Add(this.txtXYRadius);
          this.Controls.Add(this.btmPauseOrResume);
          this.Controls.Add(this.ibProcessed);
          this.Controls.Add(this.ibOriginal);
          this.Name = "Form1";
          this.Text = "Form1";
          this.Load += new System.EventHandler(this.Form1_Load);
          ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.CrMin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.Ymin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.CbMin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.Ymax)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.CrMax)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.CbMax)).EndInit();
          this.tabColorTolerance.ResumeLayout(false);
          this.tabYCrCb.ResumeLayout(false);
          this.tabYCrCb.PerformLayout();
          this.tabRGB.ResumeLayout(false);
          this.tabRGB.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.BMax)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.RMax)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.GMax)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.GMin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.RMin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.BMin)).EndInit();
          this.tabHSV.ResumeLayout(false);
          this.tabHSV.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.HMax)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.SMin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.HMin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.VMin)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.SMax)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.VMax)).EndInit();
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numPerimeterApprox)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibProcessed;
        private System.Windows.Forms.Button btmPauseOrResume;
        private System.Windows.Forms.TextBox txtXYRadius;
        private System.Windows.Forms.NumericUpDown CrMin;
        private System.Windows.Forms.NumericUpDown Ymin;
        private System.Windows.Forms.NumericUpDown CbMin;
        private System.Windows.Forms.CheckBox checkGaussian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Ymax;
        private System.Windows.Forms.NumericUpDown CrMax;
        private System.Windows.Forms.NumericUpDown CbMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabColorTolerance;
        private System.Windows.Forms.TabPage tabYCrCb;
        private System.Windows.Forms.TabPage tabRGB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BMax;
        private System.Windows.Forms.NumericUpDown RMax;
        private System.Windows.Forms.NumericUpDown GMax;
        private System.Windows.Forms.NumericUpDown GMin;
        private System.Windows.Forms.NumericUpDown RMin;
        private System.Windows.Forms.NumericUpDown BMin;
        private System.Windows.Forms.TabPage tabHSV;
        private System.Windows.Forms.NumericUpDown HMax;
        private System.Windows.Forms.NumericUpDown SMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown HMin;
        private System.Windows.Forms.NumericUpDown VMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown SMax;
        private System.Windows.Forms.NumericUpDown VMax;
        private System.Windows.Forms.CheckBox checkErosion;
        private System.Windows.Forms.CheckBox checkDilation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numPerimeterApprox;
        private System.ComponentModel.BackgroundWorker check;
        private System.Windows.Forms.CheckBox checkCamera;
    }
}

