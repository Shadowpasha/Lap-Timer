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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Submit = new System.Windows.Forms.Button();
            this.Donebut = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.Weightbox = new System.Windows.Forms.TextBox();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.Heightbox = new System.Windows.Forms.TextBox();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.Topic = new System.Windows.Forms.Label();
            this.Namelab = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Genderbox = new System.Windows.Forms.ComboBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filechoosebut = new System.Windows.Forms.Button();
            this.Confirmation = new System.Windows.Forms.Label();
            this.Idbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Photo = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Location = new System.Drawing.Point(16, 409);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(174, 30);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Donebut
            // 
            this.Donebut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Donebut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Donebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Donebut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Donebut.Location = new System.Drawing.Point(154, 449);
            this.Donebut.Name = "Donebut";
            this.Donebut.Size = new System.Drawing.Size(104, 30);
            this.Donebut.TabIndex = 3;
            this.Donebut.Text = "Done";
            this.Donebut.UseCompatibleTextRendering = true;
            this.Donebut.UseVisualStyleBackColor = false;
            this.Donebut.Click += new System.EventHandler(this.Donebut_Click);
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Export.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Export.Location = new System.Drawing.Point(226, 409);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(183, 30);
            this.Export.TabIndex = 5;
            this.Export.Text = "Export";
            this.Export.UseCompatibleTextRendering = true;
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Read.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Read.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Read.Location = new System.Drawing.Point(226, 369);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(183, 34);
            this.Read.TabIndex = 27;
            this.Read.Text = "Start Reader";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Weightlabel
            // 
            this.Weightlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Weightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Weightlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Weightlabel.Location = new System.Drawing.Point(15, 323);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(151, 31);
            this.Weightlabel.TabIndex = 26;
            this.Weightlabel.Text = "Weight";
            this.Weightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weightbox
            // 
            this.Weightbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.Weightbox.Location = new System.Drawing.Point(154, 323);
            this.Weightbox.Name = "Weightbox";
            this.Weightbox.Size = new System.Drawing.Size(255, 31);
            this.Weightbox.TabIndex = 25;
            // 
            // Heightlabel
            // 
            this.Heightlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Heightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Heightlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Heightlabel.Location = new System.Drawing.Point(16, 278);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(151, 31);
            this.Heightlabel.TabIndex = 24;
            this.Heightlabel.Text = "Height";
            this.Heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Heightbox
            // 
            this.Heightbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.Heightbox.Location = new System.Drawing.Point(155, 278);
            this.Heightbox.Name = "Heightbox";
            this.Heightbox.Size = new System.Drawing.Size(254, 31);
            this.Heightbox.TabIndex = 23;
            // 
            // Agelabel
            // 
            this.Agelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Agelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Agelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Agelabel.Location = new System.Drawing.Point(16, 236);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(153, 29);
            this.Agelabel.TabIndex = 22;
            this.Agelabel.Text = "Date Of Birth";
            this.Agelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Genderlabel
            // 
            this.Genderlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Genderlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Genderlabel.Location = new System.Drawing.Point(16, 189);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(151, 32);
            this.Genderlabel.TabIndex = 20;
            this.Genderlabel.Text = "Gender";
            this.Genderlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Topic
            // 
            this.Topic.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Topic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Topic.Location = new System.Drawing.Point(-4, -1);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(432, 36);
            this.Topic.TabIndex = 18;
            this.Topic.Text = "Registeration Form";
            this.Topic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Namelab
            // 
            this.Namelab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Namelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Namelab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Namelab.Location = new System.Drawing.Point(16, 58);
            this.Namelab.Name = "Namelab";
            this.Namelab.Size = new System.Drawing.Size(151, 30);
            this.Namelab.TabIndex = 17;
            this.Namelab.Text = "First name";
            this.Namelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.FirstName.Location = new System.Drawing.Point(157, 58);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(252, 31);
            this.FirstName.TabIndex = 16;
            // 
            // Genderbox
            // 
            this.Genderbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderbox.FormattingEnabled = true;
            this.Genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Genderbox.Location = new System.Drawing.Point(155, 189);
            this.Genderbox.Name = "Genderbox";
            this.Genderbox.Size = new System.Drawing.Size(254, 32);
            this.Genderbox.TabIndex = 28;
            // 
            // Lastname
            // 
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.Lastname.Location = new System.Drawing.Point(157, 101);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(252, 31);
            this.Lastname.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Last name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filechoosebut
            // 
            this.filechoosebut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.filechoosebut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filechoosebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.filechoosebut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filechoosebut.Location = new System.Drawing.Point(16, 369);
            this.filechoosebut.Name = "filechoosebut";
            this.filechoosebut.Size = new System.Drawing.Size(174, 32);
            this.filechoosebut.TabIndex = 31;
            this.filechoosebut.Text = "Upload Picture";
            this.filechoosebut.UseVisualStyleBackColor = false;
            this.filechoosebut.Click += new System.EventHandler(this.filechoosebut_Click);
            // 
            // Confirmation
            // 
            this.Confirmation.BackColor = System.Drawing.Color.Transparent;
            this.Confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmation.Location = new System.Drawing.Point(8, 482);
            this.Confirmation.MaximumSize = new System.Drawing.Size(408, 41);
            this.Confirmation.MinimumSize = new System.Drawing.Size(408, 41);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(408, 41);
            this.Confirmation.TabIndex = 32;
            this.Confirmation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Idbox
            // 
            this.Idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.Idbox.Location = new System.Drawing.Point(157, 146);
            this.Idbox.Name = "Idbox";
            this.Idbox.Size = new System.Drawing.Size(252, 31);
            this.Idbox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 29);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(423, 534);
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
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.Namelab);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Donebut);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Confirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(439, 573);
            this.MinimumSize = new System.Drawing.Size(439, 573);
            this.Name = "Form2";
            this.Text = "Register Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Donebut;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.TextBox Weightbox;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.TextBox Heightbox;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.Label Genderlabel;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Label Namelab;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.ComboBox Genderbox;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filechoosebut;
        private System.Windows.Forms.Label Confirmation;
        private System.Windows.Forms.TextBox Idbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog Photo;
        public System.Windows.Forms.Button Read;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}