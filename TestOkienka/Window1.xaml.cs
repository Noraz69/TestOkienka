﻿using System;
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
using System.Windows.Navigation;

namespace TestOkienka
{
    
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_Checker(object sender, RoutedEventArgs e)
        {
            string passWrittenEM = pass.Text;
            PasswordChecker Equal = new PasswordChecker();
            Equal.EqualMethod(passWrittenEM);

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            this.Close();

        }
    }
}
