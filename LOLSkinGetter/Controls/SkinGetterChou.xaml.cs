using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ay.Framework.WPF.AyAnimate;

namespace LOLSkinGetter
{
    /// <summary>
    /// SkinGetterChou.xaml 的交互逻辑
    /// </summary>
    public partial class SkinGetterChou : UserControl
    {
        public SkinGetterChou()
        {
            InitializeComponent();
            Loaded += SkinGetterChou_Loaded;
        }

        private void SkinGetterChou_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= SkinGetterChou_Loaded;
            this.IsVisibleChanged += SkinGetterChou_IsVisibleChanged;
        }

        private void SkinGetterChou_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (((bool)e.NewValue))
            {
                ug.Children.Clear();
                CardImageConverter cic = new CardImageConverter();
                var _1 = JiangPin as List<SkinGetterModel>;
                int ind = 0;
                for (int j = 0; j < 2; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SkinGetterViewBox2 s1 = new SkinGetterViewBox2();
                        s1.HorizontalAlignment = HorizontalAlignment.Center;
                        s1.VerticalAlignment = VerticalAlignment.Center;
                        s1.CardTitle = _1[ind].Title;
                        s1.CardType = _1[ind].CardType;
                        s1.CardExpire = _1[ind].CardExpire;
                        s1.Visibility = Visibility.Collapsed;
                        if (_1[ind].ID.ToInt() >= 1000)
                        {
                            if (Global.DatasLight[_1[ind].ID] == "1")
                            {
                                s1.HasXianDing = true;
                            }
                        }

                        s1.CurrentImage = cic.Convert(_1[ind].ID, null, null, null) as BitmapImage;
                        ind++;
                        Grid.SetColumn(s1, i);
                        Grid.SetRow(s1, j);
                        ug.Children.Add(s1);
                    }

                }
                ugEx.CardType = _1[10].CardType;
                ugEx.CardTitle = _1[10].Title;
                ugEx.CurrentImage = cic.Convert(_1[10].ID, null, null, null) as BitmapImage;
                ugEx.CardShowTitle = (ugEx.CardType == 1 ? "英雄" : "皮肤") + " " + ugEx.CardTitle;
                //动画出现
                ugEx.Visibility = Visibility.Collapsed;
                //启动动画
                AnimateShowCard();
            }
            else
            {
                ClearResult();
            }
        }

        PropertyPath pp = new PropertyPath("(UIElement.Opacity)");
        //IEasingFunction d2 = new System.Windows.Media.Animation.CircleEase { EasingMode = EasingMode.EaseOut };
        public void AnimateShowCard()
        {
            List<AyAniDouble> anis = new List<AyAniDouble>();
            //ug.Children;
            foreach (var item in ug.Children)
            {
                AyAniDouble ad = new AyAniDouble(item as SkinGetterViewBox2);
                ad.FromDouble = 0;
                ad.ToDouble = 1;
                ad.AniPropertyPath = pp;
                ad.AnimateSpeed = 200;
                ad.AniEasingMode = 1;
                anis.Add(ad);
            }
            if (ug.Children.Count > 0)
            {
                anis[0].Animate().End();
            }
            int diz = 500;
            int first = 500;

            AyTime.setTimeout(first, () =>
             {
                 if (ug.Children.Count > 0)
                 {
                     anis[1].Animate().End();
                 }

             });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[2].Animate().End();
                }
            });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[3].Animate().End();
                }
            });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[4].Animate().End();
                }
            });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[5].Animate().End();
                }
            });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[6].Animate().End();
                }
            });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[7].Animate().End();
                }
            });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[8].Animate().End();
                }
            });
            first = first + diz;
            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    anis[9].Animate().End();
                }
            });
            first = first + diz;

            var bn = new AyAniSlideInLeft(ugEx, () =>
            {

            });
            bn.FromDistance = -192;
            bn.OpacityNeed = false;
            bn.AnimateSpeed = 200;

            AyTime.setTimeout(first, () =>
            {
                if (ug.Children.Count > 0)
                {
                    bn.Animate().End();
                }
            });


        }
        public double MWidth
        {
            get { return (double)GetValue(MWidthProperty); }
            set { SetValue(MWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MWidthProperty =
            DependencyProperty.Register("MWidth", typeof(double), typeof(SkinGetterChou), new PropertyMetadata(970.0));



        public double MHeight
        {
            get { return (double)GetValue(MHeightProperty); }
            set { SetValue(MHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MHeightProperty =
            DependencyProperty.Register("MHeight", typeof(double), typeof(SkinGetterChou), new PropertyMetadata(578.0));



        public string TitleBar
        {
            get { return (string)GetValue(TitleBarProperty); }
            set { SetValue(TitleBarProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleBar.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleBarProperty =
            DependencyProperty.Register("TitleBar", typeof(string), typeof(SkinGetterChou), new PropertyMetadata("璀璨星光水晶"));



        public IEnumerable JiangPin
        {
            get { return (IEnumerable)GetValue(JiangPinProperty); }
            set { SetValue(JiangPinProperty, value); }
        }

        // Using a DependencyProperty as the backing store for JiangPin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty JiangPinProperty =
            DependencyProperty.Register("JiangPin", typeof(IEnumerable), typeof(SkinGetterChou), new PropertyMetadata(null));


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClearResult();
        }

        private void ClearResult()
        {
            this.Visibility = Visibility.Collapsed;
            ug.Children.Clear();
            ugEx.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_TouchDown(object sender, TouchEventArgs e)
        {
            ClearResult();
        }

        private void AyImageButton_Click(object sender, RoutedEventArgs e)
        {
            ClearResult();
        }
    }
}
