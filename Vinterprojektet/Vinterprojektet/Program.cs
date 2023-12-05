using Raylib_cs;
using System;

//----//
const int heightY = 1000;
const int widthX = 1200;

int gameScreen = 0;

void draw{
    if (gameScreen == 0)
    {
        start();
    }
}

while (!Raylib.WindowShouldClose())
{



  Raylib.EndDrawing();

}