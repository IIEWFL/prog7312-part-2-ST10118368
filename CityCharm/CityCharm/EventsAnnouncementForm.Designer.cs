namespace CityCharm
{
    partial class EventsAnnouncementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsAnnouncementForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAnnouncementSearch = new System.Windows.Forms.GroupBox();
            this.btnAnnouncementSearch = new System.Windows.Forms.Button();
            this.dpAnnouncementSearch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnnouncementSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpEventSearch = new System.Windows.Forms.GroupBox();
            this.btnEventSearch = new System.Windows.Forms.Button();
            this.dpEventSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEventSearch = new System.Windows.Forms.ComboBox();
            this.lblEventSearch = new System.Windows.Forms.Label();
            this.tabEventsAnncouncements = new System.Windows.Forms.TabControl();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.dtEvents = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstAnnouncements = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEventsAnnouncements = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpAnnouncementSearch.SuspendLayout();
            this.grpEventSearch.SuspendLayout();
            this.tabEventsAnncouncements.SuspendLayout();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvents)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(48, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(224, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpAnnouncementSearch);
            this.panel1.Controls.Add(this.grpEventSearch);
            this.panel1.Controls.Add(this.tabEventsAnncouncements);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 424);
            this.panel1.TabIndex = 2;
            // 
            // grpAnnouncementSearch
            // 
            this.grpAnnouncementSearch.Controls.Add(this.btnAnnouncementSearch);
            this.grpAnnouncementSearch.Controls.Add(this.dpAnnouncementSearch);
            this.grpAnnouncementSearch.Controls.Add(this.label2);
            this.grpAnnouncementSearch.Controls.Add(this.cmbAnnouncementSearch);
            this.grpAnnouncementSearch.Controls.Add(this.label3);
            this.grpAnnouncementSearch.Location = new System.Drawing.Point(450, 248);
            this.grpAnnouncementSearch.Name = "grpAnnouncementSearch";
            this.grpAnnouncementSearch.Size = new System.Drawing.Size(340, 173);
            this.grpAnnouncementSearch.TabIndex = 2;
            this.grpAnnouncementSearch.TabStop = false;
            this.grpAnnouncementSearch.Text = "Announcement Search";
            // 
            // btnAnnouncementSearch
            // 
            this.btnAnnouncementSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAnnouncementSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncementSearch.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnnouncementSearch.Location = new System.Drawing.Point(201, 106);
            this.btnAnnouncementSearch.Name = "btnAnnouncementSearch";
            this.btnAnnouncementSearch.Size = new System.Drawing.Size(123, 50);
            this.btnAnnouncementSearch.TabIndex = 5;
            this.btnAnnouncementSearch.Text = "Search";
            this.btnAnnouncementSearch.UseVisualStyleBackColor = false;
            this.btnAnnouncementSearch.Click += new System.EventHandler(this.btnAnnouncementSearch_Click);
            // 
            // dpAnnouncementSearch
            // 
            this.dpAnnouncementSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpAnnouncementSearch.Location = new System.Drawing.Point(89, 71);
            this.dpAnnouncementSearch.Name = "dpAnnouncementSearch";
            this.dpAnnouncementSearch.Size = new System.Drawing.Size(245, 29);
            this.dpAnnouncementSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // cmbAnnouncementSearch
            // 
            this.cmbAnnouncementSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnnouncementSearch.FormattingEnabled = true;
            this.cmbAnnouncementSearch.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.cmbAnnouncementSearch.Location = new System.Drawing.Point(89, 15);
            this.cmbAnnouncementSearch.Name = "cmbAnnouncementSearch";
            this.cmbAnnouncementSearch.Size = new System.Drawing.Size(245, 34);
            this.cmbAnnouncementSearch.TabIndex = 2;
            this.cmbAnnouncementSearch.Text = "Select Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category";
            // 
            // grpEventSearch
            // 
            this.grpEventSearch.Controls.Add(this.btnEventSearch);
            this.grpEventSearch.Controls.Add(this.dpEventSearch);
            this.grpEventSearch.Controls.Add(this.label1);
            this.grpEventSearch.Controls.Add(this.cmbEventSearch);
            this.grpEventSearch.Controls.Add(this.lblEventSearch);
            this.grpEventSearch.Location = new System.Drawing.Point(7, 253);
            this.grpEventSearch.Name = "grpEventSearch";
            this.grpEventSearch.Size = new System.Drawing.Size(340, 168);
            this.grpEventSearch.TabIndex = 1;
            this.grpEventSearch.TabStop = false;
            this.grpEventSearch.Text = "Event Search";
            // 
            // btnEventSearch
            // 
            this.btnEventSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEventSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventSearch.ForeColor = System.Drawing.Color.Ivory;
            this.btnEventSearch.Location = new System.Drawing.Point(198, 106);
            this.btnEventSearch.Name = "btnEventSearch";
            this.btnEventSearch.Size = new System.Drawing.Size(123, 50);
            this.btnEventSearch.TabIndex = 6;
            this.btnEventSearch.Text = "Search";
            this.btnEventSearch.UseVisualStyleBackColor = false;
            this.btnEventSearch.Click += new System.EventHandler(this.btnEventSearch_Click);
            // 
            // dpEventSearch
            // 
            this.dpEventSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEventSearch.Location = new System.Drawing.Point(89, 71);
            this.dpEventSearch.Name = "dpEventSearch";
            this.dpEventSearch.Size = new System.Drawing.Size(245, 29);
            this.dpEventSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // cmbEventSearch
            // 
            this.cmbEventSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventSearch.FormattingEnabled = true;
            this.cmbEventSearch.Items.AddRange(new object[] {
            "Sport",
            "Arts"});
            this.cmbEventSearch.Location = new System.Drawing.Point(89, 15);
            this.cmbEventSearch.Name = "cmbEventSearch";
            this.cmbEventSearch.Size = new System.Drawing.Size(245, 34);
            this.cmbEventSearch.TabIndex = 2;
            this.cmbEventSearch.Text = "Select Category";
            // 
            // lblEventSearch
            // 
            this.lblEventSearch.AutoSize = true;
            this.lblEventSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventSearch.Location = new System.Drawing.Point(6, 18);
            this.lblEventSearch.Name = "lblEventSearch";
            this.lblEventSearch.Size = new System.Drawing.Size(86, 26);
            this.lblEventSearch.TabIndex = 1;
            this.lblEventSearch.Text = "Category";
            // 
            // tabEventsAnncouncements
            // 
            this.tabEventsAnncouncements.Controls.Add(this.tabEvents);
            this.tabEventsAnncouncements.Controls.Add(this.tabPage2);
            this.tabEventsAnncouncements.Location = new System.Drawing.Point(3, 3);
            this.tabEventsAnncouncements.Name = "tabEventsAnncouncements";
            this.tabEventsAnncouncements.SelectedIndex = 0;
            this.tabEventsAnncouncements.Size = new System.Drawing.Size(794, 243);
            this.tabEventsAnncouncements.TabIndex = 0;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.lstEvents);
            this.tabEvents.Controls.Add(this.dtEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(786, 217);
            this.tabEvents.TabIndex = 0;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(0, 0);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(783, 212);
            this.lstEvents.TabIndex = 1;
            // 
            // dtEvents
            // 
            this.dtEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEvents.Location = new System.Drawing.Point(0, 0);
            this.dtEvents.Name = "dtEvents";
            this.dtEvents.Size = new System.Drawing.Size(786, 217);
            this.dtEvents.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstAnnouncements);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Announcements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstAnnouncements
            // 
            this.lstAnnouncements.FormattingEnabled = true;
            this.lstAnnouncements.Location = new System.Drawing.Point(0, 0);
            this.lstAnnouncements.Name = "lstAnnouncements";
            this.lstAnnouncements.Size = new System.Drawing.Size(786, 212);
            this.lstAnnouncements.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CityCharm.Properties.Resources._3792321;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblEventsAnnouncements);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 56);
            this.panel2.TabIndex = 3;
            // 
            // lblEventsAnnouncements
            // 
            this.lblEventsAnnouncements.AutoSize = true;
            this.lblEventsAnnouncements.BackColor = System.Drawing.SystemColors.Info;
            this.lblEventsAnnouncements.Font = new System.Drawing.Font("Sitka Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsAnnouncements.ForeColor = System.Drawing.Color.Black;
            this.lblEventsAnnouncements.Location = new System.Drawing.Point(147, -7);
            this.lblEventsAnnouncements.Name = "lblEventsAnnouncements";
            this.lblEventsAnnouncements.Size = new System.Drawing.Size(590, 69);
            this.lblEventsAnnouncements.TabIndex = 0;
            this.lblEventsAnnouncements.Text = "Events and Announcements";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(578, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(224, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EventsAnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 542);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventsAnnouncementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events & Announcement";
            this.Load += new System.EventHandler(this.EventsAnnouncementForm_Load);
            this.panel1.ResumeLayout(false);
            this.grpAnnouncementSearch.ResumeLayout(false);
            this.grpAnnouncementSearch.PerformLayout();
            this.grpEventSearch.ResumeLayout(false);
            this.grpEventSearch.PerformLayout();
            this.tabEventsAnncouncements.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtEvents)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabEventsAnncouncements;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEventsAnnouncements;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtEvents;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.ListBox lstAnnouncements;
        private System.Windows.Forms.GroupBox grpEventSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEventSearch;
        private System.Windows.Forms.Label lblEventSearch;
        private System.Windows.Forms.DateTimePicker dpEventSearch;
        private System.Windows.Forms.GroupBox grpAnnouncementSearch;
        private System.Windows.Forms.Button btnAnnouncementSearch;
        private System.Windows.Forms.DateTimePicker dpAnnouncementSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnnouncementSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEventSearch;
    }
}