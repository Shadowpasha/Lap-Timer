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
using EPPlus;
using System.Reflection;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using MetroFramework.Forms;
namespace Lap_Timer
{
    public partial class Form2 : MetroForm
    {
        public string[] firstnames { get; set; }
        public string[] lastnames { get; set; }
        public string[] id { get; set; }
        public string[] ages { get; set; }
        public  string[] genders { get; set; }
        public  string[] heights { get; set; }
        public Image[] photopath { get; set; }

        public Form1 Main;
        public bool isreading = false;
        public string[] weights { get; set; }
       public string[] tags;
        string tagholder;
       
        int racers = 0;
        
        ExcelWorksheet ws;
        ExcelPackage excelReport;
        FileInfo file;
        string directory, filepath, excelpath;
        public Form2()
        {
            InitializeComponent();
            firstnames = new string[200];
            lastnames = new string[200];
            id = new string[200];
            ages = new string[200];
            genders = new string[200];
            heights = new string[200];
            weights = new string[200];
            tags = new string[200];
            photopath= new Image[200];
          
        }
       

       

      
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

            ExcelWorksheet ws = excelReport.Workbook.Worksheets["Sheet" + (excelReport.Workbook.Worksheets.ToArray().Length - 1).ToString()];

            WriteCell(ws, 1, 1, 1, 1, "First Name");
            WriteCell(ws, 1, 2, 1, 2, "Last Name");
            WriteCell(ws, 1, 3, 1, 3, "ID");
            WriteCell(ws, 1, 4, 1, 4, "Date Of Birth");
            WriteCell(ws, 1, 5, 1, 5, "Gender");
            WriteCell(ws, 1, 6, 1, 6, "Height");
            WriteCell(ws, 1, 7, 1, 7, "Weight");
            WriteCell(ws, 1, 8, 1, 8, "Tag");
            WriteCell(ws, 1, 9, 1, 9, "Picture");

            for (int x = 1; x <= racers; x++)
            {
                WriteCell(ws, x + 1, 1, x + 1, 1, firstnames[x]);
                WriteCell(ws, x + 1, 2, x + 1, 2, lastnames[x]);
                WriteCell(ws, x + 1, 3, x + 1, 3, id[x]);
                WriteCell(ws, x + 1, 4, x + 1, 4, ages[x]);
                WriteCell(ws, x + 1, 5, x + 1, 5, genders[x]);
                WriteCell(ws, x + 1, 6, x + 1, 6, heights[x]);
                WriteCell(ws, x + 1, 7, x + 1, 7, weights[x]);
                WriteCell(ws, x + 1, 8, x + 1, 8, tags[x]);
                try
                {
                    var pic = ws.Drawings.AddPicture(id[x], photopath[x]);
                    pic.SetSize(2, 20);
                    pic.From.Column = 8;
                    pic.From.Row = x;
                    pic.To.Column = 9;
                    pic.To.Row = x + 1;
                }
                catch { }

            }

            excelReport.Save();



        }
        private void writeToExcel()
        {
            directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filepath = directory + "\\" + DateTime.Now.ToLongDateString();
            excelpath = filepath + @"\" +  "ids.xlsx";

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

                ExcelWorksheet ws = excelReport.Workbook.Worksheets.Add(String.Format("Sheet{0}", excelReport.Workbook.Worksheets.ToArray().Length.ToString() ));
                writereport();
                Confirmation.ForeColor = Color.Green;
                Confirmation.Text = ("Exported Succesfully");

            }
            catch (Exception)
            {

                Confirmation.ForeColor = Color.Red;
                Confirmation.Text = ("Failed to export,if the Excel file is open please close and try again");
            
            }
        }

        public string[] fnamesf1
        {
            get
            {
                return this.firstnames;
            }
            set
            {
                this.firstnames = value;
            }
        }
        public string[] lnamesf1
        {
            get
            {
                return this.lastnames;
            }
            set
            {
                this.lastnames = value;
            }
        }
        public int racersf1
        {
            get
            {
                return this.racers;
            }
            set
            {
                this.racers = value;
            }
        }
        public string[] tagsf1
        {
            get
            {
                return this.tags;
            }
            set
            {
                this.tags = value;
            }
        }

        public delegate void MessageReceivedEventHandler(byte[] btAryBuffer);

        
        private void Export_Click(object sender, EventArgs e)
        {
            writeToExcel();
        }

        
        private delegate void RefreshFastSwitchUnsafe(byte btCmd);
        private void Read_Click(object sender, EventArgs e)
        {
            isreading = true;
            Main.StartFastSwitch();
           
        }
        public void RefreshFastSwitch(byte btCmd)
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

                        }
                        break;
                    /// End of Package
                    case 0x02:
                        {
                            int nTagCount = Main.m_curInventoryBuffer.dtTagTable.Rows.Count;
                            int nTotalRead = Main.m_nTotal;// m_curInventoryBuffer.dtTagDetailTable.Rows.Count;
                            TimeSpan ts = Main.m_curInventoryBuffer.dtEndInventory - Main.m_curInventoryBuffer.dtStartInventory;
                            int nTotalTime = ts.Minutes * 60 * 1000 + ts.Seconds * 1000 + ts.Milliseconds;

                            string tagInfo = "";
                           
                            for (int i = 0; i < nTagCount; i++)
                            {
                                DataRow row = Main.m_curInventoryBuffer.dtTagTable.Rows[i];
                                tagInfo = "Antenna " + row[7].ToString() + "/" + row[8].ToString() + "/" + row[9].ToString() + "/" + row[10] + "    " /* Antenna */
                                                     + row[2].ToString() + "    " /* EPC */
                                                     + row[6].ToString() + "    " /* FREQ */
                                                     + row[4].ToString() + "    ";/* RSSI */
                                tagholder = row[2].ToString();
                               
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


        private void filechoosebut_Click(object sender, EventArgs e)
        {
            Photo.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            Photo.ShowDialog();
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Submit_Click(object sender, EventArgs e)
        {
            if (!tags.Contains(tagholder))
            {
                racers++;
                firstnames[racers] = FirstName.Text;
                lastnames[racers] = Lastname.Text;
                id[racers] = Idbox.Text;
                ages[racers] = dateTimePicker1.Value.ToString();
                genders[racers] = Genderbox.Text;
                heights[racers] = Heightbox.Text;
                weights[racers] = Weightbox.Text;
                tags[racers] = tagholder.ToString();
                photopath[racers] = new Bitmap(Photo.FileName);
                Confirmation.ForeColor = Color.Green;
                Confirmation.Text = firstnames[racers] + " has been registered successfully";
            }
            else
            {
                Confirmation.ForeColor = Color.Red;
                Confirmation.Text = "Tag already exists or hasn't been scanned";
            }
        }

        private void Donebut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
