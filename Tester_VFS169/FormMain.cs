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
        public static string GlobalFolder;
        public static string TestSettings;// = "Settings.xml";
        public static string PlikRaportu;// = "Report.txt";

        private static bool TerminalStop = false;

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
        /// Metoda wpisywania wartosci do TERMINALA
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="value"></param>
        public void SetTextBoxLines(TextBox tbl, string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<TextBox, string>(SetTextBoxLines), new object[] { tbl, value });
                return;
            }

            tbl.AppendText(value+Environment.NewLine);
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



                    ///<remarks>
                    ///Wpisywanie zmiennych do Terminala
                    ///</remarks>
                    if (tERMINALToolStripMenuItem.Checked == true && TerminalStop == false)
                    {
                    SetTextBoxLines(Terminal, ZmienneCOM[0] + " ; " + ZmienneCOM[1] + " ; " + ZmienneCOM[2] + " ; " + ZmienneCOM[3]
                    + " ; " + ZmienneCOM[4] + " ; " + ZmienneCOM[5] + " ; " + ZmienneCOM[6] + " ; " + ZmienneCOM[7] + " ; " + ZmienneCOM[8]);
                    }



                    //double[] 
                    zmienne = Array.ConvertAll(ZmienneCOM, Double.Parse);


                    ///<remarks>
                    ///Zapisywanie zanych do pliku
                    ///</remarks>
                    WriteDataLog(PlikRaportu, DateTime.Now.ToShortDateString() + ";" + DateTime.Now.ToLongTimeString()
                            + ";" + String.Format("{0:D3}:{1:D2}:{2:d2}", s2, s1, t)
                            + ";" + zmienne[0].ToString() + ";" + zmienne[1].ToString() + ";" + zmienne[2].ToString()
                            + ";" + zmienne[3].ToString() + ";" + zmienne[5].ToString() + ";" + zmienne[4].ToString() + ";" + zmienne[6].ToString()
                            + ";" + zmienne[7].ToString() + ";" + zmienne[8].ToString() + ";" + zmienne[9].ToString() + ";" + zmienne[10].ToString()
                            + ";" + zmienne[11].ToString() + ";" + zmienne[12].ToString() + ";" + zmienne[13].ToString() + ";" + zmienne[14].ToString()
                            + ";" + zmienne[15].ToString() + ";" + zmienne[16].ToString() + ";" + zmienne[17].ToString() + ";" + zmienne[18].ToString()
                            + ";" + zmienne[19].ToString());

              
                    
                    
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



                    ///<remarks>
                    ///Wysyłanie danych do GRAPH CHART
                    ///</remarks>
                    WFPressureSuction.PlotYAppend(zmienne[12]);
                    WFPressureDischarge.PlotYAppend(zmienne[13]);

                    WFTempCompressor.PlotYAppend(zmienne[7]);
                    WFTempCondenserIn.PlotYAppend(zmienne[2]);
                    WFTempCondenserOut.PlotYAppend(zmienne[3]);
                    WFTempDischarge.PlotYAppend(zmienne[1]);
                    WFTempEvapIn.PlotYAppend(zmienne[5]);
                    WFTempEvapOut.PlotYAppend(zmienne[4]);
                    WFTempHotbox.PlotYAppend(zmienne[6]);
                    WFTempSuction.PlotYAppend(zmienne[0]);



                    ///<remarks>
                    ///Obsługa kontrolek z podziałem na funkcje
                    ///</remarks>
                    ///


                    //Discharge
                    gaugeDischarge.Value = zmienne[13];
                    SetTextLabel(gaugeDischargeLAB, zmienne[13].ToString());
                    SetTextBox(TBACDischargePress, zmienne[13].ToString() + " BarG");

                    thermometerDischarge.Value = zmienne[1];
                    SetTextBox(thermometerDischargeTB, zmienne[1].ToString() + " °C");
                    SetTextBox(TBACDischargeTemp, zmienne[1].ToString() + " °C");

                    
                    //Suction
                    gaugeSuction.Value = zmienne[12];
                    SetTextLabel(gaugeSuctionLAB, zmienne[12].ToString());
                    SetTextBox(TBACSuctionPress, zmienne[12].ToString() + " BarG");

                    thermometerSuction.Value = zmienne[0];
                    SetTextBox(thermometerSuctionTB, zmienne[0].ToString() + " °C");
                    SetTextBox(TBACSuctionTemp, zmienne[0].ToString() + " °C");

                    //Condenser
                    thermometerCondIn.Value = zmienne[2];
                    SetTextBox(thermometerCondInTB, zmienne[2].ToString() + " °C");
                    SetTextBox(TBACCondenserINTemp, zmienne[2].ToString() + " °C");
                    thermometerCondOut.Value = zmienne[3];
                    SetTextBox(thermometerCondOutTB, zmienne[3].ToString() + " °C");
                    SetTextBox(TBACCondenserOUTTemp, zmienne[3].ToString() + " °C");

                    //Compressor
                    thermometerCompressor.Value = zmienne[7];
                    SetTextBox(thermometerCompressorTB, zmienne[7].ToString() + " °C");
                    SetTextBox(TBACCompressorTemp, zmienne[7].ToString() + " °C");

                    if (zmienne[7] >= Convert.ToDouble(textBoxCompressorLimit.Text))
                    {
                        ledCompressor.Value = true;
                    }
                    else
                    {
                        ledCompressor.Value = false;
                    }


                    //Evapurator
                    SetTextBox(thermometerEvapInTB, zmienne[5].ToString() + " °C");
                    SetTextBox(TBACEvapINTemp, zmienne[5].ToString() + " °C");
                    SetTextBox(thermometerEvapOutTB, zmienne[4].ToString() + " °C");
                    SetTextBox(TBACEvapOUTTemp, zmienne[4].ToString() + " °C");

                    //Air in Evapurator
                    SetTextBox(thermometerAirInTB, zmienne[8].ToString() + " °C");
                    SetTextBox(TBACAirINTemp, zmienne[8].ToString() + " °C");
                    SetTextBox(thermometerAirOutTB, zmienne[10].ToString() + " °C");
                    SetTextBox(TBACAirOutTemp, zmienne[10].ToString() + " °C");

                    SetTextBox(HumidityAirInTB, zmienne[9].ToString() + " %");
                    SetTextBox(HumidityAirOutTB, zmienne[11].ToString() + " %");


                    //Hotbox
                    thermometerHotbox.Value = zmienne[6];
                    SetTextBox(thermometerHotboxTB, zmienne[6].ToString() + " °C");
                    SetTextBox(TBACHotboxTemp, zmienne[6].ToString() + " °C");


                    if (zmienne[6] >= (Convert.ToDouble(textBoxHBmax.Text)-5) & (zmienne[6] <= Convert.ToDouble(textBoxHBmax.Text)+5))
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
                    if (zmienne[18] == 0 & iloscCykliLast == 1)
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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.ShotTestInfo' . Możesz go przenieść lub usunąć.
            this.shotTestInfoTableAdapter.Fill(this.databaseDataSet.ShotTestInfo);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestDescriptionInput' . Możesz go przenieść lub usunąć.
            this.testDescriptionInputTableAdapter.Fill(this.databaseDataSet.TestDescriptionInput);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestDescriptionSetup' . Możesz go przenieść lub usunąć.
            this.testDescriptionSetupTableAdapter.Fill(this.databaseDataSet.TestDescriptionSetup);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'databaseDataSet.TestParameters' . Możesz go przenieść lub usunąć.
            this.testParametersTableAdapter.Fill(this.databaseDataSet.TestParameters);






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
            if (aCLoopToolStripMenuItem.Checked == true)
            {
                BoxDischrge.Visible = true;
                BoxSuction.Visible = true;
                BoxCompressor.Visible = true;
                BoxEvapurator.Visible = true;
                BoxCondenser.Visible = true;
                BoxECV.Visible = true;
                BoxHotbox.Visible = true;
                BoxChart.Visible = false;
                BoxInformation.Visible = true;
                BoxAC.Visible = false;


                aCLoopToolStripMenuItem.Checked = false;
                chartToolStripMenuItem.Checked = false;
            }

            else
            {
                BoxDischrge.Visible = false;
                BoxSuction.Visible = false;
                BoxCompressor.Visible = false;
                BoxEvapurator.Visible = false;
                BoxCondenser.Visible = false;
                BoxECV.Visible = false;
                BoxHotbox.Visible = false;
                BoxChart.Visible = false;
                BoxInformation.Visible = true;
                BoxAC.Visible = true;

                aCLoopToolStripMenuItem.Checked = true;
                chartToolStripMenuItem.Checked = false;
            }

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
        /// Wyswietlanie okna dialogowego "Chart"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pressuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chartToolStripMenuItem.Checked == true)
            {
                BoxDischrge.Visible = true;
                BoxSuction.Visible = true;
                BoxCompressor.Visible = true;
                BoxEvapurator.Visible = true;
                BoxCondenser.Visible = true;
                BoxECV.Visible = true;
                BoxHotbox.Visible = true;
                BoxInformation.Visible = true;
                BoxChart.Visible = false;

                BoxAC.Visible = false;


                aCLoopToolStripMenuItem.Checked = false;
                chartToolStripMenuItem.Checked = false;
            }

            else
            {
                BoxDischrge.Visible = false;
                BoxSuction.Visible = false;
                BoxCompressor.Visible = false;
                BoxEvapurator.Visible = false;
                BoxCondenser.Visible = false;
                BoxECV.Visible = false;
                BoxHotbox.Visible = false;
                BoxInformation.Visible = false;
                BoxChart.Visible = true;

                BoxAC.Visible = false;

                aCLoopToolStripMenuItem.Checked = false;
                chartToolStripMenuItem.Checked = true;
            }



            WFPressureSuction.Visible = true;
            WFPressureDischarge.Visible = true;
            WFTempCompressor.Visible = false;
            WFTempCondenserIn.Visible = false;
            WFTempCondenserOut.Visible = false;
            WFTempDischarge.Visible = true;
            WFTempEvapIn.Visible = false;
            WFTempEvapOut.Visible = false;
            WFTempHotbox.Visible = false;
            WFTempSuction.Visible = true;
            PlotBoxTempSuction.Checked = true;
            PlotBoxTempDischarge.Checked = true;
        }

        /// <summary>
        /// Zapisywanych danych do XML przy zamknieciu programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
#if DEBUG

#else


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
                xml.WriteElementString("GlobalLocation", GlobalFolder.ToString());
                xml.WriteElementString("SettingsLocation", TestSettings.ToString());
                xml.WriteElementString("ReportLocation", PlikRaportu.ToString());
                xml.WriteEndElement();

                //xml.WriteStartElement("TestParameters");
                //xml.WriteElementString("SelectedTest", TestSelected.SelectedText);
                //xml.WriteEndElement();

                xml.WriteEndElement();

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
#endif
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

                //Wyswetlanie Informcji o folderach
                string RepS = TestSettings.Replace("/", @"\");
                string RepR = PlikRaportu.Replace("/", @"\");
                textBoxSettingsInfo.Text = RepS;
                textBoxReportInfo.Text = RepR;
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



        /// <summary>
        /// Szybkie za zamykanie połaczenia - TYLKO DEBUG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                textBoxReportInfo.Text = PlikRaportu;


                if (!File.Exists(@PlikRaportu))
                {
                    using (FileStream fileStream = new FileStream(PlikRaportu, FileMode.Append, FileAccess.Write, FileShare.None))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(fileStream))
                        {
                            streamWriter.WriteLine("DURABILITY TESTER VFS169");
                            streamWriter.WriteLine("Rozpoczęcie Testu: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                            streamWriter.WriteLine("DataNow;TomeNow;TimeOfTest;Tsuc;TdisTcondenserIn;TcondenserOut;TevapuratorIn;TevapuratorOut;Thotbox;Tcompressor;TairIn;HairIn;TairOut;HairOut;Psuc;Pdis;COILvoltage;COILcurrent;ECVvoltage;ECVcurrent;Cewka;rpm");
                            streamWriter.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Otwieranie ustawienia formulaża z komentazem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commentsToTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComments FC = new FormComments();
            FC.Show();
        }


        /// <summary>
        /// Otwieranie formulaża konczącergo test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFinishTest FFinish = new FormFinishTest();
            FFinish.Show();
        }

        /// <summary>
        /// Ustawienie Folderu i pliku Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backlogFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileSetting.ShowDialog() == DialogResult.OK)
            {
                TestSettings = saveFileSetting.FileName;
                textBoxSettingsInfo.Text = TestSettings;
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
        

        /// <summary>
        /// Metoda zapisywania danych do pliku .txt
        /// </summary>
        /// <param name="logFileName"></param>
        /// <param name="data"></param>
        public static void WriteDataLog(string logFileName, string data)
        {
            if (File.Exists(logFileName) & dzialanie == true)
            {
                using (FileStream fileStream = new FileStream(logFileName, FileMode.Append, FileAccess.Write, FileShare.None))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        streamWriter.WriteLine(data);
                        streamWriter.Close();
                    }
                }
            }
        }


        /// <summary>
        /// Ustawienie standardowych scieżek do raportu i testu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TestSettingsDir = "c:/TESTER_VFS169/Settings/";
            string PlikRaportyDir = "c:/TESTER_VFS169/Reports/";

            TestSettings = "c:/TESTER_VFS169/Settings/Settings.xml";
            PlikRaportu = "c:/TESTER_VFS169/Settings/Report.txt";
            GlobalFolder = "c:/TESTER_VFS169/Settings/";


            DirectoryInfo dirSetting = null;
            if (!Directory.Exists(@TestSettings))
            {
                dirSetting = Directory.CreateDirectory(@TestSettingsDir);
            }


            DirectoryInfo dirReport = null;
            if (!Directory.Exists(@TestSettings))
            {
                dirReport = Directory.CreateDirectory(@PlikRaportyDir);
            }


            string RepS = TestSettings.Replace("/", @"\");
            string RepR = PlikRaportu.Replace("/", @"\");
            textBoxSettingsInfo.Text = RepS;
            textBoxReportInfo.Text = RepR;
        }


        /// <summary>
        /// Kopiowanie do schowka scieżki do pliku SETTINGS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButCopySettings_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@textBoxSettingsInfo.Text);
                //System.Windows.Forms.Clipboard.SetText(textBoxSettingsInfo.Text);
            }
            catch
            {
                MessageBox.Show("Lack of correct file", "Warning");
            }

        }


        /// <summary>
        /// Kopiowanie do schowka scieżki do pliku TEST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCopyReport_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@textBoxReportInfo.Text);
                //System.Windows.Forms.Clipboard.SetText(textBoxReportInfo.Text);
            }
            catch
            {
                MessageBox.Show("Lack of correct file", "Warning");
            }
            

        }

        /// <summary>
        /// Otwieranie formy definicji nowego testu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTestDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNTD FNTD = new FormNTD();
            FNTD.ShowDialog();
        }


        /// <summary>
        /// Wyswietlanie aktualnej daty i godziny w pasku dolnym
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerZegar_Tick(object sender, EventArgs e)
        {
            StripStatusTime.Text = DateTime.Now.ToShortDateString() + "    " + DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Otwieranie formy Rozpoczecia nowego testu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startNewTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSNT FSNT = new FormSNT();
            FSNT.Show();
        }



        /// <summary>
        /// Wyswietlanie wykresu oraz skali Pressure Suction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxPressureSuction.Checked)
            {
                WFPressureSuction.Visible = true;
                legendItem1.Visible = true;
            }
            else
            {
                WFPressureSuction.Visible = false;
                legendItem1.Visible = false;
            }

            if (!PlotBoxPressureDischarge.Checked & !PlotBoxPressureSuction.Checked)
            {
                AxisPressure.Visible = false;
            }
            else
            {
                AxisPressure.Visible = true;
            }
        }

        /// <summary>
        /// Wyswietlanie wykresu oraz skali PressureDischatge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotPressureDischarge_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxPressureDischarge.Checked)
            {
                WFPressureDischarge.Visible = true;
                legendItem2.Visible = true;
            }
            else
            {
                WFPressureDischarge.Visible = false;
                legendItem2.Visible = false;
            }

            if (!PlotBoxPressureDischarge.Checked & !PlotBoxPressureSuction.Checked)
            {
                AxisPressure.Visible = false;
            }
            else
            {
                AxisPressure.Visible = true;
            }
        }

        /// <summary>
        /// Wyswietlanie wykresu oraz skali TempSuction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempSuction_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempSuction.Checked)
            {
                WFTempSuction.Visible = true;
                legendItem3.Visible = true;
            }
            else
            {
                WFTempSuction.Visible = false;
                legendItem3.Visible = false;
            }

            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }


        /// <summary>
        /// Wyswietlanie wykresu oraz skali TempDischarge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempDischarge_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempDischarge.Checked)
            {
                WFTempDischarge.Visible = true;
                legendItem4.Visible = true;
            }
            else
            {
                WFTempDischarge.Visible = false;
                legendItem4.Visible = false;
            }
            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }


        /// <summary>
        /// Wyswietlanie wykresu oraz skali CONDENSERIn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempCondenserIn_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempCondenserIn.Checked)
            {
                WFTempCondenserIn.Visible = true;
                legendItem5.Visible = true;
            }
            else
            {
                WFTempCondenserIn.Visible = false;
                legendItem5.Visible = false;
            }
            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }

        /// <summary>
        /// Wyswietlanie wykresu oraz skali CondenserOut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempCondenserOut_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempCondenserOut.Checked)
            {
                WFTempCondenserOut.Visible = true;
                legendItem6.Visible = true;
            }
            else
            {
                WFTempCondenserOut.Visible = false;
                legendItem6.Visible = false;
            }
            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }


        /// <summary>
        /// Wyswietlanie wykresu oraz skali EVAPIN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempEvapIn_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempEvapIn.Checked)
            {
                WFTempEvapIn.Visible = true;
                legendItem7.Visible = true;
            }
            else
            {
                WFTempEvapIn.Visible = false;
                legendItem7.Visible = false;
            }
            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }

        /// <summary>
        /// Wyswietlanie wykresu oraz skali EVAPOUT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempEvapOut_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempEvapOut.Checked)
            {
                WFTempEvapOut.Visible = true;
                legendItem8.Visible = true;
            }
            else
            {
                WFTempEvapOut.Visible = false;
                legendItem8.Visible = false;
            }
            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }

        /// <summary>
        /// Wyswietlanie wykresu oraz skali COMPRESSOR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempCompressor_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempCompressor.Checked)
            {
                WFTempCompressor.Visible = true;
                legendItem9.Visible = true;
            }
            else
            {
                WFTempCompressor.Visible = false;
                legendItem9.Visible = false;
            }
            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }

        /// <summary>
        /// Wyswietlanie wykresu oraz skali HOTBOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlotBoxTempHotbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PlotBoxTempHotbox.Checked)
            {
                WFTempHotbox.Visible = true;
                legendItem10.Visible = true;
            }
            else
            {
                WFTempHotbox.Visible = false;
                legendItem10.Visible = false;
            }
            if (!PlotBoxTempCompressor.Checked & !PlotBoxTempCondenserIn.Checked & !PlotBoxTempCondenserOut.Checked & !PlotBoxTempDischarge.Checked & !PlotBoxTempEvapIn.Checked & !PlotBoxTempEvapOut.Checked & !PlotBoxTempHotbox.Checked & !PlotBoxTempSuction.Checked)
            {
                AxisTemperature.Visible = false;
            }
            else
            {
                AxisTemperature.Visible = true;
            }
        }



        /// <summary>
        /// Zmiana stanu pomiedzy auto a Manual Value dla osi TEMPERATURE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaxisBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TaxisBox.Checked)
            {
                TaxisMIN.ReadOnly = true;
                TaxisMAX.ReadOnly = true;
                AxisTemperature.Mode = NationalInstruments.UI.AxisMode.AutoScaleLoose;
            }
            else
            {
                TaxisMIN.ReadOnly = false;
                TaxisMAX.ReadOnly = false;
                AxisTemperature.Mode = NationalInstruments.UI.AxisMode.Fixed;
                NationalInstruments.UI.Range TAxis = new NationalInstruments.UI.Range(Convert.ToDouble(TaxisMIN.Text), Convert.ToDouble(TaxisMAX.Text));
                AxisTemperature.Range = TAxis;
            }
        }


        /// <summary>
        /// Zmiana stanu pomiedzy auto a Manual Value dla osi PRESSURE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaxisBOX_CheckedChanged_1(object sender, EventArgs e)
        {
            if (PaxisBOX.Checked)
            {
                PaxisMIN.ReadOnly = true;
                PaxisMAX.ReadOnly = true;
                AxisPressure.Mode = NationalInstruments.UI.AxisMode.AutoScaleLoose;
            }
            else
            {
                PaxisMIN.ReadOnly = false;
                PaxisMAX.ReadOnly = false;
                AxisPressure.Mode = NationalInstruments.UI.AxisMode.Fixed;
                NationalInstruments.UI.Range PAxis = new NationalInstruments.UI.Range(Convert.ToDouble(PaxisMIN.Text), Convert.ToDouble(PaxisMAX.Text));
                AxisPressure.Range = PAxis;
            }
        }


        /// <summary>
        /// Wyswietlanie terminala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tERMINALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tERMINALToolStripMenuItem.Checked == true)
            {
                BoxCoil.Visible = true;
                BoxRPM.Visible = true;
                BoxTerminal.Visible = false;
                tERMINALToolStripMenuItem.Checked = false;

            }
            else
            {
                BoxCoil.Visible = false;
                BoxRPM.Visible = false;
                BoxTerminal.Visible = true;
                tERMINALToolStripMenuItem.Checked = true;
                
            }
        }

        /// <summary>
        ///  Wstrzymanie sysyłanie danych do terminala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TerminalStopCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (TerminalStopCheck.Checked)
            {
                TerminalStop = true;
            }
            else
            {
                TerminalStop = false;
            }
        }

        private void TerminalClearBut_Click(object sender, EventArgs e)
        {
            Terminal.Text = "";
        }

        private void saveTestStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Zmiana stanu pomiedzy auto a Manual Value dla osi TIME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeAxisBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeAxisBOX.Checked)
            {
                TimeAxisMIN.ReadOnly = true;
                TimeAxisMAX.ReadOnly = true;
                TimeAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            }
            else
            {
                TimeAxisMIN.ReadOnly = false;
                TimeAxisMAX.ReadOnly = false;
                TimeAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
                NationalInstruments.UI.Range TAxis = new NationalInstruments.UI.Range(Convert.ToDouble(TimeAxisMIN.Text), Convert.ToDouble(TimeAxisMAX.Text));
                TimeAxis.Range = TAxis;
            }
        }
        

        /// <summary>
        /// Ustawienie wartosci MIN i MAX dla skali Temperature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaxisMIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.UI.Range TAxis = new NationalInstruments.UI.Range(Convert.ToDouble(TaxisMIN.Text), Convert.ToDouble(TaxisMAX.Text));
                AxisTemperature.Range = TAxis;
            }
            catch
            {
                //MessageBox.Show("Wrong ValueType");
            }
        }

        private void TaxisMAX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.UI.Range TAxis = new NationalInstruments.UI.Range(Convert.ToDouble(TaxisMIN.Text), Convert.ToDouble(TaxisMAX.Text));
                AxisTemperature.Range = TAxis;
            }
            catch
            {
                //MessageBox.Show("Wrong ValueType");
            }
        }


        /// <summary>
        /// Ustawienie wartosci MIN i MAX dla skali Pressure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaxisMIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.UI.Range PAxis = new NationalInstruments.UI.Range(Convert.ToDouble(PaxisMIN.Text), Convert.ToDouble(PaxisMAX.Text));
                AxisPressure.Range = PAxis;
            }
            catch
            {
                //MessageBox.Show("Wrong ValueType");
            }
        }

        private void PaxisMAX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.UI.Range PAxis = new NationalInstruments.UI.Range(Convert.ToDouble(PaxisMIN.Text), Convert.ToDouble(PaxisMAX.Text));
                AxisPressure.Range = PAxis;
            }
            catch
            {
                //MessageBox.Show("Wrong ValueType");
            }
        }


        /// <summary>
        /// Ustawienie wartosci MIN i MAX dla skali TIME
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeAxisMIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.UI.Range TAxis = new NationalInstruments.UI.Range(Convert.ToDouble(TimeAxisMIN.Text), Convert.ToDouble(TimeAxisMAX.Text));
                TimeAxis.Range = TAxis;
            }
            catch
            {
                //MessageBox.Show("Wrong ValueType");
            }
        }

        private void TimeAxisMAX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.UI.Range TAxis = new NationalInstruments.UI.Range(Convert.ToDouble(TimeAxisMIN.Text), Convert.ToDouble(TimeAxisMAX.Text));
                TimeAxis.Range = TAxis;
            }
            catch
            {
                //MessageBox.Show("Wrong ValueType");
            }
        }


        /// <summary>
        /// Ustawienie automatycznego  Minimum w oknie czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label36_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TimeAxisMIN.Text = "0";
        }


        /// <summary>
        /// Kopiowanie linku do pliku raportu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxReportInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Windows.Forms.Clipboard.SetText(textBoxReportInfo.Text);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Kopiowanie linku do pliku Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSettingsInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Windows.Forms.Clipboard.SetText(textBoxSettingsInfo.Text);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Przeładowanie data base dla DataSet 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.testDescriptionInputTableAdapter.Fill(this.databaseDataSet.TestDescriptionInput);
            this.testDescriptionSetupTableAdapter.Fill(this.databaseDataSet.TestDescriptionSetup);
            this.testParametersTableAdapter.Fill(this.databaseDataSet.TestParameters);
        }




    }
}