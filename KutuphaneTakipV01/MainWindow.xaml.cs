﻿using KutuphaneTakipV01.Classlar;
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
            Versiyon.Content = DBbaglanti.BagDurum;
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
    }
}
