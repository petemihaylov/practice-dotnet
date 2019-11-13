namespace CookerApp
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dayOrders = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.timerListOreders = new System.Windows.Forms.Timer(this.components);
            this.btnTodayOrders = new System.Windows.Forms.Button();
            this.mytimer = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.btnStat = new System.Windows.Forms.Button();
            this.myport = new System.IO.Ports.SerialPort(this.components);
            this.lbCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dayOrders);
            this.panel3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(26, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 428);
            this.panel3.TabIndex = 2;
            // 
            // dayOrders
            // 
            this.dayOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOrders.FormattingEnabled = true;
            this.dayOrders.ItemHeight = 18;
            this.dayOrders.Location = new System.Drawing.Point(0, 0);
            this.dayOrders.Name = "dayOrders";
            this.dayOrders.Size = new System.Drawing.Size(222, 432);
            this.dayOrders.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(27, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Orders for the day";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(27, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 474);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 791);
            this.panel2.TabIndex = 18;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(47, 229);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(232, 10);
            this.progressBar.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CookerApp.Properties.Resources.background;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 211);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(27, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::CookerApp.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(208, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "COOK";
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.White;
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.Font = new System.Drawing.Font("Verdana", 13F);
            this.tbInfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbInfo.Location = new System.Drawing.Point(510, 51);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(594, 33);
            this.tbInfo.TabIndex = 22;
            this.tbInfo.Text = "select an order";
            this.tbInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(402, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(715, 1);
            this.panel5.TabIndex = 19;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label26.Location = new System.Drawing.Point(1205, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 29);
            this.label26.TabIndex = 26;
            this.label26.Text = "READY";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.Location = new System.Drawing.Point(393, 244);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 1);
            this.panel8.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(388, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "PIZZA LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(397, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "CURRENT";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CookerApp.Properties.Resources.check;
            this.pictureBox2.Location = new System.Drawing.Point(1154, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // listOrders
            // 
            this.listOrders.Font = new System.Drawing.Font("Verdana", 12F);
            this.listOrders.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listOrders.FormattingEnabled = true;
            this.listOrders.ItemHeight = 25;
            this.listOrders.Location = new System.Drawing.Point(393, 258);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(821, 454);
            this.listOrders.TabIndex = 27;
            // 
            // timerListOreders
            // 
            this.timerListOreders.Tick += new System.EventHandler(this.TimerListOreders_Tick);
            // 
            // btnTodayOrders
            // 
            this.btnTodayOrders.BackColor = System.Drawing.Color.SlateGray;
            this.btnTodayOrders.FlatAppearance.BorderSize = 0;
            this.btnTodayOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodayOrders.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodayOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTodayOrders.Location = new System.Drawing.Point(950, 744);
            this.btnTodayOrders.Name = "btnTodayOrders";
            this.btnTodayOrders.Size = new System.Drawing.Size(192, 35);
            this.btnTodayOrders.TabIndex = 3;
            this.btnTodayOrders.Text = "Done for Today";
            this.btnTodayOrders.UseVisualStyleBackColor = false;
            this.btnTodayOrders.Click += new System.EventHandler(this.BtnTodayOrders_Click);
            // 
            // mytimer
            // 
            this.mytimer.Enabled = true;
            this.mytimer.Tick += new System.EventHandler(this.Mytimer_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.time.Location = new System.Drawing.Point(742, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(104, 20);
            this.time.TabIndex = 28;
            this.time.Text = "00:00:00 HH";
            // 
            // btnStat
            // 
            this.btnStat.BackColor = System.Drawing.Color.SlateGray;
            this.btnStat.FlatAppearance.BorderSize = 0;
            this.btnStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStat.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStat.Location = new System.Drawing.Point(402, 744);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(192, 35);
            this.btnStat.TabIndex = 29;
            this.btnStat.Text = "Statistics";
            this.btnStat.UseVisualStyleBackColor = false;
            this.btnStat.Click += new System.EventHandler(this.BtnStat_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbCount.Location = new System.Drawing.Point(1171, 221);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(18, 20);
            this.lbCount.TabIndex = 31;
            this.lbCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(1057, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Finished Pizzas:";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1358, 791);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btnTodayOrders);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooker";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.Timer timerListOreders;
        private System.Windows.Forms.Button btnTodayOrders;
        private System.Windows.Forms.Timer mytimer;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ListBox dayOrders;
        private System.Windows.Forms.Button btnStat;
        private System.IO.Ports.SerialPort myport;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label5;
    }
}

