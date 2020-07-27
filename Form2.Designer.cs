namespace Lap_Timer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Submit = new MetroFramework.Controls.MetroButton();
            this.Donebut = new MetroFramework.Controls.MetroButton();
            this.Export = new MetroFramework.Controls.MetroButton();
            this.Read = new MetroFramework.Controls.MetroButton();
            this.Weightlabel = new MetroFramework.Controls.MetroLabel();
            this.Weightbox = new MetroFramework.Controls.MetroTextBox();
            this.Heightlabel = new MetroFramework.Controls.MetroLabel();
            this.Heightbox = new MetroFramework.Controls.MetroTextBox();
            this.Agelabel = new MetroFramework.Controls.MetroLabel();
            this.Genderlabel = new MetroFramework.Controls.MetroLabel();
            this.Namelab = new MetroFramework.Controls.MetroLabel();
            this.FirstName = new MetroFramework.Controls.MetroTextBox();
            this.Genderbox = new MetroFramework.Controls.MetroComboBox();
            this.Lastname = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.filechoosebut = new MetroFramework.Controls.MetroButton();
            this.Confirmation = new MetroFramework.Controls.MetroLabel();
            this.Idbox = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.Photo = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(19, 462);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(174, 30);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Donebut
            // 
            this.Donebut.Location = new System.Drawing.Point(157, 507);
            this.Donebut.Name = "Donebut";
            this.Donebut.Size = new System.Drawing.Size(104, 30);
            this.Donebut.TabIndex = 3;
            this.Donebut.Text = "Done";
            this.Donebut.Click += new System.EventHandler(this.Donebut_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(220, 462);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(183, 30);
            this.Export.TabIndex = 5;
            this.Export.Text = "Export";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(220, 422);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(183, 34);
            this.Read.TabIndex = 27;
            this.Read.Text = "Start Reader";
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Weightlabel
            // 
            this.Weightlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Weightlabel.Location = new System.Drawing.Point(23, 343);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(141, 31);
            this.Weightlabel.TabIndex = 26;
            this.Weightlabel.Text = "Weight";
            this.Weightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weightbox
            // 
            this.Weightbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Weightbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Weightbox.Location = new System.Drawing.Point(158, 343);
            this.Weightbox.Name = "Weightbox";
            this.Weightbox.Size = new System.Drawing.Size(255, 31);
            this.Weightbox.TabIndex = 25;
            // 
            // Heightlabel
            // 
            this.Heightlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Heightlabel.Location = new System.Drawing.Point(23, 298);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(140, 31);
            this.Heightlabel.TabIndex = 24;
            this.Heightlabel.Text = "Height";
            this.Heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Heightbox
            // 
            this.Heightbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Heightbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Heightbox.Location = new System.Drawing.Point(159, 298);
            this.Heightbox.Name = "Heightbox";
            this.Heightbox.Size = new System.Drawing.Size(254, 31);
            this.Heightbox.TabIndex = 23;
            // 
            // Agelabel
            // 
            this.Agelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Agelabel.Location = new System.Drawing.Point(23, 256);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(140, 29);
            this.Agelabel.TabIndex = 22;
            this.Agelabel.Text = "Date Of Birth";
            this.Agelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Genderlabel
            // 
            this.Genderlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Genderlabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.Genderlabel.Location = new System.Drawing.Point(23, 208);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(140, 32);
            this.Genderlabel.TabIndex = 20;
            this.Genderlabel.Text = "Gender";
            this.Genderlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Namelab
            // 
            this.Namelab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Namelab.Location = new System.Drawing.Point(22, 78);
            this.Namelab.Name = "Namelab";
            this.Namelab.Size = new System.Drawing.Size(140, 30);
            this.Namelab.TabIndex = 17;
            this.Namelab.Text = "First name";
            this.Namelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstName
            // 
            this.FirstName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.FirstName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.FirstName.Location = new System.Drawing.Point(161, 78);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(252, 31);
            this.FirstName.TabIndex = 16;
            // 
            // Genderbox
            // 
            this.Genderbox.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.Genderbox.FormattingEnabled = true;
            this.Genderbox.ItemHeight = 29;
            this.Genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Genderbox.Location = new System.Drawing.Point(159, 207);
            this.Genderbox.Name = "Genderbox";
            this.Genderbox.Size = new System.Drawing.Size(254, 35);
            this.Genderbox.TabIndex = 28;
            // 
            // Lastname
            // 
            this.Lastname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Lastname.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Lastname.Location = new System.Drawing.Point(161, 122);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(252, 31);
            this.Lastname.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Last name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filechoosebut
            // 
            this.filechoosebut.Location = new System.Drawing.Point(18, 422);
            this.filechoosebut.Name = "filechoosebut";
            this.filechoosebut.Size = new System.Drawing.Size(174, 32);
            this.filechoosebut.TabIndex = 31;
            this.filechoosebut.Text = "Upload Picture";
            this.filechoosebut.Click += new System.EventHandler(this.filechoosebut_Click);
            // 
            // Confirmation
            // 
            this.Confirmation.Location = new System.Drawing.Point(10, 378);
            this.Confirmation.MaximumSize = new System.Drawing.Size(408, 41);
            this.Confirmation.MinimumSize = new System.Drawing.Size(408, 41);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(408, 41);
            this.Confirmation.TabIndex = 32;
            this.Confirmation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Idbox
            // 
            this.Idbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Idbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Idbox.Location = new System.Drawing.Point(161, 166);
            this.Idbox.Name = "Idbox";
            this.Idbox.Size = new System.Drawing.Size(252, 31);
            this.Idbox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(22, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Photo
            // 
            this.Photo.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 29);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(437, 571);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Idbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filechoosebut);
            this.Controls.Add(this.Weightbox);
            this.Controls.Add(this.Heightbox);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Genderbox);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Weightlabel);
            this.Controls.Add(this.Heightlabel);
            this.Controls.Add(this.Agelabel);
            this.Controls.Add(this.Genderlabel);
            this.Controls.Add(this.Namelab);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Donebut);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Confirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(439, 573);
            this.Name = "Form2";
            this.Resizable = false;
            this.Text = "Register Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton Submit;
        private MetroFramework.Controls.MetroButton Donebut;
        private MetroFramework.Controls.MetroButton Export;
        private MetroFramework.Controls.MetroLabel Weightlabel;
        private MetroFramework.Controls.MetroTextBox Weightbox;
        private MetroFramework.Controls.MetroLabel Heightlabel;
        private MetroFramework.Controls.MetroTextBox Heightbox;
        private MetroFramework.Controls.MetroLabel Agelabel;
        private MetroFramework.Controls.MetroLabel Genderlabel;
        private MetroFramework.Controls.MetroLabel Namelab;
        private MetroFramework.Controls.MetroTextBox FirstName;
        private MetroFramework.Controls.MetroComboBox Genderbox;
        private MetroFramework.Controls.MetroTextBox Lastname;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton filechoosebut;
        private MetroFramework.Controls.MetroLabel Confirmation;
        private MetroFramework.Controls.MetroTextBox Idbox;
        private MetroFramework.Controls.MetroLabel label2;
        private System.Windows.Forms.OpenFileDialog Photo;
        public  MetroFramework.Controls.MetroButton Read;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
    }
}