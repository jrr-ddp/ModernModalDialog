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

namespace ModalDialog
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


        private void ShowModal_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomModalDialog() { TitleText = "WPF Tutorial", SubTitleText = "VBJ IT Solution", BodyMessage = "Hi, this is the channel for learning purpose. First we" +
                "Staryt with WPF tutorials other things are follows, Thank you" };
            MainGrid.Children.Add(dialog);
        }
    }
}
