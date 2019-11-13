#include "Display.h"

const int LED1 = 4;
const int LED2 = 5;
const int LED3 = 6;
const int LED4 = 7;

//buzzer chords setup
const int BUZZER = 3; //buzzer is on pin 3
const int e4 = 330;

// for light sensor
const int PIN_LDR = 16;


int count = 0;
void setup() {
  Serial.begin(9600); // serial monitor connection
  pinMode(PIN_LDR, INPUT);
  
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);


  pinMode(BUZZER, OUTPUT);
  digitalWrite(BUZZER, LOW); // set it to silent in case it was on
  
  Display.show(0);
  
}

bool flag = true;
void loop() {
    
     float res = get_light_sens();     
      if(res > 10 ){
        if(flag){
          flag = false; 
          count++; 
          Serial.println(count);
          digitalWrite(LED3, HIGH);
          delay(300);
          tone(BUZZER, e4, 250);
        }
        
        Display.show(count);
     
     }else {flag = true;}

     digitalWrite(LED3, LOW);
}


/*
 * gives light value
 */
float get_light_sens(){
  int sensorValue = analogRead(PIN_LDR);
  float resistance_sens = (float)(1023-sensorValue)*10/sensorValue;
  return resistance_sens;
}
