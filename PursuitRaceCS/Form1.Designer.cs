namespace PursuitRaceCS
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSerialRefresh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Log = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSerialConnect = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.maskedTextBoxRefTime1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBoxRefTime2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRefTime3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRefTime4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRefTime5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRefTime6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStart1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStart2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStart3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStart4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStart5 = new System.Windows.Forms.MaskedTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.maskedTextBoxStart6 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(80, 36);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSerialPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM-Port:";
            // 
            // buttonSerialRefresh
            // 
            this.buttonSerialRefresh.Location = new System.Drawing.Point(207, 34);
            this.buttonSerialRefresh.Name = "buttonSerialRefresh";
            this.buttonSerialRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialRefresh.TabIndex = 2;
            this.buttonSerialRefresh.Text = "Refresh";
            this.buttonSerialRefresh.UseVisualStyleBackColor = true;
            this.buttonSerialRefresh.Click += new System.EventHandler(this.buttonSerialRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnectionStatus,
            this.toolStripStatusLabel_Log});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConnectionStatus
            // 
            this.toolStripStatusLabelConnectionStatus.Name = "toolStripStatusLabelConnectionStatus";
            this.toolStripStatusLabelConnectionStatus.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabelConnectionStatus.Text = "Disconnected";
            // 
            // toolStripStatusLabel_Log
            // 
            this.toolStripStatusLabel_Log.Name = "toolStripStatusLabel_Log";
            this.toolStripStatusLabel_Log.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel_Log.Text = "---";
            // 
            // buttonSerialConnect
            // 
            this.buttonSerialConnect.Location = new System.Drawing.Point(289, 34);
            this.buttonSerialConnect.Name = "buttonSerialConnect";
            this.buttonSerialConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialConnect.TabIndex = 4;
            this.buttonSerialConnect.Text = "Connect";
            this.buttonSerialConnect.UseVisualStyleBackColor = true;
            this.buttonSerialConnect.Click += new System.EventHandler(this.buttonSerialConnect_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(12, 431);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(654, 53);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // maskedTextBoxRefTime1
            // 
            this.maskedTextBoxRefTime1.Location = new System.Drawing.Point(58, 23);
            this.maskedTextBoxRefTime1.Mask = "00:00,00";
            this.maskedTextBoxRefTime1.Name = "maskedTextBoxRefTime1";
            this.maskedTextBoxRefTime1.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxRefTime1.TabIndex = 6;
            this.maskedTextBoxRefTime1.Leave += new System.EventHandler(this.maskedTextBoxRefTime_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bahn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Referenzzeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Startzeit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxRefTime1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxRefTime2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxRefTime3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxRefTime4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxRefTime5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxRefTime6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStart1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStart2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStart3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStart4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStart5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.progressBar4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.progressBar5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxStart6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 4, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 153);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "6";
            // 
            // maskedTextBoxRefTime2
            // 
            this.maskedTextBoxRefTime2.Location = new System.Drawing.Point(58, 43);
            this.maskedTextBoxRefTime2.Mask = "00:00,00";
            this.maskedTextBoxRefTime2.Name = "maskedTextBoxRefTime2";
            this.maskedTextBoxRefTime2.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxRefTime2.TabIndex = 16;
            this.maskedTextBoxRefTime2.Leave += new System.EventHandler(this.maskedTextBoxRefTime_Leave);
            // 
            // maskedTextBoxRefTime3
            // 
            this.maskedTextBoxRefTime3.Location = new System.Drawing.Point(58, 63);
            this.maskedTextBoxRefTime3.Mask = "00:00,00";
            this.maskedTextBoxRefTime3.Name = "maskedTextBoxRefTime3";
            this.maskedTextBoxRefTime3.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxRefTime3.TabIndex = 17;
            this.maskedTextBoxRefTime3.Leave += new System.EventHandler(this.maskedTextBoxRefTime_Leave);
            // 
            // maskedTextBoxRefTime4
            // 
            this.maskedTextBoxRefTime4.Location = new System.Drawing.Point(58, 83);
            this.maskedTextBoxRefTime4.Mask = "00:00,00";
            this.maskedTextBoxRefTime4.Name = "maskedTextBoxRefTime4";
            this.maskedTextBoxRefTime4.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxRefTime4.TabIndex = 18;
            this.maskedTextBoxRefTime4.Leave += new System.EventHandler(this.maskedTextBoxRefTime_Leave);
            // 
            // maskedTextBoxRefTime5
            // 
            this.maskedTextBoxRefTime5.Location = new System.Drawing.Point(58, 103);
            this.maskedTextBoxRefTime5.Mask = "00:00,00";
            this.maskedTextBoxRefTime5.Name = "maskedTextBoxRefTime5";
            this.maskedTextBoxRefTime5.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxRefTime5.TabIndex = 19;
            this.maskedTextBoxRefTime5.Leave += new System.EventHandler(this.maskedTextBoxRefTime_Leave);
            // 
            // maskedTextBoxRefTime6
            // 
            this.maskedTextBoxRefTime6.Location = new System.Drawing.Point(58, 123);
            this.maskedTextBoxRefTime6.Mask = "00:00,00";
            this.maskedTextBoxRefTime6.Name = "maskedTextBoxRefTime6";
            this.maskedTextBoxRefTime6.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxRefTime6.TabIndex = 20;
            this.maskedTextBoxRefTime6.Leave += new System.EventHandler(this.maskedTextBoxRefTime_Leave);
            // 
            // maskedTextBoxStart1
            // 
            this.maskedTextBoxStart1.Enabled = false;
            this.maskedTextBoxStart1.Location = new System.Drawing.Point(138, 23);
            this.maskedTextBoxStart1.Mask = "00:00,00";
            this.maskedTextBoxStart1.Name = "maskedTextBoxStart1";
            this.maskedTextBoxStart1.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxStart1.TabIndex = 6;
            // 
            // maskedTextBoxStart2
            // 
            this.maskedTextBoxStart2.Enabled = false;
            this.maskedTextBoxStart2.Location = new System.Drawing.Point(138, 43);
            this.maskedTextBoxStart2.Mask = "00:00,00";
            this.maskedTextBoxStart2.Name = "maskedTextBoxStart2";
            this.maskedTextBoxStart2.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxStart2.TabIndex = 21;
            // 
            // maskedTextBoxStart3
            // 
            this.maskedTextBoxStart3.Enabled = false;
            this.maskedTextBoxStart3.Location = new System.Drawing.Point(138, 63);
            this.maskedTextBoxStart3.Mask = "00:00,00";
            this.maskedTextBoxStart3.Name = "maskedTextBoxStart3";
            this.maskedTextBoxStart3.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxStart3.TabIndex = 21;
            // 
            // maskedTextBoxStart4
            // 
            this.maskedTextBoxStart4.Enabled = false;
            this.maskedTextBoxStart4.Location = new System.Drawing.Point(138, 83);
            this.maskedTextBoxStart4.Mask = "00:00,00";
            this.maskedTextBoxStart4.Name = "maskedTextBoxStart4";
            this.maskedTextBoxStart4.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxStart4.TabIndex = 21;
            // 
            // maskedTextBoxStart5
            // 
            this.maskedTextBoxStart5.Enabled = false;
            this.maskedTextBoxStart5.Location = new System.Drawing.Point(138, 103);
            this.maskedTextBoxStart5.Mask = "00:00,00";
            this.maskedTextBoxStart5.Name = "maskedTextBoxStart5";
            this.maskedTextBoxStart5.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxStart5.TabIndex = 21;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(211, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 14);
            this.progressBar1.TabIndex = 22;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(211, 43);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(244, 14);
            this.progressBar2.TabIndex = 22;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(211, 63);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(244, 14);
            this.progressBar3.TabIndex = 22;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(211, 83);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(244, 14);
            this.progressBar4.TabIndex = 22;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(211, 103);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(244, 14);
            this.progressBar5.TabIndex = 22;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(211, 123);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(244, 14);
            this.progressBar6.TabIndex = 22;
            // 
            // maskedTextBoxStart6
            // 
            this.maskedTextBoxStart6.Enabled = false;
            this.maskedTextBoxStart6.Location = new System.Drawing.Point(138, 123);
            this.maskedTextBoxStart6.Mask = "00:00,00";
            this.maskedTextBoxStart6.Name = "maskedTextBoxStart6";
            this.maskedTextBoxStart6.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxStart6.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(461, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 14);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(461, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 14);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(461, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 14);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(461, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 14);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(461, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 14);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(461, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 14);
            this.panel6.TabIndex = 23;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(462, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 88);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "Bildschirmanzeige und LEDs sind nicht synchronisiert.\r\nEs gilt die LED-Anzeige!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 509);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSerialConnect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonSerialRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSerialPort);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PursuitRace v1.0beta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSerialRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnectionStatus;
        private System.Windows.Forms.Button buttonSerialConnect;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRefTime1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRefTime2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRefTime3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRefTime4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRefTime5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRefTime6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStart1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStart2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStart3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStart4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStart5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStart6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Log;
        private System.Windows.Forms.Timer timer1;
        private int timerTicks;
        private System.DateTime timerStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}

