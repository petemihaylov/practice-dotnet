namespace MissionControl
{
    partial class MissionControlForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddAstronaut = new System.Windows.Forms.Button();
            this.cbAstronautGender = new System.Windows.Forms.ComboBox();
            this.tbAstronautNationality = new System.Windows.Forms.TextBox();
            this.tbAstronautName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLaunchDate = new System.Windows.Forms.DateTimePicker();
            this.btAddMission = new System.Windows.Forms.Button();
            this.tbSpaceship = new System.Windows.Forms.TextBox();
            this.tbMissionName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btAssign = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMissions = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAstronauts = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btShowAllMissions = new System.Windows.Forms.Button();
            this.lbMissions = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbAstronautDetails = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTravelCompanions = new System.Windows.Forms.ListBox();
            this.tbLongestMission = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDaysInSpace = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbMissionHistory = new System.Windows.Forms.ListBox();
            this.btShowAstronautDetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddAstronaut);
            this.groupBox1.Controls.Add(this.cbAstronautGender);
            this.groupBox1.Controls.Add(this.tbAstronautNationality);
            this.groupBox1.Controls.Add(this.tbAstronautName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(305, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add astronaut";
            // 
            // btAddAstronaut
            // 
            this.btAddAstronaut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddAstronaut.Location = new System.Drawing.Point(12, 132);
            this.btAddAstronaut.Margin = new System.Windows.Forms.Padding(4);
            this.btAddAstronaut.Name = "btAddAstronaut";
            this.btAddAstronaut.Size = new System.Drawing.Size(285, 28);
            this.btAddAstronaut.TabIndex = 9;
            this.btAddAstronaut.Text = "Add astronaut";
            this.btAddAstronaut.UseVisualStyleBackColor = true;
            this.btAddAstronaut.Click += new System.EventHandler(this.btAddAstronaut_Click);
            // 
            // cbAstronautGender
            // 
            this.cbAstronautGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAstronautGender.FormattingEnabled = true;
            this.cbAstronautGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cbAstronautGender.Location = new System.Drawing.Point(104, 64);
            this.cbAstronautGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbAstronautGender.Name = "cbAstronautGender";
            this.cbAstronautGender.Size = new System.Drawing.Size(192, 24);
            this.cbAstronautGender.TabIndex = 8;
            // 
            // tbAstronautNationality
            // 
            this.tbAstronautNationality.Location = new System.Drawing.Point(104, 100);
            this.tbAstronautNationality.Margin = new System.Windows.Forms.Padding(4);
            this.tbAstronautNationality.Name = "tbAstronautNationality";
            this.tbAstronautNationality.Size = new System.Drawing.Size(192, 22);
            this.tbAstronautNationality.TabIndex = 7;
            // 
            // tbAstronautName
            // 
            this.tbAstronautName.Location = new System.Drawing.Point(104, 34);
            this.tbAstronautName.Margin = new System.Windows.Forms.Padding(4);
            this.tbAstronautName.Name = "tbAstronautName";
            this.tbAstronautName.Size = new System.Drawing.Size(192, 22);
            this.tbAstronautName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpReturnDate);
            this.groupBox2.Controls.Add(this.dtpLaunchDate);
            this.groupBox2.Controls.Add(this.btAddMission);
            this.groupBox2.Controls.Add(this.tbSpaceship);
            this.groupBox2.Controls.Add(this.tbMissionName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(17, 250);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(305, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add mission";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(104, 105);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(189, 22);
            this.dtpReturnDate.TabIndex = 11;
            // 
            // dtpLaunchDate
            // 
            this.dtpLaunchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLaunchDate.Location = new System.Drawing.Point(104, 73);
            this.dtpLaunchDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLaunchDate.Name = "dtpLaunchDate";
            this.dtpLaunchDate.Size = new System.Drawing.Size(189, 22);
            this.dtpLaunchDate.TabIndex = 10;
            // 
            // btAddMission
            // 
            this.btAddMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddMission.Location = new System.Drawing.Point(12, 186);
            this.btAddMission.Margin = new System.Windows.Forms.Padding(4);
            this.btAddMission.Name = "btAddMission";
            this.btAddMission.Size = new System.Drawing.Size(285, 28);
            this.btAddMission.TabIndex = 9;
            this.btAddMission.Text = "Add mission";
            this.btAddMission.UseVisualStyleBackColor = true;
            this.btAddMission.Click += new System.EventHandler(this.btAddMission_Click);
            // 
            // tbSpaceship
            // 
            this.tbSpaceship.Location = new System.Drawing.Point(104, 138);
            this.tbSpaceship.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpaceship.Name = "tbSpaceship";
            this.tbSpaceship.Size = new System.Drawing.Size(192, 22);
            this.tbSpaceship.TabIndex = 7;
            // 
            // tbMissionName
            // 
            this.tbMissionName.Location = new System.Drawing.Point(104, 34);
            this.tbMissionName.Margin = new System.Windows.Forms.Padding(4);
            this.tbMissionName.Name = "tbMissionName";
            this.tbMissionName.Size = new System.Drawing.Size(192, 22);
            this.tbMissionName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Spaceship";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Return date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Launch date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btAssign);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbMissions);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbAstronauts);
            this.groupBox3.Location = new System.Drawing.Point(17, 575);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(305, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assign astronaut to mission";
            // 
            // btAssign
            // 
            this.btAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAssign.Location = new System.Drawing.Point(12, 105);
            this.btAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btAssign.Name = "btAssign";
            this.btAssign.Size = new System.Drawing.Size(285, 28);
            this.btAssign.TabIndex = 4;
            this.btAssign.Text = "Assign";
            this.btAssign.UseVisualStyleBackColor = true;
            this.btAssign.Click += new System.EventHandler(this.btAssign_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mission";
            // 
            // cbMissions
            // 
            this.cbMissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMissions.FormattingEnabled = true;
            this.cbMissions.Location = new System.Drawing.Point(85, 66);
            this.cbMissions.Margin = new System.Windows.Forms.Padding(4);
            this.cbMissions.Name = "cbMissions";
            this.cbMissions.Size = new System.Drawing.Size(211, 24);
            this.cbMissions.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Astronaut";
            // 
            // cbAstronauts
            // 
            this.cbAstronauts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAstronauts.FormattingEnabled = true;
            this.cbAstronauts.Location = new System.Drawing.Point(85, 33);
            this.cbAstronauts.Margin = new System.Windows.Forms.Padding(4);
            this.cbAstronauts.Name = "cbAstronauts";
            this.cbAstronauts.Size = new System.Drawing.Size(211, 24);
            this.cbAstronauts.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btShowAllMissions);
            this.groupBox4.Controls.Add(this.lbMissions);
            this.groupBox4.Location = new System.Drawing.Point(331, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(827, 314);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mission overview";
            // 
            // btShowAllMissions
            // 
            this.btShowAllMissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowAllMissions.Location = new System.Drawing.Point(9, 25);
            this.btShowAllMissions.Margin = new System.Windows.Forms.Padding(4);
            this.btShowAllMissions.Name = "btShowAllMissions";
            this.btShowAllMissions.Size = new System.Drawing.Size(180, 28);
            this.btShowAllMissions.TabIndex = 2;
            this.btShowAllMissions.Text = "Show all missions";
            this.btShowAllMissions.UseVisualStyleBackColor = true;
            this.btShowAllMissions.Click += new System.EventHandler(this.btShowAllMissions_Click);
            // 
            // lbMissions
            // 
            this.lbMissions.FormattingEnabled = true;
            this.lbMissions.ItemHeight = 16;
            this.lbMissions.Location = new System.Drawing.Point(9, 66);
            this.lbMissions.Margin = new System.Windows.Forms.Padding(4);
            this.lbMissions.Name = "lbMissions";
            this.lbMissions.Size = new System.Drawing.Size(808, 228);
            this.lbMissions.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbAstronautDetails);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lbTravelCompanions);
            this.groupBox5.Controls.Add(this.tbLongestMission);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.tbDaysInSpace);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lbMissionHistory);
            this.groupBox5.Controls.Add(this.btShowAstronautDetails);
            this.groupBox5.Location = new System.Drawing.Point(331, 337);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(827, 390);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Astronaut details";
            // 
            // cbAstronautDetails
            // 
            this.cbAstronautDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAstronautDetails.FormattingEnabled = true;
            this.cbAstronautDetails.Location = new System.Drawing.Point(13, 21);
            this.cbAstronautDetails.Margin = new System.Windows.Forms.Padding(4);
            this.cbAstronautDetails.Name = "cbAstronautDetails";
            this.cbAstronautDetails.Size = new System.Drawing.Size(211, 24);
            this.cbAstronautDetails.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 263);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Travelled with:";
            // 
            // lbTravelCompanions
            // 
            this.lbTravelCompanions.FormattingEnabled = true;
            this.lbTravelCompanions.ItemHeight = 16;
            this.lbTravelCompanions.Location = new System.Drawing.Point(9, 287);
            this.lbTravelCompanions.Margin = new System.Windows.Forms.Padding(4);
            this.lbTravelCompanions.Name = "lbTravelCompanions";
            this.lbTravelCompanions.Size = new System.Drawing.Size(808, 84);
            this.lbTravelCompanions.TabIndex = 7;
            // 
            // tbLongestMission
            // 
            this.tbLongestMission.Location = new System.Drawing.Point(153, 222);
            this.tbLongestMission.Margin = new System.Windows.Forms.Padding(4);
            this.tbLongestMission.Name = "tbLongestMission";
            this.tbLongestMission.Size = new System.Drawing.Size(156, 22);
            this.tbLongestMission.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 225);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Longest mission:";
            // 
            // tbDaysInSpace
            // 
            this.tbDaysInSpace.Location = new System.Drawing.Point(153, 193);
            this.tbDaysInSpace.Margin = new System.Windows.Forms.Padding(4);
            this.tbDaysInSpace.Name = "tbDaysInSpace";
            this.tbDaysInSpace.Size = new System.Drawing.Size(156, 22);
            this.tbDaysInSpace.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total days in space:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 66);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mission history";
            // 
            // lbMissionHistory
            // 
            this.lbMissionHistory.FormattingEnabled = true;
            this.lbMissionHistory.ItemHeight = 16;
            this.lbMissionHistory.Location = new System.Drawing.Point(9, 90);
            this.lbMissionHistory.Margin = new System.Windows.Forms.Padding(4);
            this.lbMissionHistory.Name = "lbMissionHistory";
            this.lbMissionHistory.Size = new System.Drawing.Size(808, 84);
            this.lbMissionHistory.TabIndex = 1;
            // 
            // btShowAstronautDetails
            // 
            this.btShowAstronautDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowAstronautDetails.Location = new System.Drawing.Point(247, 18);
            this.btShowAstronautDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btShowAstronautDetails.Name = "btShowAstronautDetails";
            this.btShowAstronautDetails.Size = new System.Drawing.Size(256, 28);
            this.btShowAstronautDetails.TabIndex = 0;
            this.btShowAstronautDetails.Text = "Show astronaut details";
            this.btShowAstronautDetails.UseVisualStyleBackColor = true;
            this.btShowAstronautDetails.Click += new System.EventHandler(this.btShowAstronautDetails_Click);
            // 
            // MissionControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 775);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MissionControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mission Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddAstronaut;
        private System.Windows.Forms.ComboBox cbAstronautGender;
        private System.Windows.Forms.TextBox tbAstronautNationality;
        private System.Windows.Forms.TextBox tbAstronautName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpLaunchDate;
        private System.Windows.Forms.Button btAddMission;
        private System.Windows.Forms.TextBox tbSpaceship;
        private System.Windows.Forms.TextBox tbMissionName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAssign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMissions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAstronauts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btShowAllMissions;
        private System.Windows.Forms.ListBox lbMissions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbLongestMission;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDaysInSpace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbMissionHistory;
        private System.Windows.Forms.Button btShowAstronautDetails;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbTravelCompanions;
        private System.Windows.Forms.ComboBox cbAstronautDetails;
    }
}

