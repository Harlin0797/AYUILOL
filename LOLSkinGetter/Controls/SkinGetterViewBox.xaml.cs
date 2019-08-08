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
    /// SkinGetterViewBox.xaml 的交互逻辑
    /// </summary>
    public partial class SkinGetterViewBox : UserControl
    {
        public SkinGetterViewBox()
        {
            InitializeComponent();
            Loaded += SkinGetterViewBox_Loaded;
        }

        private void SkinGetterViewBox_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= SkinGetterViewBox_Loaded;
            if (CardStatus == 0)
            {
                btnArea.Visibility = Visibility.Collapsed;
                btnLingqu.Visibility = Visibility.Visible;
            }
            else
            {
                btnArea.Visibility = Visibility.Visible;
                btnLingqu.Visibility = Visibility.Collapsed;
                imgCurrentImage.Effect = AyEffects.HeiBai();
                imgCurrentImage.Opacity = 0.5;
                btnOverlay.Visibility = Visibility.Visible;
            }
   

            if (HasXianDing)
            {
                Image i = new Image();
                i.VerticalAlignment = VerticalAlignment.Top;
                i.HorizontalAlignment = HorizontalAlignment.Left;
                i.Width = 146;
                i.Height = 168;
                ImageBehavior.SetRepeatBehavior(i, RepeatBehavior.Forever);

                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.UriSource = new Uri(@"pack://application:,,,/LOLSkinGetter;component/Contents/Images/Sow/gold_cover_146x168.gif", UriKind.RelativeOrAbsolute);
                bmp.EndInit();
      
                ImageBehavior.SetAnimatedSource(i, bmp);
                gridImagePre.Children.Add(i);
            }
        }

        public int CardType
        {
            get { return (int)GetValue(CardTypeProperty); }
            set { SetValue(CardTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardTypeProperty =
            DependencyProperty.Register("CardType", typeof(int), typeof(SkinGetterViewBox), new PropertyMetadata(1));




        public string CardTitle
        {
            get { return (string)GetValue(CardTitleProperty); }
            set { SetValue(CardTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardTitleProperty =
            DependencyProperty.Register("CardTitle", typeof(string), typeof(SkinGetterViewBox), new PropertyMetadata(""));




        public string CardExpire
        {
            get { return (string)GetValue(CardExpireProperty); }
            set { SetValue(CardExpireProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardExpire.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardExpireProperty =
            DependencyProperty.Register("CardExpire", typeof(string), typeof(SkinGetterViewBox), new PropertyMetadata("7天"));


        /// <summary>
        /// 0未领取  1已经领取
        /// </summary>
        public int CardStatus
        {
            get { return (int)GetValue(CardStatusProperty); }
            set { SetValue(CardStatusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardStatus.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardStatusProperty =
            DependencyProperty.Register("CardStatus", typeof(int), typeof(SkinGetterViewBox), new PropertyMetadata(0));


        /// <summary>
        /// 领取区
        /// </summary>
        public string CardPlace
        {
            get { return (string)GetValue(CardPlaceProperty); }
            set { SetValue(CardPlaceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardPlace.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardPlaceProperty =
            DependencyProperty.Register("CardPlace", typeof(string), typeof(SkinGetterViewBox), new PropertyMetadata(null));




        public ImageSource CurrentImage
        {
            get { return (ImageSource)GetValue(CurrentImageProperty); }
            set { SetValue(CurrentImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentImageProperty =
            DependencyProperty.Register("CurrentImage", typeof(ImageSource), typeof(SkinGetterViewBox), new PropertyMetadata(null));



        public bool HasXianDing
        {
            get { return (bool)GetValue(HasXianDingProperty); }
            set { SetValue(HasXianDingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HasXianDing.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasXianDingProperty =
            DependencyProperty.Register("HasXianDing", typeof(bool), typeof(SkinGetterViewBox), new PropertyMetadata(false));

        private void btnLingqu_Click(object sender, RoutedEventArgs e)
        {
            SkinGetterModel d = this.Tag as SkinGetterModel;
            
            MessageBox.Show("领取成功  -  "+ d.Title, "AY提示");
        }
    }

    public sealed class YXPFConverter : IValueConverter
    {

        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            int CardType = value.ToInt();//得到文件路径
            string path = null;
            if (CardType == 1)
            {
                path = AyuiConfig.BaseDirectory + @"contents\Images\Sow\gift_ico_yx.png";
            }
            else if (CardType == 2)
            {
                path = AyuiConfig.BaseDirectory + @"contents\Images\Sow\gift_ico_pf.png";
            }
            //如果文件路径存在
            if (path != null)
            {
                //创建一个新的BitmapImage对象以及一个新的文件流
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();//开始更新状态
                                        //指定BitmapImage的StreamSource为按指定路径打开的文件流
                bitmapImage.StreamSource = new FileStream(path, FileMode.Open, FileAccess.Read);
                //加载Image后以便立即释放流
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();//结束更新
                                      //清除流以避免在尝试删除图像时出现文件访问异常
                bitmapImage.StreamSource.Dispose();
                return bitmapImage;//返回BitmapImage
            }
            else
            {
                return DependencyProperty.UnsetValue;//返回未设置依赖值
            }
        }
        //反转换方法，不需要进行实现
        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }

    public sealed class CardImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            int Id = value.ToInt();
            string ids = Id.ToString();
            string path = null;
            if (Id < 1000)
            {
                ids = ids + "000";
            }
            path = AyuiConfig.BaseDirectory + @"contents\appgames\" + ids + ".jpg";

            //如果文件路径存在
            if (path != null)
            {
                //创建一个新的BitmapImage对象以及一个新的文件流
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();//开始更新状态
                                        //指定BitmapImage的StreamSource为按指定路径打开的文件流
                bitmapImage.StreamSource = new FileStream(path, FileMode.Open, FileAccess.Read);
                //加载Image后以便立即释放流
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();//结束更新
                                      //清除流以避免在尝试删除图像时出现文件访问异常
                bitmapImage.StreamSource.Dispose();
                return bitmapImage;//返回BitmapImage
            }
            else
            {
                return DependencyProperty.UnsetValue;//返回未设置依赖值
            }
        }
        //反转换方法，不需要进行实现
        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }

   
}
