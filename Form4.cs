using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap_Timer
{
    public partial class Form4 : Form
    {
        string[] rank;
        string[] id;
        string[] lap;
        string[] current;
        string[] finish;
        int update=2;
        public Form4()
        {
            InitializeComponent();
            rank = new string[999];
            id = new string[999];
            lap = new string[999];
            current = new string[999];
            finish = new string[999];
            panel1.BackColor = Color.FromArgb(160, Color.Black);
            tableLayoutPanel1.BackColor = Color.FromArgb(125, Color.White);
            Timer.BackColor = Color.FromArgb(200, Color.White);
        }


        public string[] ranking
        {
            get
            {
                return this.rank;
            }
            set
            {
                this.rank = value;
            }
        }
        public string[] ids
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
             public string[] laps
        {
            get
            {
                return this.lap;
            }
            set
            {
                this.lap = value;
            }
        }
             public string[] currents
        {
            get
            {
                return this.current;
            }
            set
            {
                this.current = value;
            }
        }
        public string[] finishs
        {
            get
            {
                return this.finish;
            }
            set
            {
                this.finish = value;
            }
        }








        private void Form4_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
            FormBorderStyle = FormBorderStyle.None;
               WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout();
        }

  
   
        


        private void Updategui_Tick_1(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();
            for (int x = update; x > update-2; x--)
            {
                try
                {
                    this.tableLayoutPanel1.Controls["current" + x.ToString()].Text = current[x];
                    this.tableLayoutPanel1.Controls["finish" + x.ToString()].Text = finish[x];
                }
                catch { }


            }
            if (update < 10)
            {
                update += 2;
            }
            else
            {
                update = 2;
            }
            tableLayoutPanel1.ResumeLayout();
        }

       

        private void Idlabel_Click(object sender, EventArgs e)
        {

        }
    }

}
