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

namespace FormalLogislation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Random rn = new Random();
            //int numba1 = rn.Next(1, 8);
            //Zdjecie.Source = new BitmapImage(new Uri(@"images\" + numba1.ToString() + ".png", UriKind.Relative));

        }
       
        Random rn = new Random();
        //int numba1 = rn.Next(1, 8);
        

        
        private void zaloguj_Click(object sender, RoutedEventArgs e)
        {
            if(uzytkownik.Text == "admin" && haslo.Text == "Qwerty1@34")
            {
                if (1 == 1)
                {


                }




                SecondaryWindow objSecondaryWindow = new SecondaryWindow();
                this.Visibility = Visibility.Hidden;
                objSecondaryWindow.Show();

            }
            else
            {
                uzytkownik.Text = "";
                haslo.Text = "";
                obrazek_haslo.Text = "";
            }
            
        }
        private void losujnowy_click(object sender, RoutedEventArgs e)
        {
            //Zdjecie.Source = new BitmapImage(new Uri(@"images\1.png", UriKind.Relative));
            int numba = rn.Next(1, 8);
            Zdjecie.Source = new BitmapImage(new Uri(@"images\" + numba.ToString() + ".png", UriKind.Relative)) ;


        }
    }
}
