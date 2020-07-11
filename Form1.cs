using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using EPPlus;
using System.IO.Ports;
using OfficeOpenXml;
using SimpleTCP;
using System.Reflection;
using System.Net;
using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace Lap_Timer
{
    public partial class Form1 : Form
    {
        public Reader.ReaderMethod reader;
        public ReaderSetting m_curSetting = new ReaderSetting();
        public InventoryBuffer m_curInventoryBuffer = new InventoryBuffer();
        public OperateTagBuffer m_curOperateTagBuffer = new OperateTagBuffer();
        /*---------- Reader Flags ----------*/
        public bool m_bDisplayLog = false;        // Display Log
        public bool m_connected = false;          // Connected to reader or not
        public byte[] m_btAryData = new byte[10]; // Command parameter byte arrays                     
        public int m_nSwitchTotal = 0;            // fast switch counts
        public int m_nSwitchTime = 0;             // Fast switch counts
        public int m_nTotal = 0;                  // 实时盘存次数
        public int m_nRealRate = 20;              // 列表更新频率

        ExcelWorksheet ws;
        ExcelPackage excelReport;
        FileInfo file;
        public  Form2 Registeration = new Form2();
        Form3 loadids = new Form3();
        Form4 display = new Form4();
        int[] Totaltime;
        float timer;
        float ftimer;
        int oldlap = 0;
        int oldracers = 0;
        int[] racermap;
        string tagholder;
        int racer=1;
        int[] lapinterval;
        int countdown=0;
        bool register;
        bool first_round = true;
        int[] maxrank;
        int[] order;
        bool flagAnt1 = false;
        bool flagAnt2 = false;
        bool flagAnt3 = false;
        bool flagAnt4 = false;
        byte power = 0;
        int updateqf =3;
        int updateq =0;
        int finishcheck =0;
        int[] finishchecker;
        bool finished =false;
        int[] rankmemory;
        int maxindex2;
        int maxindex; System.Threading.Timer maintimer;
        System.Diagnostics.Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();
        string directory, filepath, excelpath;

        


        public Form1()
        {
            InitializeComponent();
            rankmemory =new int[ 999];
            finishchecker = new int[999];
            Registeration.Main = this;
            maintimer = new System.Threading.Timer( timer_Elapsed, null, System.Threading.Timeout.Infinite, 1);
            Rs323Panel.Enabled = false;
            Tcppanel.Enabled = false;
            updownlaps.Value = 2;
            updownlaps.Value = 1;
            updatePorts();
            initReader();
        }

        [STAThread] static void Main(string[] args) { Application.Run(new Form1()); }

        public void timer_Elapsed(object data)
        {

            countdown++;
            if (countdown == 1)
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.count_3);
                simpleSound.Play();

            }
            if (countdown == 100)
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.count_2);
                simpleSound.Play();

            }
            if (countdown == 200)
            {

                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.count_1);
                simpleSound.Play();

            }
            if (countdown == 250)
            {

                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Air_Horn);
                simpleSound.Play();
              //  myStopWatch.Restart();
            }
            else
            {
               
                timer = (int)myStopWatch.Elapsed.TotalMilliseconds / 10;
                ftimer = (int)myStopWatch.Elapsed.TotalMilliseconds / 10;

                this.Invoke((MethodInvoker)delegate ()
                {
                    Timerlabel.Text = ((TimeSpan.FromMilliseconds(timer * 10))).ToString(@"mm\:ss\:ff");
                    display.Timer.Text = ((TimeSpan.FromMilliseconds(timer * 10))).ToString(@"mm\:ss\:ff");
                });

            }
        }


        private SerialPort ComPort = new SerialPort();
        

     

       

        private void WriteCell(ExcelWorksheet ws, int y1, int x1, int y2, int x2, string value)
        {
            using (ExcelRange cell = ws.Cells[y1, x1, y2, x2])
            {
                cell.Merge = true;
                cell.Value = value;
                cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
                cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Medium;
            }
        }
        void writereport()
        {
            
            ExcelWorksheet ws = excelReport.Workbook.Worksheets["Sheet"+ (excelReport.Workbook.Worksheets.ToArray().Length - 1).ToString()];

            
            for (int y = 0; y < maintable.RowCount +updownlaps.Value ; y++)
            {

                for (int x = 0; x <= updownlaps.Value ; x++)
                {
                    Label all = new Label();

                    Control c = maintable.GetControlFromPosition(y, x);
                    try { all = (Label)c; } catch { }
                    try
                    {
                        WriteCell(ws, x + 1, y + 1, x + 1, y + 1, all.Text);
                    }
                    catch { }


                }


            }


            WriteCell(ws, 1, 1 + maintable.ColumnCount, 1, 1 + maintable.ColumnCount, "ID");
            WriteCell(ws, 1, 2 + maintable.ColumnCount, 1, 2 + maintable.ColumnCount, "Date Of Birth");
            WriteCell(ws, 1, 3 + maintable.ColumnCount, 1, 3 + maintable.ColumnCount, "Gender");
            WriteCell(ws, 1, 4 + maintable.ColumnCount, 1, 4 + maintable.ColumnCount, "Height");
            WriteCell(ws, 1, 5 + maintable.ColumnCount, 1, 5 + maintable.ColumnCount, "Weight");
            WriteCell(ws, 1, 6 + maintable.ColumnCount, 1, 6 + maintable.ColumnCount, "Tag");
            WriteCell(ws, 1, 7 + maintable.ColumnCount, 1, 7 + maintable.ColumnCount, "Picture");


            for (int y = 1; y < maintable.RowCount - 1; y++)
            {

                if (register)
                {
                    WriteCell(ws, y + 1, 1 + maintable.ColumnCount, y + 1, 1 + maintable.ColumnCount, Registeration.id[y]);
                    WriteCell(ws, y + 1, 2 + maintable.ColumnCount, y + 1, 2 + maintable.ColumnCount, Registeration.ages[y]);
                    WriteCell(ws, y + 1, 3 + maintable.ColumnCount, y + 1, 3 + maintable.ColumnCount, Registeration.genders[y]);
                    WriteCell(ws, y + 1, 4 + maintable.ColumnCount, y + 1, 4 + maintable.ColumnCount, Registeration.heights[y]);
                    WriteCell(ws, y + 1, 5 + maintable.ColumnCount, y + 1, 5 + maintable.ColumnCount, Registeration.weights[y]);
                     WriteCell(ws, y + 1, 6 + maintable.ColumnCount, y + 1, 6 + maintable.ColumnCount, Registeration.tags[y]);
                    try
                    {
                        var pic = ws.Drawings.AddPicture(Registeration.id[y], Registeration.photopath[y]);
                        
                        pic.SetSize(1, 20);
                        ws.Row(y + 1).Height = 30;
                        ws.Column(7 + maintable.ColumnCount).Width = 8;
                        pic.From.Column = 6 + maintable.ColumnCount;
                        pic.From.Row = y;
                        pic.To.Column = 7 + maintable.ColumnCount;
                        pic.To.Row = y + 1;
                        
                    }
                    catch { }
                }
                else
                {
                    WriteCell(ws, y + 1, 1 + maintable.ColumnCount, y + 1, 1 + maintable.ColumnCount, loadids.idf1[y - 1]);
                    WriteCell(ws, y + 1, 2 + maintable.ColumnCount, y + 1, 2 + maintable.ColumnCount, loadids.agesf1[y - 1]);
                    WriteCell(ws, y + 1, 3 + maintable.ColumnCount, y + 1, 3 + maintable.ColumnCount, loadids.gendersf1[y - 1]);
                    WriteCell(ws, y + 1, 4 + maintable.ColumnCount, y + 1, 4 + maintable.ColumnCount, loadids.heightf1[y - 1]);
                    WriteCell(ws, y + 1, 5 + maintable.ColumnCount, y + 1, 5 + maintable.ColumnCount, loadids.weightsf1[y - 1]);
                     WriteCell(ws, y + 1, 6 + maintable.ColumnCount, y + 1, 6 + maintable.ColumnCount, loadids.tagsf1[y-1]);
                    try
                    {
                        var pic = ws.Drawings.AddPicture(loadids.idf1[y - 1], loadids.phtotpathf1[y - 1]);

                        pic.SetSize(1, 20);
                        ws.Row(y + 1).Height = 30;
                        ws.Column(7 + maintable.ColumnCount).Width = 8;
                        pic.From.Column = 6 + maintable.ColumnCount;
                        pic.From.Row = y;
                        pic.To.Column = 7 + maintable.ColumnCount;
                        pic.To.Row = y + 1;
                    }
                    catch { }

                }

            }


            excelReport.Save();



        }



        private void writeToExcel()
        {
            directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
            filepath = directory + "\\" + DateTime.Now.ToLongDateString();
            excelpath = filepath + @"\" + DateTime.Now.ToLongDateString() + ".xlsx";

            file = new FileInfo(excelpath);
            excelReport = new ExcelPackage(file);


            try
            {
                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Create folder");
            }


            try
            {
            
                ExcelWorksheet ws = excelReport.Workbook.Worksheets.Add(String.Format("Sheet{0}", excelReport.Workbook.Worksheets.ToArray().Length.ToString()));
                writereport();
                MessageBox.Show("Data Exported to Excel Successfully");
               

            }
           catch (Exception)
            {
         
               MessageBox.Show("Failed to export,if the Excel file is open please close and try again");
            }

        }

      

        private void racebeginbutton_Click(object sender, EventArgs e)
        {
            if (racebeginbutton.Text == "Start Race")
            {
                //Maintimer.Enabled = true;
              //  myStopWatch.Restart();
                  maintimer.Change(0, 1);
                // Finish.Enabled = true;
                display.Updategui.Enabled = true;
                
                    Updatemain.Enabled = true;
                    updatefinish.Enabled = true;
                racebeginbutton.Text = "End Race";
               
            }
            else 
            {
                racebeginbutton.Text = "Start Race";
                // Maintimer.Enabled = false;
                maintimer.Change(System.Threading.Timeout.Infinite, 1);
                myStopWatch.Stop();
                // Finish.Enabled = false;
                display.Updategui.Enabled = false;
                Updatemain.Enabled = false;
                updatefinish.Enabled = false;
                Updatemaingui(0);
                Updatefgui(0);

            }



        }

        private void Endracebutton_Click(object sender, EventArgs e)
        {
          
        }


        public void updownracers_ValueChanged(object sender, EventArgs e)
        {
            //updateColumns();
            updateRows();
            
           
        }

        private void updownlaps_ValueChanged(object sender, EventArgs e)
        {
        
            updateColumns();
            updateRows();
            Lapsleft.Text = racermap.Max().ToString() + " / " + updownlaps.Value.ToString();

        }




       private void updateColumns()
        {
            maintable.SuspendLayout();

            if (oldlap > updownlaps.Value)

            {

                for (int y = maintable.ColumnCount; y > 2; y--)
                {
                    try
                    {
                        Control c1 = maintable.GetControlFromPosition(y, 0);
                        maintable.Controls.Remove(c1);
                        c1.Dispose();
                    }
                    catch
                    {
                        Control c1 = maintable.GetControlFromPosition(y - 1, 0);
                        maintable.Controls.Remove(c1);
                        c1.Dispose();
                    }
                }

                maintable.ColumnCount = (int)updownlaps.Value + 3;
               
               
                for (int y = maintable.ColumnCount; y > 3; y--)
                {
                    Label Lap = new Label();
                    Lap.Name = "Lap";
                    Lap.Text = "Lap " + (y - 3).ToString();
                    Lap.Anchor = System.Windows.Forms.AnchorStyles.None;
                    Lap.BackColor = System.Drawing.SystemColors.WindowFrame;
                    Lap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
                    Lap.ForeColor = System.Drawing.SystemColors.Window;
                    Lap.Location = new System.Drawing.Point(311, 1);
                    Lap.Margin = new System.Windows.Forms.Padding(0);
                    Lap.MinimumSize = new System.Drawing.Size(294, 51);
                    Lap.Size = new System.Drawing.Size(240, 51);
                    Lap.TabIndex = 2;
                    Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    maintable.Controls.Add(Lap, y - 2, 0);
                }

                Label finish = new Label();
                finish.Name = "finish";
                finish.Text = "Finish";
                finish.Anchor = System.Windows.Forms.AnchorStyles.None;
                finish.BackColor = System.Drawing.SystemColors.WindowFrame;
                finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
                finish.ForeColor = System.Drawing.SystemColors.Window;
                finish.Location = new System.Drawing.Point(311, 1);
                finish.Margin = new System.Windows.Forms.Padding(0);
                finish.MinimumSize = new System.Drawing.Size(240, 51);
                finish.Size = new System.Drawing.Size(1076, 51);
                finish.TabIndex = 2;
                finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                maintable.Controls.Add(finish, maintable.ColumnCount - 1, 0);
                

            }






            if (updownlaps.Value > oldlap)
            {
                ColumnStyle temp = maintable.ColumnStyles[0];

                maintable.ColumnCount = (int)updownlaps.Value + 3;
               
                

                for (int x = maintable.ColumnCount; x >= 0; x--)
                    maintable.ColumnStyles.Add(new ColumnStyle(temp.SizeType, 240));

                for (int y = maintable.ColumnCount; y > 3; y--)
                {
                    try
                    {
                        Control c1 = maintable.GetControlFromPosition(y - 2, 0);
                        maintable.Controls.Remove(c1);
                        c1.Dispose();
                    }
                    catch
                    {
                        Control c1 = maintable.GetControlFromPosition(y - 1, 0);
                        maintable.Controls.Remove(c1);
                        try { c1.Dispose(); } catch { }
                    }
                }




                Label finish = new Label();
                finish.Name = "finish";
                finish.Text = "Finish";
                finish.Anchor = System.Windows.Forms.AnchorStyles.None;
                finish.BackColor = System.Drawing.SystemColors.WindowFrame;
                finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
                finish.ForeColor = System.Drawing.SystemColors.Window;
                finish.Location = new System.Drawing.Point(311, 1);
                finish.Margin = new System.Windows.Forms.Padding(0);
                finish.MinimumSize = new System.Drawing.Size(240, 51);
                finish.Size = new System.Drawing.Size(1076, 51);
                finish.TabIndex = 2;
                finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


                for (int y = maintable.ColumnCount; y > 3; y--)
                {
                    Label Lap = new Label();
                    Lap.Name = "Lap";
                    Lap.Text = "Lap " + (y - 3).ToString();
                    Lap.Anchor = System.Windows.Forms.AnchorStyles.None;
                    Lap.BackColor = System.Drawing.SystemColors.WindowFrame;
                    Lap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
                    Lap.ForeColor = System.Drawing.SystemColors.Window;
                    Lap.Location = new System.Drawing.Point(311, 1);
                    Lap.Margin = new System.Windows.Forms.Padding(0);
                    Lap.MinimumSize = new System.Drawing.Size(240, 51);
                    Lap.Size = new System.Drawing.Size(240, 51);
                    Lap.TabIndex = 2;
                    Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Lap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    maintable.Controls.Add(Lap, y - 2, 0);
                }
                maintable.Controls.Add(finish, maintable.ColumnCount - 1, 0);




            }
            maintable.ResumeLayout();
            oldlap = (int)updownlaps.Value;
        }

       private void updateRows()
        {

            maintable.SuspendLayout();
            if (oldracers > updownracers.Value)
            {
                for (int x = maintable.RowCount; x > 1; x--)
                {
                    Control c2 = maintable.GetControlFromPosition(1, x - 1);
                    maintable.Controls.Remove(c2);
                    try { c2.Dispose(); } catch { }
                    Control c3 = maintable.GetControlFromPosition(0, x - 1);
                    maintable.Controls.Remove(c3);
                    try { c3.Dispose(); } catch { }

                    for (int y = maintable.ColumnCount; y > 2; y--)
                    {


                        Control c1 = maintable.GetControlFromPosition(y - 1, x - 1);
                        maintable.Controls.Remove(c1);
                        try { c1.Dispose(); } catch { }

                    }

                }
                maintable.RowCount = (int)updownracers.Value + 2;
                racermap = new int[(int)updownracers.Value + 2];
                lapinterval = new int[(int)updownracers.Value + 2];
                for (int x = maintable.RowCount; x > 2; x--)
                {
                    Label rank = new Label();
                    rank.Name = "rank" + (x - 2).ToString();
                    rank.Text = "__";
                    rank.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    rank.Size = new Size(156, 62);

                    Label id = new Label();
                    id.Name = "id" + (x - 2).ToString();
                    if (register)
                    {
                        id.Text = Registeration.fnamesf1[x - 2] + " " + Registeration.lnamesf1[x - 2];
                    }
                    else
                    {
                        id.Text = loadids.namesf1[x - 2];
                    }
                    id.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    id.Size = new Size(152, 62);
                    id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    maintable.Controls.Add(id, 1, x - 2);
                    maintable.Controls.Add(rank, 0, x - 2);
                    for (int y = maintable.ColumnCount; y > 2; y--)
                    {


                        Label time = new Label();
                        time.Name = "time" + (y - 1).ToString() + (x - 2).ToString();
                        time.Text = "00:00:00";
                        time.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        time.Size = new Size(230, 51);
                        time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                        maintable.Controls.Add(time, y - 1, x - 2);

                    }

                }


            }

            if (updownracers.Value >= oldracers)
            {

                RowStyle temp = maintable.RowStyles[maintable.RowCount - 1];

                maintable.RowCount = (int)updownracers.Value + 2;
                racermap = new int[(int)updownracers.Value + 2];
                lapinterval = new int[(int)updownracers.Value + 2];
                for (int x = maintable.RowCount; x >= 0; x--)
                {
                    maintable.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));



                }
                for (int x = maintable.RowCount; x > 1; x--)
                {
                    Control c2 = maintable.GetControlFromPosition(1, x - 1);
                    maintable.Controls.Remove(c2);
                    try { c2.Dispose(); } catch { }
                    Control c3 = maintable.GetControlFromPosition(0, x - 1);
                    maintable.Controls.Remove(c3);
                    try { c3.Dispose(); } catch { }

                    for (int y = maintable.ColumnCount; y > 2; y--)
                    {


                        Control c1 = maintable.GetControlFromPosition(y - 1, x - 1);
                        maintable.Controls.Remove(c1);

                        try { c1.Dispose(); } catch { }

                    }

                }
                for (int x = maintable.RowCount; x > 2; x--)
                {
                    Label rank = new Label();
                    rank.Name = "rank" + (x - 2).ToString();
                    rank.Text = "__";
                  
                    rank.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    rank.Size = new Size(156, 62);

                     Label id = new Label();
                    id.Name = "id" + (x - 2).ToString();
                    if (register)
                    {
                        id.Text = Registeration.fnamesf1[x - 2] + " " + Registeration.lnamesf1[x - 2];
                    }
                    else
                    {
                        id.Text = loadids.namesf1[x - 2];
                    }
                    id.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    id.Size = new Size(152, 62);
                    id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    maintable.Controls.Add(id, 1, x - 2);
                    maintable.Controls.Add(rank, 0, x - 2);
                    for (int y = maintable.ColumnCount; y > 2; y--)
                    {


                        Label time = new Label();
                        time.Name = "time" + (y - 1).ToString() + (x - 2).ToString();
                        time.Text = "00:00:00";
                        time.Font = new Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        time.Size = new Size(230, 51);
                        time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                        maintable.Controls.Add(time, y - 1, x - 2);

                    }

                }


            }

            maintable.ResumeLayout();
            oldracers = (int)updownracers.Value;
        }

        private void Export_Click(object sender, EventArgs e)
        {  
            Updatemaingui(0);
            Updatefgui(0);
            writeToExcel();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            countdown = 0;
            updownracers.Value = 0;
            updownlaps.Value = 1;
            racebeginbutton.Text = "Start Race";
          //  Maintimer.Enabled = false;
            maintimer.Change(System.Threading.Timeout.Infinite, 1);
            Finish.Enabled = false;
            ftimer = 0;
            timer = 0;
            Timerlabel.Text = "00:00:00";
            Registeration.fnamesf1 = new string[999];
            Registeration.lnamesf1 = new string[999];
            loadids.namesf1 = new string[999];
            loadids.racersf1 = 0;
            Registeration.racersf1 = 0;
            finished = false;
            for(int x = 10; x > 0 ; x--)
            {
                display.tableLayoutPanel1.Controls["rank" + x.ToString()].Text = "--";
                display.tableLayoutPanel1.Controls["id" + x.ToString()].Text = "--";
                display.tableLayoutPanel1.Controls["lap" + x.ToString()].Text = "--";
                display.tableLayoutPanel1.Controls["current" + x.ToString()].Text = "--";
                display.tableLayoutPanel1.Controls["finish" + x.ToString()].Text = "--";

            }
            display.Timer.Text = "00:00:00";
            myStopWatch.Reset();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Registeration.Show();
            register = true;
        }

        private void LoadRacers_Click(object sender, EventArgs e)
        {
            if (register)
            {
                updownracers.Value = (int)Registeration.racersf1;
                NRUNNERS.Value= (int)Registeration.racersf1;
            }
            else
            {
                updownracers.Value = (int)loadids.racersf1;
                NRUNNERS.Value = (int)loadids.racersf1;
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            loadids.Show();
            register = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        
        private void Updatemaingui(int w)
        {
            if (w == 1)
            {
                maintable.SuspendLayout();
                if (racermap != null)
                {

                    for (int x = updateq; x <= updateq + 3; x++)
                    {
                        try
                        {

                            if (racermap[x] < maintable.ColumnCount - 3)
                            {
                                Label time = new Label();

                                Control[] c;

                                c = maintable.Controls.Find("time" + (racermap[x] + 2).ToString() + (x).ToString(), true);
                                if (c.Length > 0)
                                {

                                    time = (Label)c[0];
                                }
                                time.Text = ((TimeSpan.FromMilliseconds((timer - lapinterval[x]) * 10))).ToString(@"mm\:ss\:ff");
                                display.currents[rankmemory[x]] = ((TimeSpan.FromMilliseconds((timer - lapinterval[x]) * 10))).ToString(@"mm\:ss\:ff");
                            }
                            else
                            {
                                if (finished)
                                {
                                    Label time = new Label();

                                    Control[] c;

                                    c = maintable.Controls.Find("time" + (racermap[x] + 1).ToString() + (x).ToString(), true);
                                    if (c.Length > 0)
                                    {

                                        time = (Label)c[0];
                                    }
                                    display.currents[rankmemory[x]] = time.Text;

                                }
                            }

                        }
                        catch { }

                    }
                    if (updateq <= maintable.RowCount)
                        updateq += 3;
                    else
                        updateq = 0;
                }
                maintable.ResumeLayout();
            }
            else if (w == 0)
            {
                maintable.SuspendLayout();
                if (racermap != null)
                {

                    for (int x = 0; x < maintable.RowCount; x++)
                    {
                        try
                        {

                            if (racermap[x] < maintable.ColumnCount - 3)
                            {
                                Label time = new Label();

                                Control[] c;

                                c = maintable.Controls.Find("time" + (racermap[x] + 2).ToString() + (x).ToString(), true);
                                if (c.Length > 0)
                                {

                                    time = (Label)c[0];
                                }
                                time.Text = ((TimeSpan.FromMilliseconds((timer - lapinterval[x]) * 10))).ToString(@"mm\:ss\:ff");
                                display.currents[rankmemory[x]] = ((TimeSpan.FromMilliseconds((timer - lapinterval[x]) * 10))).ToString(@"mm\:ss\:ff");
                            }
                            else
                            {
                                if (finished)
                                {
                                    Label time = new Label();

                                    Control[] c;

                                    c = maintable.Controls.Find("time" + (racermap[x] + 1).ToString() + (x).ToString(), true);
                                    if (c.Length > 0)
                                    {

                                        time = (Label)c[0];
                                    }
                                    display.currents[rankmemory[x]] = time.Text;

                                }
                            }

                        }
                        catch { }

                    }

                    maintable.ResumeLayout();


                }
            }
        }
        private void Updatefgui(int l)
        {
            if (l == 1)
            {
                maintable.SuspendLayout();
                for (int x = updateqf; x > updateqf - 3; x--)
                {
                    try
                    {
                        if (racermap[x - 1] < updownlaps.Value)
                        {
                            Label finish = new Label();
                            Control[] c;
                            c = maintable.Controls.Find("time" + ((int)updownlaps.Value + 2).ToString() + (x - 1).ToString(), true);
                            if (c.Length > 0)
                            {
                                finish = (Label)c[0];
                            }

                            display.finishs[rankmemory[x - 1]] = ((TimeSpan.FromMilliseconds((ftimer) * 10))).ToString(@"mm\:ss\:ff");
                            finish.Text = ((TimeSpan.FromMilliseconds((ftimer) * 10))).ToString(@"mm\:ss\:ff");

                        }
                        else
                        {
                            if (!finishchecker.Contains(x - 1))
                            {
                                finishchecker[finishcheck] = x - 1;
                                finishcheck++;
                            }
                            if (finishcheck == updownracers.Value)
                            {
                                maintimer.Change(System.Threading.Timeout.Infinite, 1);
                                myStopWatch.Stop();
                                finished = true;
                                Label finish = new Label();
                                Control[] c;
                                c = maintable.Controls.Find("time" + ((int)updownlaps.Value + 2).ToString() + (x - 1).ToString(), true);
                                if (c.Length > 0)
                                {
                                    finish = (Label)c[0];
                                }
                                display.finishs[rankmemory[x - 1]] = finish.Text;


                            }

                        }
                    }
                    catch { }
                }
                if (updateqf < maintable.RowCount)
                    updateqf += 3;
                else
                    updateqf = 3;
                maintable.ResumeLayout();
            }
            else if (l == 0)
            {
                maintable.SuspendLayout();
                for (int x = maintable.RowCount; x > 0; x--)
                {
                    try
                    {
                        if (racermap[x - 1] < updownlaps.Value)
                        {
                            Label finish = new Label();
                            Control[] c;
                            c = maintable.Controls.Find("time" + ((int)updownlaps.Value + 2).ToString() + (x - 1).ToString(), true);
                            if (c.Length > 0)
                            {
                                finish = (Label)c[0];
                            }

                            display.finishs[rankmemory[x - 1]] = ((TimeSpan.FromMilliseconds((ftimer) * 10))).ToString(@"mm\:ss\:ff");
                            finish.Text = ((TimeSpan.FromMilliseconds((ftimer) * 10))).ToString(@"mm\:ss\:ff");

                        }
                        else
                        {
                            if (!finishchecker.Contains(x - 1))
                            {
                                finishchecker[finishcheck] = x - 1;
                                finishcheck++;
                            }
                            if (finishcheck == updownracers.Value)
                            {

                                maintimer.Change(System.Threading.Timeout.Infinite, 1);
                                myStopWatch.Stop();
                                finished = true;
                                Label finish = new Label();
                                Control[] c;
                                c = maintable.Controls.Find("time" + ((int)updownlaps.Value + 2).ToString() + (x - 1).ToString(), true);
                                if (c.Length > 0)
                                {
                                    finish = (Label)c[0];
                                }
                                display.finishs[rankmemory[x - 1]] = finish.Text;


                            }

                        }
                    }
                    catch { }
                }

                maintable.ResumeLayout();


            }

         
        }

        private void Updatemain_Tick(object sender, EventArgs e)
        {
            Updatemaingui(1);
            
        }

        private void updatefinish_Tick(object sender, EventArgs e)
        {
            Updatefgui(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen[] screen = Screen.AllScreens;
            try
            {
                display.StartPosition = FormStartPosition.Manual;
                display.Location = screen[1].Bounds.Location;
                display.Show();
                //  FormBorderStyle = FormBorderStyle.None;
                //  WindowState = FormWindowState.Maximized;
            }
            catch
            {
                //   FormBorderStyle = FormBorderStyle.None;
                //   WindowState = FormWindowState.Maximized;
                display.Show();
                MessageBox.Show("Connect to a Second Display or Screen");
            }
        }



        private void Finish_Tick(object sender, EventArgs e)
        {
            
            
        }
        private void updaterank()
        {
            
            

            bool allequal = true;
            for (int y = (int)updownracers.Value - 1; y > 0; y--)
            {
                if (racermap[y] == racermap[y + 1])
                {
                    allequal = true;
                }
                else
                {
                    allequal = false;
                    break;
                }
            }


            if (allequal)
            {
                
                maxrank = lapinterval.OrderBy(i => i).ToArray();
                List<int> lst = maxrank.OfType<int>().ToList();
                lst.RemoveAll(i => i == 0);
                maxrank = lst.ToArray();
              

                for (int x = maxrank.Length; x >= 1; x--)
                {
                  

                    maxindex = lapinterval.ToList().IndexOf(maxrank[x - 1]);

                    Label rank = new Label();
                    Control[] c = maintable.Controls.Find("rank" + (maxindex).ToString(), true);

                    try { rank = (Label)c[0]; } catch { }
                   
                    rank.Text = (x).ToString();
                    rankmemory[maxindex] = x;
                    display.ranking[x] = rank.Text;
                    if (register)
                    {
                        display.ids[x]  = Registeration.fnamesf1[maxindex] + " " + Registeration.lnamesf1[maxindex];
                    }
                    else
                    {
                        display.ids[x] = loadids.namesf1[maxindex];
                    }
                    if(racermap[maxindex]<maintable.ColumnCount - 3)
                    display.laps[x] =(racermap[maxindex]+1).ToString() + "/" + updownlaps.Value.ToString();
                    else
                    display.laps[x] = (racermap[maxindex] ).ToString() + "/" + updownlaps.Value.ToString();

                    display.tableLayoutPanel1.Controls["rank" + x.ToString()].Text = display.ranking[x];
                    display.tableLayoutPanel1.Controls["id" + x.ToString()].Text = display.ids[x];
                    display.tableLayoutPanel1.Controls["lap" + x.ToString()].Text = display.laps[x];

                    Lapsleft.Text = racermap.Max().ToString() + " / " + updownlaps.Value.ToString();
                    

                }

            }
            else
            {

                maxindex2 = -1;
                order = lapinterval.OrderBy(i => i).ToArray();
                List<int> lst = order.OfType<int>().ToList();
                lst.RemoveAll(i => i == 0);
                order = lst.ToArray();


                int rankorder = order.Length + 1;
                for (int t = racermap.Max(); t >= 0; t--)
                {
                    for (int w = order.Length; w > 0; w--)
                    {

                        maxindex2 = lapinterval.ToList().IndexOf(order[w - 1]);
                        if (racermap[maxindex2] == (racermap.Max() - t))
                        {
                            rankorder--;
                            Label rank = new Label();
                            Control[] c = maintable.Controls.Find("rank" + (maxindex2).ToString(), true);
                            if (c.Length > 0)
                            {
                                rank = (Label)c[0];
                            }
                            rank.Text = (rankorder).ToString();
                            rankmemory[maxindex2] = rankorder;
                            display.ranking[rankorder] = rank.Text;
                            if (register)
                            {
                                display.ids[rankorder] = Registeration.fnamesf1[maxindex2] + Registeration.lnamesf1[maxindex2];
                            }
                            else
                            {
                                display.ids[rankorder] = loadids.namesf1[maxindex2];
                            }
                            if (racermap[maxindex2] < maintable.ColumnCount - 3)
                                display.laps[rankorder] = (racermap[maxindex2] + 1).ToString();
                            else
                                display.laps[rankorder] = (racermap[maxindex2]).ToString();

                            display.tableLayoutPanel1.Controls["rank" + rankorder.ToString()].Text = display.ranking[rankorder];
                            display.tableLayoutPanel1.Controls["id" + rankorder.ToString()].Text = display.ids[rankorder];
                            display.tableLayoutPanel1.Controls["lap" + rankorder.ToString()].Text = display.laps[rankorder];
                        }
                    }

                }


            }

        }

        /*---------- Reader ----------*/
        private void initReader()
        {
            // Initialize Reader
            reader = new Reader.ReaderMethod();
            reader.AnalyCallback = AnalyData;
            reader.ReceiveCallback = ReceiveData;
            reader.SendCallback = SendData;
            // GUI
            EnableInterface(false);
            gbAntenna.Enabled = false; // temporarily disabled
            gbRFPower.Enabled = false; // temporarily disabled
            tabControl1.SelectedIndex = 1;
            // Set Up Application Specific Settings
            SetupSettings();
        }
        private void ReceiveData(byte[] btAryReceiveData)
        {
            if (m_bDisplayLog)
            {
                string strLog = CCommondMethod.ByteArrayToString(btAryReceiveData, 0, btAryReceiveData.Length);
                MessageBox.Show(strLog);
                //WriteLog(lrtxtDataTran, strLog, 1);
            }
        }
        private void SendData(byte[] btArySendData)
        {
            if (m_bDisplayLog)
            {
                string strLog = CCommondMethod.ByteArrayToString(btArySendData, 0, btArySendData.Length);
                MessageBox.Show(strLog);
                //WriteLog(lrtxtDataTran, strLog, 0);
            }
        }
        private void AnalyData(Reader.MessageTran msgTran)
        {
              if (msgTran.PacketType != 0xA0)
                {
                    return;
                }
                switch (msgTran.Cmd)
                {   /*
                    case 0x69:
                        ProcessSetProfile(msgTran);
                        break;
                    case 0x6A:
                        ProcessGetProfile(msgTran);
                        break;
                    case 0x71:
                        ProcessSetUartBaudrate(msgTran);
                        break;
                    case 0x72:
                        ProcessGetFirmwareVersion(msgTran);
                        break;
                    case 0x73:
                        ProcessSetReadAddress(msgTran);
                        break;
                    case 0x74:
                        ProcessSetWorkAntenna(msgTran);
                        break;
                    case 0x75:
                        ProcessGetWorkAntenna(msgTran);
                        break;
                    case 0x76:
                        ProcessSetOutputPower(msgTran);
                        break;
                    case 0x77:
                        ProcessGetOutputPower(msgTran);
                        break;
                    */
                    case 0x78:
                        ProcessSetFrequencyRegion(msgTran);
                        break;
                    /*
                    case 0x79:
                        ProcessGetFrequencyRegion(msgTran);
                        break;
                    case 0x7A:
                        ProcessSetBeeperMode(msgTran);
                        break;
                    case 0x7B:
                        ProcessGetReaderTemperature(msgTran);
                        break;
                    case 0x7C:
                        ProcessSetDrmMode(msgTran);
                        break;
                    case 0x7D:
                        ProcessGetDrmMode(msgTran);
                        break;
                    case 0x7E:
                        ProcessGetImpedanceMatch(msgTran);
                        break;
                    case 0x60:
                        ProcessReadGpioValue(msgTran);
                        break;
                    case 0x61:
                        ProcessWriteGpioValue(msgTran);
                        break;
                    case 0x62:
                        ProcessSetAntDetector(msgTran);
                        break;
                    case 0x63:
                        ProcessGetAntDetector(msgTran);
                        break;
                    case 0x67:
                        ProcessSetReaderIdentifier(msgTran);
                        break;
                    case 0x68:
                        ProcessGetReaderIdentifier(msgTran);
                        break;
                    case 0x80:
                        ProcessInventory(msgTran);
                        break;
                    case 0x81:
                        ProcessReadTag(msgTran);
                        break;
                    case 0x82:
                        ProcessWriteTag(msgTran);
                        break;
                    case 0x83:
                        ProcessLockTag(msgTran);
                        break;
                    case 0x84:
                        ProcessKillTag(msgTran);
                        break;
                    case 0x85:
                        ProcessSetAccessEpcMatch(msgTran);
                        break;
                    case 0x86:
                        ProcessGetAccessEpcMatch(msgTran);
                        break;
                    case 0x89:
                    case 0x8B:
                        ProcessInventoryReal(msgTran);
                        break;
                    */
                    case 0x8A:
                        ProcessFastSwitch(msgTran);
                        break;
                    /*
                    case 0x8D:
                        ProcessSetMonzaStatus(msgTran);
                        break;
                    case 0x8E:
                        ProcessGetMonzaStatus(msgTran);
                        break;
                    case 0x90:
                        ProcessGetInventoryBuffer(msgTran);
                        break;
                    case 0x91:
                        ProcessGetAndResetInventoryBuffer(msgTran);
                        break;
                    case 0x92:
                        ProcessGetInventoryBufferTagCount(msgTran);
                        break;
                    case 0x93:
                        ProcessResetInventoryBuffer(msgTran);
                        break;
                    case 0xb0:
                        ProcessInventoryISO18000(msgTran);
                        break;
                    case 0xb1:
                        ProcessReadTagISO18000(msgTran);
                        break;
                    case 0xb2:
                        ProcessWriteTagISO18000(msgTran);
                        break;
                    case 0xb3:
                        ProcessLockTagISO18000(msgTran);
                        break;
                    case 0xb4:
                        ProcessQueryISO18000(msgTran);
                        break;*/
                    default: 
                        break;
                }
        }
        /*---------- Logs   ----------*/
        /*
        private delegate void WriteLogUnSafe(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType);
        private void WriteLog(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType)
        {
            if (this.InvokeRequired)
            {
                WriteLogUnSafe InvokeWriteLog = new WriteLogUnSafe(WriteLog);
                this.Invoke(InvokeWriteLog, new object[] { logRichTxt, strLog, nType });
            }
            else
            {
                if (nType == 0)
                {
                    logRichTxt.AppendTextEx(strLog, Color.Indigo);
                }
                else
                {
                    logRichTxt.AppendTextEx(strLog, Color.Red);
                }

                if (ckClearOperationRec.Checked)
                {
                    if (logRichTxt.Lines.Length > 50)
                    {
                        logRichTxt.Clear();
                    }
                }

                logRichTxt.Select(logRichTxt.TextLength, 0);
                logRichTxt.ScrollToCaret();
            }
        }
        */ //Custom control (codes from demo, for customized display) not added in yet.
        /*---------- Communication ----------*/
        private void rdbTcpIp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTcpIp.Checked)
            {
                Tcppanel.Enabled = true;
                btndisconnect.Enabled = false;

                Rs323Panel.Enabled = false;
            }
        }
        private void rdbRS232_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRS232.Checked)
            {
                Rs323Panel.Enabled = true;
                StopTCp.Enabled = false;

                Tcppanel.Enabled = false;
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            updatePorts();
        }
        private void updatePorts()
        {

            string[] ports = SerialPort.GetPortNames();
            cmbPortName.Items.Clear();
            foreach (string port in ports)
            {
                cmbPortName.Items.Add(port);
            }
        }
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            string strException = string.Empty;
            try
            {
                string strComPort = cmbPortName.Text;
                int nBaudrate = Convert.ToInt32(cmbBaudRate.Text);

                int nRet = reader.OpenCom(strComPort, nBaudrate, out strException);
                if (nRet != 0)
                {
                    string strLog = "Failed to connect to the reader： " + strException;

                    MessageBox.Show(strLog);
                    return;
                }
                else
                {
                    string strLog = "Reader Connected " + strComPort + "@" + nBaudrate.ToString();
                    MessageBox.Show(strLog);
                    m_connected = true;
                    tabControl1.SelectedIndex = 0;
                    EnableInterface(true);
                    SetupSettings();
                }

                btnConnect.Enabled = false;
                btndisconnect.Enabled = true;
            }
            catch { MessageBox.Show("Please Enter Com Settings before Connecting"); }
        }
        private void btndisconnect_Click(object sender, EventArgs e)
        {
            reader.CloseCom();

            btnConnect.Enabled = true;
            btndisconnect.Enabled = false;

            m_connected = false;
            EnableInterface(false);
        }
        private void StartTcp_Click(object sender, EventArgs e)
        {
            try
            {

                string strException = string.Empty;
                IPAddress ipAddress = IPAddress.Parse(IPBOX.Text);
                int nPort = Convert.ToInt32(PortBox.Text);

                int nRet = reader.ConnectServer(ipAddress, nPort, out strException);
                if (nRet != 0)
                {
                    string strLog = "Failed to connect to reader " + strException;

                    MessageBox.Show(strLog);
                    return;
                }
                else
                {
                    string strLog = "Reader Connected " + IPBOX.Text + "@" + nPort.ToString();
                    MessageBox.Show(strLog);
                    m_connected = true;
                    tabControl1.SelectedIndex = 0;
                    EnableInterface(true);
                    SetupSettings();
                }

                StartTcp.Enabled = true;
                StopTCp.Enabled = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StopTCp_Click(object sender, EventArgs e)
        {
            reader.SignOut();

            StartTcp.Enabled = true;
            StopTCp.Enabled = false;

            m_connected = false;
            EnableInterface(false);
        }
        /*--!--##!## Inactive Functions ##!##--!--*/
        private void cbAnt1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnt1.Checked) flagAnt1 = true;
            else flagAnt1 = false;
        }
        private void cbAnt2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnt2.Checked) flagAnt2 = true;
            else flagAnt2 = false;
        }
        private void cbAnt3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnt3.Checked) flagAnt3 = true;
            else flagAnt3 = false;
        }
        private void cbAnt4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnt4.Checked) flagAnt4 = true;
            else flagAnt4 = false;
        }
        /*---------- Settings ----------*/
        private void SetupSettings()
        {
            if (!m_connected)
            {
                MessageBox.Show("Not connected!\nHint: Connect through RS232 or TCP/IP.");
                return;
            }
           
            cbUserFreq.Checked = true;
            rbFCC.Checked = false;
            rbETSI.Checked = false;
            rbCHN.Checked = false;
            cmbFrequencyStart.Items.Clear();
            cmbFrequencyEnd.Items.Clear();
            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            cbUserFreq.Checked = true;
            txtStartFreq.Text = "920";
            txtFreqSpace.Text = "1";
            txtQuantity.Text = "1";
            int nStartFrequency = Convert.ToInt32(txtStartFreq.Text);
            int nFrequencyInterval = Convert.ToInt32(txtFreqSpace.Text);
            nFrequencyInterval = nFrequencyInterval / 10;
            byte btChannelQuantity = Convert.ToByte(txtQuantity.Text);
            reader.SetUserDefineFrequency(m_curSetting.btReadId, nStartFrequency, (byte)nFrequencyInterval, btChannelQuantity);
            m_curSetting.btRegion = 4;
            m_curSetting.nUserDefineStartFrequency = nStartFrequency;
            m_curSetting.btUserDefineFrequencyInterval = (byte)nFrequencyInterval;
            m_curSetting.btUserDefineChannelQuantity = btChannelQuantity;
        }
        private void EnableInterface(bool trigger)
        {
           // racebeginbutton.Enabled = trigger;
            StartReading.Enabled = trigger;
            group.Enabled = trigger;
           // MANUAL.Enabled = trigger;
        }
        private void btSetConfig_Click(object sender, EventArgs e)
        {

            /*
            btSetConfig.Enabled = false;
            byte j = 7, k = 7;
            if (flagAnt1) reader.SetWorkAntenna(255, 1);
            if (flagAnt2) reader.SetWorkAntenna(255, 2);
            if (flagAnt3) reader.SetWorkAntenna(255, 3);
            if (flagAnt4) reader.SetWorkAntenna(255, 4);
            power = Convert.ToByte(comboPower.SelectedItem);
            //reader.SetOutputPower(255, power);
            startFreq = Convert.ToDouble(SysStartFreq.Value);
            endFreq = Convert.ToDouble(SysEndFreq.Value);
            */
            try
            {
                if (cbUserFreq.Checked == true)
                {
                    int nStartFrequency = Convert.ToInt32(txtStartFreq.Text);
                    int nFrequencyInterval = Convert.ToInt32(txtFreqSpace.Text);
                    nFrequencyInterval = nFrequencyInterval / 10;
                    byte btChannelQuantity = Convert.ToByte(txtQuantity.Text);
                    reader.SetUserDefineFrequency(m_curSetting.btReadId, nStartFrequency, (byte)nFrequencyInterval, btChannelQuantity);
                    m_curSetting.btRegion = 4;
                    m_curSetting.nUserDefineStartFrequency = nStartFrequency;
                    m_curSetting.btUserDefineFrequencyInterval = (byte)nFrequencyInterval;
                    m_curSetting.btUserDefineChannelQuantity = btChannelQuantity;
                }
                else
                {
                    byte btRegion = 0x00;
                    byte btStartFreq = 0x00;
                    byte btEndFreq = 0x00;

                    int nStartIndex = cmbFrequencyStart.SelectedIndex;
                    int nEndIndex = cmbFrequencyEnd.SelectedIndex;
                    if (nEndIndex < nStartIndex)
                    {
                        MessageBox.Show("Spectrum definition is not valid, please see communication protocol sepcification");
                        return;
                    }

                    if (rbFCC.Checked)
                    {
                        btRegion = 0x01;
                        btStartFreq = Convert.ToByte(nStartIndex + 7);
                        btEndFreq = Convert.ToByte(nEndIndex + 7);
                    }
                    else if (rbETSI.Checked)
                    {
                        btRegion = 0x02;
                        btStartFreq = Convert.ToByte(nStartIndex);
                        btEndFreq = Convert.ToByte(nEndIndex);
                    }
                    else if (rbCHN.Checked)
                    {
                        btRegion = 0x03;
                        btStartFreq = Convert.ToByte(nStartIndex + 43);
                        btEndFreq = Convert.ToByte(nEndIndex + 43);
                    }
                    else
                    {
                        return;
                    }
                    reader.SetFrequencyRegion(m_curSetting.btReadId, btRegion, btStartFreq, btEndFreq);
                    m_curSetting.btRegion = btRegion;
                    m_curSetting.btFrequencyStart = btStartFreq;
                    m_curSetting.btFrequencyEnd = btEndFreq;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            btSetConfig.Enabled = true;
            reader.Reset(255);
            SetupSettings();
        }
        private void rbFCC_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (rbFCC.Checked)
            {
                flagFCC = true;
                SysStartFreq.DecimalPlaces = 1;
                SysStartFreq.Increment = 0.5M;
                SysStartFreq.Maximum = 928;
                SysStartFreq.Minimum = 902;
                SysStartFreq.Value = 902;

                SysEndFreq.DecimalPlaces = 1;
                SysEndFreq.Increment = 0.5M;
                SysEndFreq.Maximum = 928;
                SysEndFreq.Minimum = 902;
                SysEndFreq.Value = 902;
            }
            else
            {
                flagFCC = false;
            } */

            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            cmbFrequencyStart.Items.Clear();
            cmbFrequencyEnd.Items.Clear();

            float nStart = 902.00f;
            for (int nloop = 0; nloop < 53; nloop++)
            {
                string strTemp = nStart.ToString("0.00");
                cmbFrequencyStart.Items.Add(strTemp);
                cmbFrequencyEnd.Items.Add(strTemp);

                nStart += 0.5f;
            }
            cmbFrequencyStart.SelectedIndex = 0;
            cmbFrequencyEnd.SelectedIndex = 52;
        }
        private void rbETSI_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (rbETSI.Checked)
            {
                flagETSI = true;
                SysStartFreq.DecimalPlaces = 1;
                SysStartFreq.Increment = 0.5M;
                SysStartFreq.Maximum = 868;
                SysStartFreq.Minimum = 865;
                SysStartFreq.Value = 865;

                SysEndFreq.DecimalPlaces = 1;
                SysEndFreq.Increment = 0.5M;
                SysEndFreq.Maximum = 868;
                SysEndFreq.Minimum = 865;
                SysEndFreq.Value = 865;
            }
            else
            {
                flagETSI = false;
            }*/
            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            cmbFrequencyStart.Items.Clear();
            cmbFrequencyEnd.Items.Clear();

            float nStart = 865.00f;
            for (int nloop = 0; nloop < 7; nloop++)
            {
                string strTemp = nStart.ToString("0.00");
                cmbFrequencyStart.Items.Add(strTemp);
                cmbFrequencyEnd.Items.Add(strTemp);

                nStart += 0.5f;
            }
        }
        private void rbCHN_CheckedChanged(object sender, EventArgs e)
        {
            /*(if (rbCHN.Checked) flagCHN = true;
            else
            {
                flagCHN = false;
            }*/
            cmbFrequencyStart.SelectedIndex = -1;
            cmbFrequencyEnd.SelectedIndex = -1;
            cmbFrequencyStart.Items.Clear();
            cmbFrequencyEnd.Items.Clear();

            float nStart = 920.00f;
            for (int nloop = 0; nloop < 11; nloop++)
            {
                string strTemp = nStart.ToString("0.00");
                cmbFrequencyStart.Items.Add(strTemp);
                cmbFrequencyEnd.Items.Add(strTemp);

                nStart += 0.5f;
            }
        }
        private void cbUserFreq_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUserFreq.Checked)
            {
               // gbUserFreq.Visible = true;
                gbSysFreq.Enabled = false;
                gbUserFreq.Enabled = true;
                /*flagFCC = false;
                flagETSI = false;
                flagCHN = false;*/
            }
            else
            {
               // gbUserFreq.Visible = false;
                gbSysFreq.Enabled = true;
                gbUserFreq.Enabled = false;
                /* rbFCC.Checked = false;
                 rbETSI.Checked = false;
                 rbCHN.Checked = false; */
            }
        }
        /*---------- FastSwitchInventory ----------*/
        private void StartReading_Click(object sender, EventArgs e)
        {
            StartFastSwitch();
        }
        public void StartFastSwitch()
        {
            if (Registeration.isreading) {
                if (Registeration.Read.Text == "Start Reader")
                {
                    
                    m_curInventoryBuffer.bLoopInventory = true;
                    m_btAryData[0] = Convert.ToByte(0); // A
                    m_btAryData[1] = Convert.ToByte(1); // Stay
                    m_btAryData[2] = Convert.ToByte(1); // B
                    m_btAryData[3] = Convert.ToByte(1); // Stay
                    m_btAryData[4] = Convert.ToByte(2); // C
                    m_btAryData[5] = Convert.ToByte(1); // Stay
                    m_btAryData[6] = Convert.ToByte(3); // D
                    m_btAryData[7] = Convert.ToByte(1); // Stay
                    m_btAryData[8] = Convert.ToByte(20); //Interval
                    m_btAryData[0] = Convert.ToByte(0);
                    m_nSwitchTotal = 0;
                    m_nSwitchTime = 0;
                    reader.FastSwitchInventory(m_curSetting.btReadId, m_btAryData);
                    Registeration.Read.Text = "Stop Reader";
                }
                else
                {
                    
                    m_curInventoryBuffer.bLoopInventory = false;
                    Registeration.Read.Text = "Start Reader";
                    Registeration.isreading = false;
                }
            }
            else
            {
                if (StartReading.Text == "Start Reader")
                {
                    m_curInventoryBuffer.bLoopInventory = true;
                    m_btAryData[0] = Convert.ToByte(0); // A
                    m_btAryData[1] = Convert.ToByte(1); // Stay
                    m_btAryData[2] = Convert.ToByte(1); // B
                    m_btAryData[3] = Convert.ToByte(1); // Stay
                    m_btAryData[4] = Convert.ToByte(2); // C
                    m_btAryData[5] = Convert.ToByte(1); // Stay
                    m_btAryData[6] = Convert.ToByte(3); // D
                    m_btAryData[7] = Convert.ToByte(1); // Stay
                    m_btAryData[8] = Convert.ToByte(20); //Interval
                    m_btAryData[0] = Convert.ToByte(0);
                    m_nSwitchTotal = 0;
                    m_nSwitchTime = 0;
                    reader.FastSwitchInventory(m_curSetting.btReadId, m_btAryData);
                    StartReading.Text = "Stop Reader";
                   // racebeginbutton.Enabled = true; ;
                }
                else
                {
                    m_curInventoryBuffer.bLoopInventory = false;
                    StartReading.Text = "Start Reader";
                   // racebeginbutton.Enabled = false;
                }
            }
        }
        private delegate void RefreshFastSwitchUnsafe(byte btCmd);
        private void RefreshFastSwitch(byte btCmd)
        {
            if (this.InvokeRequired)
            {
                RefreshFastSwitchUnsafe InvokeRefreshFastSwitch = new RefreshFastSwitchUnsafe(RefreshFastSwitch);
                this.Invoke(InvokeRefreshFastSwitch, new object[] { btCmd });
            }
            else
            {
                switch (btCmd)
                {
                    /// Update tag report everytime succeed to receive new tag
                    case 0x00:
                        {
                        
                            /*
                            int nTagCount = m_curInventoryBuffer.dtTagTable.Rows.Count;
                            int nTotalRead = m_nTotal;// m_curInventoryBuffer.dtTagDetailTable.Rows.Count;
                            TimeSpan ts = m_curInventoryBuffer.dtEndInventory - m_curInventoryBuffer.dtStartInventory;
                            int nTotalTime = ts.Minutes * 60 * 1000 + ts.Seconds * 1000 + ts.Milliseconds;

                            // Form List
                            int nEpcCount = lvFastList.Items.Count;
                            int nEpcLength = m_curInventoryBuffer.dtTagTable.Rows.Count;
                            if (nEpcCount < nEpcLength)
                            {
                                DataRow row = m_curInventoryBuffer.dtTagTable.Rows[nEpcLength - 1];

                                ListViewItem item = new ListViewItem();
                                item.Text = (nEpcCount + 1).ToString();
                                item.SubItems.Add(row[2].ToString());
                                item.SubItems.Add(row[0].ToString());
                                //item.SubItems.Add(row[5].ToString());
                                item.SubItems.Add(row[7].ToString() + "  /  " + row[8].ToString() + "  /  " + row[9].ToString() + "  /  " + row[10]);
                                item.SubItems.Add((Convert.ToInt32(row[4]) - 129).ToString() + "dBm");
                                item.SubItems.Add(row[6].ToString());

                                lvFastList.Items.Add(item);
                                lvFastList.Items[nEpcCount].EnsureVisible();
                            }

                            //更新列表中读取的次数
                            if (m_nTotal % m_nRealRate == 1)
                            {
                                int nIndex = 0;
                                foreach (DataRow row in m_curInventoryBuffer.dtTagTable.Rows)
                                {
                                    ListViewItem item = lvFastList.Items[nIndex];
                                    //item.SubItems[3].Text = row[5].ToString();
                                    item.SubItems[3].Text = (row[7].ToString() + "  /  " + row[8].ToString() + "  /  " + row[9].ToString() + "  /  " + row[10]);
                                    item.SubItems[4].Text = (Convert.ToInt32(row[4]) - 129).ToString() + "dBm";
                                    item.SubItems[5].Text = row[6].ToString();

                                    nIndex++;
                                }
                            }
                            */

                        }
                        break;
                    /// Error Handling
                    case 0x01:
                        {
                            MessageBox.Show("Couldn't Start Scanning");
                        }
                        break;
                    /// End of Package
                    case 0x02:
                        {
                          
                            int nTagCount = m_curInventoryBuffer.dtTagTable.Rows.Count;
                            int nTotalRead = m_nTotal;// m_curInventoryBuffer.dtTagDetailTable.Rows.Count;
                            TimeSpan ts = m_curInventoryBuffer.dtEndInventory - m_curInventoryBuffer.dtStartInventory;
                            int nTotalTime = ts.Minutes * 60 * 1000 + ts.Seconds * 1000 + ts.Milliseconds;

                            string tagInfo = "";
                            listBox1.Items.Clear();
                            for (int i = 0; i < nTagCount; i++)
                            {
                                DataRow row = m_curInventoryBuffer.dtTagTable.Rows[i];
                                tagInfo = "Antenna " + row[7].ToString() + "/" + row[8].ToString() + "/" + row[9].ToString() + "/" + row[10] + "    " /* Antenna */
                                                     + row[2].ToString() + "    " /* EPC */
                                                     + row[6].ToString() + "    " /* FREQ */
                                                     + row[4].ToString() + "    ";/* RSSI */
                                tagholder = row[2].ToString();
                                if (register)
                                {
                                    racer = Registeration.tagsf1.ToList().IndexOf(tagholder.ToString());
                                }
                                else
                                {
                                    racer = loadids.tagsf1.ToList().IndexOf(tagholder.ToString()) + 1;
                                }
                                Label time = new Label();
                                if (racer == loadids.tagsf1.Length && first_round)
                                {
                                    myStopWatch.Restart();
                                    first_round = false; 
                                }

                                Control[] c;
                                c = maintable.Controls.Find("time" + (racermap[racer] + 2).ToString() + (racer).ToString(), true);

                                if (c.Length > 0)
                                    time = (Label)c[0];

                                time.Text = ((TimeSpan.FromMilliseconds((timer - lapinterval[racer]) * 10))).ToString(@"mm\:ss\:ff");
                                display.currents[rankmemory[racer]] = ((TimeSpan.FromMilliseconds((timer - lapinterval[racer]) * 10))).ToString(@"mm\:ss\:ff");

                                Label finish = new Label();
                                Control[] c1;
                                c1 = maintable.Controls.Find("time" + ((int)updownlaps.Value + 2).ToString() + (racer).ToString(), true);
                                if (c1.Length > 0)
                                    finish = (Label)c1[0];


                                display.finishs[rankmemory[racer]] = ((TimeSpan.FromMilliseconds((ftimer) * 10))).ToString(@"mm\:ss\:ff");
                                finish.Text = ((TimeSpan.FromMilliseconds((ftimer) * 10))).ToString(@"mm\:ss\:ff");

                                try
                                {
                                    for (int b = 1; b < maintable.RowCount - 1; b++)
                                        Totaltime[b] += ((int)timer - lapinterval[b]);
                                    racermap[racer]++;
                                    lapinterval[racer] = (int)ftimer;
                                }
                                catch { }
                                updaterank();
                            }
                            //ledFast1.Text.Text = m_nSwitchTime.ToString();
                            //ledFast1.Text.Text = m_nSwitchTotal.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private delegate void RunLoopFastSwitchUnsafe();
        private void RunLoopFastSwitch()
        {
            if (this.InvokeRequired)
            {
                RunLoopFastSwitchUnsafe InvokeRunLoopFastSwitch = new RunLoopFastSwitchUnsafe(RunLoopFastSwitch);
                this.Invoke(InvokeRunLoopFastSwitch, new object[] { });
            }
            else
            {
                if (m_curInventoryBuffer.bLoopInventory)
                {
                    reader.FastSwitchInventory(m_curSetting.btReadId, m_btAryData);
                }
            }
        }
        private string GetFreqString(byte btFreq)
        {
            string strFreq = string.Empty;

            if (m_curSetting.btRegion == 4)
            {
                float nExtraFrequency = btFreq * m_curSetting.btUserDefineFrequencyInterval * 10;
                float nstartFrequency = ((float)m_curSetting.nUserDefineStartFrequency) / 1000;
                float nStart = nstartFrequency + nExtraFrequency / 1000;
                string strTemp = nStart.ToString("0.000");
                return strTemp;
            }
            else
            {
                if (btFreq < 0x07)
                {
                    float nStart = 865.00f + Convert.ToInt32(btFreq) * 0.5f;

                    string strTemp = nStart.ToString("0.00");

                    return strTemp;
                }
                else
                {
                    float nStart = 902.00f + (Convert.ToInt32(btFreq) - 7) * 0.5f;

                    string strTemp = nStart.ToString("0.00");

                    return strTemp;
                }
            }
        }
        private void SetMaxMinRSSI(int nRSSI)
        {
            if (m_curInventoryBuffer.nMaxRSSI < nRSSI)
            {
                m_curInventoryBuffer.nMaxRSSI = nRSSI;
            }

            if (m_curInventoryBuffer.nMinRSSI == 0)
            {
                m_curInventoryBuffer.nMinRSSI = nRSSI;
            }
            else if (m_curInventoryBuffer.nMinRSSI > nRSSI)
            {
                m_curInventoryBuffer.nMinRSSI = nRSSI;
            }
        }

 







        /*---------- Process Feedback Package ----------*/
        private void ProcessSetFrequencyRegion(Reader.MessageTran msgTran)
        {
            string strCmd = "Set RF spectrum ";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1)
            {
                if (msgTran.AryData[0] == 0x10)
                {
                    m_curSetting.btReadId = msgTran.ReadId;
                    MessageBox.Show(strCmd);
                    //WriteLog(lrtxtLog, strCmd, 0);

                    return;
                }
                else
                {
                    strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                }
            }
            else
            {
                strErrorCode = "Unknown error";
            }

            string strLog = strCmd + "failed , due to: " + strErrorCode;
            MessageBox.Show(strLog);
            //WriteLog(lrtxtLog, strLog, 1);
        }
        private void ProcessFastSwitch(Reader.MessageTran msgTran)
        {
            string strCmd = "Fast switch antenna inventory ";
            string strErrorCode;
            if (msgTran.AryData.Length == 1 || (msgTran.AryData.Length == 0)) // Error
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "failed, due to: " + strErrorCode;

                MessageBox.Show(strLog);
                //WriteLog(lrtxtLog, strLog, 1);
                if (Registeration.isreading)
                    Registeration.RefreshFastSwitch(0x01);
                else
                    RefreshFastSwitch(0x01); //Basically do nothing here
                RunLoopFastSwitch();
            }
            else if (msgTran.AryData.Length == 2) // Antenna Error
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[1]);
                string strLog = strCmd + "failed, due to: " + strErrorCode + "--" + "antenna " + (msgTran.AryData[0] + 1);
                MessageBox.Show(strLog);
                //WriteLog(lrtxtLog, strLog, 1);
            }

            else if (msgTran.AryData.Length == 7) // Succeeded Package
            {
                m_nSwitchTotal = Convert.ToInt32(msgTran.AryData[0]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[1]) * 255 + Convert.ToInt32(msgTran.AryData[2]);
                m_nSwitchTime = Convert.ToInt32(msgTran.AryData[3]) * 255 * 255 * 255 + Convert.ToInt32(msgTran.AryData[4]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[5]) * 255 + Convert.ToInt32(msgTran.AryData[6]);

                m_curInventoryBuffer.nDataCount = m_nSwitchTotal;
                m_curInventoryBuffer.nCommandDuration = m_nSwitchTime;
                MessageBox.Show(strCmd);
                //WriteLog(lrtxtLog, strCmd, 0);
                if (Registeration.isreading)
                    Registeration.RefreshFastSwitch(0x02);
                else
                    RefreshFastSwitch(0x02); //Basically do nothing here

                RunLoopFastSwitch();
            }
            /*else if (msgTran.AryData.Length == 8)
            {
                
                m_nSwitchTotal = Convert.ToInt32(msgTran.AryData[0]) * 255 * 255 * 255 + Convert.ToInt32(msgTran.AryData[1]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[2]) * 255 + Convert.ToInt32(msgTran.AryData[3]);
                m_nSwitchTime = Convert.ToInt32(msgTran.AryData[4]) * 255 * 255 * 255 + Convert.ToInt32(msgTran.AryData[5]) * 255 * 255 + Convert.ToInt32(msgTran.AryData[6]) * 255 + Convert.ToInt32(msgTran.AryData[7]);

                m_curInventoryBuffer.nDataCount = m_nSwitchTotal;
                m_curInventoryBuffer.nCommandDuration = m_nSwitchTime;
                WriteLog(lrtxtLog, strCmd, 0);
                RefreshFastSwitch(0x02);
                RunLoopFastSwitch();
            }*/
            else
            {
                m_nTotal++;
                int nLength = msgTran.AryData.Length;
                int nEpcLength = nLength - 4;

                // Process single tag list
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, nEpcLength);
                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 2);
                string strRSSI = msgTran.AryData[nLength - 1].ToString();
                SetMaxMinRSSI(Convert.ToInt32(msgTran.AryData[nLength - 1]));
                byte btTemp = msgTran.AryData[0];
                byte btAntId = (byte)((btTemp & 0x03) + 1);
                m_curInventoryBuffer.nCurrentAnt = (int)btAntId;
                string strAntId = btAntId.ToString();
                byte btFreq = (byte)(btTemp >> 2);

                string strFreq = GetFreqString(btFreq);

                DataRow[] drs = m_curInventoryBuffer.dtTagTable.Select(string.Format("COLEPC = '{0}'", strEPC));
                if (drs.Length == 0)
                {
                    DataRow row1 = m_curInventoryBuffer.dtTagTable.NewRow();
                    row1[0] = strPC;
                    row1[2] = strEPC;
                    row1[4] = strRSSI;
                    row1[5] = "1";
                    row1[6] = strFreq;
                    row1[7] = "0";
                    row1[8] = "0";
                    row1[9] = "0";
                    row1[10] = "0";
                    switch (btAntId)
                    {
                        case 0x01:
                            {
                                row1[7] = "1";
                            }
                            break;
                        case 0x02:
                            {
                                row1[8] = "1";
                            }
                            break;
                        case 0x03:
                            {
                                row1[9] = "1";
                            }
                            break;
                        case 0x04:
                            {
                                row1[10] = "1";
                            }
                            break;
                        default:
                            break;
                    }

                    m_curInventoryBuffer.dtTagTable.Rows.Add(row1);
                    m_curInventoryBuffer.dtTagTable.AcceptChanges();
                }
                else
                {
                    foreach (DataRow dr in drs)
                    {
                        dr.BeginEdit();
                        int nTemp = 0;

                        dr[4] = strRSSI;
                        //dr[5] = (Convert.ToInt32(dr[5]) + 1).ToString();
                        nTemp = Convert.ToInt32(dr[5]);
                        dr[5] = (nTemp + 1).ToString();
                        dr[6] = strFreq;
                        switch (btAntId) 
                        {
                            case 0x01:
                                {
                                    //dr[7] = (Convert.ToInt32(dr[7]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[7]);
                                    dr[7] = (nTemp + 1).ToString();
                                }
                                break;
                            case 0x02:
                                {
                                    //dr[8] = (Convert.ToInt32(dr[8]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[8]);
                                    dr[8] = (nTemp + 1).ToString();
                                }
                                break;
                            case 0x03:
                                {
                                    //dr[9] = (Convert.ToInt32(dr[9]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[9]);
                                    dr[9] = (nTemp + 1).ToString();
                                }
                                break;
                            case 0x04:
                                {
                                    //dr[10] = (Convert.ToInt32(dr[10]) + 1).ToString();
                                    nTemp = Convert.ToInt32(dr[10]);
                                    dr[10] = (nTemp + 1).ToString();
                                }
                                break;
                            default:
                                break;
                        }

                        dr.EndEdit();
                    }
                    m_curInventoryBuffer.dtTagTable.AcceptChanges();
                }

                m_curInventoryBuffer.dtEndInventory = DateTime.Now;
                if(Registeration.isreading)
                    Registeration.RefreshFastSwitch(0x00);
                else
                RefreshFastSwitch(0x00); //Refresh data table
               
            }

        }
    }
}

