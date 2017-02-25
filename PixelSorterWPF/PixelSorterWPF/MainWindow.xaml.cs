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

namespace PixelSorterWPF
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

        private void MainImageLoaded(object sender, RoutedEventArgs e)
        {
            BitmapImage bmap = new BitmapImage();
            bmap.BeginInit();
            bmap.UriSource = new Uri("C:\\Users\\Yggdrasil\\Documents\\PixelSorter\\Space.jpg");
            bmap.EndInit();

            var image = sender as Image;
            image.Source = bmap;

        }
    }
}
