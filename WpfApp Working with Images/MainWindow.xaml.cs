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

namespace WpfApp_Working_with_Images
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nullable<bool> _isImageTile = null;
        public MainWindow()
        {
            InitializeComponent();
        }     

        private void LstBxImage_DragEnter(object sender, DragEventArgs e)
        {
            LstBxImage.Background = Brushes.SpringGreen;
        }

        private void LstBxImage_DragLeave(object sender, DragEventArgs e)
        {
            LstBxImage.Background = Brushes.WhiteSmoke;
        }

        private void LstBxImage_Drop(object sender, DragEventArgs e)
        {
            LstBxImage.Background = Brushes.WhiteSmoke;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            string path = ImageHelper.GetFileNamesFromFiles(files);

            if (ImageHelper.IsFileImage(path) == false)
            {
                MessageBox.Show("File is not an image format.");
                return;
            }

            Image image = new Image
            {
                Source = new BitmapImage(new Uri(path)),
                Width = 350,
                Height = 250,
                Stretch = Stretch.Fill
            };

            image.MouseUp += Image_MouseUp;

            LstBxImage.Items.Add(image);
            LstBxImage.ScrollIntoView(LstBxImage.Items[LstBxImage.Items.Count - 1]);
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Hide();

            HelperWindow helper = new HelperWindow(GetChangedImages(350, 250), LstBxImage.SelectedIndex);
            helper.ShowDialog();

            this.Show();
            LstBxImage.SelectedIndex = 0;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (_isImageTile == null)
            {
                ChangeImagesInsideListBox(350, 250);
            }
            else if (_isImageTile == true)
            {
                ChangeImagesInsideListBox(100, 100);
            }
            else
            {
                ChangeImagesInsideListBox(250, 150);
            }
        }

        private void MnItmTiles_Click(object sender, RoutedEventArgs e)
        {
            ChangeImagesInsideListBox(100, 100);
            _isImageTile = true;
        }

        private void MnItmSmallIcons_Click(object sender, RoutedEventArgs e)
        {
            ChangeImagesInsideListBox(250, 150);
            _isImageTile = false;
        }

        private void MnItmNormalIcons_Click(object sender, RoutedEventArgs e)
        {
            ChangeImagesInsideListBox(350, 250);
            _isImageTile = null;
        }

        private void ChangeImagesInsideListBox(int width, int height)
        {
            List<Image> _images = GetChangedImages(width, height);
            LstBxImage.Items.Clear();
            _images.ForEach(img => LstBxImage.Items.Add(img));
        }

        private List<Image> GetChangedImages(int width, int height)
        {
            List<Image> _images = new List<Image>();

            for (int i = 0; i < LstBxImage.Items.Count; i++)
            {
                _images.Add(LstBxImage.Items[i] as Image);
                _images[i].Width = width;
                _images[i].Height = height;
                _images[i].Stretch = Stretch.Fill;
            }

            return _images;
        }

    }



    public static class ImageHelper
    {

        public static string GetFileNamesFromFiles(string[] files)
        {
            StringBuilder allFileNames = new StringBuilder();

            foreach (var file in files)
            {
                allFileNames.Append(file);
            }

            return allFileNames.ToString();
        }

        public static bool IsFileImage(string path)
        {
            List<string> imageExtensions = new List<string> { ".jpg", ".jpeg", ".jfif", ".png", ".jpe" };

            for (int i = 0; i < imageExtensions.Count; i++)
            {
                if (path.ToLower().EndsWith(imageExtensions[i].ToLower()))
                {
                    return true;
                }
            }

            return false;
        }
    }


}
