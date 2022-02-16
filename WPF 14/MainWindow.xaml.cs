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

namespace WPF_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                ProductName = "Пицца Маргарита",
                ProductPrice = 500,
                ProductImage = "Data/Пицца Маргарита.jpg",
                ProductCategory = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProductName = "Пицца Гавайская",
                ProductPrice = 400,
                ProductImage = "Data/Пицца Гавайская.jpg",
                ProductCategory = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProductName = "Пицца Неапалетано",
                ProductPrice = 450,
                ProductImage = "Data/Пицца Неапалетано.jpg",
                ProductCategory = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProductName = "Духовой шкаф",
                ProductPrice = 50000,
                ProductImage = "Data/Духовой шкаф.jpg",
                ProductCategory = ProductCategories.Appliances
            });

            products.Add(new Product()
            {
                ProductName = "Кофемашина",
                ProductPrice = 70000,
                ProductImage = "Data/Кофемашина.jpg",
                ProductCategory = ProductCategories.Appliances
            });

            products.Add(new Product()
            {
                ProductName = "Микроволновка",
                ProductPrice = 30000,
                ProductImage = "Data/Микроволновка.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
