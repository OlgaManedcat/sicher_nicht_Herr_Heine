using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                "im Raum A1.25 in einem Zelt ist jemand (der sicherlich nicht Sebastian Heine heißt) zu finden. " +
                "Er hat großes Wissen uber zukunft");
            MessageBox.Show("Das Orakel: Hallo Wanderer, meine name ist Herr Hei....*Pause* unwichtig eigentlich. " +
                "Ich weiß viel und wenn du Fragen über die Zukunft hast stell sie mir, vieliecht werde ich sie antworten.");
        }
       
        private void TextBox_TBAusgabe() { }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
