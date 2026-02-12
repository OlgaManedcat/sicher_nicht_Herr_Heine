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
              if (TbEingabe.Contains("+","-","*","/",""))
                {
                    MessageBox.Show("Das kann man doch im Kopf rechnen!");
                }
            }
        }
    }
}
