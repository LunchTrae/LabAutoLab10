namespace Lab10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.txtADRate = new System.Windows.Forms.TextBox();
            this.txtAquisitionTime = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdAquire = new System.Windows.Forms.Button();
            this.updHighChannel = new System.Windows.Forms.NumericUpDown();
            this.updNumSamples = new System.Windows.Forms.NumericUpDown();
            this.updChannelSampleRate = new System.Windows.Forms.NumericUpDown();
            this.updLowChannel = new System.Windows.Forms.NumericUpDown();
            this.lblADRate = new System.Windows.Forms.Label();
            this.lblAquisitionTime = new System.Windows.Forms.Label();
            this.lblNumSamples = new System.Windows.Forms.Label();
            this.lblHighChannel = new System.Windows.Forms.Label();
            this.lblChannelSampleRate = new System.Windows.Forms.Label();
            this.lblVoltageRange = new System.Windows.Forms.Label();
            this.lblLowChannel = new System.Windows.Forms.Label();
            this.lblChannelRange = new System.Windows.Forms.Label();
            this.lblTerminalConfig = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cboVoltageRange = new System.Windows.Forms.ComboBox();
            this.cboTerminalConfig = new System.Windows.Forms.ComboBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.chData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHighChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updNumSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updChannelSampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLowChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chData)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.txtADRate);
            this.grpConfig.Controls.Add(this.txtAquisitionTime);
            this.grpConfig.Controls.Add(this.cmdClear);
            this.grpConfig.Controls.Add(this.cmdAquire);
            this.grpConfig.Controls.Add(this.updHighChannel);
            this.grpConfig.Controls.Add(this.updNumSamples);
            this.grpConfig.Controls.Add(this.updChannelSampleRate);
            this.grpConfig.Controls.Add(this.updLowChannel);
            this.grpConfig.Controls.Add(this.lblADRate);
            this.grpConfig.Controls.Add(this.lblAquisitionTime);
            this.grpConfig.Controls.Add(this.lblNumSamples);
            this.grpConfig.Controls.Add(this.lblHighChannel);
            this.grpConfig.Controls.Add(this.lblChannelSampleRate);
            this.grpConfig.Controls.Add(this.lblVoltageRange);
            this.grpConfig.Controls.Add(this.lblLowChannel);
            this.grpConfig.Controls.Add(this.lblChannelRange);
            this.grpConfig.Controls.Add(this.lblTerminalConfig);
            this.grpConfig.Controls.Add(this.lblDevice);
            this.grpConfig.Controls.Add(this.cboVoltageRange);
            this.grpConfig.Controls.Add(this.cboTerminalConfig);
            this.grpConfig.Controls.Add(this.cboDevice);
            this.grpConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpConfig.Location = new System.Drawing.Point(12, 29);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(362, 291);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "DAQ Configuration";
            // 
            // txtADRate
            // 
            this.txtADRate.Enabled = false;
            this.txtADRate.Location = new System.Drawing.Point(199, 256);
            this.txtADRate.Name = "txtADRate";
            this.txtADRate.ReadOnly = true;
            this.txtADRate.Size = new System.Drawing.Size(144, 20);
            this.txtADRate.TabIndex = 4;
            this.txtADRate.Text = "250000";
            // 
            // txtAquisitionTime
            // 
            this.txtAquisitionTime.Enabled = false;
            this.txtAquisitionTime.Location = new System.Drawing.Point(199, 209);
            this.txtAquisitionTime.Name = "txtAquisitionTime";
            this.txtAquisitionTime.ReadOnly = true;
            this.txtAquisitionTime.Size = new System.Drawing.Size(144, 20);
            this.txtAquisitionTime.TabIndex = 4;
            this.txtAquisitionTime.Text = "10";
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdClear.Location = new System.Drawing.Point(98, 235);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(71, 47);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Clear Chart";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdAquire
            // 
            this.cmdAquire.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAquire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAquire.Location = new System.Drawing.Point(22, 235);
            this.cmdAquire.Name = "cmdAquire";
            this.cmdAquire.Size = new System.Drawing.Size(71, 47);
            this.cmdAquire.TabIndex = 3;
            this.cmdAquire.Text = "Aquire";
            this.cmdAquire.UseVisualStyleBackColor = true;
            this.cmdAquire.Click += new System.EventHandler(this.cmdAquire_Click);
            // 
            // updHighChannel
            // 
            this.updHighChannel.Location = new System.Drawing.Point(22, 202);
            this.updHighChannel.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.updHighChannel.Name = "updHighChannel";
            this.updHighChannel.Size = new System.Drawing.Size(147, 20);
            this.updHighChannel.TabIndex = 2;
            this.updHighChannel.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.updHighChannel.ValueChanged += new System.EventHandler(this.updHighChannel_ValueChanged);
            // 
            // updNumSamples
            // 
            this.updNumSamples.Location = new System.Drawing.Point(196, 137);
            this.updNumSamples.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updNumSamples.Name = "updNumSamples";
            this.updNumSamples.Size = new System.Drawing.Size(147, 20);
            this.updNumSamples.TabIndex = 2;
            this.updNumSamples.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updNumSamples.ValueChanged += new System.EventHandler(this.updNumSamples_ValueChanged);
            // 
            // updChannelSampleRate
            // 
            this.updChannelSampleRate.Location = new System.Drawing.Point(196, 90);
            this.updChannelSampleRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updChannelSampleRate.Name = "updChannelSampleRate";
            this.updChannelSampleRate.Size = new System.Drawing.Size(147, 20);
            this.updChannelSampleRate.TabIndex = 2;
            this.updChannelSampleRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updChannelSampleRate.ValueChanged += new System.EventHandler(this.updChannelSampleRate_ValueChanged);
            // 
            // updLowChannel
            // 
            this.updLowChannel.Location = new System.Drawing.Point(22, 162);
            this.updLowChannel.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.updLowChannel.Name = "updLowChannel";
            this.updLowChannel.Size = new System.Drawing.Size(147, 20);
            this.updLowChannel.TabIndex = 2;
            this.updLowChannel.ValueChanged += new System.EventHandler(this.updLowChannel_ValueChanged);
            // 
            // lblADRate
            // 
            this.lblADRate.AutoSize = true;
            this.lblADRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADRate.Location = new System.Drawing.Point(196, 235);
            this.lblADRate.Name = "lblADRate";
            this.lblADRate.Size = new System.Drawing.Size(122, 18);
            this.lblADRate.TabIndex = 1;
            this.lblADRate.Text = "A/D Rate (S/s):";
            // 
            // lblAquisitionTime
            // 
            this.lblAquisitionTime.AutoSize = true;
            this.lblAquisitionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAquisitionTime.Location = new System.Drawing.Point(196, 185);
            this.lblAquisitionTime.Name = "lblAquisitionTime";
            this.lblAquisitionTime.Size = new System.Drawing.Size(154, 18);
            this.lblAquisitionTime.TabIndex = 1;
            this.lblAquisitionTime.Text = "Aquisition Time (s):";
            // 
            // lblNumSamples
            // 
            this.lblNumSamples.AutoSize = true;
            this.lblNumSamples.Location = new System.Drawing.Point(193, 120);
            this.lblNumSamples.Name = "lblNumSamples";
            this.lblNumSamples.Size = new System.Drawing.Size(140, 13);
            this.lblNumSamples.TabIndex = 1;
            this.lblNumSamples.Text = "Number Samples / Channel:";
            // 
            // lblHighChannel
            // 
            this.lblHighChannel.AutoSize = true;
            this.lblHighChannel.Location = new System.Drawing.Point(19, 185);
            this.lblHighChannel.Name = "lblHighChannel";
            this.lblHighChannel.Size = new System.Drawing.Size(74, 13);
            this.lblHighChannel.TabIndex = 1;
            this.lblHighChannel.Text = "High Channel:";
            // 
            // lblChannelSampleRate
            // 
            this.lblChannelSampleRate.AutoSize = true;
            this.lblChannelSampleRate.Location = new System.Drawing.Point(193, 73);
            this.lblChannelSampleRate.Name = "lblChannelSampleRate";
            this.lblChannelSampleRate.Size = new System.Drawing.Size(113, 13);
            this.lblChannelSampleRate.TabIndex = 1;
            this.lblChannelSampleRate.Text = "Channel Sample Rate:";
            // 
            // lblVoltageRange
            // 
            this.lblVoltageRange.AutoSize = true;
            this.lblVoltageRange.Location = new System.Drawing.Point(196, 25);
            this.lblVoltageRange.Name = "lblVoltageRange";
            this.lblVoltageRange.Size = new System.Drawing.Size(81, 13);
            this.lblVoltageRange.TabIndex = 1;
            this.lblVoltageRange.Text = "Voltage Range:";
            // 
            // lblLowChannel
            // 
            this.lblLowChannel.AutoSize = true;
            this.lblLowChannel.Location = new System.Drawing.Point(19, 145);
            this.lblLowChannel.Name = "lblLowChannel";
            this.lblLowChannel.Size = new System.Drawing.Size(72, 13);
            this.lblLowChannel.TabIndex = 1;
            this.lblLowChannel.Text = "Low Channel:";
            // 
            // lblChannelRange
            // 
            this.lblChannelRange.AutoSize = true;
            this.lblChannelRange.Location = new System.Drawing.Point(19, 127);
            this.lblChannelRange.Name = "lblChannelRange";
            this.lblChannelRange.Size = new System.Drawing.Size(81, 13);
            this.lblChannelRange.TabIndex = 1;
            this.lblChannelRange.Text = "Channel Range";
            // 
            // lblTerminalConfig
            // 
            this.lblTerminalConfig.AutoSize = true;
            this.lblTerminalConfig.Location = new System.Drawing.Point(19, 74);
            this.lblTerminalConfig.Name = "lblTerminalConfig";
            this.lblTerminalConfig.Size = new System.Drawing.Size(115, 13);
            this.lblTerminalConfig.TabIndex = 1;
            this.lblTerminalConfig.Text = "Terminal Configuration:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(19, 25);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 1;
            this.lblDevice.Text = "Device:";
            // 
            // cboVoltageRange
            // 
            this.cboVoltageRange.FormattingEnabled = true;
            this.cboVoltageRange.Items.AddRange(new object[] {
            "+/- 10 V",
            "+/- 5 V",
            "+/- 1 V",
            "+/- 0.2 V"});
            this.cboVoltageRange.Location = new System.Drawing.Point(196, 41);
            this.cboVoltageRange.Name = "cboVoltageRange";
            this.cboVoltageRange.Size = new System.Drawing.Size(150, 21);
            this.cboVoltageRange.TabIndex = 0;
            this.cboVoltageRange.SelectedIndexChanged += new System.EventHandler(this.cboVoltageRange_SelectedIndexChanged);
            // 
            // cboTerminalConfig
            // 
            this.cboTerminalConfig.FormattingEnabled = true;
            this.cboTerminalConfig.Items.AddRange(new object[] {
            "Differential",
            "Reference Single Ended",
            "Non-Reference Single Ended"});
            this.cboTerminalConfig.Location = new System.Drawing.Point(19, 90);
            this.cboTerminalConfig.Name = "cboTerminalConfig";
            this.cboTerminalConfig.Size = new System.Drawing.Size(150, 21);
            this.cboTerminalConfig.TabIndex = 0;
            this.cboTerminalConfig.SelectedIndexChanged += new System.EventHandler(this.cboTerminalConfig_SelectedIndexChanged);
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(19, 41);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(150, 21);
            this.cboDevice.TabIndex = 0;
            // 
            // chData
            // 
            chartArea1.Name = "ChartArea1";
            this.chData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chData.Legends.Add(legend1);
            this.chData.Location = new System.Drawing.Point(380, 35);
            this.chData.Name = "chData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chData.Series.Add(series1);
            this.chData.Size = new System.Drawing.Size(408, 285);
            this.chData.TabIndex = 1;
            this.chData.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.chData);
            this.Controls.Add(this.grpConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Oscilloscope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHighChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updNumSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updChannelSampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLowChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.DataVisualization.Charting.Chart chData;
        private System.Windows.Forms.TextBox txtADRate;
        private System.Windows.Forms.TextBox txtAquisitionTime;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdAquire;
        private System.Windows.Forms.NumericUpDown updHighChannel;
        private System.Windows.Forms.NumericUpDown updNumSamples;
        private System.Windows.Forms.NumericUpDown updChannelSampleRate;
        private System.Windows.Forms.NumericUpDown updLowChannel;
        private System.Windows.Forms.Label lblADRate;
        private System.Windows.Forms.Label lblAquisitionTime;
        private System.Windows.Forms.Label lblNumSamples;
        private System.Windows.Forms.Label lblHighChannel;
        private System.Windows.Forms.Label lblChannelSampleRate;
        private System.Windows.Forms.Label lblVoltageRange;
        private System.Windows.Forms.Label lblLowChannel;
        private System.Windows.Forms.Label lblChannelRange;
        private System.Windows.Forms.Label lblTerminalConfig;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cboVoltageRange;
        private System.Windows.Forms.ComboBox cboTerminalConfig;
        private System.Windows.Forms.ComboBox cboDevice;
    }
}

