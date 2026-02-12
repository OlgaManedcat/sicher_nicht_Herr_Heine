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
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("In einem weit entverntem Land in Babendorf, in den Tiefen, des Schulgebaude-Dschungles " +
                "im Raum A1.25 in einem Zelt ist Jemand (der sicherlich nicht Sebastian Heine heißt) zu finden. " +
                "Er hat großes Wissen über die Zukunft");
            MessageBox.Show("Das Orakel: Hallo Wanderer, meine Name ist Herr Hei....*Pause* unwichtig eigentlich. " +
                "Ich weiß viel und wenn du Fragen über die Zukunft hast stell sie mir, vieliecht werde ich sie antworten.");
        }

        private void TextBox_TBAusgabe() { }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tschüssiiiii!!!");
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
