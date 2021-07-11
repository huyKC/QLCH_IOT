/* code cho reader ở cửa phòng A110*/

#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <WiFiClient.h>

#include <SPI.h>
#include <MFRC522.h>


constexpr uint8_t RST_PIN = D3;     // Config chân reset
constexpr uint8_t SS_PIN = D4;     // Config chân SS
//#define SS_PIN 10
//#define RST_PIN 9

MFRC522 rfid(SS_PIN, RST_PIN); 

MFRC522::MIFARE_Key key;

const char* ssid = "HuyHoang_2.4G";//STASSID;  
const char* password = "28060208";//STAPSK;  

//String serverName = "http://192.168.1.8:8080/dacntt2_api/databaseConfig.php";
String serverName = "http://192.168.1.8:8080/dacntt2_api/room_api.php";

byte nuidPICC[4];

String tag;
int32_t room;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  SPI.begin(); 
  rfid.PCD_Init();

  for (byte i = 0; i < 6; i++) {
    key.keyByte[i] = 0xFF;
  }
  
  Serial.println();
  Serial.print("Connecting to: ");
  Serial.println(ssid);

  //WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, password);
  

  while (WiFi.status() != WL_CONNECTED){
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("Wifi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  
}

void loop() {

  byte block;
  byte len;
  MFRC522::StatusCode status;
  
  if ( ! rfid.PICC_IsNewCardPresent())
    return;

  if ( ! rfid.PICC_ReadCardSerial())
    return;


  if (rfid.uid.uidByte[0] != nuidPICC[0] || 
    rfid.uid.uidByte[1] != nuidPICC[1] || 
    rfid.uid.uidByte[2] != nuidPICC[2] || 
    rfid.uid.uidByte[3] != nuidPICC[3] ) {
    //Serial.println(F("A new card has been detected."));

    // Store NUID into nuidPICC array
    //for (byte i = 0; i < 4; i++) {
      //nuidPICC[i] = rfid.uid.uidByte[i];
    //}
   
    //Serial.println(F("The NUID tag is:"));
    //Serial.print(F("In hex: "));
    //printHex(rfid.uid.uidByte, rfid.uid.size);
    //Serial.println();
    //Serial.print(F("In dec: "));
    printDec(rfid.uid.uidByte, rfid.uid.size);
    //Serial.println();
  }
  else Serial.println(F("Card read previously."));
//-----------------------------------------------------------------
// read Room

  Serial.print(F("Room: "));

  byte buffer1[18];

  block = 4;
  len = 18;

  status = rfid.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, 4, &key, &(rfid.uid)); //line 834 of MFRC522.cpp file
  if (status != MFRC522::STATUS_OK) {
    Serial.print(F("Authentication failed: "));
    Serial.println(rfid.GetStatusCodeName(status));
    return;
  }

  status = rfid.MIFARE_Read(block, buffer1, &len);
  if (status != MFRC522::STATUS_OK) {
    Serial.print(F("Reading failed: "));
    Serial.println(rfid.GetStatusCodeName(status));
    return;
  }

  // print room
  for (uint8_t i = 0; i < 16; i++)
  {
    if (buffer1[i] != 32)
    {
      Serial.write(buffer1[i]);
      //Serial.print(buffer1[i]);
    }
  }
  //Serial.print(" ");
  Serial.println();
  status = rfid.MIFARE_GetValue(block, &room);
  if (status != MFRC522::STATUS_OK) {
    Serial.print(F("Reading failed: "));
    Serial.println(rfid.GetStatusCodeName(status));
    return;
  }
  Serial.println(room);
  if ( room == 825311498 ){
    Serial.println(F("Room allowed"));
    //Serial.print("Connecting to: ");
    //Serial.println(host);

    if (WiFi.status() == WL_CONNECTED){
      WiFiClient client;
      HTTPClient http;

      //Serial.println(tag);
      String serverPath = serverName + "?ID="+ tag +"&Room=A110";
      http.begin(client, serverPath.c_str());

      int httpResponseCode = http.GET();

      if(httpResponseCode > 0){
        Serial.print("HTTP Response Code: ");
        Serial.println(httpResponseCode);
        String payload = http.getString();
        Serial.println(payload);
      }
      else{
        Serial.print("Error code: ");
        Serial.println(httpResponseCode);
      }
      http.end();
    }
    else{
      Serial.println("Wifi disconnect");
    }
    //Serial.println(F("Send data success"));
  }
  else{
    Serial.println(F("Wrong room"));  
  }

//-----------------------------------------------------------------

//-----------------------------------------------------------------
  // Halt PICC
  rfid.PICC_HaltA();

  // Stop encryption on PCD
  rfid.PCD_StopCrypto1();
  
}

void printDec(byte *buffer, byte bufferSize) {
  
  tag = "";
  for (byte i = 0; i < 4; i++) {
      tag += rfid.uid.uidByte[i];
  }
  Serial.println(tag);
  
}
