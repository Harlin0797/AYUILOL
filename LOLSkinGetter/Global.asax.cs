using System.Windows;
using Ay.Framework.WPF.MVC;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using LOLSkinGetter.DAL;

namespace LOLSkinGetter
{
    public class Global : AYUIGlobal
    {
        public static string LOLGameConfig
        {
            get
            {
                return AyuiConfig.BaseDirectory + @"contents\Config\GameConfig.xml";
            }
        }

        public static string LOLTitleDatas
        {
            get
            {
                return AyuiConfig.BaseDirectory + @"contents\appgames\games\RALFSHEN_HEROSKIN.js";
            }
        }
        public static string ISLIGHT
        {
            get
            {
                return AyuiConfig.BaseDirectory + @"contents\appgames\games\ISLIGHT.js";
            }
        }


        public static Dictionary<string, string> _DatasTitle;
        public static Dictionary<string, string> DatasTitle
        {
            get
            {
                if (_DatasTitle == null)
                {
                    _DatasTitle = JsonConvert.DeserializeObject<Dictionary<string, string>>(FileHelper.Read(LOLTitleDatas));
                }
                return _DatasTitle;
            }
        }
        public static Dictionary<string, string> _DatasLight;
        public static Dictionary<string, string> DatasLight
        {
            get
            {
                if (_DatasLight == null)
                {
                    _DatasLight = JsonConvert.DeserializeObject<Dictionary<string, string>>(FileHelper.Read(ISLIGHT));
                }
                return _DatasLight;
            }
        }

        public override void Application_Start(StartupEventArgs e, Application appliation)
        {
            appliation.AddExceptionSimply();
        }
        public override void RegisterResourceDictionary(ClientResourceDictionaryCollection resources)
        {
            resources.Add(AyExtension.CreateResourceDictionary("Contents/Styles/AYUIProjectDictionary.xaml"));
        }


    }

}

