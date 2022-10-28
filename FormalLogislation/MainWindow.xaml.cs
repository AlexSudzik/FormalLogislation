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
        public string Captcha = "";
        public MainWindow()
        {
            InitializeComponent();
            
            //losowanie obrazka i prawidlowego hasla do niego
            Random rn = new Random();
            int numba1 = rn.Next(1, 8);
            Zdjecie.Source = new BitmapImage(new Uri(@"images\" + numba1.ToString() + ".png", UriKind.Relative));
            if(numba1 == 1)
            {
                Captcha = "mxyxw";
            }
            if (numba1 == 2)
            {
                Captcha = "b5nmm";
            }
            if (numba1 == 3)
            {
                Captcha = "74853";
            }
            if (numba1 == 4)
            {
                Captcha = "cg5dd";
            }
            if (numba1 == 5)
            {
                Captcha = "x3deb";
            }
            if (numba1 == 6)
            {
                Captcha = "befbd";
            }
            if (numba1 == 7)
            {
                Captcha = "rc7gb3";
            }

        }
        


        private void zaloguj_Click(object sender, RoutedEventArgs e)
        {
            //sprawdzanie prawidlowosci danych
            if(uzytkownik.Text == "admin" && haslo.Text == "Qwerty1@34" && obrazek_haslo.Text == Captcha)
            {
                //odpala drugie okno
                SecondaryWindow objSecondaryWindow = new SecondaryWindow();
                this.Visibility = Visibility.Hidden;
                objSecondaryWindow.Show();

            }
            else
            {
                //błędne odpowiedzi przy logowaniu
                uzytkownik.Text = "błąd";
                haslo.Text = "błąd";
                obrazek_haslo.Text = "błąd";

                //ponowne losowanie captch'y
                Random rn = new Random();
                int numba1 = rn.Next(1, 8);
                Zdjecie.Source = new BitmapImage(new Uri(@"images\" + numba1.ToString() + ".png", UriKind.Relative));
                if (numba1 == 1)
                {
                    Captcha = "mxyxw";
                }
                if (numba1 == 2)
                {
                    Captcha = "b5nmm";
                }
                if (numba1 == 3)
                {
                    Captcha = "74853";
                }
                if (numba1 == 4)
                {
                    Captcha = "cg5dd";
                }
                if (numba1 == 5)
                {
                    Captcha = "x3deb";
                }
                if (numba1 == 6)
                {
                    Captcha = "befbd";
                }
                if (numba1 == 7)
                {
                    Captcha = "rc7gb3";
                }
            }
            
        }


        private void losujnowy_click(object sender, RoutedEventArgs e)
        {
            //losowanie obrazka i prawidlowego hasla do niego, po kliknieciu guzika "losuj nowy"
            Random rn = new Random();
            int numba1 = rn.Next(1, 8);
            Zdjecie.Source = new BitmapImage(new Uri(@"images\" + numba1.ToString() + ".png", UriKind.Relative));
            if (numba1 == 1)
            {
                Captcha = "mxyxw";
            }
            if (numba1 == 2)
            {
                Captcha = "b5nmm";
            }
            if (numba1 == 3)
            {
                Captcha = "74853";
            }
            if (numba1 == 4)
            {
                Captcha = "cg5dd";
            }
            if (numba1 == 5)
            {
                Captcha = "x3deb";
            }
            if (numba1 == 6)
            {
                Captcha = "befbd";
            }
            if (numba1 == 7)
            {
                Captcha = "rc7gb3";
            }

        }
    }
}
