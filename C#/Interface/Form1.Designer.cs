namespace WindowsFormsApplication1
{
    partial class Form1_load
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.off = new System.Windows.Forms.Button();
            this.on_call = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.led1 = new NationalInstruments.UI.WindowsForms.Led();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericEdit3 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit2 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEdit1 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.knob3 = new NationalInstruments.UI.WindowsForms.Knob();
            this.knob1 = new NationalInstruments.UI.WindowsForms.Knob();
            this.knob2 = new NationalInstruments.UI.WindowsForms.Knob();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.off);
            this.groupBox1.Controls.Add(this.on_call);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 108);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки соединения";
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.White;
            this.off.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.off.Location = new System.Drawing.Point(6, 77);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(177, 23);
            this.off.TabIndex = 24;
            this.off.Text = "Отключиться";
            this.off.UseVisualStyleBackColor = false;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // on_call
            // 
            this.on_call.BackColor = System.Drawing.Color.White;
            this.on_call.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.on_call.Location = new System.Drawing.Point(6, 48);
            this.on_call.Name = "on_call";
            this.on_call.Size = new System.Drawing.Size(177, 23);
            this.on_call.TabIndex = 23;
            this.on_call.Text = "Подключиться";
            this.on_call.UseVisualStyleBackColor = false;
            this.on_call.Click += new System.EventHandler(this.on_call_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.Black;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.ForeColor = System.Drawing.Color.Lime;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(104, 21);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(77, 21);
            this.comboBox5.TabIndex = 22;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "№ COM порта:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(473, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(75, 54);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Select N";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "With";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(488, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "N";
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.Black;
            this.comboBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.comboBox9.ForeColor = System.Drawing.Color.Lime;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "04",
            "12",
            "20",
            "28",
            "36",
            "44",
            "52",
            "60",
            "68",
            "76",
            "84",
            "92",
            "100",
            "108",
            "116",
            "124",
            "132",
            "140",
            "148",
            "156",
            "164",
            "172",
            "180",
            "188",
            "196",
            "204",
            "212",
            "220",
            "228",
            "236",
            "244",
            "252"});
            this.comboBox9.Location = new System.Drawing.Point(473, 79);
            this.comboBox9.MinimumSize = new System.Drawing.Size(44, 0);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(57, 21);
            this.comboBox9.TabIndex = 38;
            this.comboBox9.Text = "04";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(473, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Write";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.led1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(554, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(75, 120);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Work";
            // 
            // led1
            // 
            this.led1.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.led1.Location = new System.Drawing.Point(6, 10);
            this.led1.Name = "led1";
            this.led1.OffColor = System.Drawing.Color.Red;
            this.led1.Size = new System.Drawing.Size(35, 35);
            this.led1.TabIndex = 47;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(6, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 27);
            this.button4.TabIndex = 17;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.stop);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(6, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 27);
            this.button3.TabIndex = 16;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.start);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(555, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 40);
            this.button6.TabIndex = 30;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.numericEdit3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericEdit2);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.numericEdit1);
            this.groupBox2.Controls.Add(this.comboBox9);
            this.groupBox2.Controls.Add(this.knob3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.knob1);
            this.groupBox2.Controls.Add(this.knob2);
            this.groupBox2.Location = new System.Drawing.Point(1, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 189);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка параметров";
            // 
            // numericEdit3
            // 
            this.numericEdit3.BackColor = System.Drawing.Color.Black;
            this.numericEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.numericEdit3.ForeColor = System.Drawing.Color.Lime;
            this.numericEdit3.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.numericEdit3.Location = new System.Drawing.Point(366, 166);
            this.numericEdit3.Name = "numericEdit3";
            this.numericEdit3.Range = new NationalInstruments.UI.Range(10, 320);
            this.numericEdit3.Size = new System.Drawing.Size(54, 19);
            this.numericEdit3.TabIndex = 42;
            this.numericEdit3.Value = 10;
            // 
            // numericEdit2
            // 
            this.numericEdit2.BackColor = System.Drawing.Color.Black;
            this.numericEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.numericEdit2.ForeColor = System.Drawing.Color.Lime;
            this.numericEdit2.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.numericEdit2.Location = new System.Drawing.Point(212, 166);
            this.numericEdit2.Name = "numericEdit2";
            this.numericEdit2.Range = new NationalInstruments.UI.Range(10, 320);
            this.numericEdit2.Size = new System.Drawing.Size(54, 19);
            this.numericEdit2.TabIndex = 41;
            this.numericEdit2.Value = 10;
            // 
            // numericEdit1
            // 
            this.numericEdit1.BackColor = System.Drawing.Color.Black;
            this.numericEdit1.CoercionIntervalBase = 1;
            this.numericEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.numericEdit1.ForeColor = System.Drawing.Color.Lime;
            this.numericEdit1.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.numericEdit1.Location = new System.Drawing.Point(61, 166);
            this.numericEdit1.Name = "numericEdit1";
            this.numericEdit1.Range = new NationalInstruments.UI.Range(10, 320);
            this.numericEdit1.Size = new System.Drawing.Size(54, 19);
            this.numericEdit1.TabIndex = 40;
            this.numericEdit1.Value = 10;
            // 
            // knob3
            // 
            this.knob3.Caption = "T (ns)";
            this.knob3.CaptionBackColor = System.Drawing.Color.DarkSlateGray;
            this.knob3.CaptionFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.knob3.CoercionInterval = 10;
            this.knob3.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
            this.knob3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knob3.DialColor = System.Drawing.SystemColors.MenuText;
            this.knob3.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle3D;
            this.knob3.Location = new System.Drawing.Point(307, 19);
            this.knob3.MinorDivisions.TickLength = 1F;
            this.knob3.MinorDivisions.TickVisible = false;
            this.knob3.Name = "knob3";
            this.knob3.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.knob3.PointerColor = System.Drawing.SystemColors.Highlight;
            this.knob3.Range = new NationalInstruments.UI.Range(10, 320);
            this.knob3.Size = new System.Drawing.Size(150, 158);
            this.knob3.TabIndex = 39;
            this.knob3.ToolTipFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "F0");
            this.knob3.Value = 10;
            this.knob3.ValueChanged += new System.EventHandler(this.knob3_change);
            // 
            // knob1
            // 
            this.knob1.Caption = "Delay (ns)";
            this.knob1.CaptionBackColor = System.Drawing.Color.DarkSlateGray;
            this.knob1.CaptionFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.knob1.CoercionInterval = 10;
            this.knob1.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
            this.knob1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knob1.DialColor = System.Drawing.SystemColors.MenuText;
            this.knob1.EditRangeNumericFormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.knob1.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle3D;
            this.knob1.Location = new System.Drawing.Point(7, 19);
            this.knob1.MinorDivisions.TickLength = 1F;
            this.knob1.MinorDivisions.TickVisible = false;
            this.knob1.Name = "knob1";
            this.knob1.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.knob1.PointerColor = System.Drawing.SystemColors.Highlight;
            this.knob1.Range = new NationalInstruments.UI.Range(10, 320);
            this.knob1.Size = new System.Drawing.Size(150, 158);
            this.knob1.TabIndex = 36;
            this.knob1.ToolTipFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "F0");
            this.knob1.Value = 10;
            this.knob1.ValueChanged += new System.EventHandler(this.knob1_change);
            // 
            // knob2
            // 
            this.knob2.Caption = "Tau (ns)";
            this.knob2.CaptionBackColor = System.Drawing.Color.DarkSlateGray;
            this.knob2.CaptionFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.knob2.CoercionInterval = 10;
            this.knob2.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
            this.knob2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knob2.DialColor = System.Drawing.SystemColors.MenuText;
            this.knob2.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle3D;
            this.knob2.Location = new System.Drawing.Point(157, 19);
            this.knob2.MinorDivisions.TickLength = 1F;
            this.knob2.MinorDivisions.TickVisible = false;
            this.knob2.Name = "knob2";
            this.knob2.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.knob2.PointerColor = System.Drawing.SystemColors.Highlight;
            this.knob2.Range = new NationalInstruments.UI.Range(10, 320);
            this.knob2.Size = new System.Drawing.Size(150, 158);
            this.knob2.TabIndex = 38;
            this.knob2.ToolTipFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "F0");
            this.knob2.Value = 10;
            this.knob2.ValueChanged += new System.EventHandler(this.knob2_change);
            // 
            // comboBox10
            // 
            this.comboBox10.BackColor = System.Drawing.Color.Black;
            this.comboBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox10.ForeColor = System.Drawing.Color.Lime;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "01",
            "09",
            "17",
            "25",
            "33",
            "41",
            "49",
            "57",
            "65",
            "73",
            "81",
            "89",
            "97",
            "105",
            "113",
            "121",
            "129",
            "137",
            "145",
            "153",
            "161",
            "169",
            "177",
            "185",
            "193",
            "201",
            "209",
            "217",
            "225",
            "233",
            "241",
            "249"});
            this.comboBox10.Location = new System.Drawing.Point(582, 6);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(55, 21);
            this.comboBox10.TabIndex = 44;
            this.comboBox10.Text = "1";
            // 
            // comboBox11
            // 
            this.comboBox11.BackColor = System.Drawing.Color.Black;
            this.comboBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox11.ForeColor = System.Drawing.Color.Lime;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "02",
            "10",
            "18",
            "26",
            "34",
            "42",
            "50",
            "58",
            "66",
            "74",
            "82",
            "90",
            "98",
            "106",
            "114",
            "122",
            "130",
            "138",
            "146",
            "154",
            "162",
            "170",
            "178",
            "186",
            "194",
            "202",
            "210",
            "218",
            "226",
            "234",
            "242",
            "250"});
            this.comboBox11.Location = new System.Drawing.Point(582, 33);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(52, 21);
            this.comboBox11.TabIndex = 45;
            this.comboBox11.Text = "1";
            // 
            // comboBox12
            // 
            this.comboBox12.BackColor = System.Drawing.Color.Black;
            this.comboBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox12.ForeColor = System.Drawing.Color.Lime;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "03",
            "11",
            "19",
            "27",
            "35",
            "43",
            "51",
            "59",
            "67",
            "75",
            "83",
            "91",
            "99",
            "107",
            "115",
            "123",
            "131",
            "139",
            "147",
            "155",
            "163",
            "171",
            "179",
            "187",
            "195",
            "203",
            "211",
            "219",
            "227",
            "235",
            "243",
            "251"});
            this.comboBox12.Location = new System.Drawing.Point(582, 60);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(50, 21);
            this.comboBox12.TabIndex = 46;
            this.comboBox12.Text = "1";
            // 
            // Form1_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(642, 338);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(652, 370);
            this.MinimumSize = new System.Drawing.Size(652, 370);
            this.Name = "Form1_load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DG1";
            this.Load += new System.EventHandler(this.Form1_load_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button on_call;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private NationalInstruments.UI.WindowsForms.Knob knob1;
        private NationalInstruments.UI.WindowsForms.Knob knob3;
        private NationalInstruments.UI.WindowsForms.Knob knob2;
        private System.IO.Ports.SerialPort serialPort1;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit3;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit2;
        private NationalInstruments.UI.WindowsForms.NumericEdit numericEdit1;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox12;
        private NationalInstruments.UI.WindowsForms.Led led1;
    }
}

