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
    /// SkinGetterViewBox2.xaml 的交互逻辑
    /// </summary>
    public partial class SkinGetterViewBox2 : UserControl
    {
        public SkinGetterViewBox2()
        {
            InitializeComponent();
            Loaded += SkinGetterViewBox2_Loaded;
        }

        private void SkinGetterViewBox2_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= SkinGetterViewBox2_Loaded;

            string _1 = (CardType == 1 ? "英雄" : "皮肤") + " " + CardTitle;
            if (CardExpire != "")
            {
                _1 = _1 + " 7天体验";
            }
            CardShowTitle = _1;

            if (HasXianDing)
            {
                Image i = new Image();
                i.VerticalAlignment = VerticalAlignment.Top;
                i.HorizontalAlignment = HorizontalAlignment.Left;
                i.Width = 107;
                i.Height = 142;
                ImageBehavior.SetRepeatBehavior(i, RepeatBehavior.Forever);

                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.UriSource = new Uri(@"pack://application:,,,/LOLSkinGetter;component/Contents/Images/Sow/gold_cover_107x142.gif", UriKind.RelativeOrAbsolute);
                bmp.EndInit();

                ImageBehavior.SetAnimatedSource(i, bmp);
                gridImagePre.Children.Add(i);
            }
        }


        public string CardShowTitle
        {
            get { return (string)GetValue(CardShowTitleProperty); }
            set { SetValue(CardShowTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardShowTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardShowTitleProperty =
            DependencyProperty.Register("CardShowTitle", typeof(string), typeof(SkinGetterViewBox2), new PropertyMetadata(""));



        public int CardType
        {
            get { return (int)GetValue(CardTypeProperty); }
            set { SetValue(CardTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardTypeProperty =
            DependencyProperty.Register("CardType", typeof(int), typeof(SkinGetterViewBox2), new PropertyMetadata(1));




        public string CardTitle
        {
            get { return (string)GetValue(CardTitleProperty); }
            set { SetValue(CardTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardTitleProperty =
            DependencyProperty.Register("CardTitle", typeof(string), typeof(SkinGetterViewBox2), new PropertyMetadata(""));


        public string CardExpire
        {
            get { return (string)GetValue(CardExpireProperty); }
            set { SetValue(CardExpireProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardExpire.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardExpireProperty =
            DependencyProperty.Register("CardExpire", typeof(string), typeof(SkinGetterViewBox2), new PropertyMetadata(""));



        public ImageSource CurrentImage
        {
            get { return (ImageSource)GetValue(CurrentImageProperty); }
            set { SetValue(CurrentImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentImageProperty =
            DependencyProperty.Register("CurrentImage", typeof(ImageSource), typeof(SkinGetterViewBox2), new PropertyMetadata(null));



        public bool HasXianDing
        {
            get { return (bool)GetValue(HasXianDingProperty); }
            set { SetValue(HasXianDingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HasXianDing.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasXianDingProperty =
            DependencyProperty.Register("HasXianDing", typeof(bool), typeof(SkinGetterViewBox2), new PropertyMetadata(false));


    }

}
