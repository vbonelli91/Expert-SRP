﻿using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "assets\board.txt";
            bool[,] board= LeerArchivo.lecturaArchivo(url);
            
        }
    }
}
