using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOLSkinGetter.Models
{
    public class HomeModel : AyPropertyChanged
    {
        private string _Account;

        /// <summary>
        /// 未填写
        /// </summary>
        public string Account
        {
            get { return _Account; }
            set { Set(ref _Account, value); }
        }

        private string _GameArea;

        /// <summary>
        /// 未填写
        /// </summary>
        public string GameArea
        {
            get { return _GameArea; }
            set { Set(ref _GameArea, value); }
        }


        private int _Zuan=0;

        /// <summary>
        /// 未填写
        /// </summary>
        public int Zuan
        {
            get { return _Zuan; }
            set { Set(ref _Zuan, value); }
        }


        private int _Putong;

        /// <summary>
        /// 普通水晶
        /// </summary>
        public int Putong
        {
            get { return _Putong; }
            set { Set(ref _Putong, value); }
        }

        private int _CuiCan;

        /// <summary>
        /// 璀璨水晶
        /// </summary>
        public int CuiCan
        {
            get { return _CuiCan; }
            set { Set(ref _CuiCan, value); }
        }




    }
}
