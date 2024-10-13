// Start of frame is 4 ones in a row
// End of fram is 4 zeros in a row

 int brake[8] = {1,0,0,1,1,0,0,1};
static String inputString = "";
void setup() {
  // put your setup code here, to run once:
   pinMode(7, OUTPUT);
  Serial.begin(9600);
  Serial1.begin(9600);


}

   void signal (int temp []){
     digitalWrite(7, HIGH); // Turn LED on
      delay(2000); // Wait for 1 second  
      for (int i =0; i<8;++i){
        if (brake[i]==1){
          digitalWrite(7, HIGH);
          delay(500);
          }
          else{
            digitalWrite(7, LOW);
             delay(500);
            }
        }
  }


void loop() {
  // put your main code here, to run repeatedly:
      while (Serial.available() > 0) {
      char incomingByte = Serial.read();
      
      // Only append printable characters to the string
      if (isPrintable(incomingByte)) {
        inputString += incomingByte;}
      }
      int *intArray = (int *)malloc((sizeof(inputString)-1) * sizeof(int));
      char *token = strtok(inputString, " ");
 //signal(brake);
 digitalWrite(7, HIGH);
  delay(5000);
}
