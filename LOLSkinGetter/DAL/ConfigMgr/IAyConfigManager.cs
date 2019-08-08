using System;
using System.Collections.Generic;
using System.Text;

namespace LOLSkinGetter
{
    public interface IAyConfigManager
    {
        string this[string key] { get; set; }
        string XmlFilePath { get; set; }
        string GetValue(string key);
        void SetValue(string key, string value);
    }
}
