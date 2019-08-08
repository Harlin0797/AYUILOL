using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOLSkinGetter.Models
{
    public class ViewStartModel : AyPropertyChanged
    {
        private string _TextBoxStatus;

        /// <summary>
        /// 文本框状态，只为绑定ViewStart页面的文本框控件
        /// </summary>
        public string TextBoxStatus
        {
            get { return _TextBoxStatus; }
            set { Set(ref _TextBoxStatus, value); }
        }
    }
}
