namespace PortScanner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxIpAddress = new System.Windows.Forms.GroupBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonRange = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIPRange2 = new System.Windows.Forms.TextBox();
            this.labelIPTo = new System.Windows.Forms.Label();
            this.textBoxIPRange1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBoxIpAddress.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIpAddress
            // 
            this.groupBoxIpAddress.Controls.Add(this.textBoxIP);
            this.groupBoxIpAddress.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBoxIpAddress.Location = new System.Drawing.Point(14, 14);
            this.groupBoxIpAddress.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxIpAddress.Name = "groupBoxIpAddress";
            this.groupBoxIpAddress.Size = new System.Drawing.Size(200, 50);
            this.groupBoxIpAddress.TabIndex = 0;
            this.groupBoxIpAddress.TabStop = false;
            this.groupBoxIpAddress.Text = "IP Address";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(8, 21);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(182, 20);
            this.textBoxIP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonRange);
            this.groupBox2.Controls.Add(this.radioButtonSingle);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(14, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(200, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port Options";
            // 
            // radioButtonRange
            // 
            this.radioButtonRange.AutoSize = true;
            this.radioButtonRange.Checked = true;
            this.radioButtonRange.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButtonRange.Location = new System.Drawing.Point(111, 23);
            this.radioButtonRange.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonRange.Name = "radioButtonRange";
            this.radioButtonRange.Size = new System.Drawing.Size(79, 17);
            this.radioButtonRange.TabIndex = 1;
            this.radioButtonRange.TabStop = true;
            this.radioButtonRange.Text = "Port Range";
            this.radioButtonRange.UseVisualStyleBackColor = true;
            this.radioButtonRange.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButtonSingle.Location = new System.Drawing.Point(10, 23);
            this.radioButtonSingle.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(76, 17);
            this.radioButtonSingle.TabIndex = 0;
            this.radioButtonSingle.Text = "Single Port";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIPRange2);
            this.groupBox3.Controls.Add(this.labelIPTo);
            this.groupBox3.Controls.Add(this.textBoxIPRange1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(14, 134);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(200, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port(s)";
            // 
            // textBoxIPRange2
            // 
            this.textBoxIPRange2.Location = new System.Drawing.Point(115, 21);
            this.textBoxIPRange2.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxIPRange2.Name = "textBoxIPRange2";
            this.textBoxIPRange2.Size = new System.Drawing.Size(75, 20);
            this.textBoxIPRange2.TabIndex = 2;
            // 
            // labelIPTo
            // 
            this.labelIPTo.AutoSize = true;
            this.labelIPTo.Location = new System.Drawing.Point(87, 21);
            this.labelIPTo.Margin = new System.Windows.Forms.Padding(3);
            this.labelIPTo.Name = "labelIPTo";
            this.labelIPTo.Padding = new System.Windows.Forms.Padding(3);
            this.labelIPTo.Size = new System.Drawing.Size(22, 19);
            this.labelIPTo.TabIndex = 1;
            this.labelIPTo.Text = "to";
            // 
            // textBoxIPRange1
            // 
            this.textBoxIPRange1.Location = new System.Drawing.Point(8, 21);
            this.textBoxIPRange1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxIPRange1.Name = "textBoxIPRange1";
            this.textBoxIPRange1.Size = new System.Drawing.Size(75, 20);
            this.textBoxIPRange1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxResults);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Location = new System.Drawing.Point(14, 198);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(200, 180);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(10, 23);
            this.textBoxResults.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(180, 147);
            this.textBoxResults.TabIndex = 0;
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(14, 388);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(5);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(200, 30);
            this.buttonScan.TabIndex = 4;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(14, 428);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(84, 428);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 30);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(154, 428);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 30);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 468);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 20);
            this.progressBar.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(224, 501);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxIpAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PScan";
            this.groupBoxIpAddress.ResumeLayout(false);
            this.groupBoxIpAddress.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIpAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonRange;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxIPRange1;
        private System.Windows.Forms.TextBox textBoxIPRange2;
        private System.Windows.Forms.Label labelIPTo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

