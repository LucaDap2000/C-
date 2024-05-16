﻿using System.Net.Cache;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name = "John", Age = 30},
            new Person{Name = "Peter", Age = 20},
            new Person{Name = "Maria", Age = 40},
            new Person{Name = "Mark", Age = 35},
            new Person{Name = "Scott", Age = 27}
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(item.GetType().ToString());
            }
        }
    }
}