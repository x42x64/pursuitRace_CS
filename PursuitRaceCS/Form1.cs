using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace PursuitRaceCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.serialPort1 = new SerialPort();
            this.timerTicks = 0;
        }


        private void updatePorts()
        {
            this.comboBoxSerialPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            for (int i = 0; i < ports.Length; i++)
            {
                this.comboBoxSerialPort.Items.Add(ports[i]);
            }
        }

        private bool connect()
        {
            if(this.serialPort1.IsOpen==true)
            {
                this.serialPort1.Close();
            }

                try
                {
                    this.serialPort1.BaudRate = 9600;
                    this.serialPort1.NewLine = "\n";
                    this.serialPort1.PortName = this.comboBoxSerialPort.SelectedItem.ToString();
                    this.serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beim Öffnen des Ports ist etwas schief gegangen.\n" + ex.ToString());
                    return false;
                }

            this.buttonSerialConnect.Text = "Disconnect";
            this.toolStripStatusLabelConnectionStatus.Text = "Connected to Port " + this.comboBoxSerialPort.SelectedItem.ToString();
            this.buttonStart.Enabled = true;

            this.buttonStart.Text = "Start";
            return true;
            
        }

        private void disconnect()
        {
            stop();
            this.serialPort1.Close();
            this.buttonStart.Enabled = false;
            this.buttonSerialConnect.Text = "Connect";
            this.toolStripStatusLabelConnectionStatus.Text = "Disconnected";
            
        }

        private void go()
        {
            this.serialPort1.WriteLine("go");
            this.timerTicks = 0;
            this.timerStart = DateTime.Now;
            this.timer1.Start();
        }

        private void stop()
        {
            this.serialPort1.WriteLine("stop");
            this.timerTicks = 0;
            this.timer1.Stop();
            updateProgressBars();
        }

        private void setLanes(int[] laneTime_ms)
        {
            for(int i=0; i<laneTime_ms.Length; i++)
            {
                this.serialPort1.WriteLine(String.Format("L{0}:{1}", i, laneTime_ms[i]));
            }
        }

        private void calculateStartTimes()
        {
            int[] laneStartTime_ms = new int[6];
            int[] laneBaseTime_ms = new int[6];
            int startOffsetTime = 5000;

            laneBaseTime_ms[0] = stringTime2Millisecond(maskedTextBoxRefTime1.Text);
            laneBaseTime_ms[1] = stringTime2Millisecond(maskedTextBoxRefTime2.Text);
            laneBaseTime_ms[2] = stringTime2Millisecond(maskedTextBoxRefTime3.Text);
            laneBaseTime_ms[3] = stringTime2Millisecond(maskedTextBoxRefTime4.Text);
            laneBaseTime_ms[4] = stringTime2Millisecond(maskedTextBoxRefTime5.Text);
            laneBaseTime_ms[5] = stringTime2Millisecond(maskedTextBoxRefTime6.Text);

            // find slowest time
            int slowestTime = -1;
            for(int i=0; i<6; i++)
            {
                if(laneBaseTime_ms[i]>slowestTime)
                {
                    slowestTime = laneBaseTime_ms[i];
                }
            }

            // create start times
            for(int i=0; i<6; i++)
            {
                laneStartTime_ms[i] = startOffsetTime + (slowestTime - laneBaseTime_ms[i]);
                if(laneStartTime_ms[i]>65535)
                {
                    laneStartTime_ms[i] = 65535;
                    MessageBox.Show("Bahn " + i.ToString() + " hat eine Wartezeit > 65s. Das System kann maximal 65s darstellen. Die Wartezeit wird auf 65s gekürzt.");
                }
                if(laneBaseTime_ms[i] < 0)
                {
                    laneStartTime_ms[i] = 0;
                }
            }

            this.maskedTextBoxStart1.Text = millisecond2Time(laneStartTime_ms[0]);
            this.maskedTextBoxStart2.Text = millisecond2Time(laneStartTime_ms[1]);
            this.maskedTextBoxStart3.Text = millisecond2Time(laneStartTime_ms[2]);
            this.maskedTextBoxStart4.Text = millisecond2Time(laneStartTime_ms[3]);
            this.maskedTextBoxStart5.Text = millisecond2Time(laneStartTime_ms[4]);
            this.maskedTextBoxStart6.Text = millisecond2Time(laneStartTime_ms[5]);

            this.progressBar1.Maximum = laneStartTime_ms[0];
            this.progressBar2.Maximum = laneStartTime_ms[1];
            this.progressBar3.Maximum = laneStartTime_ms[2];
            this.progressBar4.Maximum = laneStartTime_ms[3];
            this.progressBar5.Maximum = laneStartTime_ms[4];
            this.progressBar6.Maximum = laneStartTime_ms[5];

            if (this.serialPort1.IsOpen)
            {
                setLanes(laneStartTime_ms);
            }

        }

        private string millisecond2Time(int ms)
        {
            string s;
            int minutes = (ms - (ms % 60000)) / 60000;
            int seconds = (ms - 60000 * minutes) / 1000;
            int hdrt = (ms % 1000) / 10;

            s = minutes.ToString("00") + ":" + seconds.ToString("00") + "." + hdrt.ToString("00");

            return s;
        }

        private int stringTime2Millisecond(string s)
        {
            string[] parts = s.Split(':');
            string[] parts2 = parts[1].Split('.');

            int min, sec, hdrt;

            if(Int32.TryParse(parts[0], out min) && Int32.TryParse(parts2[0], out sec) && Int32.TryParse(parts2[1], out hdrt))
            {
                return min * 60000 + sec * 1000 + hdrt * 10;
            }

            return -1;
        }

        private void buttonSerialRefresh_Click(object sender, EventArgs e)
        {
            updatePorts();
        }

        private void buttonSerialConnect_Click(object sender, EventArgs e)
        {
            if(this.buttonSerialConnect.Text == "Connect")
            {
                connect();
                calculateStartTimes();
            }
            else 
            {
                disconnect();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try 
            {
                toolStripStatusLabel_Log.Text = sp.ReadExisting();
            }
            catch(Exception ex)
            {
                toolStripStatusLabel_Log.Text = "Fehler beim Lesen!";
            }
        }

        private void maskedTextBoxRefTime_Leave(object sender, EventArgs e)
        {
            calculateStartTimes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.timerTicks = this.timerTicks + this.timer1.Interval;
            this.timerTicks = (int)((DateTime.Now.Ticks - this.timerStart.Ticks)/10000);

            updateProgressBars();

            if(this.timerTicks > 65535)
            {
                this.timer1.Stop();
            }
        }

        private void updateProgressBars()
        {
            // progress bar 1
            if (this.timerTicks > this.progressBar1.Maximum)
            {
                this.progressBar1.Value = this.progressBar1.Maximum;
                this.panel1.BackColor = Color.Green;
            }
            else
            {
                this.progressBar1.Value = this.timerTicks;
                this.panel1.BackColor = Color.Red;
            }

            // progress bar 2
            if (this.timerTicks > this.progressBar2.Maximum)
            {
                this.progressBar2.Value = this.progressBar2.Maximum;
                this.panel2.BackColor = Color.Green;
            }
            else
            {
                this.progressBar2.Value = this.timerTicks;
                this.panel2.BackColor = Color.Red;
            }

            // progress bar 3
            if (this.timerTicks > this.progressBar3.Maximum)
            {
                this.progressBar3.Value = this.progressBar3.Maximum;
                this.panel3.BackColor = Color.Green;
            }
            else
            {
                this.progressBar3.Value = this.timerTicks;
                this.panel3.BackColor = Color.Red;
            }

            // progress bar 4
            if (this.timerTicks > this.progressBar4.Maximum)
            {
                this.progressBar4.Value = this.progressBar4.Maximum;
                this.panel4.BackColor = Color.Green;
            }
            else
            {
                this.progressBar4.Value = this.timerTicks;
                this.panel4.BackColor = Color.Red;
            }

            // progress bar 5
            if (this.timerTicks > this.progressBar5.Maximum)
            {
                this.progressBar5.Value = this.progressBar5.Maximum;
                this.panel5.BackColor = Color.Green;
            }
            else
            {
                this.progressBar5.Value = this.timerTicks;
                this.panel5.BackColor = Color.Red;
            }

            // progress bar 6
            if (this.timerTicks > this.progressBar6.Maximum)
            {
                this.progressBar6.Value = this.progressBar6.Maximum;
                this.panel6.BackColor = Color.Green;
            }
            else
            {
                this.progressBar6.Value = this.timerTicks;
                this.panel6.BackColor = Color.Red;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (this.buttonStart.Text == "Start")
            {
                go();
                this.buttonStart.Text = "Abbruch";
            }
            else 
            {
                stop();
                this.buttonStart.Text = "Start";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePorts();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PursuitRace v1.0beta\n (c) Jan Martin \n SV Hengersberg");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.serialPort1.IsOpen)
            {
                disconnect();
            }
        }
     

    }
}
