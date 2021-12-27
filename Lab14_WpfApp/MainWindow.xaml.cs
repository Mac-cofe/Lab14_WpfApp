using System;
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

namespace Lab14_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public enum Type
    {
        food, technique
    }

    public class Product
    {
        public string NameProduct { get; set; }
        public string ImageProduct { get; set; }
        public int PriceProduct { get; set; }
        public Type Type { get; set; }
    }


    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Телевизор",
                PriceProduct = 20500,
                Type = Type.technique,
                ImageProduct = "Picture/tv.jpg"
            });

            products.Add(new Product()
            {
                NameProduct = "Яблоки",
                PriceProduct = 85,
                Type = Type.food,
                ImageProduct = "Picture/apple.jpeg"
            });

            products.Add(new Product()
            {
                NameProduct = "Пылесос",
                PriceProduct = 6500,
                Type = Type.technique,
                ImageProduct = "Picture/cleaner.jpg"
            });

            products.Add(new Product()
            {
                NameProduct = "Печенье",
                PriceProduct = 120,
                Type = Type.food,
                ImageProduct = "Picture/cookies.jpg"
            });


            lst.ItemsSource = products;

        }
    }





}
