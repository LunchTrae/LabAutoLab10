using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab10
{
    public partial class Form1 : Form
    {
        NationalInstruments.DAQmx.Task analogReadTask;
        AnalogMultiChannelReader reader;

        const double MAXTIME = 10;
        const double A2D_MAXRATE = 250000;
        double[,] data;
        double minVolt;
        double maxVolt;
        AITerminalConfiguration TerminalConfig;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTerminalConfig.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVoltageRange.DropDownStyle = ComboBoxStyle.DropDownList;

            cboDevice.Items.AddRange(DaqSystem.Local.Devices);
            if (cboDevice.Items.Count > 0)
                cboDevice.SelectedIndex = 0;
            else MessageBox.Show("No devices available. Please connect a device!!!");

            cboTerminalConfig.SelectedIndex = 0;
            cboVoltageRange.SelectedIndex = 0;
            
            //Chart Setup
            Title title = chData.Titles.Add("Voltage vs Time");
            title.Font = new System.Drawing.Font("Arial", 24, FontStyle.Bold);
            title.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);

            chData.ChartAreas[0].AxisX.Minimum = 0.0;
            chData.ChartAreas[0].AxisY.Minimum = -10.5;
            chData.ChartAreas[0].AxisY.Maximum = 10.5;

            chData.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            chData.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

            chData.ChartAreas[0].AxisX.Title = "Time(s)";
            chData.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            chData.ChartAreas[0].AxisY.Title = "Voltage (v)";
            chData.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

            chData.Legends[0].Alignment = StringAlignment.Center;
            chData.Legends[0].Docking = Docking.Right;
            chData.Legends[0].LegendStyle = LegendStyle.Table;
            chData.Legends[0].TableStyle = LegendTableStyle.Auto;
            chData.Legends[0].Font = new System.Drawing.Font("Arial", 8, FontStyle.Bold);

            while (chData.Series.Count > 0) chData.Series.RemoveAt(0);

        }

        private void UpdateChannelInfo()
        {
            int numChannels = Convert.ToInt16(updHighChannel.Value) - Convert.ToInt16(updLowChannel.Value) + 1;
            decimal ADsampleRate = Convert.ToDecimal(numChannels * 1000.0);
            double aquireTime;
            if (ADsampleRate > Convert.ToDecimal(A2D_MAXRATE))
            {
                MessageBox.Show("Exceeding Max A2D Rate!");
            }
            updChannelSampleRate.Maximum = ADsampleRate;
            aquireTime = Convert.ToDouble(updNumSamples.Value / updChannelSampleRate.Value);
            if (aquireTime > 9.0)
            {
                updChannelSampleRate.Value = Convert.ToDecimal(Convert.ToDouble(updNumSamples.Value) / 9.0);
                aquireTime = Convert.ToDouble(updNumSamples.Value / updChannelSampleRate.Value);
            }
            txtAquisitionTime.Text = aquireTime.ToString("#.##");
            txtADRate.Text = (Convert.ToDouble(ADsampleRate) * numChannels / aquireTime).ToString("#.");
            
        }

        private void SetControlEnable(bool b)
        {
            cboDevice.Enabled = b;
            cboTerminalConfig.Enabled = b;
            cboVoltageRange.Enabled = b;
            updLowChannel.Enabled = b;
            updHighChannel.Enabled = b;
            cmdAquire.Enabled = b;
            cmdClear.Enabled = b;
            updChannelSampleRate.Enabled = b;
            updNumSamples.Enabled = b;
            Application.DoEvents();
        }

        public void OnDataReady(IAsyncResult result)
        {
            try
            {
                data = reader.EndReadMultiSample(result);
                GraphData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GraphData()
        {
            for (int i = Convert.ToInt32(updLowChannel.Value); i <= Convert.ToInt32(updHighChannel.Value); i++)
            {
                for (int j = 0; j < updNumSamples.Value; j++)
                {
                    chData.Series["Channel" + i.ToString()].Points.AddXY(j * (1 / updChannelSampleRate.Value), data[i - Convert.ToInt32(updLowChannel.Value), j]);
                    //Application.DoEvents();
                }
            }
        }

        private void updLowChannel_ValueChanged(object sender, EventArgs e)
        {
            if(updLowChannel.Value > updHighChannel.Value)
            {
                updLowChannel.Value = updHighChannel.Value;
            }
            UpdateChannelInfo();
        }

        private void updHighChannel_ValueChanged(object sender, EventArgs e)
        {
            if (updLowChannel.Value > updHighChannel.Value)
            {
                updHighChannel.Value = updLowChannel.Value;
            }
            UpdateChannelInfo();
        }

        private void updNumSamples_ValueChanged(object sender, EventArgs e)
        {
            UpdateChannelInfo();
        }

        private void updChannelSampleRate_ValueChanged(object sender, EventArgs e)
        {
            UpdateChannelInfo();
        }

        private void cmdAquire_Click(object sender, EventArgs e)
        {
            int numChannels = Convert.ToInt16(updHighChannel.Value) - Convert.ToInt16(updLowChannel.Value) + 1;
            double[,] data = new double[numChannels, Convert.ToInt64(updNumSamples.Value)];

            SetControlEnable(false);

            try
            {
                while (chData.Series.Count > 0) chData.Series.RemoveAt(0);

                //Create Task
                analogReadTask = new NationalInstruments.DAQmx.Task();

                //Channel Creation ----------------------------------------------------------------------------------------------------
                for (int i = Convert.ToInt32(updLowChannel.Value); i <= Convert.ToInt32(updHighChannel.Value); i++)
                {
                    analogReadTask.AIChannels.CreateVoltageChannel(cboDevice.Text + "/ai" + i.ToString(), "Channel" + i.ToString(),
                                                                   TerminalConfig, minVolt, maxVolt,
                                                                   AIVoltageUnits.Volts);
                    chData.Series.Add("Channel" + i.ToString());
                    chData.Series["Channel" + i.ToString()].ChartType = SeriesChartType.Line;
                }

                //Setup Timing
                //analogReadTask.Timing.AIConvertRate = Convert.ToDouble(updChannelSampleRate.Value);
                analogReadTask.Timing.ConfigureSampleClock("", Convert.ToDouble(updChannelSampleRate.Value), SampleClockActiveEdge.Rising,
                                                           SampleQuantityMode.FiniteSamples, Convert.ToInt32(updNumSamples.Value));

                //Verify Task is setup correctly
                analogReadTask.Control(TaskAction.Verify);

                //Read data
                analogReadTask.Start();
                reader = new AnalogMultiChannelReader(analogReadTask.Stream);
                reader.BeginReadMultiSample(Convert.ToInt32(updNumSamples.Value), OnDataReady, null);

                //Destroy Task
                analogReadTask.Stop();
                analogReadTask.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetControlEnable(true);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            while (chData.Series.Count > 0) chData.Series.RemoveAt(0);
        }

        private void cboTerminalConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTerminalConfig.SelectedIndex == 0)
            {
                updHighChannel.Maximum = 7;
                updLowChannel.Maximum = 7;
                TerminalConfig = AITerminalConfiguration.Differential;
            }
            else
            {
                updHighChannel.Maximum = 15;
                updLowChannel.Maximum = 15;
                if(cboTerminalConfig.SelectedIndex == 1)
                {
                    TerminalConfig = AITerminalConfiguration.Rse;
                }
                else
                {
                    TerminalConfig = AITerminalConfiguration.Nrse;
                }
            }
        }

        private void cboVoltageRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVoltageRange.SelectedIndex == 0)
            {
                minVolt = -10.0;
                maxVolt = 10.0;
            }
            else if (cboVoltageRange.SelectedIndex == 1)
            {
                minVolt = -5.0;
                maxVolt = 5.0;
            }
            else if (cboVoltageRange.SelectedIndex == 2)
            {
                minVolt = -1.0;
                maxVolt = 1.0;
            }
            else if (cboVoltageRange.SelectedIndex == 3)
            {
                minVolt = -0.2;
                maxVolt = 0.2;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines;
                openFD.InitialDirectory = "C:\\Users\\jenksiiija\\Documents\\JenksLabAutoLabs\\Lab13";
                openFD.Title = "Open a Data File";
                openFD.FileName = "";
                openFD.Filter = "Text Files|*.csv|All Files|*.*";

                if (openFD.ShowDialog() != DialogResult.Cancel)
                {
                    while (chData.Series.Count > 0) chData.Series.RemoveAt(0);
                    double ymax = 0.0;
                    double ymin = 0.0;
                    lines = File.ReadAllLines(openFD.FileName);
                    int numCols = lines[5].Split(',').GetLength(0);
                    int numRows = lines.GetLength(0);
                    for (int i = 1; i < numCols; i++)
                    {
                        chData.Series.Add(lines[3].Split(',')[i]);
                    }
                    for (int i = 0; i < numRows; i++)
                    {
                        if (i > 3)
                        {
                            for (int j = 0; j < numCols - 1; j++)
                            {
                                chData.Series[j].Points.AddXY(lines[i].Split(',')[0], lines[i].Split(',')[j + 1]);
                                if (Convert.ToDouble(lines[i].Split(',')[j + 1]) > ymax)
                                {
                                    ymax = Convert.ToDouble(lines[i].Split(',')[j + 1]);
                                }
                                if (Convert.ToDouble(lines[i].Split(',')[j + 1]) < ymin)
                                {
                                    ymin = Convert.ToDouble(lines[i].Split(',')[j + 1]);
                                }
                            }
                        }
                    }
                    //MessageBox.Show(ymin.ToString());
                    chData.ChartAreas[0].AxisY.Minimum = ymin - (0.05 * (ymax - ymin));
                    chData.ChartAreas[0].AxisY.Maximum = ymax + (0.05 * (ymax - ymin));

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int numChannels = Convert.ToInt32(updHighChannel.Value) - Convert.ToInt32(updLowChannel.Value) + 1;
                string[] fileLines;
                System.IO.StreamWriter objWriter;

                saveFD.InitialDirectory = "C:\\Users\\jenksiiija\\Documents\\JenksLabAutoLabs\\Lab13";
                saveFD.Title = "Save a Data File";
                saveFD.FileName = "";
                saveFD.Filter = "Text Files|*.csv|All Files|*.*";
                if (saveFD.ShowDialog() != DialogResult.Cancel)
                {
                    fileLines = new string[data.GetLength(1) + 4];
                    fileLines[0] = "date," + DateTime.Now.ToString("d");
                    fileLines[1] = "time," + DateTime.Now.ToString("T"); ;
                    fileLines[2] = "# data points," + data.GetLength(1).ToString();
                    fileLines[3] = "elapsed time";

                    for (int i = 0; i < numChannels; i++)
                    {
                        fileLines[3] = fileLines[3] + ',' + chData.Series[i].ToString();
                    }
                    for (int i = 0; i < data.GetLength(1); i++)
                    {
                        fileLines[i+4] = (i * (1 / updChannelSampleRate.Value)).ToString();
                        for (int j = 0; j < numChannels; j++)
                        {
                            fileLines[i+4] = fileLines[i+4] + ',' + data[j, i].ToString();
                        }
                    }
                    if (sender.ToString() == "&New")
                    {
                        objWriter = new System.IO.StreamWriter(saveFD.FileName);
                    }
                    else
                    {
                        objWriter = new System.IO.StreamWriter(saveFD.FileName, true);
                    }

                    for (int i = 0; i < fileLines.GetLength(0); i++)
                    {
                        objWriter.WriteLine(fileLines[i]);
                    }
                    objWriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help Information BLah Blah Blahhhhh");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
