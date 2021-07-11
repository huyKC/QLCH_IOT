/* code để đọc mã DEX trong thẻ RFID, kết nối với máy qua cáp*/

#include <SPI.h>
#include <MFRC522.h>

constexpr uint8_t RST_PIN = D3;     // Config chân reset
constexpr uint8_t SS_PIN = D4;     // Config chân SS

//#define SS_PIN 10
//#define RST_PIN 9

MFRC522 rfid(SS_PIN, RST_PIN); 
MFRC522::MIFARE_Key key;
String tag; // biến tag dùng để chứa dữ liệu đọc được

void setup() {
  Serial.begin(9600);
  SPI.begin(); 
  rfid.PCD_Init(); 
}

void loop() {

  if ( ! rfid.PICC_IsNewCardPresent())
    return;
  if (rfid.PICC_ReadCardSerial()) {
    for (byte i = 0; i < 4; i++) {
      tag += rfid.uid.uidByte[i];
    }
    Serial.println(tag);
    tag = "";
    rfid.PICC_HaltA();
    rfid.PCD_StopCrypto1();
  }

  
}
