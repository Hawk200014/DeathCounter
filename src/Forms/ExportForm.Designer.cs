﻿namespace DeathCounterHotkey.Forms
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            filterDeathGameCombo = new ComboBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            DeathsExportBtn = new Button();
            deathExportFormatCombo = new ComboBox();
            deathEntriesTB = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            filterDeathDateCombo = new ComboBox();
            filterDeathLocationCombo = new ComboBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            markerExportFormatCombo = new ComboBox();
            markerExportBtn = new Button();
            MarkerEntriesTB = new TextBox();
            label7 = new Label();
            groupBox4 = new GroupBox();
            label9 = new Label();
            filterMarkerSessionCombo = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            filterMarkerGameCombo = new ComboBox();
            filterMarkerDateCombo = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // filterDeathGameCombo
            // 
            filterDeathGameCombo.BackColor = SystemColors.ControlDark;
            filterDeathGameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterDeathGameCombo.FlatStyle = FlatStyle.Flat;
            filterDeathGameCombo.FormattingEnabled = true;
            filterDeathGameCombo.Location = new Point(203, 20);
            filterDeathGameCombo.Name = "filterDeathGameCombo";
            filterDeathGameCombo.Size = new Size(244, 28);
            filterDeathGameCombo.TabIndex = 0;
            filterDeathGameCombo.SelectedIndexChanged += filterDeathGameCombo_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(DeathsExportBtn);
            groupBox1.Controls.Add(deathExportFormatCombo);
            groupBox1.Controls.Add(deathEntriesTB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 269);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Export Deaths";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 197);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 11;
            label8.Text = "Export Format";
            // 
            // DeathsExportBtn
            // 
            DeathsExportBtn.BackColor = SystemColors.ControlDark;
            DeathsExportBtn.FlatStyle = FlatStyle.Flat;
            DeathsExportBtn.Location = new Point(360, 227);
            DeathsExportBtn.Name = "DeathsExportBtn";
            DeathsExportBtn.Size = new Size(94, 29);
            DeathsExportBtn.TabIndex = 10;
            DeathsExportBtn.Text = "Export";
            DeathsExportBtn.UseVisualStyleBackColor = false;
            DeathsExportBtn.Click += DeathsExportBtn_Click;
            // 
            // deathExportFormatCombo
            // 
            deathExportFormatCombo.BackColor = SystemColors.ControlDark;
            deathExportFormatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            deathExportFormatCombo.FlatStyle = FlatStyle.Flat;
            deathExportFormatCombo.FormattingEnabled = true;
            deathExportFormatCombo.Location = new Point(210, 193);
            deathExportFormatCombo.Name = "deathExportFormatCombo";
            deathExportFormatCombo.Size = new Size(244, 28);
            deathExportFormatCombo.TabIndex = 6;
            // 
            // deathEntriesTB
            // 
            deathEntriesTB.BackColor = SystemColors.ControlDark;
            deathEntriesTB.Location = new Point(210, 160);
            deathEntriesTB.Name = "deathEntriesTB";
            deathEntriesTB.ReadOnly = true;
            deathEntriesTB.Size = new Size(244, 27);
            deathEntriesTB.TabIndex = 9;
            deathEntriesTB.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 163);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 7;
            label6.Text = "Found Entries:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(filterDeathGameCombo);
            groupBox2.Controls.Add(filterDeathDateCombo);
            groupBox2.Controls.Add(filterDeathLocationCombo);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(6, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 128);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 91);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // filterDeathDateCombo
            // 
            filterDeathDateCombo.BackColor = SystemColors.ControlDark;
            filterDeathDateCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterDeathDateCombo.FlatStyle = FlatStyle.Flat;
            filterDeathDateCombo.FormattingEnabled = true;
            filterDeathDateCombo.Location = new Point(203, 88);
            filterDeathDateCombo.Name = "filterDeathDateCombo";
            filterDeathDateCombo.Size = new Size(244, 28);
            filterDeathDateCombo.TabIndex = 4;
            filterDeathDateCombo.SelectedIndexChanged += filterDeathDateCombo_SelectedIndexChanged;
            // 
            // filterDeathLocationCombo
            // 
            filterDeathLocationCombo.BackColor = SystemColors.ControlDark;
            filterDeathLocationCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterDeathLocationCombo.FlatStyle = FlatStyle.Flat;
            filterDeathLocationCombo.FormattingEnabled = true;
            filterDeathLocationCombo.Location = new Point(203, 53);
            filterDeathLocationCombo.Name = "filterDeathLocationCombo";
            filterDeathLocationCombo.Size = new Size(244, 28);
            filterDeathLocationCombo.TabIndex = 2;
            filterDeathLocationCombo.SelectedIndexChanged += filterDeathLocationCombo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Location";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(markerExportFormatCombo);
            groupBox3.Controls.Add(markerExportBtn);
            groupBox3.Controls.Add(MarkerEntriesTB);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(469, 269);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Export Marker";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 197);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 14;
            label10.Text = "Export Format";
            // 
            // markerExportFormatCombo
            // 
            markerExportFormatCombo.BackColor = SystemColors.ControlDark;
            markerExportFormatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            markerExportFormatCombo.FlatStyle = FlatStyle.Flat;
            markerExportFormatCombo.FormattingEnabled = true;
            markerExportFormatCombo.Location = new Point(210, 193);
            markerExportFormatCombo.Name = "markerExportFormatCombo";
            markerExportFormatCombo.Size = new Size(244, 28);
            markerExportFormatCombo.TabIndex = 13;
            // 
            // markerExportBtn
            // 
            markerExportBtn.BackColor = SystemColors.ControlDark;
            markerExportBtn.FlatStyle = FlatStyle.Flat;
            markerExportBtn.Location = new Point(360, 227);
            markerExportBtn.Name = "markerExportBtn";
            markerExportBtn.Size = new Size(94, 29);
            markerExportBtn.TabIndex = 12;
            markerExportBtn.Text = "Export";
            markerExportBtn.UseVisualStyleBackColor = false;
            markerExportBtn.Click += markerExportBtn_Click;
            // 
            // MarkerEntriesTB
            // 
            MarkerEntriesTB.BackColor = SystemColors.ControlDark;
            MarkerEntriesTB.Location = new Point(210, 160);
            MarkerEntriesTB.Name = "MarkerEntriesTB";
            MarkerEntriesTB.ReadOnly = true;
            MarkerEntriesTB.Size = new Size(244, 27);
            MarkerEntriesTB.TabIndex = 10;
            MarkerEntriesTB.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 163);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 8;
            label7.Text = "Found Entries:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(filterMarkerSessionCombo);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(filterMarkerGameCombo);
            groupBox4.Controls.Add(filterMarkerDateCombo);
            groupBox4.Location = new Point(6, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(456, 128);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filter";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 91);
            label9.Name = "label9";
            label9.Size = new Size(130, 20);
            label9.TabIndex = 7;
            label9.Text = "Recording Session";
            // 
            // filterMarkerSessionCombo
            // 
            filterMarkerSessionCombo.BackColor = SystemColors.ControlDark;
            filterMarkerSessionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterMarkerSessionCombo.FlatStyle = FlatStyle.Flat;
            filterMarkerSessionCombo.FormattingEnabled = true;
            filterMarkerSessionCombo.Location = new Point(203, 88);
            filterMarkerSessionCombo.Name = "filterMarkerSessionCombo";
            filterMarkerSessionCombo.Size = new Size(244, 28);
            filterMarkerSessionCombo.TabIndex = 6;
            filterMarkerSessionCombo.SelectedIndexChanged += filterMarkerSessionCombo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 1;
            label4.Text = "Game";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 57);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 5;
            label5.Text = "Date";
            // 
            // filterMarkerGameCombo
            // 
            filterMarkerGameCombo.BackColor = SystemColors.ControlDark;
            filterMarkerGameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterMarkerGameCombo.FlatStyle = FlatStyle.Flat;
            filterMarkerGameCombo.FormattingEnabled = true;
            filterMarkerGameCombo.Location = new Point(203, 20);
            filterMarkerGameCombo.Name = "filterMarkerGameCombo";
            filterMarkerGameCombo.Size = new Size(244, 28);
            filterMarkerGameCombo.TabIndex = 0;
            filterMarkerGameCombo.SelectedIndexChanged += filterMarkerGameCombo_SelectedIndexChanged;
            // 
            // filterMarkerDateCombo
            // 
            filterMarkerDateCombo.BackColor = SystemColors.ControlDark;
            filterMarkerDateCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterMarkerDateCombo.FlatStyle = FlatStyle.Flat;
            filterMarkerDateCombo.FormattingEnabled = true;
            filterMarkerDateCombo.Location = new Point(203, 53);
            filterMarkerDateCombo.Name = "filterMarkerDateCombo";
            filterMarkerDateCombo.Size = new Size(244, 28);
            filterMarkerDateCombo.TabIndex = 4;
            filterMarkerDateCombo.SelectedIndexChanged += filterMarkerDateCombo_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(491, 316);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlDarkDark;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(483, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Deaths";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlDarkDark;
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(483, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Marker";
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(513, 337);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExportForm";
            Text = "FallenTally - Export";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox filterDeathGameCombo;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox filterDeathDateCombo;
        private Label label2;
        private ComboBox filterDeathLocationCombo;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private GroupBox groupBox4;
        private Label label4;
        private Label label5;
        private ComboBox filterMarkerGameCombo;
        private ComboBox filterMarkerDateCombo;
        private TextBox deathEntriesTB;
        private Label label8;
        private Button DeathsExportBtn;
        private ComboBox deathExportFormatCombo;
        private Button markerExportBtn;
        private TextBox MarkerEntriesTB;
        private Label label9;
        private ComboBox filterMarkerSessionCombo;
        private Label label10;
        private ComboBox markerExportFormatCombo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}