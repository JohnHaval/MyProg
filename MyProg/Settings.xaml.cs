﻿using Microsoft.Win32;
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
using WorkNotepadLibrary;

namespace MyProg
{
    /// <summary>
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }
        WorkNotepad _worknotepad;
        private void LImpact_Selected(object sender, RoutedEventArgs e)
        {
            
        }
        public static void Settings_Click()
        {
            
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            _worknotepad.SaveSettings();            
        }

        private void StyleSegoeUI_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void TimesNewRoman_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void StyleArial_ComboBox_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void LoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog loadimage = new OpenFileDialog
            {
                Title = "Выбор картинки",
                Filter = "Фон(.png) | *.png | Фон(.jpg) | *.jpg | Все фоны(.*) | *.*",
                FilterIndex = 1,
                DefaultExt = ".png",
            };
            if (loadimage.ShowDialog() == true)
            {
                ImagePath.Text = _worknotepad.ImagePath = loadimage.FileName;
            }
        }
    }
}