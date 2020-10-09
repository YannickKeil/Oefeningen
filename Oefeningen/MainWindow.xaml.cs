using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace Oefeningen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> geslacht = new List<string>() { "Man", "Vrouw" };
        List<string> leeftijdCategory = new List<string>() { "Minderjarige", "Volwassen","Bejaard" };
        
        public MainWindow()
        {
            InitializeComponent();
            oef1();
            oef5();
        }
        public void oef1()
        {
            cbGeslacht.ItemsSource = geslacht;
            cbGeslacht.SelectedIndex = 0;
            cbLeeftijdCategory.ItemsSource = leeftijdCategory;
            cbLeeftijdCategory.SelectedIndex = 0;
        }

        private void btnOef1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cbLeeftijdCategory.Text + " " + cbGeslacht.Text);
        }

        private void tbOef2tab1_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbOef2tab2.Text = tbOef2tab1.Text;
        }

        private void tbOef2tab2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbOef2tab1.Text = tbOef2tab2.Text;
        }

        private void btnOef3_Click(object sender, RoutedEventArgs e)
        {
            if(txtLorem.Foreground == Brushes.Blue)
            {
                txtLorem.Foreground = Brushes.Black;
            }
            else
            {
                txtLorem.Foreground = Brushes.Blue;
            }


        }

        private void mnClearText_Click(object sender, RoutedEventArgs e)
        {
            txtOef4.Text = "";
        }
        List<Persoon> personenlijst = new List<Persoon>();
        public void oef5()
        {
            personenlijst.Add(new Persoon("Naruto", "Uzumaki", true));
            personenlijst.Add(new Persoon("Moka", "akashia", false));
            personenlijst.Add(new Persoon("Yoruichi", "Shihōin", true));
            personenlijst.Add(new Persoon("Sasuke", "Uchiha", false));
            lbOef5.ItemsSource = personenlijst;
                       
        }
        public class Persoon 
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public bool Online { get; set; }
            public string GetSource 
            { 
                get{
                    if (Online) { return $"{Directory.GetCurrentDirectory()}/check-mark.png"; } else { return $"{Directory.GetCurrentDirectory()}/cross-mark.png"; }
                } 
            }

            public Persoon(string voornaam, string achternaam,bool online)
            {
                Voornaam = voornaam;
                Achternaam = achternaam;
                Online = online;

            }
        }

        private void btnOef6_Click(object sender, RoutedEventArgs e)
        {
            string tonen ="";
            if ((bool)xbRood.IsChecked)
            {
                tonen += xbRood.Content + " ";
            }
            if ((bool)xbOranje.IsChecked)
            {
                tonen += xbOranje.Content + " "; 
            }
            if ((bool)xbGeel.IsChecked)
            {
                tonen += xbGeel.Content + " "; 
            }
            if ((bool)xbGroen.IsChecked)
            {
                tonen += xbGroen.Content + " "; 
            }
            if ((bool)xbBlauw.IsChecked)
            {
                tonen += xbBlauw.Content + " ";
            }
            MessageBox.Show(tonen);
        }





        //<Menu HorizontalAlignment = "Left" >
        //        < Menu.ItemsPanel >
        //            < ItemsPanelTemplate >
        //                < StackPanel />
        //            </ ItemsPanelTemplate >
        //        </ Menu.ItemsPanel >
        //        < MenuItem Header="Oefeningen">
        //            <MenuItem Header = "oefening 1" x:Name="mnuOef1" Click="mnuOef1_Click" />
        //            <MenuItem Header = "oefening 2" x:Name="mnuOef2" Click="mnuOef2_Click" />
        //            <MenuItem Header = "oefening 3" x:Name="mnuOef3" Click="mnuOef3_Click" />
        //            <MenuItem Header = "oefening 4" x:Name="mnuOef4" Click="mnuOef4_Click" />
        //            <MenuItem Header = "oefening 5" x:Name="mnuOef5" Click="mnuOef5_Click" />
        //            <MenuItem Header = "oefening 6" x:Name="mnuOef6" Click="mnuOef6_Click" />
        //            <MenuItem Header = "oefening 7" x:Name="mnuOef7" Click="mnuOef7_Click" />
        //        </MenuItem>
        //        <MenuItem Header = "Item 2" >
        //        </ MenuItem >
        //        < MenuItem Header="Item 3" />
        //        <MenuItem Header = "Item 4" />
        //    </ Menu >
        //private void mnuOef1_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void mnuOef2_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void mnuOef3_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void mnuOef4_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void mnuOef5_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void mnuOef6_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void mnuOef7_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
