using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LOLSkinGetter
{
    /// <summary>
    /// MessageDialog.xaml 的交互逻辑
    /// </summary>
    public partial class MessageDialog : UserControl
    {
        public MessageDialog()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(MessageDialog), new PropertyMetadata("温馨提示"));



        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Message.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(MessageDialog), new PropertyMetadata(""));




        public double MWidth
        {
            get { return (double)GetValue(MWidthProperty); }
            set { SetValue(MWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MWidthProperty =
            DependencyProperty.Register("MWidth", typeof(double), typeof(MessageDialog), new PropertyMetadata(560.0));



        public double MHeight
        {
            get { return (double)GetValue(MHeightProperty); }
            set { SetValue(MHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MHeightProperty =
            DependencyProperty.Register("MHeight", typeof(double), typeof(MessageDialog), new PropertyMetadata(150.0));

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_TouchDown(object sender, TouchEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
