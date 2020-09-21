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

namespace Pra.HerhalingEnums.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //ENUMERATIES hebben pas echt zin wanneer je klassen gebruikt
        // deze demo toont enkel wat dingetjes die je kan doen met een gegeven enumeratie
        enum Vormen { cirkel, vierkant, ovaal, rechthoek, piramide, parallelogram }

        private void BtnEnum1_Click(object sender, RoutedEventArgs e)
        {
            // je kan de namen uit een enumartie als volgt opvragen (m.b.v. Enum.GetNames)
            string[] vormen = Enum.GetNames(typeof(Vormen));
            lstDisplay.Items.Clear();
            foreach (string vorm in vormen)
            {
                lstDisplay.Items.Add(vorm);
            }
        }

        private void BtnEnum2_Click(object sender, RoutedEventArgs e)
        {
            // namen zijn voorstellingen.
            // in werkelijkheid zijn enumeraties NUMERIEKE waarden
            // je kan deze numerieke waarden opvragen met de GetValues() methode
            Array waarden = Enum.GetValues(typeof(Vormen));
            lstDisplay.Items.Clear();
            foreach (int waarde in waarden)
            {
                lstDisplay.Items.Add(waarde);
            }
        }


        // hieronder nog wat "bizarre" code die verder weinig belangrijk is
        // alleen maar omdat het kan ...
        enum Raredingen { voetganger = 1, fietser = 3, auto = 9, trein = 81 }
        private void BtnEnum3_Click(object sender, RoutedEventArgs e)
        {
            var waarden = Enum.GetValues(typeof(Raredingen));
            lstDisplay.Items.Clear();
            foreach (var waarde in waarden)
            {
                lstDisplay.Items.Add(waarde.ToString() + " = " + (int)waarde);
            }

        }
    }
}
