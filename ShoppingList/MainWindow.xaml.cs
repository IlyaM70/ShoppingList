﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> _list;
        public MainWindow()
        {
            InitializeComponent();
            _list = new ObservableCollection<string>();
            List.ItemsSource = _list;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _list.Add(Add.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (_list.Contains(Delete.Text))
            {
                _list.Remove(Delete.Text);
            }
        }
    }
}
