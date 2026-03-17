using System;
using System.Windows;
using System.Windows.Controls;

namespace Oraculbvisual
{
    

    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int zahl = 0;
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("In einem weit entverntem Land in Babendorf, in den Tiefen, des Schulgebaude-Dschungles " +
                "im Raum A1.25 in einem Zelt ist Jemand (der sicherlich nicht Sebastian Heine heißt) zu finden. " +
                "Er hat großes Wissen über die Zukunft");
            MessageBox.Show("Das Orakel: Hallo Wanderer, meine Name ist Herr Hei....*Pause* unwichtig eigentlich. " +
                "Ich weiß viel und wenn du Fragen über die Zukunft hast stell sie mir, vieliecht werde ich sie antworten.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tüdelü!!!");
            this.Close();
        }
        private void Antwort_Click(object sender, RoutedEventArgs e)
        {
            string Eingabe = TbEingabe.Text;
            Orakel ausführung = new Orakel(Eingabe,zahl);
            zahl++;

            if (zahl == 4) this.Close();
        }

        private void TbEingabe_TextChanged()
        {

        }
    }
}

