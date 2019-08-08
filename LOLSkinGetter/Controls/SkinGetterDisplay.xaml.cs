using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// SkinGetterDisplay.xaml 的交互逻辑
    /// </summary>
    public partial class SkinGetterDisplay : UserControl
    {
        public SkinGetterDisplay()
        {
            InitializeComponent();
            Loaded += SkinGetterDisplay_Loaded;
        }

        private void SkinGetterDisplay_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= SkinGetterDisplay_Loaded;
            CurrentPageIndex = 1;
            SelectFreshData();
            RefreshNavButtonVisibility();
        }
        const int pagesize = 6;
        private void SelectFreshData()
        {
            var _1 = AllSources as ObservableCollection<SkinGetterModel>;
            if (_1.IsNotNull())
            {
                //排序
                var _2 = from m in _1
                         orderby m.CardStatus descending, m.CreateTime descending
                         select m;
                //分页
                int t = CurrentPageIndex - 1;
                var _3 = _2.Skip((t*pagesize)).Take(pagesize);
                if (DisplaySource.IsNotNull())
                {
                    DisplaySource = null;
                }
                DisplaySource = new ObservableCollection<SkinGetterModel>(_3);
                AllPageTotal = (_1.Count() / pagesize) + 1;
            }
        }

        public string Left1
        {
            get { return (string)GetValue(Left1Property); }
            set { SetValue(Left1Property, value); }
        }

        // Using a DependencyProperty as the backing store for Left1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Left1Property =
            DependencyProperty.Register("Left1", typeof(string), typeof(SkinGetterDisplay), new PropertyMetadata(""));





        public string Left2
        {
            get { return (string)GetValue(Left2Property); }
            set { SetValue(Left2Property, value); }
        }

        // Using a DependencyProperty as the backing store for Left2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Left2Property =
            DependencyProperty.Register("Left2", typeof(string), typeof(SkinGetterDisplay), new PropertyMetadata(""));





        public int CurrentPageIndex
        {
            get { return (int)GetValue(CurrentPageIndexProperty); }
            set { SetValue(CurrentPageIndexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPageIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageIndexProperty =
            DependencyProperty.Register("CurrentPageIndex", typeof(int), typeof(SkinGetterDisplay), new PropertyMetadata(0));




        public int AllPageTotal
        {
            get { return (int)GetValue(AllPageTotalProperty); }
            set { SetValue(AllPageTotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AllPageTotal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AllPageTotalProperty =
            DependencyProperty.Register("AllPageTotal", typeof(int), typeof(SkinGetterDisplay), new PropertyMetadata(0));




        public IEnumerable DisplaySource
        {
            get { return (IEnumerable)GetValue(DisplaySourceProperty); }
            set { SetValue(DisplaySourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplaySource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplaySourceProperty =
            DependencyProperty.Register("DisplaySource", typeof(IEnumerable), typeof(SkinGetterDisplay), new PropertyMetadata(null));



        public IEnumerable AllSources
        {
            get { return (IEnumerable)GetValue(AllSourcesProperty); }
            set { SetValue(AllSourcesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AllSources.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AllSourcesProperty =
            DependencyProperty.Register("AllSources", typeof(IEnumerable), typeof(SkinGetterDisplay), new PropertyMetadata(null));





        private void rightOpr_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CurrentPageIndex == AllPageTotal)
            {
                return;
            }
            CurrentPageIndex++;
            //下一页
            //排序
            //创建数据源到DisplaySource
            //显示该页的 数据
            SelectFreshData();
            RefreshNavButtonVisibility();
        }
        public void RefreshNavButtonVisibility()
        {
            if (CurrentPageIndex == 0 && AllPageTotal == 0)
            {
                leftOpr.Visibility = Visibility.Collapsed;
                rightOpr.Visibility = Visibility.Collapsed;
                sp_pagination.Visibility = Visibility.Collapsed;
                return;
            }
            if (CurrentPageIndex == 1)
            {
                leftOpr.Visibility = Visibility.Collapsed;
            }

            if (CurrentPageIndex < AllPageTotal)
            {
                rightOpr.Visibility = Visibility.Visible;
            }

            if (CurrentPageIndex != 1 && CurrentPageIndex <= AllPageTotal)
            {
                leftOpr.Visibility = Visibility.Visible;
            }

            if (CurrentPageIndex == AllPageTotal)
            {
                rightOpr.Visibility = Visibility.Collapsed;
            }
        }


        private void leftOpr_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (CurrentPageIndex == 1)
            {
                return;
            }
            CurrentPageIndex--;
            //上一页
            //排序
            //创建数据源到DisplaySource
            //显示该页的 数据
            SelectFreshData();

            RefreshNavButtonVisibility();
        }

    }
}
