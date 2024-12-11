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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set the image sources
            image2.Source = new BitmapImage(new Uri("pack://application:,,,/Images/image2.jpg"));
            image3.Source = new BitmapImage(new Uri("pack://application:,,,/Images/image3.jfif"));
            liliac.Source = new BitmapImage(new Uri("pack://application:,,,/Images/liliac.jpg"));
        }
    }
    }

