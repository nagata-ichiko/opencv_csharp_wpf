using OpenCvSharp;
using System.Windows;

namespace opencv_csharp_wpf.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var img = new Mat("D:\\dev\\opencv_csharp_wpf\\opencv_csharp_wpf\\image\\wj-Y3dc9.jpeg", ImreadModes.Color);

            Cv2.ImShow("image", img);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var img = new Mat("D:\\dev\\opencv_csharp_wpf\\opencv_csharp_wpf\\image\\wj-Y3dc9.jpeg", ImreadModes.Grayscale);

            Cv2.ImShow("image", img);
        }
    }
}
