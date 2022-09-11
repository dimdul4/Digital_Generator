using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using FTD2XX_NET;

namespace WindowsFormsApplication1
{
    public partial class Form1_load : Form
    {
        string sendvalue, sendvalue2, sendvalue3;
        delegate void SetTextCallback(string text);
        public Form1_load()
        {
            InitializeComponent();

            comboBox10.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false;
        }

        //Установка формата текста
        private void SetText(string text)
        {
            /*if (this.textBox2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                textBox2.Text += text;
            }*/
        }

        //Настройки соединения     
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Text = comboBox5.SelectedItem.ToString();
            serialPort1.PortName = comboBox5.Text;
        }

        private void Form1_load_Load(object sender, EventArgs e)
        {
           l1:
            UInt32 ftdiDeviceCount = 0;
            FTDI myFtdiDevice = new FTDI();
            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
            ftStatus = myFtdiDevice.GetNumberOfDevices(ref ftdiDeviceCount);
            if (ftStatus == FTDI.FT_STATUS.FT_OK)
            {
            }

            if (ftdiDeviceCount == 0)
            {
                DialogResult dlg = new DialogResult();
                dlg = MessageBox.Show("Устройство не найдено!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlg == DialogResult.OK)
                {
                    MessageBox.Show("Подключите устройство!");
                    goto l1;
                }
                else
                {
                    MessageBox.Show("Программа управления не будет запущена!");
                    Application.Exit();
                }
            }

            try
            {
                string[] availablePorts = SerialPort.GetPortNames();
                foreach (string port in availablePorts)
                {
                    comboBox5.Items.Add(port);
                }
                comboBox5.Text = comboBox5.Items[0].ToString();
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.BaudRate = 115200;
                serialPort1.PortName = comboBox5.Text;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            catch (Exception e9)
            { 
                MessageBox.Show("Подключите устройство!", e9.Message);
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = serialPort1.BytesToRead;
            byte[] comBuffer = new byte[bytes];
            serialPort1.Read(comBuffer, 0, bytes);
            SetText(ByteToHex(comBuffer));
            //SetText(ASCIIEncoding.GetEncodings(comBuffer));
        }

        //Кнопка подключиться
        private void on_call_Click(object sender, EventArgs e)
        {
            FTDI myFtdiDevice = new FTDI();
            FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OK;
            ftStatus = myFtdiDevice.OpenByDescription("DG1");
            if (ftStatus == FTDI.FT_STATUS.FT_OK)
            {
                MessageBox.Show(" Устройство готово к работе ");
            }
            else
            {
                MessageBox.Show(" Устройство не подключено.");
                MessageBox.Show("Программа управления не будет запущена!");
                Application.Exit();
            }
            ftStatus = myFtdiDevice.Close();
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    groupBox2.Visible = true;
                    groupBox3.Visible = true;
                    on_call.Enabled = false;
                    off.Enabled = true;
                    radioButton2.Checked = true;
                    comboBox9.Visible = false;
                    label9.Visible = false; 
                    button4.Enabled = false;

                    //Всплываающие подсказки при наведениии курсора                   
                    ToolTip write = new ToolTip();
                    write.SetToolTip(button1, "Запись значений для генерации");
                    ToolTip start = new ToolTip();
                    start.SetToolTip(button3, "Старт генератора");
                    ToolTip stop = new ToolTip();
                    stop.SetToolTip(button4, "Остановка генератора");
                    ToolTip exit = new ToolTip();
                    exit.ToolTipIcon = ToolTipIcon.Warning;
                    exit.SetToolTip(button6, "Выход из программы");
                    ToolTip kn1 = new ToolTip();
                    kn1.SetToolTip(knob1, "Изменение задержки импульсов");
                    kn1.SetToolTip(numericEdit1, "Изменение задержки импульсов");
                    ToolTip kn2 = new ToolTip();
                    kn2.SetToolTip(knob2, "Изменение длительности импульсов");
                    kn2.SetToolTip(numericEdit2, "Изменение длительности импульсов");
                    ToolTip kn3 = new ToolTip();
                    kn3.SetToolTip(knob3, "Изменение скважности импульсов");
                    kn3.SetToolTip(numericEdit3, "Изменение скважности импульсов");
                    ToolTip radiobut1 = new ToolTip();
                    radiobut1.SetToolTip(radioButton1, "Выбор количества импульсов");
                    ToolTip radiobut2 = new ToolTip();
                    radiobut2.SetToolTip(radioButton2, "Режим постоянной генерации");
                    ToolTip kolvo = new ToolTip();
                    kolvo.SetToolTip(comboBox9,"Количество импульсов");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        
        //Кнопка отключиться
        private void off_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                if (!serialPort1.IsOpen)
                {
                    on_call.Enabled = true;
                    off.Enabled = false;
                    groupBox2.Visible = false;
                    groupBox3.Visible = false;

                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        //Проверка заданных параметров
        //Круглые кнопки
        private void knob1_change(object sender, EventArgs e)
        {
/*            richTextBox7.Text = "Delay = " + (Convert.ToInt32(knob1.Value)) + " ns\n"
                              + "Tau = " + Convert.ToInt32(knob2.Value) + " ns\n"
                              + "T = " + Convert.ToInt32(knob3.Value) + " ns\n";*/

            numericEdit1.Source = knob1;
            if (knob1.Value == 10) { sendvalue = Convert.ToString(comboBox10.Items[0]); }
            else if (knob1.Value == 20) { sendvalue = Convert.ToString(comboBox10.Items[1]); }
            else if (knob1.Value == 30) { sendvalue = Convert.ToString(comboBox10.Items[2]); }
            else if (knob1.Value == 40) { sendvalue = Convert.ToString(comboBox10.Items[3]); }
            else if (knob1.Value == 50) { sendvalue = Convert.ToString(comboBox10.Items[4]); }
            else if (knob1.Value == 60) { sendvalue = Convert.ToString(comboBox10.Items[5]); }
            else if (knob1.Value == 70) { sendvalue = Convert.ToString(comboBox10.Items[6]); }
            else if (knob1.Value == 80) { sendvalue = Convert.ToString(comboBox10.Items[7]); }
            else if (knob1.Value == 90) { sendvalue = Convert.ToString(comboBox10.Items[8]); }
            else if (knob1.Value == 100) { sendvalue = Convert.ToString(comboBox10.Items[9]); }
            else if (knob1.Value == 110) { sendvalue = Convert.ToString(comboBox10.Items[10]); }
            else if (knob1.Value == 120) { sendvalue = Convert.ToString(comboBox10.Items[11]); }
            else if (knob1.Value == 130) { sendvalue = Convert.ToString(comboBox10.Items[12]); }
            else if (knob1.Value == 140) { sendvalue = Convert.ToString(comboBox10.Items[13]); }
            else if (knob1.Value == 150) { sendvalue = Convert.ToString(comboBox10.Items[14]); }
            else if (knob1.Value == 160) { sendvalue = Convert.ToString(comboBox10.Items[15]); }
            else if (knob1.Value == 170) { sendvalue = Convert.ToString(comboBox10.Items[16]); }
            else if (knob1.Value == 180) { sendvalue = Convert.ToString(comboBox10.Items[17]); }
            else if (knob1.Value == 190) { sendvalue = Convert.ToString(comboBox10.Items[18]); }
            else if (knob1.Value == 200) { sendvalue = Convert.ToString(comboBox10.Items[19]); }
            else if (knob1.Value == 210) { sendvalue = Convert.ToString(comboBox10.Items[20]); }
            else if (knob1.Value == 220) { sendvalue = Convert.ToString(comboBox10.Items[21]); }
            else if (knob1.Value == 230) { sendvalue = Convert.ToString(comboBox10.Items[22]); }
            else if (knob1.Value == 240) { sendvalue = Convert.ToString(comboBox10.Items[23]); }
            else if (knob1.Value == 250) { sendvalue = Convert.ToString(comboBox10.Items[24]); }
            else if (knob1.Value == 260) { sendvalue = Convert.ToString(comboBox10.Items[25]); }
            else if (knob1.Value == 270) { sendvalue = Convert.ToString(comboBox10.Items[26]); }
            else if (knob1.Value == 280) { sendvalue = Convert.ToString(comboBox10.Items[27]); }
            else if (knob1.Value == 290) { sendvalue = Convert.ToString(comboBox10.Items[28]); }
            else if (knob1.Value == 300) { sendvalue = Convert.ToString(comboBox10.Items[29]); }
            else if (knob1.Value == 310) { sendvalue = Convert.ToString(comboBox10.Items[30]); }
            else if (knob1.Value == 320) { sendvalue = Convert.ToString(comboBox10.Items[31]); }
        }
        
        private void knob2_change(object sender, EventArgs e)
        {
           /* richTextBox7.Text = "Delay = " + (Convert.ToInt32(knob1.Value)) + " ns\n"
                              + "Tau = " + Convert.ToInt32(knob2.Value) + " ns\n"
                              + "T = " + Convert.ToInt32(knob3.Value) + " ns\n";*/

            numericEdit2.Source = knob2;
            if (knob2.Value == 10) { sendvalue2 = Convert.ToString(comboBox11.Items[0]); }
            else if (knob2.Value == 20) { sendvalue2 = Convert.ToString(comboBox11.Items[1]); }
            else if (knob2.Value == 30) { sendvalue2 = Convert.ToString(comboBox11.Items[2]); }
            else if (knob2.Value == 40) { sendvalue2 = Convert.ToString(comboBox11.Items[3]); }
            else if (knob2.Value == 50) { sendvalue2 = Convert.ToString(comboBox11.Items[4]); }
            else if (knob2.Value == 60) { sendvalue2 = Convert.ToString(comboBox11.Items[5]); }
            else if (knob2.Value == 70) { sendvalue2 = Convert.ToString(comboBox11.Items[6]); }
            else if (knob2.Value == 80) { sendvalue2 = Convert.ToString(comboBox11.Items[7]); }
            else if (knob2.Value == 90) { sendvalue2 = Convert.ToString(comboBox11.Items[8]); }
            else if (knob2.Value == 100) { sendvalue2 = Convert.ToString(comboBox11.Items[9]); }
            else if (knob2.Value == 110) { sendvalue2 = Convert.ToString(comboBox11.Items[10]); }
            else if (knob2.Value == 120) { sendvalue2 = Convert.ToString(comboBox11.Items[11]); }
            else if (knob2.Value == 130) { sendvalue2 = Convert.ToString(comboBox11.Items[12]); }
            else if (knob2.Value == 140) { sendvalue2 = Convert.ToString(comboBox11.Items[13]); }
            else if (knob2.Value == 150) { sendvalue2 = Convert.ToString(comboBox11.Items[14]); }
            else if (knob2.Value == 160) { sendvalue2 = Convert.ToString(comboBox11.Items[15]); }
            else if (knob2.Value == 170) { sendvalue2 = Convert.ToString(comboBox11.Items[16]); }
            else if (knob2.Value == 180) { sendvalue2 = Convert.ToString(comboBox11.Items[17]); }
            else if (knob2.Value == 190) { sendvalue2 = Convert.ToString(comboBox11.Items[18]); }
            else if (knob2.Value == 200) { sendvalue2 = Convert.ToString(comboBox11.Items[19]); }
            else if (knob2.Value == 210) { sendvalue2 = Convert.ToString(comboBox11.Items[20]); }
            else if (knob2.Value == 220) { sendvalue2 = Convert.ToString(comboBox11.Items[21]); }
            else if (knob2.Value == 230) { sendvalue2 = Convert.ToString(comboBox11.Items[22]); }
            else if (knob2.Value == 240) { sendvalue2 = Convert.ToString(comboBox11.Items[23]); }
            else if (knob2.Value == 250) { sendvalue2 = Convert.ToString(comboBox11.Items[24]); }
            else if (knob2.Value == 260) { sendvalue2 = Convert.ToString(comboBox11.Items[25]); }
            else if (knob2.Value == 270) { sendvalue2 = Convert.ToString(comboBox11.Items[26]); }
            else if (knob2.Value == 280) { sendvalue2 = Convert.ToString(comboBox11.Items[27]); }
            else if (knob2.Value == 290) { sendvalue2 = Convert.ToString(comboBox11.Items[28]); }
            else if (knob2.Value == 300) { sendvalue2 = Convert.ToString(comboBox11.Items[29]); }
            else if (knob2.Value == 310) { sendvalue2 = Convert.ToString(comboBox11.Items[30]); }
            else if (knob2.Value == 320) { sendvalue2 = Convert.ToString(comboBox11.Items[31]); }
        }
        
        private void knob3_change(object sender, EventArgs e)
        {
          /*  richTextBox7.Text = "Delay = " + (Convert.ToInt32(knob1.Value)) + " ns\n"
                              + "Tau = " + Convert.ToInt32(knob2.Value) + " ns\n"
                              + "T = " + Convert.ToInt32(knob3.Value) + " ns\n";*/

            numericEdit3.Source = knob3;
            if (knob3.Value == 10) { sendvalue3 = Convert.ToString(comboBox12.Items[0]); }
            else if (knob3.Value == 20) { sendvalue3 = Convert.ToString(comboBox12.Items[1]); }
            else if (knob3.Value == 30) { sendvalue3 = Convert.ToString(comboBox12.Items[2]); }
            else if (knob3.Value == 40) { sendvalue3 = Convert.ToString(comboBox12.Items[3]); }
            else if (knob3.Value == 50) { sendvalue3 = Convert.ToString(comboBox12.Items[4]); }
            else if (knob3.Value == 60) { sendvalue3 = Convert.ToString(comboBox12.Items[5]); }
            else if (knob3.Value == 70) { sendvalue3 = Convert.ToString(comboBox12.Items[6]); }
            else if (knob3.Value == 80) { sendvalue3 = Convert.ToString(comboBox12.Items[7]); }
            else if (knob3.Value == 90) { sendvalue3 = Convert.ToString(comboBox12.Items[8]); }
            else if (knob3.Value == 100) { sendvalue3 = Convert.ToString(comboBox12.Items[9]); }
            else if (knob3.Value == 110) { sendvalue3 = Convert.ToString(comboBox12.Items[10]); }
            else if (knob3.Value == 120) { sendvalue3 = Convert.ToString(comboBox12.Items[11]); }
            else if (knob3.Value == 130) { sendvalue3 = Convert.ToString(comboBox12.Items[12]); }
            else if (knob3.Value == 140) { sendvalue3 = Convert.ToString(comboBox12.Items[13]); }
            else if (knob3.Value == 150) { sendvalue3 = Convert.ToString(comboBox12.Items[14]); }
            else if (knob3.Value == 160) { sendvalue3 = Convert.ToString(comboBox12.Items[15]); }
            else if (knob3.Value == 170) { sendvalue3 = Convert.ToString(comboBox12.Items[16]); }
            else if (knob3.Value == 180) { sendvalue3 = Convert.ToString(comboBox12.Items[17]); }
            else if (knob3.Value == 190) { sendvalue3 = Convert.ToString(comboBox12.Items[18]); }
            else if (knob3.Value == 200) { sendvalue3 = Convert.ToString(comboBox12.Items[19]); }
            else if (knob3.Value == 210) { sendvalue3 = Convert.ToString(comboBox12.Items[20]); }
            else if (knob3.Value == 220) { sendvalue3 = Convert.ToString(comboBox12.Items[21]); }
            else if (knob3.Value == 230) { sendvalue3 = Convert.ToString(comboBox12.Items[22]); }
            else if (knob3.Value == 240) { sendvalue3 = Convert.ToString(comboBox12.Items[23]); }
            else if (knob3.Value == 250) { sendvalue3 = Convert.ToString(comboBox12.Items[24]); }
            else if (knob3.Value == 260) { sendvalue3 = Convert.ToString(comboBox12.Items[25]); }
            else if (knob3.Value == 270) { sendvalue3 = Convert.ToString(comboBox12.Items[26]); }
            else if (knob3.Value == 280) { sendvalue3 = Convert.ToString(comboBox12.Items[27]); }
            else if (knob3.Value == 290) { sendvalue3 = Convert.ToString(comboBox12.Items[28]); }
            else if (knob3.Value == 300) { sendvalue3 = Convert.ToString(comboBox12.Items[29]); }
            else if (knob3.Value == 310) { sendvalue3 = Convert.ToString(comboBox12.Items[30]); }
            else if (knob3.Value == 320) { sendvalue3 = Convert.ToString(comboBox12.Items[31]); }
        }
        
        //Выбор работы : с N или без
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox9.Visible = true;
                label9.Visible = true;
            }
            else
            {
                comboBox9.Visible = false;
                label9.Visible = false;
            }
        }
        //Запись
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //******первая посылка (запись Delay)
                string tmp1 = sendvalue;
                byte[] newMsg1 = Hex1(tmp1);
                serialPort1.Write(newMsg1, 0, newMsg1.Length);
                //******вторая посылка (запись Tau)
                string tmp2 = sendvalue2;
                byte[] newMsg2 = Hex1(tmp2);
                serialPort1.Write(newMsg2, 0, newMsg2.Length);
                //******третья посылка (запись T)
                string tmp3 = sendvalue3;
                byte[] newMsg3 = Hex1(tmp3);
                serialPort1.Write(newMsg3, 0, newMsg3.Length);
                //******четвертая посылка (запись N)
                if (radioButton1.Checked == true)
                {
                    string tmp4 = comboBox9.Text;
                    byte[] newMsg4 = Hex1(tmp4);
                    serialPort1.Write(newMsg4, 0, newMsg4.Length);
                }
                else
                {
                    
                }
            }
            catch (Exception e7)
            {
                MessageBox.Show(e7.Message);
            }
        }

        //Кнопка Start (запуск генератора)
        private void start(object sender, EventArgs e)
        {
            try
            {
                string start = "05";
                byte[] newMsg1 = HexToByte(start);//новая переменная(на отправку)
                serialPort1.Write(newMsg1, 0, newMsg1.Length);
                //button3.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = true;
                led1.Value = true;
            }
            catch (Exception e8)
            {
                MessageBox.Show(e8.Message);
            }
        }

        //Кнопка Stop (остановка генератора)
        private void stop(object sender, EventArgs e)
        {
            try
            {
                string stop = "06";
                byte[] newMsg1 = HexToByte(stop);//новая переменная(на отправку)
                serialPort1.Write(newMsg1, 0, newMsg1.Length);
                //button4.Enabled = false;
                button1.Enabled = true;
                button3.Enabled = true;
                led1.Value = false;
            }
            catch (Exception e9)
            {
                MessageBox.Show(e9.Message);
            }
        }

        //Кнопка EXIT
        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }

        //Перевод массива битов в HEX строку
        private string ByteToHex(byte[] comByte)
        {
            StringBuilder builder = new StringBuilder(comByte.Length * 3);
            foreach (byte data in comByte)
                builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            return builder.ToString().ToUpper();
        }

        //Перевод HEX строки в массив битов
        private byte[] HexToByte(string msg)
        {
            msg = msg.Replace(" ", "");
            byte[] comBuffer = new byte[msg.Length / 2];
            for (int i = 0; i < msg.Length; i += 2)
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            return comBuffer;
        }

        private byte[] Hex1(string msg)
        {
            msg = msg.Replace(" ", "");
            byte[] comBuffer = new byte[msg.Length/2];
            for (int i = 0; i < msg.Length/2; i++ )
                comBuffer[i/2] = (byte)Convert.ToByte(msg.Substring(i));
            return comBuffer;
        }
        
    }
}
