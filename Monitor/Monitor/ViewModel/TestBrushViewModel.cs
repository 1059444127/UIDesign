using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace Monitor.ViewModel
{
    public class TestBrushViewModel : BasicModel
    {
        private string _dataText;
        public string DataText
        {
            get { return _dataText; }
            set
            {
                _dataText = value;
                OnPropertyChanged("DataText");
            }
        }

        private string _number;
        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged("Number");
            }
        }

        private Visibility _visibility;
        public Visibility GridVisibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                OnPropertyChanged("GridVisibility");
            }
        }

        private Visibility _groupBoxvisibility;
        public Visibility GroupBoxVisibility
        {
            get { return _groupBoxvisibility; }
            set
            {
                _groupBoxvisibility = value;
                OnPropertyChanged("GroupBoxVisibility");
            }
        }

        public ObservableCollection<BrowserImageItem> BrowserImageCollection { get; set; }

        public ObservableCollection<BrowserImageItem> RefImageList { get; set; }

        public ObservableCollection<BrowserImageItem> ImagesList { get; set; }

        public TestBrushViewModel()
        {
            BrowserImageCollection = new ObservableCollection<BrowserImageItem>();
            RefImageList = new ObservableCollection<BrowserImageItem>();
            ImagesList = new ObservableCollection<BrowserImageItem>();

            GridVisibility = Visibility.Visible;
            GroupBoxVisibility = Visibility.Visible;
            DataText = "2017/08/23";
            Number = "22";

            var browserItemA = new BrowserImageItem();
            browserItemA.GroupBoxVisibility = Visibility.Visible;
            browserItemA.AddImageItems();
            browserItemA.AddReferenceImageItem();
            browserItemA.DataText = "2017/08/23";
            browserItemA.Number = "12";
            BrowserImageCollection.Add(browserItemA);
            RefImageList.Add(browserItemA);
            ImagesList.Add(browserItemA);

            var browserItemB = new BrowserImageItem();
            browserItemB.GroupBoxVisibility = Visibility.Visible;
            browserItemB.AddImageItems();
            browserItemB.AddReferenceImageItem();
            browserItemB.DataText = "2017/08/28";
            browserItemB.Number = "15";
            BrowserImageCollection.Add(browserItemB);
            RefImageList.Add(browserItemB);
            ImagesList.Add(browserItemB);

            var browserItemC = new BrowserImageItem();
            browserItemC.GroupBoxVisibility = Visibility.Collapsed;
            browserItemC.AddImageItems();
            browserItemC.AddReferenceImageItem();
            browserItemC.DataText = "2017/07/23";
            browserItemC.Number = "9";
            BrowserImageCollection.Add(browserItemC);
            RefImageList.Add(browserItemC);
            ImagesList.Add(browserItemC);

            var browserItemD = new BrowserImageItem();
            browserItemD.GroupBoxVisibility = Visibility.Collapsed;
            browserItemD.AddImageItems();
            browserItemD.AddReferenceImageItem();
            browserItemD.DataText = "2017/08/22";
            browserItemD.Number = "10";
            BrowserImageCollection.Add(browserItemD);
            RefImageList.Add(browserItemD);
            ImagesList.Add(browserItemD);
        }
    }
}
