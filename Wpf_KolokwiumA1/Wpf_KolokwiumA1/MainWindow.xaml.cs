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

namespace Wpf_KolokwiumA1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SzefBudowy szefBudowy = new SzefBudowy();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProjektDomu biurowiec=new Biurowiec();
            szefBudowy.WybierzProjekt(biurowiec);
            string okno = rodzajOkien1.Text;
            string drzwi = "";
            Kolor kolor = (Kolor)kolorElewacji1.SelectedItem;
            
            szefBudowy.Buduj(okno,drzwi,kolor);
            infoOProjekcie2.Text=szefBudowy.ToString();
        }

        private void budujJednorodzinny_Click(object sender, RoutedEventArgs e)
        {
            ProjektDomu jednorodzinny = new DomJednorodzinny();
            szefBudowy.WybierzProjekt(jednorodzinny);
            string okno = rodzajOkien1.Text;
            string drzwi = rodzajDrzwi1.Text;
            Kolor kolor = Kolor.Czerwony;
            szefBudowy.Buduj(okno, drzwi, kolor);
            infoOProjekcie2.Text = szefBudowy.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
        }

        private void kolorElewacji1_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = Kolor.GetValues(typeof(Kolor));
            comboBox.SelectedItem = Kolor.Zielony;
            
        }

        private void rodzajOkien1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void rodzajDrzwi1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        

    }
}
