using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_Working_with_Images
{
    /// <summary>
    /// Interaction logic for HelperWindow.xaml
    /// </summary>
    public partial class HelperWindow : Window
    {
        public List<Image> Images { get; set; }
        private int _counter = default;
        public HelperWindow()
        {
            InitializeComponent();            
        }
        public HelperWindow(List<Image> images, int index)
        {
            InitializeComponent();
            Images = images;
            ImgFromListBox.Source = Images[index].Source;

            _counter = index;
        }

        private void ImgBack_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = true;
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (_counter - 1 >= 0)
            {
                _counter -= 1;
                ImgFromListBox.Source = Images[_counter].Source;
            }
        }

        private async void BtnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            while (_counter + 1 < Images.Count)
            {
                BtnPlayPause.Visibility = Visibility.Collapsed;

                ++_counter;
                ImgFromListBox.Source = Images[_counter].Source;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            BtnPlayPause.Visibility = Visibility.Visible;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (_counter + 1 > 0 && _counter + 1 < Images.Count)
            {
                _counter += 1;
                ImgFromListBox.Source = Images[_counter].Source;
            }
        }
    }
}