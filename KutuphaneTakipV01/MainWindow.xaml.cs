using KutuphaneTakipV01.Classlar;
using KutuphaneTakipV01.Image.UKontroller;
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

namespace KutuphaneTakipV01
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

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void menubuton_kitaplistesi_Click(object sender, RoutedEventArgs e)
        {
            uc_cagir.Uc_Ekle(Content_icerik, new ucKitapListesi());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uc_cagir.Uc_Ekle(Content_icerik, new ucKitapListesi());
            DBbaglanti.BagTest();
            
        }

        private void btn_SimgeDurumu_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_TamEkran_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void btn_hamburgerMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (btn_hamburgerMenu.Width != 60) 
            {
                GridLength grd = new GridLength(80, GridUnitType.Pixel);
                grdClmn_menu.Width = grd;

                lbl_menu1.Visibility = Visibility.Hidden;
                lbl_menu2.Visibility = Visibility.Hidden;
                lbl_menu3.Visibility = Visibility.Hidden;
                lbl_menu4.Visibility = Visibility.Hidden;
                lbl_menu5.Visibility = Visibility.Hidden;
                lbl_menu6.Visibility = Visibility.Hidden;

                lbl_logoyazi.Width = 0;
                btn_hamburgerMenu.Width = 60;
                menu_altlabel_border.Visibility = Visibility.Hidden;
            }else
            {
                GridLength grd = new GridLength(220, GridUnitType.Pixel);
                grdClmn_menu.Width = grd;

                lbl_menu1.Visibility = Visibility.Visible;
                lbl_menu2.Visibility = Visibility.Visible;
                lbl_menu3.Visibility = Visibility.Visible;
                lbl_menu4.Visibility = Visibility.Visible;
                lbl_menu5.Visibility = Visibility.Visible;
                lbl_menu6.Visibility = Visibility.Visible;

                lbl_logoyazi.Width = 150;
                btn_hamburgerMenu.Width = 100;
                menu_altlabel_border.Visibility = Visibility.Visible;
            }
            
            
        }
    }
}
