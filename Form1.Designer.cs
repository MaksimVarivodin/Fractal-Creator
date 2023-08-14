namespace IDZ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backAlfaButton = new System.Windows.Forms.Button();
            this.kochAlfaButton = new System.Windows.Forms.Button();
            this.innerAlfaButton = new System.Windows.Forms.Button();
            this.backgroundColor = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.kochColor = new System.Windows.Forms.PictureBox();
            this.innerColor = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kochSelect = new System.Windows.Forms.NumericUpDown();
            this.lineSelect = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.angleSelect = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.verticesSelect = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.heightSelect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.widthSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radiusSelect = new System.Windows.Forms.NumericUpDown();
            this.depthSelect = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yCoordinate = new System.Windows.Forms.NumericUpDown();
            this.xCoordinate = new System.Windows.Forms.NumericUpDown();
            this.centerButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kochColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kochSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticesSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinate)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.FileName = "Fractal1";
            this.saveFileDialog1.Filter = "JPEG Image (.jpg)|*.jpg|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|Png Imag" +
    "e (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 506);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Picture";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(860, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.centerButton);
            this.groupBox1.Controls.Add(this.yCoordinate);
            this.groupBox1.Controls.Add(this.xCoordinate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.backAlfaButton);
            this.groupBox1.Controls.Add(this.kochAlfaButton);
            this.groupBox1.Controls.Add(this.innerAlfaButton);
            this.groupBox1.Controls.Add(this.backgroundColor);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.kochColor);
            this.groupBox1.Controls.Add(this.innerColor);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.kochSelect);
            this.groupBox1.Controls.Add(this.lineSelect);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.angleSelect);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.verticesSelect);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.heightSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.widthSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radiusSelect);
            this.groupBox1.Controls.Add(this.depthSelect);
            this.groupBox1.Location = new System.Drawing.Point(860, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 399);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // backAlfaButton
            // 
            this.backAlfaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backAlfaButton.Location = new System.Drawing.Point(161, 344);
            this.backAlfaButton.Name = "backAlfaButton";
            this.backAlfaButton.Size = new System.Drawing.Size(75, 23);
            this.backAlfaButton.TabIndex = 58;
            this.backAlfaButton.Text = "Back Alfa";
            this.backAlfaButton.UseVisualStyleBackColor = true;
            this.backAlfaButton.Click += new System.EventHandler(this.SetBackGoundAlfa);
            // 
            // kochAlfaButton
            // 
            this.kochAlfaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kochAlfaButton.Location = new System.Drawing.Point(161, 315);
            this.kochAlfaButton.Name = "kochAlfaButton";
            this.kochAlfaButton.Size = new System.Drawing.Size(75, 23);
            this.kochAlfaButton.TabIndex = 57;
            this.kochAlfaButton.Text = "Koch Alfa";
            this.kochAlfaButton.UseVisualStyleBackColor = true;
            this.kochAlfaButton.Click += new System.EventHandler(this.SetKochAlfa);
            // 
            // innerAlfaButton
            // 
            this.innerAlfaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.innerAlfaButton.Location = new System.Drawing.Point(161, 286);
            this.innerAlfaButton.Name = "innerAlfaButton";
            this.innerAlfaButton.Size = new System.Drawing.Size(75, 23);
            this.innerAlfaButton.TabIndex = 56;
            this.innerAlfaButton.Text = "Inner Alfa";
            this.innerAlfaButton.UseVisualStyleBackColor = true;
            this.innerAlfaButton.Click += new System.EventHandler(this.SetInnerAlfa);
            // 
            // backgroundColor
            // 
            this.backgroundColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundColor.Location = new System.Drawing.Point(242, 345);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(23, 23);
            this.backgroundColor.TabIndex = 55;
            this.backgroundColor.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(19, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 54;
            this.button5.Text = "Set BackGround Color";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SetBackGroundColor);
            // 
            // kochColor
            // 
            this.kochColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kochColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kochColor.Location = new System.Drawing.Point(242, 315);
            this.kochColor.Name = "kochColor";
            this.kochColor.Size = new System.Drawing.Size(23, 23);
            this.kochColor.TabIndex = 53;
            this.kochColor.TabStop = false;
            // 
            // innerColor
            // 
            this.innerColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.innerColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.innerColor.Location = new System.Drawing.Point(242, 286);
            this.innerColor.Name = "innerColor";
            this.innerColor.Size = new System.Drawing.Size(23, 23);
            this.innerColor.TabIndex = 52;
            this.innerColor.TabStop = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(19, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "Set Koch Color";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SetKochColor);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(19, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "Set Inner Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SetInnerColor);
            // 
            // kochSelect
            // 
            this.kochSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kochSelect.Location = new System.Drawing.Point(140, 156);
            this.kochSelect.Margin = new System.Windows.Forms.Padding(10);
            this.kochSelect.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kochSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kochSelect.Name = "kochSelect";
            this.kochSelect.Size = new System.Drawing.Size(96, 20);
            this.kochSelect.TabIndex = 49;
            this.kochSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kochSelect.ValueChanged += new System.EventHandler(this.KochWidthChanged);
            // 
            // lineSelect
            // 
            this.lineSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineSelect.Location = new System.Drawing.Point(140, 128);
            this.lineSelect.Margin = new System.Windows.Forms.Padding(10);
            this.lineSelect.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lineSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineSelect.Name = "lineSelect";
            this.lineSelect.Size = new System.Drawing.Size(96, 20);
            this.lineSelect.TabIndex = 48;
            this.lineSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineSelect.ValueChanged += new System.EventHandler(this.LineWidthChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Koch Line Width:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Inner Line Width:";
            // 
            // angleSelect
            // 
            this.angleSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.angleSelect.Location = new System.Drawing.Point(160, 102);
            this.angleSelect.Margin = new System.Windows.Forms.Padding(10);
            this.angleSelect.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleSelect.Name = "angleSelect";
            this.angleSelect.Size = new System.Drawing.Size(76, 20);
            this.angleSelect.TabIndex = 45;
            this.angleSelect.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.angleSelect.ValueChanged += new System.EventHandler(this.AngleChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Polygon Start Angle:";
            // 
            // verticesSelect
            // 
            this.verticesSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verticesSelect.Location = new System.Drawing.Point(177, 47);
            this.verticesSelect.Margin = new System.Windows.Forms.Padding(10);
            this.verticesSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.verticesSelect.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.verticesSelect.Name = "verticesSelect";
            this.verticesSelect.Size = new System.Drawing.Size(59, 20);
            this.verticesSelect.TabIndex = 43;
            this.verticesSelect.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.verticesSelect.ValueChanged += new System.EventHandler(this.VerticesChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Polygon Vertices Count:";
            // 
            // heightSelect
            // 
            this.heightSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightSelect.Location = new System.Drawing.Point(113, 210);
            this.heightSelect.Margin = new System.Windows.Forms.Padding(10);
            this.heightSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightSelect.Name = "heightSelect";
            this.heightSelect.Size = new System.Drawing.Size(123, 20);
            this.heightSelect.TabIndex = 41;
            this.heightSelect.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.heightSelect.ValueChanged += new System.EventHandler(this.SetNewSize);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Height:";
            // 
            // widthSelect
            // 
            this.widthSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.widthSelect.Location = new System.Drawing.Point(113, 184);
            this.widthSelect.Margin = new System.Windows.Forms.Padding(10);
            this.widthSelect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthSelect.Name = "widthSelect";
            this.widthSelect.Size = new System.Drawing.Size(123, 20);
            this.widthSelect.TabIndex = 39;
            this.widthSelect.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.widthSelect.ValueChanged += new System.EventHandler(this.SetNewSize);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Width:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Polygon Radius:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Koch Line Depth:";
            // 
            // radiusSelect
            // 
            this.radiusSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radiusSelect.Location = new System.Drawing.Point(140, 19);
            this.radiusSelect.Margin = new System.Windows.Forms.Padding(10);
            this.radiusSelect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.radiusSelect.Name = "radiusSelect";
            this.radiusSelect.Size = new System.Drawing.Size(96, 20);
            this.radiusSelect.TabIndex = 37;
            this.radiusSelect.ValueChanged += new System.EventHandler(this.RadiusChanged);
            // 
            // depthSelect
            // 
            this.depthSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depthSelect.Location = new System.Drawing.Point(147, 76);
            this.depthSelect.Margin = new System.Windows.Forms.Padding(10);
            this.depthSelect.Name = "depthSelect";
            this.depthSelect.Size = new System.Drawing.Size(89, 20);
            this.depthSelect.TabIndex = 34;
            this.depthSelect.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.depthSelect.ValueChanged += new System.EventHandler(this.DepthChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(860, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ReDraw);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.SetNewSize);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "X:";
            // 
            // yCoordinate
            // 
            this.yCoordinate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yCoordinate.Location = new System.Drawing.Point(50, 261);
            this.yCoordinate.Margin = new System.Windows.Forms.Padding(10);
            this.yCoordinate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yCoordinate.Name = "yCoordinate";
            this.yCoordinate.Size = new System.Drawing.Size(162, 20);
            this.yCoordinate.TabIndex = 62;
            this.yCoordinate.Value = new decimal(new int[] {
            540,
            0,
            0,
            0});
            this.yCoordinate.ValueChanged += new System.EventHandler(this.YChanged);
            // 
            // xCoordinate
            // 
            this.xCoordinate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xCoordinate.Location = new System.Drawing.Point(50, 235);
            this.xCoordinate.Margin = new System.Windows.Forms.Padding(10);
            this.xCoordinate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xCoordinate.Name = "xCoordinate";
            this.xCoordinate.Size = new System.Drawing.Size(162, 20);
            this.xCoordinate.TabIndex = 61;
            this.xCoordinate.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.xCoordinate.ValueChanged += new System.EventHandler(this.XCHanged);
            // 
            // centerButton
            // 
            this.centerButton.Location = new System.Drawing.Point(219, 235);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(75, 46);
            this.centerButton.TabIndex = 63;
            this.centerButton.Text = "Center";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.MoveToCenter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koch SnowFlakes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kochColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kochSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticesSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox backgroundColor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox kochColor;
        private System.Windows.Forms.PictureBox innerColor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown kochSelect;
        private System.Windows.Forms.NumericUpDown lineSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown angleSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown verticesSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown heightSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown widthSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown radiusSelect;
        private System.Windows.Forms.NumericUpDown depthSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button kochAlfaButton;
        private System.Windows.Forms.Button innerAlfaButton;
        private System.Windows.Forms.Button backAlfaButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown yCoordinate;
        private System.Windows.Forms.NumericUpDown xCoordinate;
        private System.Windows.Forms.Button centerButton;
    }
}

