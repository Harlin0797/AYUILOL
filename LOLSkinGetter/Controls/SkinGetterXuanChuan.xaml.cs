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
using System.Windows.Threading;
using Ay.Framework.WPF.AyAnimate;

namespace LOLSkinGetter
{
    /// <summary>
    /// SkinGetterXuanChuan.xaml 的交互逻辑
    /// </summary>
    public partial class SkinGetterXuanChuan : UserControl
    {
        public SkinGetterXuanChuan()
        {
            InitializeComponent();
            Loaded += SkinGetterXuanChuan_Loaded;
        }


        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(SkinGetterXuanChuan), new PropertyMetadata(null));



        public double ViewBoxWidth
        {
            get { return (double)GetValue(ViewBoxWidthProperty); }
            set { SetValue(ViewBoxWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ViewBoxWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewBoxWidthProperty =
            DependencyProperty.Register("ViewBoxWidth", typeof(double), typeof(SkinGetterXuanChuan), new PropertyMetadata(340.0));



        public double ViewBoxHeight
        {
            get { return (double)GetValue(ViewBoxHeightProperty); }
            set { SetValue(ViewBoxHeightProperty, value); }
        }

        public static readonly DependencyProperty ViewBoxHeightProperty =
            DependencyProperty.Register("ViewBoxHeight", typeof(double), typeof(SkinGetterXuanChuan), new PropertyMetadata(225.0));

        public double LeftWidth
        {
            get { return (double)GetValue(LeftWidthProperty); }
            set { SetValue(LeftWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LeftWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LeftWidthProperty =
            DependencyProperty.Register("LeftWidth", typeof(double), typeof(SkinGetterXuanChuan), new PropertyMetadata(340.0));



        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Number.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(SkinGetterXuanChuan), new PropertyMetadata(1));



        bool isfirst = false;
        DispatcherTimer autoPlay = null;
        double currplayIndex = 0;
        private void SkinGetterXuanChuan_Loaded(object sender, RoutedEventArgs e)
        {
            //double _1 = 0;
            for (int i = 0; i < Number; i++)
            {
                RadioButton rb = new RadioButton();
                rb.AddHandler(UIElement.MouseEnterEvent, new MouseEventHandler(Rb_MouseEnter), true);
                rb.AddHandler(UIElement.MouseLeaveEvent, new MouseEventHandler(Rb_MouseLeave), true);
                rb.Checked += Rb_Checked;
                rb.SetResourceReference(RadioButton.StyleProperty, "rdoNavSkin");
                if (i == 0) rb.IsChecked = true;
                if (i > 0) rb.Margin = new Thickness(12, 0, 0, 0);
                rb.Tag = i;
                //_1 = _1 + LeftWidth;
                sp_navs.Children.Add(rb);
            }
            ad = new AyAniDouble(prev);
            isfirst = true;

            autoPlay = AyTime.setInterval(1000, () =>
             {
                 if (currplayIndex == (Number - 1))
                 {
                     //最后1个
                     currplayIndex = 0;
                     var _1 = sp_navs.Children[currplayIndex.ToInt()];
                     var _2 = _1 as RadioButton;
                     _2.IsChecked = true;
                 }
                 else
                 {
                     currplayIndex++;
                     var _1 = sp_navs.Children[currplayIndex.ToInt()];
                     var _2 = _1 as RadioButton;
                     _2.IsChecked = true;

                 }
             });

        }

        private void Rb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (autoPlay.IsNotNull())
                autoPlay.Stop();
        }

        private void Rb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (autoPlay.IsNotNull())
                autoPlay.Start();
        }

        AyAniDouble ad = null;
        PropertyPath pp = new PropertyPath("(Canvas.Left)");
        private void Rb_Checked(object sender, RoutedEventArgs e)
        {
            if (isfirst)
            {
                RadioButton rb = sender as RadioButton;
                currplayIndex = rb.Tag.ToDouble();
                double targetCanvasLeft = (currplayIndex * (-1) * LeftWidth);
                ad.FromDouble = Canvas.GetLeft(prev);
                ad.ToDouble = targetCanvasLeft;
                ad.AniPropertyPath = pp;
                ad.AnimateSpeed = 200;
                ad.AniEasingMode = 1;
                ad.Animate().End();

            }

        }
    }
}
