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
        BitmapImage bmap = new BitmapImage();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainImageLoaded(object sender, RoutedEventArgs e)
        {
            bmap.BeginInit();
            bmap.UriSource = new Uri("C:\\Users\\Yggdrasil\\Documents\\PixelSorter\\Space.jpg");
            bmap.EndInit();

            var image = sender as Image;
            image.Source = bmap;

        }

        private void SortImage(object sender, RoutedEventArgs e)
        {
            double imageWidth = bmap.Width;
            double imageHeight = bmap.Height;
            for (int i = 0; i < imageWidth; i++)
            {
                for (int j = 0; j < imageHeight; j++)
                {
                }

            }

        }
    }
}
