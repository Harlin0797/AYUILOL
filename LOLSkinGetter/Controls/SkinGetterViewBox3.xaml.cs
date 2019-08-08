using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using Ay.Framework.WPF;
using Ay.Framework.WPF.Controls;

namespace LOLSkinGetter
{
    /// <summary>
    /// SkinGetterViewBox3.xaml 的交互逻辑
    /// </summary>
    public partial class SkinGetterViewBox3 : UserControl
    {
        public SkinGetterViewBox3()
        {
            InitializeComponent();
            Loaded += SkinGetterViewBox3_Loaded;
        }

        private void SkinGetterViewBox3_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= SkinGetterViewBox3_Loaded;

            CardShowTitle = (CardType == 1 ? "英雄" : "皮肤") + " " + CardTitle;
        }


        public string CardShowTitle
        {
            get { return (string)GetValue(CardShowTitleProperty); }
            set { SetValue(CardShowTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardShowTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardShowTitleProperty =
            DependencyProperty.Register("CardShowTitle", typeof(string), typeof(SkinGetterViewBox3), new PropertyMetadata(""));



        public string ShuiJinLeiBie
        {
            get { return (string)GetValue(ShuiJinLeiBieProperty); }
            set { SetValue(ShuiJinLeiBieProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShuiJinLeiBie.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShuiJinLeiBieProperty =
            DependencyProperty.Register("ShuiJinLeiBie", typeof(string), typeof(SkinGetterViewBox3), new PropertyMetadata("璀璨星光水晶"));



        public int CardType
        {
            get { return (int)GetValue(CardTypeProperty); }
            set { SetValue(CardTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardTypeProperty =
            DependencyProperty.Register("CardType", typeof(int), typeof(SkinGetterViewBox3), new PropertyMetadata(1));




        public string CardTitle
        {
            get { return (string)GetValue(CardTitleProperty); }
            set { SetValue(CardTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardTitleProperty =
            DependencyProperty.Register("CardTitle", typeof(string), typeof(SkinGetterViewBox3), new PropertyMetadata(""));


       


        public ImageSource CurrentImage
        {
            get { return (ImageSource)GetValue(CurrentImageProperty); }
            set { SetValue(CurrentImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentImageProperty =
            DependencyProperty.Register("CurrentImage", typeof(ImageSource), typeof(SkinGetterViewBox3), new PropertyMetadata(null));



       
    }

}
