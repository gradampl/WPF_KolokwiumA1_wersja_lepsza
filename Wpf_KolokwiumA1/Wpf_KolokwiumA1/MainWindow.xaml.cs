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

        private void PobierzZbudujPokaz()
        {
            string okno = rodzajOkien1.Text;
            string drzwi = rodzajDrzwi1.Text;

            if ((okno.Length < 3)||(drzwi.Length < 3))
                {
                    MessageBox.Show(String.Format("Zarówno rodzaj okna, jak i drzwi musi być wyrazem co najmniej trzywyrazowym."));
                }
            else
            {
                Kolor kolor = (Kolor)kolorElewacji1.SelectedItem;
                szefBudowy.Buduj(okno, drzwi, kolor);
                infoOProjekcie2.Text = szefBudowy.ToString();
            }            
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProjektDomu biurowiec=new Biurowiec();
            szefBudowy.WybierzProjekt(biurowiec);
            PobierzZbudujPokaz();
        }

        private void budujJednorodzinny_Click(object sender, RoutedEventArgs e)
        {
            ProjektDomu jednorodzinny = new DomJednorodzinny();
            szefBudowy.WybierzProjekt(jednorodzinny);
            PobierzZbudujPokaz();
        }

        private void kolorElewacji1_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = Kolor.GetValues(typeof(Kolor));
            comboBox.SelectedItem = Kolor.Zielony;
        }
   }
}
