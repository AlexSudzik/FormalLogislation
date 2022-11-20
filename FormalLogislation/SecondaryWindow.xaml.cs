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
using System.Windows.Shapes;
using System.IO;

namespace FormalLogislation
{
    /// <summary>
    /// Interaction logic for SecondaryWindow.xaml
    /// </summary>
    public partial class SecondaryWindow : Window
    {
        public SecondaryWindow()
        {
            InitializeComponent();
            ComboBox1.Items.Add("Imię");
            ComboBox1.Items.Add("Nazwisko");
            ComboBox1.Items.Add("Klasa");
            ComboBox2.Items.Add("zawiea");
            ComboBox2.Items.Add("rozpoczyna się od");
            

        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            string path = (@"C:\Users\Alex Sudzik\source\repos\AlexSudzik\FormalLogislation\FormalLogislation\images\uczen.txt");
            //File.WriteAllText(@"uczen.txt", SecondaryImie.Text);
            //(@"images\" + numba1.ToString() + ".png", UriKind.Relative));
            //File.AppendAllText(@"uczen.txt", SecondaryImie.Text.ToString() + " " + SecondaryNazwisko.Text.ToString() + " " + SecondaryKlasa.Text.ToString() + Environment.NewLine);
            //File.AppendAllText(@"C:\Users\Alex Sudzik\source\repos\AlexSudzik\FormalLogislation\FormalLogislation\uczen.txt", SecondaryImie.Text.ToString() + " " + SecondaryNazwisko.Text.ToString() + " " + SecondaryKlasa.Text.ToString() + Environment.NewLine);
            File.AppendAllText(path, SecondaryImie.Text.ToString() + ", " + SecondaryNazwisko.Text.ToString() + ", " + SecondaryKlasa.Text.ToString() + Environment.NewLine);
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
