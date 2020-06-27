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
            this.filechoosebut = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.Label();
            this.sheetnamelab = new System.Windows.Forms.Label();
            this.sheetname = new System.Windows.Forms.TextBox();
            this.confirmation = new System.Windows.Forms.Label();
            this.import = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.FileName = "openFileDialog1";
            this.file.FileOk += new System.ComponentModel.CancelEventHandler(this.file_FileOk);
            // 
            // filechoosebut
            // 
            this.filechoosebut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.filechoosebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filechoosebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.filechoosebut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filechoosebut.Location = new System.Drawing.Point(13, 15);
            this.filechoosebut.Name = "filechoosebut";
            this.filechoosebut.Size = new System.Drawing.Size(107, 32);
            this.filechoosebut.TabIndex = 1;
            this.filechoosebut.Text = "TAG FILE";
            this.filechoosebut.UseVisualStyleBackColor = false;
            this.filechoosebut.Click += new System.EventHandler(this.filechoosebut_Click);
            // 
            // filename
            // 
            this.filename.BackColor = System.Drawing.Color.White;
            this.filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.filename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filename.Location = new System.Drawing.Point(121, 15);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(287, 32);
            this.filename.TabIndex = 3;
            this.filename.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.filename.Click += new System.EventHandler(this.filename_Click);
            // 
            // sheetnamelab
            // 
            this.sheetnamelab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sheetnamelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.sheetnamelab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sheetnamelab.Location = new System.Drawing.Point(13, 51);
            this.sheetnamelab.Name = "sheetnamelab";
            this.sheetnamelab.Size = new System.Drawing.Size(107, 31);
            this.sheetnamelab.TabIndex = 4;
            this.sheetnamelab.Text = "Sheet N.";
            this.sheetnamelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sheetname
            // 
            this.sheetname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sheetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.sheetname.Location = new System.Drawing.Point(121, 52);
            this.sheetname.Name = "sheetname";
            this.sheetname.Size = new System.Drawing.Size(287, 29);
            this.sheetname.TabIndex = 5;
            // 
            // confirmation
            // 
            this.confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmation.Location = new System.Drawing.Point(5, 154);
            this.confirmation.MaximumSize = new System.Drawing.Size(415, 34);
            this.confirmation.MinimumSize = new System.Drawing.Size(415, 34);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(415, 34);
            this.confirmation.TabIndex = 6;
            this.confirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.SystemColors.ControlLight;
            this.import.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.import.Location = new System.Drawing.Point(80, 106);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(130, 40);
            this.import.TabIndex = 7;
            this.import.Text = "Import";
            this.import.UseVisualStyleBackColor = false;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Done.Location = new System.Drawing.Point(208, 106);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(130, 40);
            this.Done.TabIndex = 8;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "(leave empty to import last sheet)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(422, 199);
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
            this.MaximumSize = new System.Drawing.Size(438, 238);
            this.MinimumSize = new System.Drawing.Size(438, 238);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog file;
        private System.Windows.Forms.Button filechoosebut;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Label sheetnamelab;
        private System.Windows.Forms.TextBox sheetname;
        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label1;
    }
}