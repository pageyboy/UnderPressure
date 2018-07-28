

void setup() {
  // put your setup code here, to run once:
  Serial.begin(19200);
}

void loop() {
  // put your main code here, to run repeatedly:

  float dtPressure = (float)random(39428, 39515) / 10000;
  float tfPressure = (float)random(37887, 38056) / 10000;
  Serial.println("CON>1: " + String(tfPressure, 4) + " 0x50 2: " + String(dtPressure, 4) + " 0x00");
  delay(40);
}

