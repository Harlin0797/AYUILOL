using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ay.Framework.WPF.Controls;
using LOLSkinGetter.Models;
using Ay.Framework.WPF.Shared;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.Net;
using System.IO;

namespace LOLSkinGetter.Controllers
{
    public class HomeController : AyPropertyChanged
    {
        IAyConfigManager gameConfig = null;
        public HomeModel Model { get; set; }

        public ObservableCollection<SkinGetterModel> ShenMi { get; set; }
        public ObservableCollection<SkinGetterModel> PuTong { get; set; }
        public ObservableCollection<SkinGetterModel> CuiCan { get; set; }
        public ObservableCollection<SkinGetterModel> HeBing { get; set; }
        public HomeController()
        {
            Model = new HomeModel();
            gameConfig = ConfigManagerFactory.Create(ManagerFile.GameConfig);
            var _1 = gameConfig["GameArea"];
            Model.GameArea = gameConfig["GameArea"];
            Model.Account = gameConfig["Account"];
            Model.Putong = gameConfig["PuTong"].ToInt();
            Model.CuiCan = gameConfig["CuiCan"].ToInt();

            //var _2 = Global.DatasTitle;
            //foreach (var item in _2)
            //{
            //    try
            //    {
            //        string url = "http://ossweb-img.qq.com/images/lol/appskin/{0}.jpg";
            //        string filename = null;
            //        if (item.Key.ToInt() < 1000)
            //        {
            //            filename = item.Key + "000";
            //            url = string.Format(url, filename);
            //        }
            //        else
            //        {
            //            filename = item.Key;
            //            url = string.Format(url, item.Key);
            //        }
            //        filename = filename + ".jpg";
            //        var webRequest = WebRequest.Create(url) as HttpWebRequest;
            //        webRequest.ProtocolVersion = HttpVersion.Version10;
            //        using (var webResponse = webRequest.GetResponse())
            //        {
            //            using (var responseSteam = webResponse.GetResponseStream())
            //            {
            //                using (var fs = new FileStream("F:\\1\\" + filename, FileMode.Create))
            //                {
            //                    responseSteam.CopyTo(fs);
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(item.Key);
            //    }
            //}
            //Console.WriteLine("下载完成！");
            CreateCardGetterData("shenmi");
            CreateCardGetterData("putong");
            CreateCardGetterData("CuiCan");
        }

        private void CreateCardGetterData(string type)
        {
            XElement xe = XElement.Load(Global.LOLGameConfig);
            var elements = from xml in xe.Elements(type).Elements("item")
                           select new SkinGetterModel
                           {
                               ID = xml.Attribute("id").Value,
                               CardExpire = xml.Attribute("cexpire").Value,
                               CardPlace = xml.Attribute("cplace").Value,
                               CardStatus = xml.Attribute("cstatus").Value.ToInt(),
                               CreateTime = xml.Attribute("ctime").Value.ToDateTime()
                           };
            var _31 = elements.ToList();
            foreach (var item in _31)
            {
                if (Global.DatasTitle.Keys.Contains(item.ID))
                {
                    item.Title = Global.DatasTitle[item.ID];
                    if (item.ID.ToInt() < 1000)
                    {
                        item.CardType = 1;
                    }
                    else
                    {
                        item.CardType = 2;
                    }
                }
                if (Global.DatasLight.Keys.Contains(item.ID))
                {
                    var _2 = Global.DatasLight[item.ID];
                    item.IsLight = _2.Equals("1") ? true : false;
               
                }
                else
                {
                    item.IsLight = false;
                }
            }
            if (_31.Count() > 0)
            {
                if (type == "shenmi")
                {
                    ShenMi = new ObservableCollection<SkinGetterModel>(_31);
                }
                else if (type == "putong")
                {
                    PuTong = new ObservableCollection<SkinGetterModel>(_31);
                }
                else
                if (type == "CuiCan")
                {
                    CuiCan = new ObservableCollection<SkinGetterModel>(_31);
                }

            }
            else
            {
                if (type == "shenmi")
                {
                    ShenMi = new ObservableCollection<SkinGetterModel>();
                }
                else if (type == "putong")
                {
                    PuTong = new ObservableCollection<SkinGetterModel>();
                }
                else
                if (type == "CuiCan")
                {
                    CuiCan = new ObservableCollection<SkinGetterModel>();
                }
            }
        }

    }
}
