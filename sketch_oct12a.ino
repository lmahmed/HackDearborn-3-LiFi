int pinSense = A0;
int delayVal = 500;
int intensity = 200;
int SrOF[4] = {1,1,1,1};
int ErOF[4] = {0,0,0,0};
int myDataFlag[8] = {1,0,1,0,1,0,1,0}; //flag for our only current signal data
int myDataBuff[8] = {0,0,0,0,0,0,0,0};
int myEnableBuff[4] = {0,0,0,0};
bool receiveEnable = false;
bool frameEnd;

void printArray(int array[]){
  for(int i = 0; i < sizeof(array); i++){
    Serial.print(array[i]);
  }
}

bool compareArray(int a[], int b[]){
  Serial.print(sizeof(a));
  Serial.print(sizeof(b));
if(sizeof(a) == sizeof(b)){
  printArray(a);
  printArray(b);
  delay(10000000);
  for(int i = 0; i < (sizeof(a)-1); i++){
      if(a[i] != b[i]) return false;
    }
    return true;
    Serial.println("True");
  }  
  return false;
}

//Pop off first element and append input value
void arrayPushback(int array[], int input){
  int arraySize = sizeof(array);
  Serial.println(arraySize);
  for(int i = 0; i < (arraySize - 1); i++){
    array[i] = array[i + 1];
  }
  array[arraySize - 1] = input;
}
//Check if SOF or EOF has been transmitted
void startCheck(){
  if(compareArray(SrOF, myEnableBuff)){
     receiveEnable = true;
     Serial.println("SrOF = myEnableBuff");
  }
  if(compareArray(ErOF, myEnableBuff)) {
    frameEnd = true;
    receiveEnable = false;
  }
}

//Check if signal data matches flag
int frameCheck(){
  //Serial.println("Data Buffer\n");
  //printArray(myDataBuff);
  //Serial.println("Dataflag\n");
  //printArray(myDataFlag);
  if(compareArray(myDataFlag, myDataBuff)) return 1;
  else return 0;
}

void setup(){
  Serial.begin(9600);
  pinMode(pinSense, OUTPUT);
}

//main loop
void loop(){
  Serial.println("here");

  int senseVal = analogRead(pinSense);
  int iBit;

  if(senseVal < intensity){
    iBit = 0;
  }
  else iBit = 1;

  arrayPushback(myEnableBuff, iBit);
  printArray(myEnableBuff);

  if(receiveEnable){
     Serial.println("Enter");
    arrayPushback(myDataBuff, iBit);
  }

  if(frameCheck() == 1){ 
    Serial.println ("Signal Received\n");
  }
  Serial.println("here");
  startCheck();

  delay(delayVal);  
}
