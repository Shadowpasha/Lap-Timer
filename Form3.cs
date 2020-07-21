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
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using MetroFramework.Forms;

namespace Lap_Timer
{

    public partial class Form3 : MetroForm
    {
        string[] names;
        string[] lastnames;
        string[] id;
        string[] ages;
        string[] genders;

        string[] heights;
        Image[] photopath;

        string[] weights;
      
         string[] tagsloaded;

        int racers;
        public Form3()
        {
            InitializeComponent();
            names = new string[999];
            lastnames = new string[999];
            ages = new string[999];
            genders = new string[999];
            id = new string[999];
            heights = new string[999];
            weights = new string[999];
            photopath = new Image[999];
            tagsloaded = new string[999];
        }
        public string[] namesf1
        {
            get
            {
                return this.names;
            }
            set
            {
                this.names = value;
            }
        }
        public string[] lastnamesf1
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
        public string[] weightsf1
        {
            get
            {
                return this.weights;
            }
            set
            {
                this.weights = value;
            }
        }
        public Image[] phtotpathf1
        {
            get
            {
                return this.photopath;
            }
            set
            {
                this.photopath = value;
            }
        }
        public string[] agesf1
        {
            get
            {
                return this.ages;
            }
            set
            {
                this.ages = value;
            }
        }
        public string[] gendersf1
        {
            get
            {
                return this.genders;
            }
            set
            {
                this.genders = value;
            }
        }
        public string[] heightf1
        {
            get
            {
                return this.heights;
            }
            set
            {
                this.heights = value;
            }
        }
        public string[] tagsf1
        {
            get
            {
                return this.tagsloaded;
            }
            set
            {
                this.tagsloaded = value;
            }
        }
        public string[] idf1
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
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
        private void filechoosebut_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
        }

        private void file_FileOk(object sender, CancelEventArgs e)
        {
            filename.Text = file.SafeFileName;
        }

        private void readids()
        {

            // path to your excel file
            string path = "" + file.FileName;
            FileInfo fileInfo = new FileInfo(path);
            try
            {
                ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet;
           
            if (sheetname.Text != "")
            {
                worksheet = package.Workbook.Worksheets[sheetname.Text];
            }
            else
            {
               
                    worksheet = package.Workbook.Worksheets.Last();
              
            }



            
                int rows = worksheet.Dimension.Rows;
                int columns = worksheet.Dimension.Columns;

                Form2 Registeration = new Form2();
                // loop through the worksheet rows 
                for (int i = 1; i < rows; i++)
                {
                    names[i] = worksheet.Cells[i + 1, 1].Value.ToString() + " " + worksheet.Cells[i + 1, 2].Value.ToString();
                    // names[1] = worksheet.Cells[i + 1, 1].Value.ToString();
                    lastnames[i - 1] = worksheet.Cells[i + 1, 2].Value.ToString();
                    id[i - 1] = worksheet.Cells[i + 1, 3].Value.ToString();
                    ages[i - 1] = worksheet.Cells[i + 1, 4].Value.ToString();
                    genders[i - 1] = worksheet.Cells[i + 1, 5].Value.ToString();
                    heights[i - 1] = worksheet.Cells[i + 1, 6].Value.ToString();
                    weights[i - 1] = worksheet.Cells[i + 1, 7].Value.ToString();
                    var excelpic = worksheet.Drawings[id[i - 1]] as ExcelPicture;
                    photopath[i - 1] = excelpic.Image;
                    tagsloaded[i-1] = worksheet.Cells[i+1, 8].Value.ToString();
                }
                racers = rows - 1;
               
                confirmation.ForeColor = Color.Green;
                confirmation.Text = "Racers imported Succesfully";
            }
            catch
            {
                confirmation.ForeColor = Color.Red;
                confirmation.Text = "Sheet Invalid or Excel File is open please close it";
            }
        }




        private void import_Click(object sender, EventArgs e)
        {
            readids();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Focus();
            this.Hide();
            
        }

     
        private void filename_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
        }
    } 
}
