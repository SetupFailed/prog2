using Raylib_cs;
using System;
using System.Data;
using System.Net;

//----//
int heightY = 1000;
int widthX = 1200;

int gameScreen = 0;

ContinueButton button = new();

void Draw(){

  if (gameScreen == 00)
 {
    InformationScreen();
    Continue();
 }

 else if (gameScreen == 01)
 {
    
 }
}



Raylib.InitWindow(widthX, heightY, "storyGame");



//----Game Logic---//



while (!Raylib.WindowShouldClose())
{



  Raylib.EndDrawing();

}