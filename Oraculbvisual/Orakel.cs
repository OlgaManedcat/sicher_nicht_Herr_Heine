using System;
using System.Windows;

namespace Oraculbvisual
{
    internal class Orakel
    {
        public Orakel(string TbEingabe, int zahl)
        {
            if (zahl >= 10)
            {
                MessageBox.Show("Ach, lass mich doch in Ruhe!");
            }
            else if (TbEingabe.Contains("+") || TbEingabe.Contains("-") || TbEingabe.Contains("*") || TbEingabe.Contains("/") || TbEingabe.Contains("π") || TbEingabe.Contains("pi"))
            {
                MessageBox.Show("Das kann man doch im Kopf rechnen!");
                return;
            }
            else if (TbEingabe.Contains("seh") || TbEingabe.Contains("sieh"))
            {
                MessageBox.Show("jung, dynamisch und skelletmäßig!");
                return;
            }
            else if (TbEingabe.Contains("Wetter"))
            {
                MessageBox.Show("Guck aus dem Fenster!");
                return;
            }
            else
            {
                Zufallsmethode();
                return;
            }
        }
        void Zufallsmethode()
        {
            string[] zufallsAusgaben = { "Ja", "Nein", "Wurzel aus 7", "Vielleicht", "Da solltest du nochmal drüber nachdenken", "Sicher", "Das Probelem befindet sich meist 1/2 Meter vor dem Bildschirm" };
            Random rd = new Random();
            int zufallszahl = rd.Next(0, 6);
            MessageBox.Show(zufallsAusgaben[zufallszahl]);
            return;
        }
    }
}

