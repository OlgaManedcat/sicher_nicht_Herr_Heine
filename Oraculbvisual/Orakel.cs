using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Oraculbvisual
{
    internal class Orakel
    {
        public int Zahl;
        public Orakel()
        {
            Zahl = 0;
        }
        public Orakel(int Zahl, string TbEingabe)
        {
            while (Zahl < 10)
            {
                if (TbEingabe.Contains("+") || TbEingabe.Contains("-") || TbEingabe.Contains("*") || TbEingabe.Contains("/") || TbEingabe.Contains("π"))
                {
                    MessageBox.Show("Das kann man doch im Kopf rechnen!");
                }
                if (TbEingabe.Contains("seh") || TbEingabe.Contains("sieh"))
                {
                    MessageBox.Show("jung, dynamisch und skelletmäßig!");
                }
                if (TbEingabe.Contains("Wetter"))
                {
                    MessageBox.Show("Guck aus dem Fenster!");
                }
                Zahl++;
            }
        }
    }
}
