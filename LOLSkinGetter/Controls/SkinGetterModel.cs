using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOLSkinGetter
{
    public class SkinGetterModel:AyPropertyChanged
    {
        private string _GID;

        /// <summary>
        /// 唯一ID
        /// </summary>
        public string GID
        {
            get { return _GID; }
            set { Set(ref _GID, value); }
        }

        private string _ID;

        /// <summary>
        /// 未填写
        /// </summary>
        public string ID
        {
            get { return _ID; }
            set { Set(ref _ID, value); }
        }
        private string _Title;

        /// <summary>
        /// 未填写
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { Set(ref _Title, value); }
        }

        private bool _IsLight;

        /// <summary>
        /// 未填写
        /// </summary>
        public bool IsLight
        {
            get { return _IsLight; }
            set { Set(ref _IsLight, value); }
        }

        private int _CardType;

        /// <summary>
        /// 未填写
        /// </summary>
        public int CardType
        {
            get { return _CardType; }
            set { Set(ref _CardType, value); }
        }

        private int _CardStatus;

        /// <summary>
        /// 0未领取  1已经领取
        /// </summary>
        public int CardStatus
        {
            get { return _CardStatus; }
            set { Set(ref _CardStatus, value); }
        }

        private string _CardExpire;

        /// <summary>
        /// 未填写
        /// </summary>
        public string CardExpire
        {
            get { return _CardExpire; }
            set { Set(ref _CardExpire, value); }
        }

        private string _CardPlace;

        /// <summary>
        /// 未填写
        /// </summary>
        public string CardPlace
        {
            get { return _CardPlace; }
            set { Set(ref _CardPlace, value); }
        }

        private DateTime _CreateTime;

        /// <summary>
        /// 未填写
        /// </summary>
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set { Set(ref _CreateTime, value); }
        }


    }
}
