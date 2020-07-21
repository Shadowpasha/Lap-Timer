namespace Lap_Timer
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maintable = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label19 = new MetroFramework.Controls.MetroLabel();
            this.updownracers = new System.Windows.Forms.NumericUpDown();
            this.updownlaps = new System.Windows.Forms.NumericUpDown();
            this.Finish = new System.Windows.Forms.Timer(this.components);
            this.Timerlabel = new MetroFramework.Controls.MetroLabel();
            this.Export = new MetroFramework.Controls.MetroButton();
            this.Reset = new MetroFramework.Controls.MetroButton();
            this.MANUAL = new MetroFramework.Controls.MetroButton();
            this.LoadRacers = new MetroFramework.Controls.MetroButton();
            this.LOAD = new MetroFramework.Controls.MetroButton();
            this.Updatemain = new System.Windows.Forms.Timer(this.components);
            this.updatefinish = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Mainwindow = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new MetroFramework.Controls.MetroPanel();
            this.Lapsleft = new MetroFramework.Controls.MetroLabel();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.Communication = new MetroFramework.Controls.MetroTabPage();
            this.panel11 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbConnectType = new System.Windows.Forms.GroupBox();
            this.rdbTcpIp = new System.Windows.Forms.RadioButton();
            this.rdbRS232 = new System.Windows.Forms.RadioButton();
            this.Rs323Panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new MetroFramework.Controls.MetroComboBox();
            this.cmbPortName = new MetroFramework.Controls.MetroComboBox();
            this.panel13 = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.btndisconnect = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbAntenna = new System.Windows.Forms.GroupBox();
            this.cbAnt4 = new System.Windows.Forms.CheckBox();
            this.cbAnt2 = new System.Windows.Forms.CheckBox();
            this.cbAnt3 = new System.Windows.Forms.CheckBox();
            this.cbAnt1 = new System.Windows.Forms.CheckBox();
            this.label13 = new MetroFramework.Controls.MetroLabel();
            this.label14 = new MetroFramework.Controls.MetroLabel();
            this.label23 = new MetroFramework.Controls.MetroLabel();
            this.label24 = new MetroFramework.Controls.MetroLabel();
            this.group = new System.Windows.Forms.GroupBox();
            this.gbSysFreq = new System.Windows.Forms.GroupBox();
            this.label21 = new MetroFramework.Controls.MetroLabel();
            this.label16 = new MetroFramework.Controls.MetroLabel();
            this.cmbFrequencyStart = new MetroFramework.Controls.MetroComboBox();
            this.rbCHN = new System.Windows.Forms.RadioButton();
            this.rbETSI = new System.Windows.Forms.RadioButton();
            this.rbFCC = new System.Windows.Forms.RadioButton();
            this.cmbFrequencyEnd = new MetroFramework.Controls.MetroComboBox();
            this.gbUserFreq = new System.Windows.Forms.GroupBox();
            this.label22 = new MetroFramework.Controls.MetroLabel();
            this.label17 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtFreqSpace = new MetroFramework.Controls.MetroTextBox();
            this.txtStartFreq = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new MetroFramework.Controls.MetroLabel();
            this.cbUserFreq = new MetroFramework.Controls.MetroCheckBox();
            this.label20 = new MetroFramework.Controls.MetroLabel();
            this.gbRFPower = new System.Windows.Forms.GroupBox();
            this.comboPower = new System.Windows.Forms.ComboBox();
            this.label11 = new MetroFramework.Controls.MetroLabel();
            this.panel17 = new MetroFramework.Controls.MetroPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btSetConfig = new System.Windows.Forms.Button();
            this.Tcppanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortBox = new MetroFramework.Controls.MetroTextBox();
            this.IPBOX = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel14 = new MetroFramework.Controls.MetroPanel();
            this.StopTCp = new MetroFramework.Controls.MetroButton();
            this.StartTcp = new MetroFramework.Controls.MetroButton();
            this.panel15 = new MetroFramework.Controls.MetroPanel();
            this.panel3 = new MetroFramework.Controls.MetroPanel();
            this.panel10 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.panel8 = new MetroFramework.Controls.MetroPanel();
            this.racebeginbutton = new MetroFramework.Controls.MetroButton();
            this.StartReading = new MetroFramework.Controls.MetroButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new MetroFramework.Controls.MetroLabel();
            this.NRUNNERS = new System.Windows.Forms.NumericUpDown();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.maintable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownracers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownlaps)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Mainwindow.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Communication.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbConnectType.SuspendLayout();
            this.Rs323Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.gbAntenna.SuspendLayout();
            this.group.SuspendLayout();
            this.gbSysFreq.SuspendLayout();
            this.gbUserFreq.SuspendLayout();
            this.gbRFPower.SuspendLayout();
            this.panel17.SuspendLayout();
            this.Tcppanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NRUNNERS)).BeginInit();
            this.SuspendLayout();
            // 
            // maintable
            // 
            this.maintable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintable.AutoScroll = true;
            this.maintable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maintable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.maintable.ColumnCount = 3;
            this.maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.maintable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.maintable.Controls.Add(this.label18, 1, 0);
            this.maintable.Controls.Add(this.label5, 0, 0);
            this.maintable.Controls.Add(this.label19, 2, 0);
            this.maintable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maintable.Location = new System.Drawing.Point(10, 117);
            this.maintable.Name = "maintable";
            this.maintable.RowCount = 2;
            this.maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.maintable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.maintable.Size = new System.Drawing.Size(1031, 481);
            this.maintable.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label18.Location = new System.Drawing.Point(119, 1);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 50);
            this.label18.TabIndex = 16;
            this.label18.Text = "Name";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(1, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rank";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label19.Location = new System.Drawing.Point(320, 1);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(710, 50);
            this.label19.TabIndex = 17;
            this.label19.Text = "Finish";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updownracers
            // 
            this.updownracers.BackColor = System.Drawing.Color.AliceBlue;
            this.updownracers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownracers.Location = new System.Drawing.Point(70, 596);
            this.updownracers.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.updownracers.Name = "updownracers";
            this.updownracers.Size = new System.Drawing.Size(38, 38);
            this.updownracers.TabIndex = 2;
            this.updownracers.ValueChanged += new System.EventHandler(this.updownracers_ValueChanged);
            // 
            // updownlaps
            // 
            this.updownlaps.BackColor = System.Drawing.Color.AliceBlue;
            this.updownlaps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updownlaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownlaps.Location = new System.Drawing.Point(98, 70);
            this.updownlaps.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updownlaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownlaps.Name = "updownlaps";
            this.updownlaps.Size = new System.Drawing.Size(70, 38);
            this.updownlaps.TabIndex = 3;
            this.updownlaps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownlaps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownlaps.ValueChanged += new System.EventHandler(this.updownlaps_ValueChanged);
            // 
            // Finish
            // 
            this.Finish.Interval = 1;
            this.Finish.Tick += new System.EventHandler(this.Finish_Tick);
            // 
            // Timerlabel
            // 
            this.Timerlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Timerlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Timerlabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Timerlabel.Location = new System.Drawing.Point(274, 38);
            this.Timerlabel.Name = "Timerlabel";
            this.Timerlabel.Size = new System.Drawing.Size(182, 32);
            this.Timerlabel.TabIndex = 0;
            this.Timerlabel.Text = "00:00:00";
            this.Timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(16, 165);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(151, 28);
            this.Export.TabIndex = 9;
            this.Export.Text = "EXPORT RESULT";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(27, 53);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(124, 28);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // MANUAL
            // 
            this.MANUAL.Location = new System.Drawing.Point(28, 143);
            this.MANUAL.Name = "MANUAL";
            this.MANUAL.Size = new System.Drawing.Size(135, 26);
            this.MANUAL.TabIndex = 11;
            this.MANUAL.Text = "MANUAL";
            this.MANUAL.Click += new System.EventHandler(this.Register_Click);
            // 
            // LoadRacers
            // 
            this.LoadRacers.Location = new System.Drawing.Point(28, 174);
            this.LoadRacers.Name = "LoadRacers";
            this.LoadRacers.Size = new System.Drawing.Size(135, 27);
            this.LoadRacers.TabIndex = 12;
            this.LoadRacers.Text = "LOAD";
            this.LoadRacers.Click += new System.EventHandler(this.LoadRacers_Click);
            // 
            // LOAD
            // 
            this.LOAD.Location = new System.Drawing.Point(28, 109);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(135, 27);
            this.LOAD.TabIndex = 13;
            this.LOAD.Text = "IMPORT";
            this.LOAD.Click += new System.EventHandler(this.import_Click);
            // 
            // Updatemain
            // 
            this.Updatemain.Interval = 1;
            this.Updatemain.Tick += new System.EventHandler(this.Updatemain_Tick);
            // 
            // updatefinish
            // 
            this.updatefinish.Interval = 1;
            this.updatefinish.Tick += new System.EventHandler(this.updatefinish_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Timerlabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 108);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label7.Location = new System.Drawing.Point(30, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 61);
            this.label7.TabIndex = 2;
            this.label7.Text = "RACE TIME";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mainwindow);
            this.tabControl1.Controls.Add(this.Communication);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 24);
            this.tabControl1.Location = new System.Drawing.Point(192, 2);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1049, 633);
            this.tabControl1.MinimumSize = new System.Drawing.Size(1049, 633);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 633);
            this.tabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabControl1.TabIndex = 14;
            // 
            // Mainwindow
            // 
            this.Mainwindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Mainwindow.Controls.Add(this.panel4);
            this.Mainwindow.Controls.Add(this.panel2);
            this.Mainwindow.Controls.Add(this.maintable);
            this.Mainwindow.ForeColor = System.Drawing.Color.Black;
            this.Mainwindow.HorizontalScrollbarBarColor = true;
            this.Mainwindow.Location = new System.Drawing.Point(4, 28);
            this.Mainwindow.Name = "Mainwindow";
            this.Mainwindow.Padding = new System.Windows.Forms.Padding(3);
            this.Mainwindow.Size = new System.Drawing.Size(1041, 601);
            this.Mainwindow.TabIndex = 0;
            this.Mainwindow.Text = "Main";
            this.Mainwindow.VerticalScrollbarBarColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Lapsleft);
            this.panel4.Controls.Add(this.label6);
            this.panel4.HorizontalScrollbarBarColor = true;
            this.panel4.HorizontalScrollbarHighlightOnWheel = false;
            this.panel4.HorizontalScrollbarSize = 10;
            this.panel4.Location = new System.Drawing.Point(547, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 108);
            this.panel4.TabIndex = 15;
            this.panel4.VerticalScrollbarBarColor = true;
            this.panel4.VerticalScrollbarHighlightOnWheel = false;
            this.panel4.VerticalScrollbarSize = 10;
            // 
            // Lapsleft
            // 
            this.Lapsleft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lapsleft.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lapsleft.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Lapsleft.Location = new System.Drawing.Point(251, 20);
            this.Lapsleft.Name = "Lapsleft";
            this.Lapsleft.Size = new System.Drawing.Size(195, 64);
            this.Lapsleft.TabIndex = 0;
            this.Lapsleft.Text = "0 / 0";
            this.Lapsleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label6.Location = new System.Drawing.Point(51, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 59);
            this.label6.TabIndex = 1;
            this.label6.Text = "LAPS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Communication
            // 
            this.Communication.Controls.Add(this.panel11);
            this.Communication.HorizontalScrollbarBarColor = true;
            this.Communication.Location = new System.Drawing.Point(4, 28);
            this.Communication.Name = "Communication";
            this.Communication.Padding = new System.Windows.Forms.Padding(3);
            this.Communication.Size = new System.Drawing.Size(1041, 601);
            this.Communication.TabIndex = 1;
            this.Communication.Text = "Settings";
            this.Communication.VerticalScrollbarBarColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.Rs323Panel);
            this.panel11.Controls.Add(this.listBox1);
            this.panel11.Controls.Add(this.gbAntenna);
            this.panel11.Controls.Add(this.group);
            this.panel11.Controls.Add(this.gbRFPower);
            this.panel11.Controls.Add(this.panel17);
            this.panel11.Controls.Add(this.Tcppanel);
            this.panel11.HorizontalScrollbarBarColor = true;
            this.panel11.HorizontalScrollbarHighlightOnWheel = false;
            this.panel11.HorizontalScrollbarSize = 10;
            this.panel11.Location = new System.Drawing.Point(71, 5);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(890, 606);
            this.panel11.TabIndex = 20;
            this.panel11.VerticalScrollbarBarColor = true;
            this.panel11.VerticalScrollbarHighlightOnWheel = false;
            this.panel11.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbConnectType);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 93);
            this.panel1.TabIndex = 18;
            // 
            // gbConnectType
            // 
            this.gbConnectType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbConnectType.Controls.Add(this.rdbTcpIp);
            this.gbConnectType.Controls.Add(this.rdbRS232);
            this.gbConnectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbConnectType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbConnectType.Location = new System.Drawing.Point(22, -3);
            this.gbConnectType.Name = "gbConnectType";
            this.gbConnectType.Size = new System.Drawing.Size(433, 88);
            this.gbConnectType.TabIndex = 18;
            this.gbConnectType.TabStop = false;
            this.gbConnectType.Text = "Connection Method";
            // 
            // rdbTcpIp
            // 
            this.rdbTcpIp.AutoSize = true;
            this.rdbTcpIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbTcpIp.Location = new System.Drawing.Point(213, 42);
            this.rdbTcpIp.Name = "rdbTcpIp";
            this.rdbTcpIp.Size = new System.Drawing.Size(86, 28);
            this.rdbTcpIp.TabIndex = 1;
            this.rdbTcpIp.TabStop = true;
            this.rdbTcpIp.Text = "TCP/IP";
            this.rdbTcpIp.UseVisualStyleBackColor = true;
            this.rdbTcpIp.CheckedChanged += new System.EventHandler(this.rdbTcpIp_CheckedChanged);
            // 
            // rdbRS232
            // 
            this.rdbRS232.AutoSize = true;
            this.rdbRS232.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rdbRS232.Location = new System.Drawing.Point(86, 42);
            this.rdbRS232.Name = "rdbRS232";
            this.rdbRS232.Size = new System.Drawing.Size(83, 28);
            this.rdbRS232.TabIndex = 0;
            this.rdbRS232.TabStop = true;
            this.rdbRS232.Text = "RS232";
            this.rdbRS232.UseVisualStyleBackColor = true;
            this.rdbRS232.CheckedChanged += new System.EventHandler(this.rdbRS232_CheckedChanged);
            // 
            // Rs323Panel
            // 
            this.Rs323Panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Rs323Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rs323Panel.Controls.Add(this.groupBox1);
            this.Rs323Panel.Controls.Add(this.panel13);
            this.Rs323Panel.Location = new System.Drawing.Point(10, 108);
            this.Rs323Panel.Name = "Rs323Panel";
            this.Rs323Panel.Size = new System.Drawing.Size(472, 168);
            this.Rs323Panel.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(154, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232 Port Settings";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buad Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "COM Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.ItemHeight = 23;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(98, 67);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(168, 29);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // cmbPortName
            // 
            this.cmbPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.ItemHeight = 23;
            this.cmbPortName.Location = new System.Drawing.Point(98, 29);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(168, 29);
            this.cmbPortName.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel13.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.btnRefresh);
            this.panel13.Controls.Add(this.btnConnect);
            this.panel13.Controls.Add(this.btndisconnect);
            this.panel13.HorizontalScrollbarBarColor = true;
            this.panel13.HorizontalScrollbarHighlightOnWheel = false;
            this.panel13.HorizontalScrollbarSize = 10;
            this.panel13.Location = new System.Drawing.Point(14, 17);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(132, 139);
            this.panel13.TabIndex = 17;
            this.panel13.VerticalScrollbarBarColor = true;
            this.panel13.VerticalScrollbarHighlightOnWheel = false;
            this.panel13.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 31);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 48);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 35);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // btndisconnect
            // 
            this.btndisconnect.Location = new System.Drawing.Point(9, 93);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(114, 36);
            this.btndisconnect.TabIndex = 14;
            this.btndisconnect.Text = "Disconnect";
            this.btndisconnect.Click += new System.EventHandler(this.btndisconnect_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(10, 466);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(870, 118);
            this.listBox1.TabIndex = 19;
            // 
            // gbAntenna
            // 
            this.gbAntenna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gbAntenna.Controls.Add(this.cbAnt4);
            this.gbAntenna.Controls.Add(this.cbAnt2);
            this.gbAntenna.Controls.Add(this.cbAnt3);
            this.gbAntenna.Controls.Add(this.cbAnt1);
            this.gbAntenna.Controls.Add(this.label13);
            this.gbAntenna.Controls.Add(this.label14);
            this.gbAntenna.Controls.Add(this.label23);
            this.gbAntenna.Controls.Add(this.label24);
            this.gbAntenna.ForeColor = System.Drawing.Color.Black;
            this.gbAntenna.Location = new System.Drawing.Point(824, 484);
            this.gbAntenna.Margin = new System.Windows.Forms.Padding(2);
            this.gbAntenna.Name = "gbAntenna";
            this.gbAntenna.Padding = new System.Windows.Forms.Padding(2);
            this.gbAntenna.Size = new System.Drawing.Size(10, 21);
            this.gbAntenna.TabIndex = 23;
            this.gbAntenna.TabStop = false;
            this.gbAntenna.Text = "Antenna Selection";
            this.gbAntenna.Visible = false;
            // 
            // cbAnt4
            // 
            this.cbAnt4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbAnt4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAnt4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbAnt4.ForeColor = System.Drawing.Color.Black;
            this.cbAnt4.Location = new System.Drawing.Point(193, 53);
            this.cbAnt4.Margin = new System.Windows.Forms.Padding(2);
            this.cbAnt4.Name = "cbAnt4";
            this.cbAnt4.Size = new System.Drawing.Size(22, 23);
            this.cbAnt4.TabIndex = 2;
            this.cbAnt4.UseVisualStyleBackColor = false;
            this.cbAnt4.Visible = false;
            this.cbAnt4.CheckedChanged += new System.EventHandler(this.cbAnt4_CheckedChanged);
            // 
            // cbAnt2
            // 
            this.cbAnt2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbAnt2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAnt2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbAnt2.ForeColor = System.Drawing.Color.Black;
            this.cbAnt2.Location = new System.Drawing.Point(84, 52);
            this.cbAnt2.Margin = new System.Windows.Forms.Padding(2);
            this.cbAnt2.Name = "cbAnt2";
            this.cbAnt2.Size = new System.Drawing.Size(22, 24);
            this.cbAnt2.TabIndex = 2;
            this.cbAnt2.UseVisualStyleBackColor = false;
            this.cbAnt2.Visible = false;
            this.cbAnt2.CheckedChanged += new System.EventHandler(this.cbAnt2_CheckedChanged);
            // 
            // cbAnt3
            // 
            this.cbAnt3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbAnt3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAnt3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbAnt3.ForeColor = System.Drawing.Color.Black;
            this.cbAnt3.Location = new System.Drawing.Point(193, 27);
            this.cbAnt3.Margin = new System.Windows.Forms.Padding(2);
            this.cbAnt3.Name = "cbAnt3";
            this.cbAnt3.Size = new System.Drawing.Size(23, 24);
            this.cbAnt3.TabIndex = 2;
            this.cbAnt3.UseVisualStyleBackColor = false;
            this.cbAnt3.Visible = false;
            this.cbAnt3.CheckedChanged += new System.EventHandler(this.cbAnt3_CheckedChanged);
            // 
            // cbAnt1
            // 
            this.cbAnt1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbAnt1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAnt1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbAnt1.ForeColor = System.Drawing.Color.Black;
            this.cbAnt1.Location = new System.Drawing.Point(83, 27);
            this.cbAnt1.Margin = new System.Windows.Forms.Padding(2);
            this.cbAnt1.Name = "cbAnt1";
            this.cbAnt1.Size = new System.Drawing.Size(23, 24);
            this.cbAnt1.TabIndex = 2;
            this.cbAnt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAnt1.UseVisualStyleBackColor = false;
            this.cbAnt1.Visible = false;
            this.cbAnt1.CheckedChanged += new System.EventHandler(this.cbAnt1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(83, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Antenna 1";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(193, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Antenna 3";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(83, 52);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(108, 24);
            this.label23.TabIndex = 6;
            this.label23.Text = "Antenna 2";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(193, 52);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 24);
            this.label24.TabIndex = 7;
            this.label24.Text = "Antenna 4";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.group.Controls.Add(this.gbSysFreq);
            this.group.Controls.Add(this.gbUserFreq);
            this.group.Controls.Add(this.cbUserFreq);
            this.group.Controls.Add(this.label20);
            this.group.ForeColor = System.Drawing.Color.Black;
            this.group.Location = new System.Drawing.Point(487, 5);
            this.group.Margin = new System.Windows.Forms.Padding(2);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(2);
            this.group.Size = new System.Drawing.Size(392, 399);
            this.group.TabIndex = 25;
            this.group.TabStop = false;
            this.group.Text = "RF Output Setup";
            // 
            // gbSysFreq
            // 
            this.gbSysFreq.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbSysFreq.Controls.Add(this.label21);
            this.gbSysFreq.Controls.Add(this.label16);
            this.gbSysFreq.Controls.Add(this.cmbFrequencyStart);
            this.gbSysFreq.Controls.Add(this.rbCHN);
            this.gbSysFreq.Controls.Add(this.rbETSI);
            this.gbSysFreq.Controls.Add(this.rbFCC);
            this.gbSysFreq.Controls.Add(this.cmbFrequencyEnd);
            this.gbSysFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbSysFreq.ForeColor = System.Drawing.Color.Black;
            this.gbSysFreq.Location = new System.Drawing.Point(35, 28);
            this.gbSysFreq.Margin = new System.Windows.Forms.Padding(2);
            this.gbSysFreq.Name = "gbSysFreq";
            this.gbSysFreq.Padding = new System.Windows.Forms.Padding(2);
            this.gbSysFreq.Size = new System.Drawing.Size(312, 143);
            this.gbSysFreq.TabIndex = 0;
            this.gbSysFreq.TabStop = false;
            this.gbSysFreq.Text = "Predefined Frequency";
            // 
            // label21
            // 
            this.label21.CustomBackground = true;
            this.label21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label21.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label21.Location = new System.Drawing.Point(18, 62);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 24);
            this.label21.Style = MetroFramework.MetroColorStyle.Silver;
            this.label21.TabIndex = 14;
            this.label21.Text = "Start Freq (MHz)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label16
            // 
            this.label16.CustomBackground = true;
            this.label16.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label16.Location = new System.Drawing.Point(166, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "End Freq (MHz)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFrequencyStart
            // 
            this.cmbFrequencyStart.FormattingEnabled = true;
            this.cmbFrequencyStart.ItemHeight = 23;
            this.cmbFrequencyStart.Location = new System.Drawing.Point(18, 93);
            this.cmbFrequencyStart.Name = "cmbFrequencyStart";
            this.cmbFrequencyStart.Size = new System.Drawing.Size(132, 29);
            this.cmbFrequencyStart.TabIndex = 13;
            // 
            // rbCHN
            // 
            this.rbCHN.AutoSize = true;
            this.rbCHN.ForeColor = System.Drawing.Color.Black;
            this.rbCHN.Location = new System.Drawing.Point(229, 32);
            this.rbCHN.Margin = new System.Windows.Forms.Padding(2);
            this.rbCHN.Name = "rbCHN";
            this.rbCHN.Size = new System.Drawing.Size(69, 28);
            this.rbCHN.TabIndex = 0;
            this.rbCHN.TabStop = true;
            this.rbCHN.Text = "CHN";
            this.rbCHN.UseVisualStyleBackColor = true;
            this.rbCHN.CheckedChanged += new System.EventHandler(this.rbCHN_CheckedChanged);
            // 
            // rbETSI
            // 
            this.rbETSI.AutoSize = true;
            this.rbETSI.ForeColor = System.Drawing.Color.Black;
            this.rbETSI.Location = new System.Drawing.Point(118, 32);
            this.rbETSI.Margin = new System.Windows.Forms.Padding(2);
            this.rbETSI.Name = "rbETSI";
            this.rbETSI.Size = new System.Drawing.Size(69, 28);
            this.rbETSI.TabIndex = 0;
            this.rbETSI.TabStop = true;
            this.rbETSI.Text = "ETSI";
            this.rbETSI.UseVisualStyleBackColor = true;
            this.rbETSI.CheckedChanged += new System.EventHandler(this.rbETSI_CheckedChanged);
            // 
            // rbFCC
            // 
            this.rbFCC.AutoSize = true;
            this.rbFCC.ForeColor = System.Drawing.Color.Black;
            this.rbFCC.Location = new System.Drawing.Point(13, 32);
            this.rbFCC.Margin = new System.Windows.Forms.Padding(2);
            this.rbFCC.Name = "rbFCC";
            this.rbFCC.Size = new System.Drawing.Size(66, 28);
            this.rbFCC.TabIndex = 0;
            this.rbFCC.TabStop = true;
            this.rbFCC.Text = "FCC";
            this.rbFCC.UseVisualStyleBackColor = true;
            this.rbFCC.CheckedChanged += new System.EventHandler(this.rbFCC_CheckedChanged);
            // 
            // cmbFrequencyEnd
            // 
            this.cmbFrequencyEnd.FormattingEnabled = true;
            this.cmbFrequencyEnd.ItemHeight = 23;
            this.cmbFrequencyEnd.Location = new System.Drawing.Point(166, 93);
            this.cmbFrequencyEnd.Name = "cmbFrequencyEnd";
            this.cmbFrequencyEnd.Size = new System.Drawing.Size(131, 29);
            this.cmbFrequencyEnd.TabIndex = 13;
            // 
            // gbUserFreq
            // 
            this.gbUserFreq.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbUserFreq.Controls.Add(this.label22);
            this.gbUserFreq.Controls.Add(this.label17);
            this.gbUserFreq.Controls.Add(this.txtQuantity);
            this.gbUserFreq.Controls.Add(this.txtFreqSpace);
            this.gbUserFreq.Controls.Add(this.txtStartFreq);
            this.gbUserFreq.Controls.Add(this.label15);
            this.gbUserFreq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbUserFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbUserFreq.ForeColor = System.Drawing.Color.Black;
            this.gbUserFreq.Location = new System.Drawing.Point(35, 246);
            this.gbUserFreq.Margin = new System.Windows.Forms.Padding(2);
            this.gbUserFreq.Name = "gbUserFreq";
            this.gbUserFreq.Padding = new System.Windows.Forms.Padding(2);
            this.gbUserFreq.Size = new System.Drawing.Size(312, 130);
            this.gbUserFreq.TabIndex = 1;
            this.gbUserFreq.TabStop = false;
            this.gbUserFreq.Text = "User Defined Frequency";
            // 
            // label22
            // 
            this.label22.CustomBackground = true;
            this.label22.Location = new System.Drawing.Point(35, 94);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(148, 28);
            this.label22.TabIndex = 3;
            this.label22.Text = "Quantity ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.CustomBackground = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(35, 62);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 28);
            this.label17.TabIndex = 2;
            this.label17.Text = "Freq Space (*10kHz)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(183, 93);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(102, 29);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtFreqSpace
            // 
            this.txtFreqSpace.Location = new System.Drawing.Point(183, 62);
            this.txtFreqSpace.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreqSpace.Name = "txtFreqSpace";
            this.txtFreqSpace.Size = new System.Drawing.Size(102, 29);
            this.txtFreqSpace.TabIndex = 1;
            // 
            // txtStartFreq
            // 
            this.txtStartFreq.Location = new System.Drawing.Point(183, 29);
            this.txtStartFreq.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartFreq.Name = "txtStartFreq";
            this.txtStartFreq.Size = new System.Drawing.Size(102, 29);
            this.txtStartFreq.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.CustomBackground = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(35, 29);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "Start Freq (kHz)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbUserFreq
            // 
            this.cbUserFreq.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbUserFreq.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbUserFreq.CustomBackground = true;
            this.cbUserFreq.Location = new System.Drawing.Point(35, 202);
            this.cbUserFreq.Margin = new System.Windows.Forms.Padding(2);
            this.cbUserFreq.Name = "cbUserFreq";
            this.cbUserFreq.Size = new System.Drawing.Size(25, 27);
            this.cbUserFreq.TabIndex = 2;
            this.cbUserFreq.UseVisualStyleBackColor = false;
            this.cbUserFreq.CheckedChanged += new System.EventHandler(this.cbUserFreq_CheckedChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label20.CustomBackground = true;
            this.label20.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label20.Location = new System.Drawing.Point(47, 201);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 27);
            this.label20.TabIndex = 3;
            this.label20.Text = "Manual Frequency";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbRFPower
            // 
            this.gbRFPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.gbRFPower.Controls.Add(this.comboPower);
            this.gbRFPower.Controls.Add(this.label11);
            this.gbRFPower.ForeColor = System.Drawing.Color.Black;
            this.gbRFPower.Location = new System.Drawing.Point(810, 492);
            this.gbRFPower.Margin = new System.Windows.Forms.Padding(2);
            this.gbRFPower.Name = "gbRFPower";
            this.gbRFPower.Padding = new System.Windows.Forms.Padding(2);
            this.gbRFPower.Size = new System.Drawing.Size(10, 20);
            this.gbRFPower.TabIndex = 24;
            this.gbRFPower.TabStop = false;
            this.gbRFPower.Text = "RF Output Power";
            this.gbRFPower.Visible = false;
            // 
            // comboPower
            // 
            this.comboPower.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboPower.FormattingEnabled = true;
            this.comboPower.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33"});
            this.comboPower.Location = new System.Drawing.Point(244, 30);
            this.comboPower.Margin = new System.Windows.Forms.Padding(2);
            this.comboPower.Name = "comboPower";
            this.comboPower.Size = new System.Drawing.Size(103, 24);
            this.comboPower.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(44, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Select Output Power (dBm)";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel17.Controls.Add(this.btnReset);
            this.panel17.Controls.Add(this.btSetConfig);
            this.panel17.CustomBackground = true;
            this.panel17.HorizontalScrollbarBarColor = true;
            this.panel17.HorizontalScrollbarHighlightOnWheel = false;
            this.panel17.HorizontalScrollbarSize = 10;
            this.panel17.Location = new System.Drawing.Point(488, 410);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(391, 50);
            this.panel17.TabIndex = 20;
            this.panel17.VerticalScrollbarBarColor = true;
            this.panel17.VerticalScrollbarHighlightOnWheel = false;
            this.panel17.VerticalScrollbarSize = 10;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Enabled = false;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(225, 6);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 38);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btSetConfig
            // 
            this.btSetConfig.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSetConfig.Enabled = false;
            this.btSetConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btSetConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSetConfig.ForeColor = System.Drawing.Color.Black;
            this.btSetConfig.Location = new System.Drawing.Point(46, 7);
            this.btSetConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btSetConfig.Name = "btSetConfig";
            this.btSetConfig.Size = new System.Drawing.Size(121, 37);
            this.btSetConfig.TabIndex = 26;
            this.btSetConfig.Text = "Confirm ";
            this.btSetConfig.UseVisualStyleBackColor = false;
            this.btSetConfig.Click += new System.EventHandler(this.btSetConfig_Click);
            // 
            // Tcppanel
            // 
            this.Tcppanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tcppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tcppanel.Controls.Add(this.groupBox2);
            this.Tcppanel.Controls.Add(this.panel14);
            this.Tcppanel.Controls.Add(this.panel15);
            this.Tcppanel.Location = new System.Drawing.Point(10, 285);
            this.Tcppanel.Name = "Tcppanel";
            this.Tcppanel.Size = new System.Drawing.Size(472, 172);
            this.Tcppanel.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.PortBox);
            this.groupBox2.Controls.Add(this.IPBOX);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(152, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 134);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP Port Settings";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(67, 74);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(209, 28);
            this.PortBox.TabIndex = 8;
            // 
            // IPBOX
            // 
            this.IPBOX.Location = new System.Drawing.Point(67, 37);
            this.IPBOX.Name = "IPBOX";
            this.IPBOX.Size = new System.Drawing.Size(209, 28);
            this.IPBOX.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "IP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel14.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.StopTCp);
            this.panel14.Controls.Add(this.StartTcp);
            this.panel14.HorizontalScrollbarBarColor = true;
            this.panel14.HorizontalScrollbarHighlightOnWheel = false;
            this.panel14.HorizontalScrollbarSize = 10;
            this.panel14.Location = new System.Drawing.Point(14, 18);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(132, 134);
            this.panel14.TabIndex = 18;
            this.panel14.VerticalScrollbarBarColor = true;
            this.panel14.VerticalScrollbarHighlightOnWheel = false;
            this.panel14.VerticalScrollbarSize = 10;
            // 
            // StopTCp
            // 
            this.StopTCp.Location = new System.Drawing.Point(9, 70);
            this.StopTCp.Name = "StopTCp";
            this.StopTCp.Size = new System.Drawing.Size(114, 40);
            this.StopTCp.TabIndex = 14;
            this.StopTCp.Text = "Stop";
            this.StopTCp.Click += new System.EventHandler(this.StopTCp_Click);
            // 
            // StartTcp
            // 
            this.StartTcp.Location = new System.Drawing.Point(9, 24);
            this.StartTcp.Name = "StartTcp";
            this.StartTcp.Size = new System.Drawing.Size(114, 38);
            this.StartTcp.TabIndex = 13;
            this.StartTcp.Text = "Start";
            this.StartTcp.Click += new System.EventHandler(this.StartTcp_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel15.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panel15.HorizontalScrollbarBarColor = true;
            this.panel15.HorizontalScrollbarHighlightOnWheel = false;
            this.panel15.HorizontalScrollbarSize = 10;
            this.panel15.Location = new System.Drawing.Point(152, 18);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(308, 134);
            this.panel15.TabIndex = 19;
            this.panel15.VerticalScrollbarBarColor = true;
            this.panel15.VerticalScrollbarHighlightOnWheel = false;
            this.panel15.VerticalScrollbarSize = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.HorizontalScrollbarBarColor = true;
            this.panel3.HorizontalScrollbarHighlightOnWheel = false;
            this.panel3.HorizontalScrollbarSize = 10;
            this.panel3.Location = new System.Drawing.Point(4, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 633);
            this.panel3.TabIndex = 15;
            this.panel3.VerticalScrollbarBarColor = true;
            this.panel3.VerticalScrollbarHighlightOnWheel = false;
            this.panel3.VerticalScrollbarSize = 10;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.button1);
            this.panel10.Controls.Add(this.updownlaps);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.Export);
            this.panel10.HorizontalScrollbarBarColor = true;
            this.panel10.HorizontalScrollbarHighlightOnWheel = false;
            this.panel10.HorizontalScrollbarSize = 10;
            this.panel10.Location = new System.Drawing.Point(0, 390);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(186, 234);
            this.panel10.TabIndex = 16;
            this.panel10.VerticalScrollbarBarColor = true;
            this.panel10.VerticalScrollbarHighlightOnWheel = false;
            this.panel10.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "SCOREBOARD";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(16, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 38);
            this.label10.Style = MetroFramework.MetroColorStyle.Blue;
            this.label10.TabIndex = 10;
            this.label10.Text = "N. LAPS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "RACE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel8.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.racebeginbutton);
            this.panel8.Controls.Add(this.Reset);
            this.panel8.Controls.Add(this.StartReading);
            this.panel8.HorizontalScrollbarBarColor = true;
            this.panel8.HorizontalScrollbarHighlightOnWheel = false;
            this.panel8.HorizontalScrollbarSize = 10;
            this.panel8.Location = new System.Drawing.Point(0, 8);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(185, 133);
            this.panel8.TabIndex = 14;
            this.panel8.VerticalScrollbarBarColor = true;
            this.panel8.VerticalScrollbarHighlightOnWheel = false;
            this.panel8.VerticalScrollbarSize = 10;
            // 
            // racebeginbutton
            // 
            this.racebeginbutton.Location = new System.Drawing.Point(27, 22);
            this.racebeginbutton.Name = "racebeginbutton";
            this.racebeginbutton.Size = new System.Drawing.Size(124, 25);
            this.racebeginbutton.TabIndex = 15;
            this.racebeginbutton.Text = "Start Race";
            this.racebeginbutton.Click += new System.EventHandler(this.racebeginbutton_Click);
            // 
            // StartReading
            // 
            this.StartReading.Location = new System.Drawing.Point(27, 85);
            this.StartReading.Name = "StartReading";
            this.StartReading.Size = new System.Drawing.Size(124, 30);
            this.StartReading.TabIndex = 14;
            this.StartReading.Text = "Start Reader";
            this.StartReading.Click += new System.EventHandler(this.StartReading_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.NRUNNERS);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.LoadRacers);
            this.panel9.Controls.Add(this.MANUAL);
            this.panel9.Controls.Add(this.LOAD);
            this.panel9.Location = new System.Drawing.Point(3, 152);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(186, 227);
            this.panel9.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(18, 52);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 38);
            this.label12.Style = MetroFramework.MetroColorStyle.Orange;
            this.label12.TabIndex = 13;
            this.label12.Text = "N. RUNS.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // NRUNNERS
            // 
            this.NRUNNERS.BackColor = System.Drawing.Color.AliceBlue;
            this.NRUNNERS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NRUNNERS.Cursor = System.Windows.Forms.Cursors.Default;
            this.NRUNNERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NRUNNERS.Location = new System.Drawing.Point(99, 52);
            this.NRUNNERS.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NRUNNERS.Name = "NRUNNERS";
            this.NRUNNERS.ReadOnly = true;
            this.NRUNNERS.Size = new System.Drawing.Size(70, 38);
            this.NRUNNERS.TabIndex = 12;
            this.NRUNNERS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NRUNNERS.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, -1);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "PARTICIPANTS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1247, 642);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.updownracers);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "        ";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.maintable.ResumeLayout(false);
            this.maintable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownracers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownlaps)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Mainwindow.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Communication.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbConnectType.ResumeLayout(false);
            this.gbConnectType.PerformLayout();
            this.Rs323Panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.gbAntenna.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.gbSysFreq.ResumeLayout(false);
            this.gbSysFreq.PerformLayout();
            this.gbUserFreq.ResumeLayout(false);
            this.gbRFPower.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.Tcppanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NRUNNERS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel maintable;
        private System.Windows.Forms.NumericUpDown updownlaps;
        private System.Windows.Forms.Timer Finish;
        private MetroFramework.Controls.MetroLabel Timerlabel;
        private MetroFramework.Controls.MetroButton Export;
        private MetroFramework.Controls.MetroButton Reset;
        private MetroFramework.Controls.MetroButton MANUAL;
        private MetroFramework.Controls.MetroButton LoadRacers;
        private MetroFramework.Controls.MetroButton LOAD;
        private System.Windows.Forms.NumericUpDown updownracers;
        private System.Windows.Forms.Timer Updatemain;
        private System.Windows.Forms.Timer updatefinish;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage Communication;
        private MetroFramework.Controls.MetroTabPage Mainwindow;
        private System.Windows.Forms.Panel Rs323Panel;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cmbBaudRate;
        private MetroFramework.Controls.MetroComboBox cmbPortName;
        private MetroFramework.Controls.MetroButton btndisconnect;
        private System.Windows.Forms.Panel Tcppanel;
        private MetroFramework.Controls.MetroButton StopTCp;
        private MetroFramework.Controls.MetroButton StartTcp;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox PortBox;
        private MetroFramework.Controls.MetroTextBox IPBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbConnectType;
        private System.Windows.Forms.RadioButton rdbTcpIp;
        private System.Windows.Forms.RadioButton rdbRS232;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroPanel panel4;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel Lapsleft;
        private MetroFramework.Controls.MetroPanel panel3;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroPanel panel8;
        private System.Windows.Forms.Panel panel9;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroPanel panel10;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroLabel label12;
        private System.Windows.Forms.NumericUpDown NRUNNERS;
        private MetroFramework.Controls.MetroButton StartReading;
        private MetroFramework.Controls.MetroPanel panel11;
        private System.Windows.Forms.Button btSetConfig;
        private System.Windows.Forms.GroupBox group;
        private MetroFramework.Controls.MetroCheckBox cbUserFreq;
        private System.Windows.Forms.GroupBox gbUserFreq;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroTextBox txtFreqSpace;
        private MetroFramework.Controls.MetroTextBox txtStartFreq;
        private MetroFramework.Controls.MetroLabel label15;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbRFPower;
        private System.Windows.Forms.ComboBox comboPower;
        private MetroFramework.Controls.MetroLabel label11;
        private System.Windows.Forms.GroupBox gbAntenna;
        private System.Windows.Forms.CheckBox cbAnt4;
        private System.Windows.Forms.CheckBox cbAnt2;
        private System.Windows.Forms.CheckBox cbAnt3;
        private System.Windows.Forms.CheckBox cbAnt1;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label19;
        private MetroFramework.Controls.MetroLabel label18;
        private MetroFramework.Controls.MetroLabel label20;
        private MetroFramework.Controls.MetroLabel label22;
        private MetroFramework.Controls.MetroLabel label17;
        private MetroFramework.Controls.MetroLabel label13;
        private MetroFramework.Controls.MetroLabel label14;
        private MetroFramework.Controls.MetroLabel label23;
        private MetroFramework.Controls.MetroLabel label24;
        private MetroFramework.Controls.MetroPanel panel17;
        private System.Windows.Forms.GroupBox gbSysFreq;
        private MetroFramework.Controls.MetroLabel label21;
        private MetroFramework.Controls.MetroLabel label16;
        private MetroFramework.Controls.MetroComboBox cmbFrequencyStart;
        private System.Windows.Forms.RadioButton rbCHN;
        private System.Windows.Forms.RadioButton rbETSI;
        private System.Windows.Forms.RadioButton rbFCC;
        private MetroFramework.Controls.MetroComboBox cmbFrequencyEnd;
        private MetroFramework.Controls.MetroButton racebeginbutton;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroPanel panel13;
        private MetroFramework.Controls.MetroPanel panel14;
        private MetroFramework.Controls.MetroPanel panel15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

