namespace CityCharm
{
    partial class ReportIssuesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssuesForm));
            this.lblReportHeader = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.rTxtDescription = new System.Windows.Forms.RichTextBox();
            this.drpCategory = new System.Windows.Forms.ComboBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.prgssProgress = new System.Windows.Forms.ProgressBar();
            this.imgFile = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgFile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReportHeader.AutoSize = true;
            this.lblReportHeader.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportHeader.Location = new System.Drawing.Point(307, 9);
            this.lblReportHeader.Name = "lblReportHeader";
            this.lblReportHeader.Size = new System.Drawing.Size(196, 39);
            this.lblReportHeader.TabIndex = 0;
            this.lblReportHeader.Text = "Report Issues";
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(43, 76);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(60, 18);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(40, 142);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 18);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(463, 76);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 18);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // lblAttachment
            // 
            this.lblAttachment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(40, 271);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(79, 18);
            this.lblAttachment.TabIndex = 4;
            this.lblAttachment.Text = "Attachment";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(147, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackToMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToMain.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.Location = new System.Drawing.Point(326, 405);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(107, 33);
            this.btnBackToMain.TabIndex = 6;
            this.btnBackToMain.Text = "Back";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(533, 399);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 44);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocation.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(27, 101);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(325, 29);
            this.txtLocation.TabIndex = 8;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // rTxtDescription
            // 
            this.rTxtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rTxtDescription.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtDescription.Location = new System.Drawing.Point(455, 101);
            this.rTxtDescription.Name = "rTxtDescription";
            this.rTxtDescription.Size = new System.Drawing.Size(314, 237);
            this.rTxtDescription.TabIndex = 9;
            this.rTxtDescription.Text = "";
            this.rTxtDescription.TextChanged += new System.EventHandler(this.rTxtDescription_TextChanged);
            // 
            // drpCategory
            // 
            this.drpCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drpCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpCategory.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpCategory.FormattingEnabled = true;
            this.drpCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.drpCategory.Location = new System.Drawing.Point(27, 163);
            this.drpCategory.Name = "drpCategory";
            this.drpCategory.Size = new System.Drawing.Size(325, 30);
            this.drpCategory.TabIndex = 10;
            this.drpCategory.SelectedIndexChanged += new System.EventHandler(this.drpCategory_SelectedIndexChanged);
            // 
            // dpDate
            // 
            this.dpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dpDate.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate.Location = new System.Drawing.Point(27, 228);
            this.dpDate.MinDate = new System.DateTime(2024, 9, 10, 0, 0, 0, 0);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(325, 28);
            this.dpDate.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(40, 207);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 18);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // prgssProgress
            // 
            this.prgssProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prgssProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prgssProgress.Location = new System.Drawing.Point(27, 361);
            this.prgssProgress.Name = "prgssProgress";
            this.prgssProgress.Size = new System.Drawing.Size(742, 23);
            this.prgssProgress.Step = 20;
            this.prgssProgress.TabIndex = 13;
            // 
            // imgFile
            // 
            this.imgFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFile.Image = global::CityCharm.Properties.Resources.add;
            this.imgFile.Location = new System.Drawing.Point(27, 292);
            this.imgFile.Name = "imgFile";
            this.imgFile.Size = new System.Drawing.Size(261, 46);
            this.imgFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFile.TabIndex = 14;
            this.imgFile.TabStop = false;
            this.imgFile.Click += new System.EventHandler(this.imgFile_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrowse.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(285, 292);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 46);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.imgFile);
            this.Controls.Add(this.prgssProgress);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.drpCategory);
            this.Controls.Add(this.rTxtDescription);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblReportHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportIssuesForm";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportHeader;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RichTextBox rTxtDescription;
        private System.Windows.Forms.ComboBox drpCategory;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ProgressBar prgssProgress;
        private System.Windows.Forms.PictureBox imgFile;
        private System.Windows.Forms.Button btnBrowse;
    }
}