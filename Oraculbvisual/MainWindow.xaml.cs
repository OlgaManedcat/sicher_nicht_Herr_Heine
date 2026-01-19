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
        }
        MessageBox vorbegrussung = MessageBox("In einem wiedt entverntem land in Babendorf, in den Tiefen, des Schulgebaude-Djungles im Raum A1.25 in einem Zelt ist jemand (der sicherlich nicht Sebastian Heine heißt) zu finden. Er hat große wissen uber zukunft ) ");
        MessageBox begrussung = new MessageBox("Hallo Wanderer, meine name ist Herr Hei....*Pause* unwichtig eigentlich. Ich weiß viel und when du Fragen über Zukunft hast stell die, vieliecht ich wurde die antworten.");
        private void TextBox_TBAusgabe() { }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
