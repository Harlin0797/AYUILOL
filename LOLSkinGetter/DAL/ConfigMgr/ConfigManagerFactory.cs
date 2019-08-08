using System;
using System.Collections.Generic;
using System.Text;

namespace LOLSkinGetter
{

    public class ConfigManagerFactory
    {
        public static IAyConfigManager Create(ManagerFile managerFile)
        {
            switch (managerFile)
            {
                case ManagerFile.GameConfig:
                    return new GameConfigFile(System.AppDomain.CurrentDomain.BaseDirectory + @"Contents\Config\GameConfig.xml");
                //case ManagerFile.ServiceConfig:
                //    return new ServiceConfigFile(System.AppDomain.CurrentDomain.BaseDirectory + @"Contents\Config\ServiceConfig.xml");
            }
            return null;
        }
    }

    public enum ManagerFile
    {
        GameConfig
    }

}
