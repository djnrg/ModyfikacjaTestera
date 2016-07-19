// Program odczytuje temperaturę kilku czujników

#include <OneWire.h>
#include <DS18B20.h>
#include <DHT.h>

// Numer pinu do którego podłaczasz czujnik
#define ONEWIRE_PIN 7   //Czujnik Temperatury DS18B20
#define DHTPIN1 6       //Czujnik Temperatury DHT21
#define DHTPIN2 5       //Czujnik Temperatury DHT21

//Typ czujnika DHT
#define DHTTYPE DHT21 

// Ilość czujników
#define SENSORS_NUM 8

/*
Szary - dodatkowy sensor
0x28, 0xFF, 0x4B, 0xAF, 0x6, 0x0, 0x0, 0x33
*/

// Adresy czujników DS18B20
const byte address[SENSORS_NUM][8] PROGMEM = {
0x28, 0xB4, 0x2D, 0xF0, 0x4, 0x0, 0x0, 0x3E,
0x28, 0x4F, 0xEA, 0xDF, 0x5, 0x0, 0x0, 0x86,
0x28, 0x51, 0xA5, 0xE0, 0x5, 0x0, 0x0, 0x9A,
0x28, 0x4F, 0xAA, 0xE0, 0x5, 0x0, 0x0, 0xBD,
0x28, 0xAA, 0x66, 0xE0, 0x5, 0x0, 0x0, 0x7C,
0x28, 0xBC, 0x9B, 0xE0, 0x5, 0x0, 0x0, 0xDF,
0x28, 0xFF, 0x8D, 0xCB, 0x81, 0x15, 0x1, 0x46,
0x28, 0x15, 0x23, 0xF0, 0x4, 0x0, 0x0, 0xF7
};

//Inicjalizacja bibliotek
OneWire onewire(ONEWIRE_PIN);
DS18B20 sensors(&onewire);

DHT dht1(DHTPIN1, DHTTYPE);
DHT dht2(DHTPIN2, DHTTYPE);

//Definicja zmiennych globalnych
float Tsuc;
float Tdis;
float TcondenserIn;
float TcondenserOut;
float TevapuratorIn;
float TevapuratorOut;
float Thotbox;
float Tcompressor;
float Psuc;
float Pdis;

int P1;
int P2;

float TairIn;
float TairOut;
float HairIn;
float HairOut;


//Definicja przypisanych pinów
const int Button1 = 22;
const int Button2 = 24;
const int Button3 = 30;
const int Przelacznik1 = 26;
const int Przelacznik2 = 28;


long time = 0;
long ButtonDebounce = 500;

//Definicja diod LED
const int LED1g = 25 ;
const int LED1r = 23 ;
const int LED2g = 29 ;
const int LED2r = 27 ;
const int LED3g = 33 ;
const int LED3r = 31 ;
const int LED4g = 37 ;
const int LED4r = 35 ;
const int LED5g = 45 ;
const int LED5r = 43 ;

const int Pressure1 = A0;
const int Pressure2 = A1;

const int Buzzer = A5;

//Zmienne dla pomiarów elektrycznych
const int COILvPin =	A13;
const int ECVvPin =		A15;
const int COILcurrent =	A12;
const int ECVcurrent =	A14;
const int COILchecked = 4;
int COILcheckedState = 0;
int COILvolt;
int ECVvolt;
float COILvoltage;
float ECVvoltage;

String Cewka;
const unsigned long sampleTime = 100000UL;								// sample over 100ms, it is an exact number of cycles for both 50Hz and 60Hz mains
const unsigned long numSamples = 250UL;									// choose the number of samples to divide sampleTime exactly, but low enough for the ADC to keep up
const unsigned long sampleInterval = sampleTime/numSamples;				// the sampling interval, must be longer than then ADC conversion time
//const int adc_zero = 522;												// relative digital zero of the arudino input from ACS712 (could make this a variable and auto-adjust it)
int adc_zero1;															// autoadjusted relative digital zero
int adc_zero2;

//definicja tachometru
int ticsPerRev = 2;       // define number of tics per rev of code wheel
float rpm = 0.0;  // I prefer float for rpm
volatile int rpmcount = 0; // volitile because the variable is manipulated during the interrupt
unsigned long timeold = 0; // used to calculate d_t= millis()-timeold;
int d_t;
volatile byte status = LOW;   // set initial state of status LED


void setup() {
  //while(!Serial);
  Serial.begin(9600);
	
  sensors.begin();
  sensors.request();
  dht1.begin();
  dht2.begin();


//Ustawienia dla przycisku
  pinMode(Button1, INPUT_PULLUP);  //ustawienie rezystowow pull up
  pinMode(Button2, INPUT_PULLUP);  //ustawienie rezystowow pull up
  pinMode(Button3, INPUT_PULLUP);  //ustawienie rezystowow pull up
  
  
//Ustawienie dla przełaczkika
  pinMode(Przelacznik1, INPUT_PULLUP);   //digitalWrite(Przelacznik1, HIGH);                                   
  pinMode(Przelacznik2, INPUT_PULLUP);   //digitalWrite(Przelacznik2, HIGH);

//Ustawienia dla diod LED
	pinMode(LED1g, OUTPUT);		digitalWrite(LED1g, HIGH);
	pinMode(LED1r, OUTPUT);		digitalWrite(LED1r, HIGH);
	pinMode(LED2g, OUTPUT);		digitalWrite(LED2g, HIGH);
	pinMode(LED2r, OUTPUT);		digitalWrite(LED2r, HIGH);
	pinMode(LED3g, OUTPUT);		digitalWrite(LED3g, HIGH);
	pinMode(LED3r, OUTPUT);		digitalWrite(LED3r, HIGH);
	pinMode(LED4g, OUTPUT);		digitalWrite(LED4g, HIGH);
	pinMode(LED4r, OUTPUT);		digitalWrite(LED4r, HIGH);
	pinMode(LED5g, OUTPUT);		digitalWrite(LED5g, HIGH);
	pinMode(LED5r, OUTPUT);		digitalWrite(LED5r, HIGH);
	
//Czujnik prądu
	pinMode(COILchecked, INPUT);
		
		
	//Serial.println("Test VFS169");
	
}

void loop() {
 
 
 //===============Obsługa przycisków ===========
   int Przycisk1  = digitalRead(Button1);                               // read input value
   int Przycisk2  = digitalRead(Button2);
   int Cewka24V = digitalRead(Button3);
   int PrzelacznikA  = digitalRead(Przelacznik1);
   int PrzelacznikB  = digitalRead(Przelacznik2);

 if (Przycisk1 == LOW)
   {
     digitalWrite(LED2r, LOW);
 }
 else    {
     digitalWrite(LED2r, HIGH);
 }
  if (Przycisk2 == LOW)
   {
     digitalWrite(LED1g, LOW);
 }
 else    {
     digitalWrite(LED1g, HIGH);
 }
 
 if (PrzelacznikA == LOW)
   {
     digitalWrite(LED5r, LOW);
 }
 else    {
     digitalWrite(LED5r, HIGH);
 }
  if (PrzelacznikB == LOW)
   {
     digitalWrite(LED5g, LOW);
 }
 else    {
     digitalWrite(LED5g, HIGH);
 }
 
//===================================================================================================
 
 
//Odczyt temperatur z czujników DHT
  HairIn = dht1.readHumidity();
  TairIn = dht1.readTemperature();
  HairOut = dht2.readHumidity();
  TairOut = dht2.readTemperature();


//Odczyt i obliczenie cisnienia
P1 = analogRead(Pressure1);
	if (P1>100 && P1<925)
		{
			//Pdis = 0.0317 * P1 + (-3.1823);		//Dla przetwornika 25Bar
			Pdis = 0.049 * P1 + (-5.988);
		}
	else
		{
			Pdis = NULL;
		}


P2 = analogRead(Pressure2);
	if (P2>100 && P2<925)
		{
			Psuc = 0.0122 * P2 + (-1.2741);
		}
	else
		{
			Psuc = NULL;
		}

COILvolt = analogRead(COILvPin);
	if (Cewka24V == HIGH)
		{
			COILvoltage = COILvolt * (12/1023);		//dodac przelicznik
		}

	else if (Cewka24V == LOW)
		{
			COILvoltage = COILvolt * (24/1023);		//dodac przelicznik
		}


ECVvolt = analogRead(ECVvPin);
ECVvoltage = COILvolt * (12/1023);		//dodac przelicznik


//Odczyt temperatur z czujników DS18B20 
  if (sensors.available())
   {
      Tsuc              = sensors.readTemperature(FA(address[0]));
      Tdis              = sensors.readTemperature(FA(address[1]));
      TcondenserIn      = sensors.readTemperature(FA(address[2]));
      TcondenserOut     = sensors.readTemperature(FA(address[3]));
	  TevapuratorIn		= sensors.readTemperature(FA(address[4]));
	  TevapuratorOut	= sensors.readTemperature(FA(address[5]));
	  Thotbox			= sensors.readTemperature(FA(address[6]));
	  Tcompressor		= sensors.readTemperature(FA(address[7]));

   sensors.request();
   }

COILcheckedState = digitalRead(COILchecked);
if (COILcheckedState == HIGH)
{
	digitalWrite(LED2g, LOW);
	Cewka = "1";
} 
else
{
	digitalWrite(LED2r, LOW);
	Cewka = "0";
}


		Serial.print(Tsuc);							Serial.print(";");
		Serial.print(Tdis);							Serial.print(";");
		Serial.print(TcondenserIn);					Serial.print(";");
		Serial.print(TcondenserOut);				Serial.print(";");
		Serial.print(TevapuratorIn);				Serial.print(";");
		Serial.print(TevapuratorOut);				Serial.print(";");
		Serial.print(Thotbox);						Serial.print(";");
		Serial.print(Tcompressor);					Serial.print(";");
		Serial.print(TairIn);						Serial.print(";");
		Serial.print(HairIn);						Serial.print(";");
		Serial.print(TairOut);						Serial.print(";");
		Serial.print(HairOut);						Serial.print(";");
		Serial.print(Psuc);							Serial.print(";");
		Serial.print(Pdis);							Serial.print(";");
		Serial.print(COILvoltage);					Serial.print(";");
		
		//Serial.print(readCurrent(COILcurrent),3);	Serial.print(";");
		Serial.print("0");							Serial.print(";");
		
		Serial.print(ECVvoltage);					Serial.print(";");
		
		//Serial.print(readCurrent(ECVcurrent),3);	Serial.print(";");
		Serial.print("0");							Serial.print(";");
		
		Serial.print(Cewka);						Serial.print(";");
		Serial.print(rpm);
		
		Serial.println();

delay(1000);
}



void Sygnal()
{
	// notes in the melody:
	int melody[] = {  262 }; //NOTE_C4, NOTE_G3, NOTE_G3, NOTE_A3, NOTE_G3, 0, NOTE_B3, NOTE_C4

	// note durations: 4 = quarter note, 8 = eighth note, etc.:
	int noteDurations[] = { 4 }; // 8, 8, 4, 4, 4, 4, 4 
	for (int thisNote = 0; thisNote < 1; thisNote++)
	{

		// to calculate the note duration, take one second
		// divided by the note type.
		//e.g. quarter note = 1000 / 4, eighth note = 1000/8, etc.
		int noteDuration = 1000 / noteDurations[thisNote];
		tone(Buzzer, melody[thisNote], noteDuration);

		// to distinguish the notes, set a minimum time between them.
		// the note's duration + 30% seems to work well:
		int pauseBetweenNotes = noteDuration * 1.30;
		delay(pauseBetweenNotes);
		// stop the tone playing:
		noTone(Buzzer);
		delay (1000);
	}
}
