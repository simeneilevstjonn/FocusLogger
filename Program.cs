﻿using System;
using System.Runtime.InteropServices;
using System.Text;

namespace FocusLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string PreviousActive = null;

            while (true)
            {
                while (GetActiveWindowTitle() != PreviousActive)
                {
                    string Active = GetActiveWindowTitle();
                    Console.WriteLine($"{DateTime.UtcNow} - {Active}");
                    PreviousActive = Active;
                }
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
    }
}
