using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;              //uzycie derektywy Ports
using System.Xml;                   //uzycie dyrektyw XML
using System.IO;                    //uzycie dyrektyw IO

namespace Tester_VFS169
{
    public partial class FormMain : Form
    {
        
        

        public static double[] zmienne;
        /// <value>
        /// Zmienne do obsługi portu COM
        /// </value>
        int InttializeLenght = 0;
        int baudRate;

        /// <value>
        /// Tablica zmiennych przychodzacych z SerialPort
        /// </value>
        string[] ZmienneCOM = new string[1];

        /// <value>
        /// Zmienne dla stopera
        /// </value>
        private int t = 0;          //  sekundy
        private int s1 = 0;         //  minuty
        private int s2 = 0;         //  godiny
        public static bool dzialanie = false;

        /// <value>
        /// Obliczenie ilości cykli cewki
        /// </value>
        int iloscCykli = 0;
        int iloscCykliLast = 0;

        /// <value>
        /// Deklaracja folderów i plików
        /// </value>
        private string GlobalFolder;
        private string TestSettings = "Settings.xml";
        private string PlikRaportu = "Report.txt";
      


        public FormMain()
        {
            InitializeComponent();
            
           
        }

        /// <summary>
        /// Zamykanie aplikacji z wykorzystaniem potwierdzenia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        #if DEBUG

        #else
                    if (MessageBox.Show("Continue this application", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
        #endif


            //zamkniecie portu COM
            COM.Close();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Obsługa portu COM
        /// Automatyczna detekcja podłaczonych portów COM
        /// Podłaczenie do wybranych ustawien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCOM_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            try
            {
                if (InttializeLenght != ports.Length)
                {
                    InttializeLenght = ports.Length;

                    StripCOM.Items.Clear();
                    for (int j = 0; j < InttializeLenght; j++)
                    {
                        StripCOM.Items.Add(ports[j]);

                    }
                    StripCOM.Text = ports[0];
                    StripBaud.SelectedIndex = 0;
                    StripProgressCOM.Value = 50;
                    StripConnect.Enabled = true;
                }
            }

            catch
            {
                MessageBox.Show("COM Ports not connected!!!\n" + "Check your device", "COM Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StripCOM.Text = "";
                StripBaud.Text = "";
                StripProgressCOM.Value = 0;

            }
        }


        /// <summary>
        /// Połaczenie sie do ustawionego SERILA PORT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StripConnect_Click(object sender, EventArgs e)
        {

            try
            {
                if (StripConnect.Text == "Connect!!!")
                {
                    baudRate = Convert.ToInt32(StripBaud.Text);
                    COM.PortName = StripCOM.Text;
                    COM.BaudRate = baudRate;

                    COM.Open();
                    timerCOM.Stop();

                    StripProgressCOM.Value = 100;
                    StripConnect.Text = "Disconnect";
                }

                else
                {
                    COM.Close();
                    StripProgressCOM.Value = 50;
                    StripConnect.Text = "Connect!!!";
                    StripStatusDane.Text = "Dane???";
                    timerCOM.Start();
                }
            }



            catch
            {
                MessageBox.Show("COM Ports not connected!!!\n" + "Check your device", "COM Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StripCOM.Text = "";
                StripBaud.Text = "";
                StripProgressCOM.Value = 0;
            }

        }



        /// <summary>
        /// Metoda wpisywania wartosci do TEXT BOX
        /// </summary>
        /// <example>
        /// SetTextBox(textBox1, zmienne[3].ToString());
        /// textBox1 ===== nazwa kontrolki
        /// zmienne[3].ToString() ===== wartosc przekazywana 
        /// </example>
        /// <param name="tb"></param>
        /// <param name="value"></param>
        public void SetTextBox(TextBox tb, string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<TextBox, string>(SetTextBox), new object[] { tb, value });
                return;
            }

            tb.Text = value;
        }


        /// <summary>
        /// Metoda wpisywania wartosci do Label
        /// </summary>
        /// <example>
        /// SetTextLabel(label1, zmienne[3].ToString());
        /// textBox1 ===== nazwa kontrolki
        /// zmienne[3].ToString() ===== wartosc przekazywana 
        /// </example>
        /// <param name="lab"></param>
        /// <param name="value"></param>
        public void SetTextLabel(Label lab, string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Label, string>(SetTextLabel), new object[] { lab, value });
                return;
            }

            lab.Text = value;

        }


        /// <summary>
        /// Wyswietlanie danych przychodzacych z SerialPort na kontrolki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void COM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (COM.IsOpen)
            {
                try
                {
                    ///<remarks>
                    ///Rozbicie tekstu przychodzącegoz SerialPort na tablice zmiennych
                    ///</remarks>


                    ZmienneCOM = COM.ReadLine().Replace('.', ',').Split(';');          //19 wartosci

                    //double[] 
                        zmienne = Array.ConvertAll(ZmienneCOM, Double.Parse);

                    StripStatusDane.Text = "OK";
                    
                    /*
                    0       //Serial.print  (Tsuc);					
                    1       //Serial.print  (Tdis);					
                    2       //Serial.print  (TcondenserIn);			
                    3       //Serial.print  (TcondenserOut);		
                    4       //Serial.print  (TevapuratorIn);		
                    5       //Serial.print  (TevapuratorOut);		
                    6       //Serial.print  (Thotbox);				
                    7       //Serial.print  (Tcompressor);			
                    8       //Serial.print  (TairIn);				
                    9       //Serial.print  (HairIn);				
                    10      //Serial.print  (TairOut);	
                    11      //Serial.print  (HairOut);
                    12      //Serial.print  (Psuc);		
                    13      //Serial.print  (Pdis);		
                    14      //Serial.print  (COILvoltage);		
                    15      //Serial.print  (readCurrent(COILcurrent),3);	
                    16      //Serial.print  (ECVvoltage);	
                    17      //Serial.print  (readCurrent(ECVcurrent),3);	
                    18      //Serial.print  (Cewka);
                    19      //Serial.print  (rpm);
                    */

                                       
                    //Discharge
                    gaugeDischarge.Value = zmienne[13];
                    SetTextLabel(gaugeDischargeLAB, zmienne[13].ToString());
                    thermometerDischarge.Value = zmienne[1];
                    SetTextBox(thermometerDischargeTB, zmienne[1].ToString() + " °C");
                    
                    //Suction
                    gaugeSuction.Value = zmienne[12];
                    SetTextLabel(gaugeSuctionLAB, zmienne[12].ToString());
                    thermometerSuction.Value = zmienne[0];
                    SetTextBox(thermometerSuctionTB, zmienne[0].ToString() + " °C");

                    //Condenser
                    thermometerCondIn.Value = zmienne[2];
                    SetTextBox(thermometerCondInTB, zmienne[2].ToString() + " °C");
                    thermometerCondOut.Value = zmienne[3];
                    SetTextBox(thermometerCondOutTB, zmienne[3].ToString() + " °C");

                    //Compressor
                    thermometerCompressor.Value = zmienne[7];
                    SetTextBox(thermometerCompressorTB, zmienne[7].ToString() + " °C");

                    if (zmienne[7] >= Convert.ToDouble(textBoxCompressorLimit.Text))
                    {
                        ledCompressor.Value = true;
                    }
                    else
                    {
                        ledCompressor.Value = false;
                    }


                    //Evapurator
                    SetTextBox(thermometerEvapInTB, zmienne[4].ToString() + " °C");
                    SetTextBox(thermometerEvapOutTB, zmienne[5].ToString() + " °C");

                    //Air in Evapurator
                    SetTextBox(thermometerAirInTB, zmienne[8].ToString() + " °C");
                    SetTextBox(thermometerAirOutTB, zmienne[10].ToString() + " °C");
                    SetTextBox(HumidityAirInTB, zmienne[9].ToString() + " %");
                    SetTextBox(HumidityAirOutTB, zmienne[11].ToString() + " %");


                    //Hotbox
                    thermometerHotbox.Value = zmienne[6];
                    SetTextBox(thermometerHotboxTB, zmienne[6].ToString() + " °C");
                    if (zmienne[6] >= Convert.ToDouble(textBoxHBmin.Text) & zmienne[6] <= Convert.ToDouble(textBoxHBmax.Text))
                    {
                        ledHotbox.Value = true;
                    }
                    else
                    {
                        ledHotbox.Value = false;
                    }


                    //Coil
                    
                    meterCoilVoltage.Value = zmienne[14];
                    meterCoilCurrent.Value = zmienne[15];

                    if (zmienne[18] == 1)
                    {
                        ledCoil.Value = true;
                    }
                    else
                    {
                        ledCoil.Value = false;
                    }

                    if (zmienne[18] == 1 & iloscCykliLast == 0 & dzialanie == true)
                    {
                        iloscCykli++;
                        iloscCykliLast = 1;
                    }
                    if (zmienne[18] == 0 & iloscCykliLast ==1)
                    {
                        iloscCykliLast = 0;
                    }
                    
                    SetTextBox(textBoxCoilCycles, iloscCykli.ToString());


                    //ECV
                    SetTextBox(textBoxECVvoltage, zmienne[16].ToString() + " V");
                    SetTextBox(textBoxECVcurrent, zmienne[17].ToString() + " A");

                    //RPM
                    meterRPM.Value = zmienne[19];


                }
                catch
                {
                    StripStatusDane.Text = "Brak danych";
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #if DEBUG
            timerStoper.Interval = 10;        //Ustwienie timera dla stopera na 1 sekude     
            buttonDisconnect.Visible = true;
            #else
            timerStoper.Interval = 1000;        //Ustwienie timera dla stopera na 1 sekude     
            SplashScreen SS = new SplashScreen();
            SS.ShowDialog();                    //Wyswietlenie splash scrren
            #endif


        }

        /// <summary>
        /// Stoper działania testera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStoper_Tick(object sender, EventArgs e)
        {
            t++;

            // Obliczenia dla minut
            if (t >= 60)
            {
                t = 0;
                s1++;
            }


            // Obliczenia dla godzin
            if (s1 >= 60)
            {
                s1 = 0;
                s2++;
            }
            //Wyswietlanie czasu działania testu
            labelStoper.Text = String.Format("{0:D3}:{1:D2}:{2:d2}", s2, s1, t);
        }


        /// <summary>
        /// Obsługa przycisku "START" / "PAUSE"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (dzialanie == false)
            {
                timerStoper.Enabled = true;
                buttonStart.Text = "PAUSE";
                dzialanie = true;
                ledStoper.Value = true;

            }
            else
            {
                timerStoper.Enabled = false;
                buttonStart.Text = "START";
                dzialanie = false;
                ledStoper.Value = false;


            }
        }


        /// <summary>
        /// Obsługa przycisku "RESET"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {

        #if DEBUG
                    {
                        timerStoper.Enabled = false;
                        s2 = 0; s1 = 0; t = 0;
                        labelStoper.Text = "000:00:00";
                        buttonStart.Text = "START";
                        dzialanie = false;
                        ledStoper.Value = false;
                        iloscCykli = 0;
                        iloscCykliLast = 0;
                    }

        #else
                    if (MessageBox.Show("Continue this test", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        timerStoper.Enabled = false;
                        s2 = 0; s1 = 0; t = 0;
                        labelStoper.Text = "000:00:00";
                        buttonStart.Text = "START";
                        dzialanie = false;
                        ledStoper.Value = false;
                        iloscCykli = 0;
                        iloscCykliLast = 0;
                    }
        #endif

        }


        /// <summary>
        /// Wyswietlanie okna dialogowego "About"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AB = new AboutBox();
            AB.ShowDialog();
        }


        /// <summary>
        /// Wyswietlanie okna dialogowego "AC loop parameters"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aCLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormACLoop f = new FormACLoop();
            //f.Show();

            aCLoopToolStripMenuItem.Checked = true;
        }


        /// <summary>
        /// Wyswietlanie Splash Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splashScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreen SS = new SplashScreen();
            SS.ShowDialog();                    //Wyswietlenie splash scrren
        }


        /// <summary>
        /// Wyswietlanie okna dialogowego "Pressure"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pressuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPressures FP = new FormPressures();
            FP.Show();
        }

        /// <summary>
        /// Wyswietlanie okna dialogowego "Temperatures"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperature FT = new FormTemperature();
            FT.Show();
        }


        /// <summary>
        /// Zapisywanych danych do XML przy zamknieciu programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlTextWriter xml = null;

            try
            {
                //tworzenie pliku
                xml = new XmlTextWriter(TestSettings, System.Text.Encoding.UTF8);
                xml.Formatting = Formatting.Indented;
                xml.WriteStartDocument(true);

                xml.WriteComment("Last test parameters before application close");

                //<Settings global>>
                xml.WriteStartElement("Settings");

                //<test time>
                xml.WriteStartElement("time");
                xml.WriteElementString("Hour", s2.ToString());
                xml.WriteElementString("Minute", s1.ToString());
                xml.WriteElementString("Sekunds", t.ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("CoilCyclesTotal");
                xml.WriteElementString("Cykles", iloscCykli.ToString());
                xml.WriteEndElement();

                xml.WriteStartElement("DeafaltSettingsLocation");
                xml.WriteElementString("GlobalLocation",  GlobalFolder.ToString());
                xml.WriteElementString("SettingsLocation", TestSettings.ToString());
                xml.WriteElementString("ReportLocation", PlikRaportu.ToString());
                xml.WriteEndElement();


                xml.WriteEndElement();

                xml.WriteEndDocument();

                COM.Close();
            }

            catch (Exception exc)
            {
                MessageBox.Show("Error writing settings for files (" + exc.Message + ")");

            }

            finally
            {
                xml.Close();
                
            }

        }


        /// <summary>
        /// Oczytywanie danych do XML dla opcji Test Description -> Continu test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileSetting.ShowDialog() == DialogResult.OK)
            {
                TestSettings = openFileSetting.FileName;
            }
            
            XmlTextReader xml = null;

            try
            {
                xml = new XmlTextReader(TestSettings);

                xml.ReadStartElement("Settings");
                
                xml.Read();

                //<time>
                xml.ReadStartElement("time");
                s2 = int.Parse(xml.ReadElementString("Hour"));
                s1 = int.Parse(xml.ReadElementString("Minute"));
                t = int.Parse(xml.ReadElementString("Sekunds"));
                xml.ReadEndElement();

                xml.ReadStartElement("CoilCyclesTotal");
                iloscCykli = int.Parse(xml.ReadElementString("Cykles"));
                xml.ReadEndElement();


                xml.ReadStartElement("DeafaltSettingsLocation");
                GlobalFolder = xml.ReadElementString("GlobalLocation");
                TestSettings = xml.ReadElementString("SettingsLocation");
                PlikRaportu = xml.ReadElementString("ReportLocation");
                
                xml.ReadEndElement();


                xml.ReadEndElement();

                //Wyswietlanie czasu działania testu
                labelStoper.Text = String.Format("{0:D3}:{1:D2}:{2:d2}", s2, s1, t);
                textBoxCoilCycles.Text = iloscCykli.ToString();

            }

            catch (Exception exc)
            {
                MessageBox.Show("Błąd w odczycie pliku (" + exc.Message + ")");
            }
            finally
            {
                xml.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            COM.Close();
            StripProgressCOM.Value = 50;
            StripConnect.Text = "Connect!!!";
            StripStatusDane.Text = "Dane???";
            timerCOM.Start();
        }


        /// <summary>
        /// Inicjalizacja pliku raportu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            if (SaveFileReport.ShowDialog() == DialogResult.OK)
            {
                PlikRaportu = SaveFileReport.FileName;
                label25.Text = PlikRaportu;


                if (!File.Exists(@PlikRaportu))
                {
                    using (FileStream fileStream = new FileStream(PlikRaportu, FileMode.Append, FileAccess.Write, FileShare.None))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(fileStream))
                        {
                            streamWriter.WriteLine("DURABILITY TESTER VFS169");
                            streamWriter.WriteLine("Rozpoczęcie Testu: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());

                            

                        }
                    }
                }
            }
        }


        private void commentsToTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComments FC = new FormComments();
            FC.Show();
        }

        private void finishTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFinishTest FFinish = new FormFinishTest();
            FFinish.Show();
        }


        private void backlogFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileSetting.ShowDialog() == DialogResult.OK)
            {
                TestSettings = saveFileSetting.FileName;
            }
        }

        /// <summary>
        /// Ustawienie globalnego folderu dla aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void globalFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserGlobal.ShowDialog() == DialogResult.OK)
            {
                GlobalFolder = folderBrowserGlobal.SelectedPath;
                SaveFileReport.InitialDirectory = GlobalFolder;
                saveFileSetting.InitialDirectory = GlobalFolder;
                openFileSetting.InitialDirectory = GlobalFolder;
            }
        }

        public void WriteDataLog(string logFileName, string data)
        {
            if (!File.Exists(logFileName))
            {
                using (FileStream fileStream = new FileStream(logFileName, FileMode.Append, FileAccess.Write, FileShare.None))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        streamWriter.WriteLine(data);
                    }
                }
            }
        }

        private void SuctionBox_Enter(object sender, EventArgs e)
        {

        }

    }
}
