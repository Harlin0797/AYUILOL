using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using Ay.Framework.WPF.Controls;
using Ay.Framework.WPF.MVC.AyMarkupExtension;
using LOLSkinGetter.Controllers;
using LOLSkinGetter.DAL;
using Newtonsoft.Json;

namespace LOLSkinGetter.Views.Home
{
    /// <summary>
    /// HomeView.xaml 的交互逻辑
    /// </summary>
    public partial class HomeView : AyPage
    {

        public HomeView()
        {
            InitializeComponent();

            Loaded += HomeView_Loaded;


        }

        public HomeController Controller
        {
            get
            {
                return this.DataContext as HomeController;
            }
        }

        int startNum = 19;
        int dirNum = 19;
        AyTimeEx at = null;
        private void HomeView_Loaded(object sender, RoutedEventArgs e)
        {
            at = new AyTimeEx(1000, (t) =>
           {
               tbRefreshZuan.IsEnabled = false;
               tbRefreshZuan.Text = "{0}秒后再次可用".StringFormat((dirNum--).ToString());
               if (dirNum == 16)
               {
                   Controller.Model.Zuan = 100000;
               }
           }, startNum, () =>
           {
               tbRefreshZuan.Text = "点击刷新";
               tbRefreshZuan.IsEnabled = true;
           });

            if (svToolBox.IsNotNull())
            {
                this.PreviewMouseWheel += (sender2, arge) =>
                {
                    svToolBox.ScrollToVerticalOffset(svToolBox.VerticalOffset - arge.Delta / 2);
                    arge.Handled = true;
                };
            }


            //Console.WriteLine("");







        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            e.Handled = true;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StartRefreshZuan();
        }

        private void StartRefreshZuan()
        {
            dirNum = startNum;
            at.Start();
        }

        private void TextBlock_TouchDown(object sender, TouchEventArgs e)
        {
            StartRefreshZuan();
        }

        private void btnStep1_Click(object sender, RoutedEventArgs e)
        {
            AyTextButton atbtn = sender as AyTextButton;
            if (atbtn.IsNotNull())
            {
                int _1 = atbtn.Tag.ToInt();
                switch (_1)
                {
                    case 1:
                        svToolBox.ScrollToPosition(0, 882);
                        break;
                    case 2:
                        svToolBox.ScrollToPosition(0, 1425);
                        break;
                    case 3:
                        svToolBox.ScrollToPosition(0, 2025);
                        break;
                    case 4:
                        svToolBox.ScrollToPosition(0, 2902);
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:
                        Process.Start("http://kf.qq.com/faq/1205187FbI3Q160523ANJBNb.html");
                        break;
                    default:
                        break;
                }
            }

        }

        private void btnUseTen10_Click(object sender, RoutedEventArgs e)
        {
            md_zuanxiaofei.Message = "赠送星光水晶中，请稍后";
            md_zuanxiaofei.Visibility = Visibility.Visible;
            var _122 = AyCommon.Rnd.Next(1,300);
            AyTime.setTimeout(_122, () =>
            {
                md_zuanxiaofei.Visibility = Visibility.Collapsed;
                //检查钻石
                bool hasZuan = true;

                //开始抽奖
                if (hasZuan)
                {
                    sgc.JiangPin= CreateGiftResult();
                    //TODO同步数据到本地

                    //展示
                    sgc.TitleBar = "璀璨星光水晶";
                    sgc.Visibility = Visibility.Visible;
                    
                }
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ty">2 shi 10    1 shi 5</param>
        /// <returns></returns>
        public List<SkinGetterModel> CreateGiftResult(int ty = 2)
        {
            List<SkinGetterModel> sms = new List<SkinGetterModel>();
            var dt = DateTime.Now;
            if (ty == 2)
            {
                int _1 = Global.DatasTitle.Count;
                for (int i = 0; i < 10; i++)
                {
                    SkinGetterModel sm = new SkinGetterModel();
                    sm.CardExpire = AyCommon.Rnd.NextBool() ? "7天" : "";
                    var _2 = Math.Round(AyCommon.Rnd.NextDouble(10000, 1000000),0);
                    var _3 = _2 % _1;
                    sm.ID = Global.DatasTitle.Keys.ElementAt(_3.ToInt());
                    sm.Title = Global.DatasTitle[sm.ID];
                    sm.CardType = (sm.ID.ToInt() < 1000) ? 1 : 2;
                    sm.CardStatus = 0;
                    sm.CardPlace = "";
                    sm.CreateTime = dt;
                    sm.GID = AyCommon.GetGuid;
                    sms.Add(sm);
                }
                //特别，必定永久
                //1-134 为英雄
                var _12 = AyCommon.Rnd.Next(1, 100);
                if (_12 % 20 == 0)
                {
                    //英雄
                    SkinGetterModel sm = new SkinGetterModel();
                    int _4 = 0;
                    do
                    {
                        var _2 = Math.Round(AyCommon.Rnd.NextDouble(10000, 1000000));
                        var _3 = _2 % _1;
                        _4 = _3.ToInt();
                    } while (_4 > 135);

                    sm.ID = Global.DatasTitle.Keys.ElementAt(_4);
                    sm.Title = Global.DatasTitle[sm.ID];
                    sm.CardType = (sm.ID.ToInt() < 1000) ? 1 : 2;
                    sm.CardStatus = 0;
                    sm.CardPlace = "";
                    sm.CreateTime = dt;
                    sm.GID = AyCommon.GetGuid;
                    sms.Add(sm);
                }
                else
                {
                    SkinGetterModel sm = new SkinGetterModel();
                    int _4 = 0;
                    do
                    {
                        var _2 = Math.Round(AyCommon.Rnd.NextDouble(10000, 1000000),0);
                        var _3 = _2 % _1;
                        _4 = _3.ToInt();
                    } while (_4 < 135);
                    sm.ID = Global.DatasTitle.Keys.ElementAt(_4);
                    sm.Title = Global.DatasTitle[sm.ID];
                    sm.CardType = (sm.ID.ToInt() < 1000) ? 1 : 2;
                    sm.CardStatus = 0;
       
                    sm.CardPlace = "";
                    sm.CreateTime = dt;
                    sm.GID = AyCommon.GetGuid;
                    sms.Add(sm);
                }
            }
            return sms;


        }

        private void btnUseTen5_Click(object sender, RoutedEventArgs e)
        {

        }
    }




}
