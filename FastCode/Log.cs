﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode
{
    public class Log
    {
        static int id_show_process = 0;
        static string[] show_process = new string[] { "|", "/", "-", "|", "\\" };
        public static void DefaultColor() {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void Title(string text, ConsoleColor color = ConsoleColor.Gray) {
            DefaultColor();
            Console.BackgroundColor = color;
            Console.WriteLine(" "+text+" ");
            DefaultColor();

        }
        public static void Text(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            DefaultColor();
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            DefaultColor();
        }

        public static void Process(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            string text_process = text + " " + show_process[id_show_process];
            
            id_show_process++;
            if (id_show_process>4) {
                id_show_process = 0;
            }

            DefaultColor();

            Console.ForegroundColor = color;
            Console.Write(text_process);
            Console.SetCursorPosition(Console.CursorLeft - text_process.Length, Console.CursorTop);

            DefaultColor();
        }

        public static void Error(string text) {
            Title(text, ConsoleColor.Red);
        }
    }
}
