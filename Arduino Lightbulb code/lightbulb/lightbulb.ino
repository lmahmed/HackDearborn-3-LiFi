#include <stdlib.h>
#include <string.h>
#include <Client.h>
void setup() {
  // put your setup code here, to run once:
  pinMode(7, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0)
  {
    char input = Serial.read();
    if (input == '1')
    {
      digitalWrite(7, HIGH);
    }
    if (input == '0')
    {
      digitalWrite(7,LOW);
    }
  }
}
