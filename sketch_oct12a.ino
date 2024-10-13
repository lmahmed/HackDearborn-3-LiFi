int pinSense = A0;
int delayVal = 500;
int intensity = 50;
int SrOF[4] = {1,1,1,1};
int ErOF[4] = {0,0,0,0};
int filledBits;
int myDataFlag[8] = {1,0,0,1,1,0,0,1}; //flag for our only current signal data
int myDataBuff[32];// this is where the payload is stored
int myEnableBuff[4] = {0,0,0,0};//sliding window that detects a start of frame
bool receiveEnable = false;
bool frameEnd;



//print array contents (used for debugging)
void printArray(int array[], int size){
  for(int i = 0; i < size; i++){
    Serial.print(array[i]);
  }
}

//compare array contents
bool compareArray(int a[], int b[], int size){
  for(int i = 0; i < size - 1; i++){
      if(a[i] != b[i]) return false;
  }
   return true;
}

//Pop off first element and append input value
void arrayPushback(int array[], int input, int size){
  for(int i = 0; i < (size - 1); i++){
    array[i] = array[i + 1];
  }
  array[size - 1] = input;
}
//Check if SOF or EOF has been transmitted
void startCheck(){
  if(compareArray(SrOF, myEnableBuff, 4)){
     receiveEnable = true;
     Serial.println("SrOF = myEnableBuff");
  }
  if(compareArray(ErOF, myEnableBuff, 4)) {
    frameEnd = true;
    receiveEnable = false;
     Serial.println("ErOF = myEnableBuff");
  }
}

//Check if signal data matches flag
int frameCheck(){
  if(frameEnd){
    frameEnd = false;
  if(compareArray(myDataFlag, myDataBuff, 8)) {
    clearDataBuff();
    return 1;
    }
  }
  else return 0;
}

//empty data buffer
void clearDataBuff(){
  for(int i = 0; i <= 32; i++){
    myDataBuff[i] = 0;
  }
}

void setup(){
  Serial.begin(9600);
  pinMode(pinSense, OUTPUT);
  clearDataBuff();
}

//main loop
void loop(){

  int senseVal = analogRead(pinSense);
  int iBit;

  if(senseVal < intensity){
    iBit = 0;
  }
  else iBit = 1;

  arrayPushback(myEnableBuff, iBit, 4);
  // printArray(myEnableBuff, 4);
  // Serial.print("\n");
  printArray(myDataBuff, 32);
   Serial.print("\n"); 
  //Serial.print(sizeof(myDataBuff)/sizeof(myDataBuff[0]));

  if(receiveEnable){
    arrayPushback(myDataBuff, iBit, 12);
  }

  if(frameCheck() == 1){ 
    Serial.println ("Signal Received\n");
  }
  startCheck();

  delay(delayVal);  
}
