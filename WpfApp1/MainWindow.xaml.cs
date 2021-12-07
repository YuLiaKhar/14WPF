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

namespace WpfApp1
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
                ProductName = "Яблоки красные",
                Price = 85,
                ImageProd = "Data/apple.jpg",
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Чайник Электрический",
                Price = 2500,
                ImageProd = "Data/tea.jpg",
                Category = Categories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновая печь",
                Price = 4300,
                ImageProd = "Data/micro.jpg",
                Category = Categories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Шоколад молочный",
                Price = 110,
                ImageProd = "Data/choco.jpg",
                Category = Categories.Food
            }); products.Add(new Product()
            {
                ProductName = "Чизкейк клубничный",
                Price = 140,
                ImageProd = "Data/cheese.jpg",
                Category = Categories.Food
            });
            lstBox.ItemsSource = products;
        }
    }
}
