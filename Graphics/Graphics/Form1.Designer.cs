namespace GraphicsApp
{
    partial class Form1
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
            this.Navbar = new System.Windows.Forms.Panel();
            this.btnGO = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lines = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRECT = new System.Windows.Forms.Button();
            this.btnCIRC = new System.Windows.Forms.Button();
            this.Navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Navbar.Controls.Add(this.btnCIRC);
            this.Navbar.Controls.Add(this.btnRECT);
            this.Navbar.Controls.Add(this.btnGO);
            this.Navbar.Controls.Add(this.txtLength);
            this.Navbar.Controls.Add(this.txtCount);
            this.Navbar.Controls.Add(this.label2);
            this.Navbar.Controls.Add(this.lines);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1189, 71);
            this.Navbar.TabIndex = 0;
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGO.FlatAppearance.BorderSize = 0;
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.ForeColor = System.Drawing.Color.White;
            this.btnGO.Location = new System.Drawing.Point(1066, 17);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(90, 38);
            this.btnGO.TabIndex = 8;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(311, 24);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 6;
            this.txtLength.Text = "100";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(81, 25);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 22);
            this.txtCount.TabIndex = 4;
            this.txtCount.Text = "1";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "LENGTH";
            // 
            // lines
            // 
            this.lines.AutoSize = true;
            this.lines.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lines.ForeColor = System.Drawing.Color.White;
            this.lines.Location = new System.Drawing.Point(12, 27);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(64, 19);
            this.lines.TabIndex = 0;
            this.lines.Text = "COUNT";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 71);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1189, 646);
            this.Canvas.TabIndex = 1;
            // 
            // btnRECT
            // 
            this.btnRECT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRECT.FlatAppearance.BorderSize = 0;
            this.btnRECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRECT.ForeColor = System.Drawing.Color.White;
            this.btnRECT.Location = new System.Drawing.Point(872, 17);
            this.btnRECT.Name = "btnRECT";
            this.btnRECT.Size = new System.Drawing.Size(90, 38);
            this.btnRECT.TabIndex = 9;
            this.btnRECT.Text = "RECT";
            this.btnRECT.UseVisualStyleBackColor = false;
            this.btnRECT.Click += new System.EventHandler(this.btnRECT_Click);
            // 
            // btnCIRC
            // 
            this.btnCIRC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCIRC.FlatAppearance.BorderSize = 0;
            this.btnCIRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCIRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIRC.ForeColor = System.Drawing.Color.White;
            this.btnCIRC.Location = new System.Drawing.Point(675, 17);
            this.btnCIRC.Name = "btnCIRC";
            this.btnCIRC.Size = new System.Drawing.Size(90, 38);
            this.btnCIRC.TabIndex = 10;
            this.btnCIRC.Text = "CIRC";
            this.btnCIRC.UseVisualStyleBackColor = false;
            this.btnCIRC.Click += new System.EventHandler(this.btnCIRC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 717);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.Navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patherns Form";
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.Label lines;
        private System.Windows.Forms.FlowLayoutPanel Canvas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnCIRC;
        private System.Windows.Forms.Button btnRECT;
    }
}

