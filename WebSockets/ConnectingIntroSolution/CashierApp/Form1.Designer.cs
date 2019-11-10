namespace CashierApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.btnAsc = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.totalPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.itemsCount = new System.Windows.Forms.Label();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.timerListOrder = new System.Windows.Forms.Timer(this.components);
            this.selectedPizza = new System.Windows.Forms.TextBox();
            this.cmbSIzes = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.mytimer = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAsc
            // 
            this.btnAsc.BackColor = System.Drawing.Color.DarkGray;
            this.btnAsc.FlatAppearance.BorderSize = 0;
            this.btnAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsc.Location = new System.Drawing.Point(363, 12);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(58, 33);
            this.btnAsc.TabIndex = 120;
            this.btnAsc.Text = "Asc ";
            this.btnAsc.UseVisualStyleBackColor = false;
            this.btnAsc.Click += new System.EventHandler(this.BtnAsc_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.Location = new System.Drawing.Point(331, 78);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(467, 692);
            this.dataGridView.TabIndex = 119;
            this.dataGridView.TabStop = false;
            this.dataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totalPrice.Location = new System.Drawing.Point(1051, 22);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(0, 25);
            this.totalPrice.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(911, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label14.Location = new System.Drawing.Point(905, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 29);
            this.label14.TabIndex = 12;
            this.label14.Text = "TOTAL PRICE:";
            // 
            // itemsCount
            // 
            this.itemsCount.AutoSize = true;
            this.itemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.itemsCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.itemsCount.Location = new System.Drawing.Point(979, 648);
            this.itemsCount.Name = "itemsCount";
            this.itemsCount.Size = new System.Drawing.Size(18, 20);
            this.itemsCount.TabIndex = 12;
            this.itemsCount.Text = "0";
            // 
            // listOrders
            // 
            this.listOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrders.Font = new System.Drawing.Font("Verdana", 8F);
            this.listOrders.FormattingEnabled = true;
            this.listOrders.ItemHeight = 16;
            this.listOrders.Location = new System.Drawing.Point(921, 353);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(260, 288);
            this.listOrders.TabIndex = 11;
            // 
            // btnDesc
            // 
            this.btnDesc.BackColor = System.Drawing.Color.DarkGray;
            this.btnDesc.FlatAppearance.BorderSize = 0;
            this.btnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesc.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesc.Location = new System.Drawing.Point(443, 12);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(55, 33);
            this.btnDesc.TabIndex = 114;
            this.btnDesc.Text = "Desc";
            this.btnDesc.UseVisualStyleBackColor = false;
            this.btnDesc.Click += new System.EventHandler(this.BtnDesc_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 791);
            this.panel1.TabIndex = 115;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(42, 352);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 288);
            this.listBox1.TabIndex = 126;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CashierApp.Properties.Resources.background;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 225);
            this.panel2.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.BackgroundImage = global::CashierApp.Properties.Resources.person;
            this.picBox.Image = global::CashierApp.Properties.Resources.person;
            this.picBox.Location = new System.Drawing.Point(183, 17);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(64, 69);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(28, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "CASHIER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(918, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "items:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(921, 336);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 1);
            this.panel8.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(916, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "CURENT ORDER";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.LightGray;
            this.panel18.Location = new System.Drawing.Point(331, 51);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(900, 1);
            this.panel18.TabIndex = 118;
            // 
            // timerListOrder
            // 
            this.timerListOrder.Enabled = true;
            this.timerListOrder.Tick += new System.EventHandler(this.TimerListOrder_Tick);
            // 
            // selectedPizza
            // 
            this.selectedPizza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedPizza.Font = new System.Drawing.Font("Verdana", 10F);
            this.selectedPizza.ForeColor = System.Drawing.Color.DimGray;
            this.selectedPizza.Location = new System.Drawing.Point(911, 106);
            this.selectedPizza.Multiline = true;
            this.selectedPizza.Name = "selectedPizza";
            this.selectedPizza.Size = new System.Drawing.Size(270, 29);
            this.selectedPizza.TabIndex = 121;
            this.selectedPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSIzes
            // 
            this.cmbSIzes.FormattingEnabled = true;
            this.cmbSIzes.Location = new System.Drawing.Point(910, 172);
            this.cmbSIzes.Name = "cmbSIzes";
            this.cmbSIzes.Size = new System.Drawing.Size(121, 24);
            this.cmbSIzes.TabIndex = 122;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtPrice.Location = new System.Drawing.Point(1061, 172);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 24);
            this.txtPrice.TabIndex = 123;
            this.txtPrice.Text = "9.99 ";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(615, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSend.Location = new System.Drawing.Point(783, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(117, 34);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(287, 717);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 74);
            this.panel3.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F);
            this.label4.Location = new System.Drawing.Point(1154, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 124;
            this.label4.Text = "$";
            // 
            // mytimer
            // 
            this.mytimer.Enabled = true;
            this.mytimer.Tick += new System.EventHandler(this.Mytimer_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.time.Location = new System.Drawing.Point(703, 22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(93, 20);
            this.time.TabIndex = 125;
            this.time.Text = "00:00 HH";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 791);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.itemsCount);
            this.Controls.Add(this.cmbSIzes);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.selectedPizza);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.CashierApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label itemsCount;
        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Timer timerListOrder;
        private System.Windows.Forms.TextBox selectedPizza;
        private System.Windows.Forms.ComboBox cmbSIzes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer mytimer;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ListBox listBox1;
    }
}

