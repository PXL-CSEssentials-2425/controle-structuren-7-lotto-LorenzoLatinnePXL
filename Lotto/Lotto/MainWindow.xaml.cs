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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lotto
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("De 6 LOTTO-getallen zijn:");
            sb.AppendLine();

            for (int i = 1; i <= 6; i++)
            {
                sb.AppendLine($"Getal {i}: {rnd.Next(1, 46)}");
            }

            resultTextBox.Text = sb.ToString();
        }
    }
}
