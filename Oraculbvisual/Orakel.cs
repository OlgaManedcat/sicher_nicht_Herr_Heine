using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Oraculbvisual
{
    internal class Orakel
    {
        public int Zahl = 0;
  
        public Orakel(int Zahl, string TbEingabe)
        {
            while (Zahl < 3)
            {
                Zahl++;
                if (TbEingabe.Contains("+") || TbEingabe.Contains("-") || TbEingabe.Contains("*") || TbEingabe.Contains("/") || TbEingabe.Contains("π") || TbEingabe.Contains("pi"))
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
            if (Zahl == 3)
            {

                MessageBox.Show("Ach, lass mich doch in Ruhe!");
                Environment.Exit(100);
            }
        }
        void Zufallsmethode()
        {
            string[] zufallsAusgaben = { "Ja", "Nein", "Wurzel aus 7", "Vielleicht", "Da solltest du nochmal drüber nachdenken", "Sicher", "Das Probelem befindet sich meist 1/2 Meter vor dem Bildschirm" };
            Random rd = new Random();
            int zahl = rd.Next(0, 6);
            MessageBox.Show(zufallsAusgaben[zahl]);
            return;
        }
    }
}

