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
    /// Interaction logic for CustomModalDialog.xaml
    /// </summary>
    public partial class CustomModalDialog : UserControl
    {
        public CustomModalDialog()
        {
            InitializeComponent();
        }

        //TitleText
        public string TitleText
        {
            get { return (string)GetValue(TitleTextProperty); }
            set { SetValue(TitleTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleTextProperty =
            DependencyProperty.Register("TitleText", typeof(string), typeof(CustomModalDialog));

        //SubtitleText

        public string SubTitleText
        {
            get { return (string)GetValue(SubTitleTextProperty); }
            set { SetValue(SubTitleTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SubTitleText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubTitleTextProperty =
            DependencyProperty.Register("SubTitleText", typeof(string), typeof(CustomModalDialog));

        //BodyMessage


        public string BodyMessage
        {
            get { return (string)GetValue(BodyMessageProperty); }
            set { SetValue(BodyMessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BodyMessage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BodyMessageProperty =
            DependencyProperty.Register("BodyMessage", typeof(string), typeof(CustomModalDialog));




        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //we want exit from modal by clicking outside of our grid 
            this.Visibility = Visibility.Collapsed;
        }
    }
}
