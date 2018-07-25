

void setup() {
  // put your setup code here, to run once:
  Serial.begin(19200);
}

void loop() {
  // put your main code here, to run repeatedly:

  float dtPressure = (float)random(39500, 41000) / 10000;
  float tfPressure = (float)random(38000, 39500) / 10000;
  Serial.println("CON>1: " + String(tfPressure, 4) + " 0x50 2: " + String(dtPressure, 4) + " 0x00");
  delay(400);
}

