/*
 Name:		MuRID_Sketch.ino
 Created:	10-Jul-18 6:19:39 PM
 Author:	Manos
*/

#include "LedControl.h"
#include <EnhancedSerial.h>

#define DeviceID 97
#define UniquePing1 96
#define UniquePing2 134

#define DINPin 7
#define CLKPin 9
#define CSPin 8

#define Devices 4

#define Brightness 4

#define SetByte 24
#define BrightnessByte 25
#define PowerByte 26
#define StartByte 1
#define EndByte 128

EnhancedSerial ES;
LedControl Matrix = LedControl(DINPin, CLKPin, CSPin, Devices);

byte RXBuffer[Devices * 8 + 3];

void setup() {
	SetShutdown(false);
	SetBrightness(Brightness);
	ES.Init(DeviceID);
	ES.SetPingMessage(UniquePing1, UniquePing2);
	Clear();
}

void SetShutdown(boolean State) {
	for (int Device = 0; Device < Devices; Device++) {
		Matrix.shutdown(Device, State);
	}
}

void SetBrightness(uint8_t Value) {
	for (int Device = 0; Device < Devices; Device++) {
		Matrix.setIntensity(Device, Value);
	}
}

void Clear() {
	for (int Device = 0; Device < Devices; Device++) {
		Matrix.clearDisplay(Device);
	}
}

byte ReverseByte(byte c) {
	c = ((c >> 1) & 0x55) | ((c << 1) & 0xAA);
	c = ((c >> 2) & 0x33) | ((c << 2) & 0xCC);
	c = (c >> 4) | (c << 4);
	return c;
}

void SetColumn(int Column, byte Value) {
	Matrix.setColumn((Devices * 8 - 1 - Column) / 8, Column % 8, ReverseByte(Value));
}

void loop() {
	if (ES.IsConnected()) {
		if (Serial.available()) {
			// Shift RX left 
			for (int Index = 0; Index < Devices * 8 + 2; Index++) {
				RXBuffer[Index] = RXBuffer[Index + 1];
			}
			RXBuffer[Devices * 8 + 2] = Serial.read();
			// Process RX
			if (RXBuffer[1] == StartByte && RXBuffer[Devices * 8 + 2] == EndByte) {
				if (RXBuffer[0] == SetByte) {
					// Set the display
					for (int Index = 2; Index < Devices * 8 + 2; Index++) {
						SetColumn(Index - 2, RXBuffer[Index]);
					}
				} 
				else if (RXBuffer[0] == BrightnessByte) {
					SetBrightness(RXBuffer[2]);
				} 
				else if (RXBuffer[0] == PowerByte) {
					SetShutdown(RXBuffer[2]);
				}
			}
		}
	}
	else {
		ES.TryConnect();
	}
}
