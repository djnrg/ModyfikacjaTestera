using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;              //uzycie derektywy Ports

namespace COMautodetect
{
    public partial class Form1 : Form
    {
        
        int InttializeLenght = 0;
        int baudRate;
        
        string[] ZmienneText = new string[1];

        //double Tsuc = 0;
        //double Tdis = 0;
        //double TcondenserIn = 0;
        //double TcondenserOut = 0;
        //double TevapuratorIn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        
///Wykorzystaniu Eventu Timera 
///Ustawionego na 100
    private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
           

            if (InttializeLenght != ports.Length)
            {
                InttializeLenght = ports.Length;

                ComBox.Items.Clear();
                for (int j = 0; j < InttializeLenght; j++)
                {
                    ComBox.Items.Add(ports[j]);
                }
                ComBox.Text=ports[0];
                BaudCombo.SelectedIndex = 0;
                

            }
        }

    private void button1_Click(object sender, EventArgs e)
    {
        if (labelStatus.Text == "Disconnect")
        {   
            
            baudRate = Convert.ToInt32(BaudCombo.Text) ;
            COM.PortName = ComBox.Text;
            COM.BaudRate = baudRate;
            
            COM.Open();
            timer1.Stop();

            labelStatus.Text = baudRate.ToString();
            
            button1.Text = "Disconnect";
            buttonSend.Enabled = true;
        
        }

     else
        {
            COM.Close();
            labelStatus.Text = "Disconnect";
            button1.Text = "Connect";
            buttonSend.Enabled = false;
            timer1.Start();
        }
    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
        string s;

        if (COM.IsOpen)
        {
            s = txtSend.Text;
            COM.WriteLine(s);
        }
            
    }

    private void OnCom(object sender, SerialDataReceivedEventArgs e)
    {
        if (COM.IsOpen)
        {

            ZmienneText = COM.ReadLine().Replace('.', ',').Split(';');          //19 wartosci
            
            double[] zmienne = Array.ConvertAll(ZmienneText, Double.Parse);

        //Tsuc = Convert.ToDouble(ZmienneText[0]);
        //Tdis = Convert.ToDouble(ZmienneText[1]);
        //TcondenserIn = Convert.ToDouble(ZmienneText[2]);
        //TcondenserOut = Convert.ToDouble(ZmienneText[3]);
        //TevapuratorIn = Convert.ToDouble(ZmienneText[19]);

        //gauge1.Value = Tsuc;
        //gauge2.Value = Tdis;
        //thermometer1.Value = TcondenserIn;
        //tank1.Value = TcondenserOut;
        //meter1.Value = TevapuratorIn;
                        
            gauge1.Value = zmienne[0];
            gauge2.Value = zmienne[1];
            thermometer1.Value = zmienne[2];
            tank1.Value = zmienne[3];
            meter1.Value = zmienne[4];


        SetTextBox(textBox1, zmienne[3].ToString());

        SetTextLabel(label3, zmienne[4].ToString());

        
        }

    }

              



    private void switch1_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
    {
        led1.Value = switch1.Value;
    }


    public void SetTextBox(TextBox tb, string value)
    {
        if (InvokeRequired)
        {
            this.Invoke(new Action<TextBox, string>(SetTextBox), new object[] { tb, value });
            return;
        }
        tb.AppendText(value + Environment.NewLine);
    }



//Ustawienie tesktu jako LABEL
    public void SetTextLabel(Label lab, string value)
    {
        if (InvokeRequired)
        {
            this.Invoke(new Action<Label, string>(SetTextLabel), new object[] {lab, value });
            return;
        }
        lab.Text = value;
       
    }

    private void edycaDBToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form2 f2 = new Form2();
        f2.Show();
    }

    private void dBSetupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form3 f3 = new Form3();
        f3.Show();
    }



    }
}
