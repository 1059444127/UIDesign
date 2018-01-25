using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using Monitor.windows;

namespace Monitor.ViewModel
{
    public class BrowserImageItem : BasicModel
    {
        public ObservableCollection<ItemImage> ReferenceImageList { get; set; }
        public ObservableCollection<ItemImage> AllImageList { get; set; }

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
        public Visibility GroupBoxVisibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                OnPropertyChanged("GroupBoxVisibility");
            }
        }

        public void AddImageItems()
        {
            AllImageList = new ObservableCollection<ItemImage>();
            var allImageA = new ItemImage();
            allImageA.Visibility = Visibility.Collapsed;
            allImageA.Name = "A";
            allImageA.StudyID = "2017";
            allImageA.Type = "DR";
            AllImageList.Add(allImageA);

            var allImageB = new ItemImage();
            allImageB.Visibility = Visibility.Collapsed;
            allImageB.Name = "B";
            allImageB.StudyID = "2017";
            allImageB.Type = "DR";
            AllImageList.Add(allImageB);

            var allImageC = new ItemImage();
            allImageC.Visibility = Visibility.Collapsed;
            allImageC.Name = "C";
            allImageC.StudyID = "2017";
            allImageC.Type = "DR";
            AllImageList.Add(allImageC);

            var allImageD = new ItemImage();
            allImageD.Visibility = Visibility.Visible;
            allImageD.Name = "D";
            allImageD.StudyID = "2017";
            allImageD.Type = "DR";
            AllImageList.Add(allImageD);

            var allImageE = new ItemImage();
            allImageE.Visibility = Visibility.Collapsed;
            allImageE.Name = "A";
            allImageE.StudyID = "2017";
            allImageE.Type = "DR";
            AllImageList.Add(allImageE);

            var allImageF = new ItemImage();
            allImageF.Visibility = Visibility.Collapsed;
            allImageF.Name = "B";
            allImageF.StudyID = "2017";
            allImageF.Type = "DR";
            AllImageList.Add(allImageF);

            var allImageG = new ItemImage();
            allImageG.Visibility = Visibility.Collapsed;
            allImageG.Name = "C";
            allImageG.StudyID = "2017";
            allImageG.Type = "DR";
            AllImageList.Add(allImageG);
        }

        public void AddReferenceImageItem()
        {
            ReferenceImageList = new ObservableCollection<ItemImage>();
            var referenceImageA = new ItemImage();
            referenceImageA.Visibility = Visibility.Visible;
            referenceImageA.Name = "A";
            referenceImageA.StudyID = "2017";
            referenceImageA.Type = "DR";
            ReferenceImageList.Add(referenceImageA);

            var referenceImageB = new ItemImage();
            referenceImageB.Visibility = Visibility.Visible;
            referenceImageB.Name = "B";
            referenceImageB.StudyID = "2017";
            referenceImageB.Type = "DR";
            ReferenceImageList.Add(referenceImageB);

            var referenceImageC = new ItemImage();
            referenceImageC.Visibility = Visibility.Visible;
            referenceImageC.Name = "B";
            referenceImageC.StudyID = "2017";
            referenceImageC.Type = "DR";
            ReferenceImageList.Add(referenceImageC);
        }
    }
}
