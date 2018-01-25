using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.ViewModel
{
    public class PatientItem :BasicModel
    {

        private string _itemId;
        public string ItemId
        {
            get { return _itemId; }
            set
            {
                _itemId = value;
                OnPropertyChanged("ItemId");
            }
        }

        private string _itemData;
        public string ItemData
        {
            get { return _itemData; }
            set
            {
                _itemData = value;
                OnPropertyChanged("ItemData");
            }
        }

        private string _itemGender;
        public string ItemGender
        {
            get { return _itemGender; }
            set
            {
                _itemGender = value;
                OnPropertyChanged("ItemGender");
            }
        }

        private string _itemBirthday;
        public string ItemBirthday
        {
            get { return _itemBirthday; }
            set
            {
                _itemBirthday = value;
                OnPropertyChanged("ItemBirthday");
            }
        }

        private string _imageAge;
        public string ImageAge
        {
            get { return _imageAge; }
            set
            {
                _imageAge = value;
                OnPropertyChanged("ImageAge");
            }
        }

        private string _imagepid;
        public string ImagePID
        {
            get { return _imagepid; }
            set
            {
                _imagepid = value;
                OnPropertyChanged("ImagePID");
            }
        }
    }
}
