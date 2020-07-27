namespace Lap_Timer
{
    partial class Form3
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
            this.file = new System.Windows.Forms.OpenFileDialog();
            this.filechoosebut = new MetroFramework.Controls.MetroButton();
            this.filename = new MetroFramework.Controls.MetroLabel();
            this.sheetnamelab = new MetroFramework.Controls.MetroLabel();
            this.sheetname = new MetroFramework.Controls.MetroTextBox();
            this.confirmation = new MetroFramework.Controls.MetroLabel();
            this.import = new MetroFramework.Controls.MetroButton();
            this.Done = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.FileName = "openFileDialog1";
            this.file.FileOk += new System.ComponentModel.CancelEventHandler(this.file_FileOk);
            // 
            // filechoosebut
            // 
            this.filechoosebut.Location = new System.Drawing.Point(23, 89);
            this.filechoosebut.Name = "filechoosebut";
            this.filechoosebut.Size = new System.Drawing.Size(107, 32);
            this.filechoosebut.TabIndex = 1;
            this.filechoosebut.Text = "TAG FILE";
            this.filechoosebut.Click += new System.EventHandler(this.filechoosebut_Click);
            // 
            // filename
            // 
            this.filename.CustomBackground = true;
            this.filename.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.filename.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.filename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filename.Location = new System.Drawing.Point(129, 89);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(287, 32);
            this.filename.TabIndex = 3;
            this.filename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filename.Click += new System.EventHandler(this.filename_Click);
            // 
            // sheetnamelab
            // 
            this.sheetnamelab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.sheetnamelab.CustomBackground = true;
            this.sheetnamelab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sheetnamelab.Location = new System.Drawing.Point(23, 141);
            this.sheetnamelab.Name = "sheetnamelab";
            this.sheetnamelab.Size = new System.Drawing.Size(107, 31);
            this.sheetnamelab.TabIndex = 4;
            this.sheetnamelab.Text = "Sheet N.";
            this.sheetnamelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sheetname
            // 
            this.sheetname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.sheetname.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.sheetname.Location = new System.Drawing.Point(129, 141);
            this.sheetname.Name = "sheetname";
            this.sheetname.Size = new System.Drawing.Size(287, 29);
            this.sheetname.TabIndex = 5;
            this.sheetname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmation
            // 
            this.confirmation.CustomBackground = true;
            this.confirmation.Location = new System.Drawing.Point(57, 307);
            this.confirmation.MaximumSize = new System.Drawing.Size(415, 34);
            this.confirmation.MinimumSize = new System.Drawing.Size(415, 34);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(415, 34);
            this.confirmation.TabIndex = 6;
            this.confirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // import
            // 
            this.import.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.import.Location = new System.Drawing.Point(85, 264);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(130, 40);
            this.import.TabIndex = 7;
            this.import.Text = "Import";
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(251, 264);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(130, 40);
            this.Done.TabIndex = 8;
            this.Done.Text = "Done";
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CustomBackground = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(163, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "(leave empty to import last sheet)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(495, 361);
            this.ControlBox = false;
            this.Controls.Add(this.filechoosebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.import);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.sheetnamelab);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.sheetname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(16, 238);
            this.Name = "Form3";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Racers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog file;
        private MetroFramework.Controls.MetroButton filechoosebut;
        private MetroFramework.Controls.MetroLabel filename;
        private MetroFramework.Controls.MetroLabel sheetnamelab;
        private MetroFramework.Controls.MetroTextBox sheetname;
        private MetroFramework.Controls.MetroLabel confirmation;
        private MetroFramework.Controls.MetroButton import;
        private MetroFramework.Controls.MetroButton Done;
        private MetroFramework.Controls.MetroLabel label1;
    }
}