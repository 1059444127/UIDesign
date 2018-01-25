using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Monitor.ViewModel
{
    public class PatitentModel :BasicModel
    {

        public ObservableCollection<PatientItem> StudyList { get; set; } 

        public PatitentModel()
        {
            StudyList = new ObservableCollection<PatientItem>();
        }

        public void InitStudyList()
        {
            var item = new PatientItem();
            item.ItemId = "United";
            item.ItemGender = "Male";
            item.ItemData = "2017";
            item.ItemBirthday = "2017";
            item.ImagePID = "1111";
            item.ImageAge = "20";
            StudyList.Add(item);

            item = new PatientItem();
            item.ItemId = "United";
            item.ItemGender = "Female";
            item.ItemData = "2016";
            item.ItemBirthday = "2016";
            item.ImagePID = "22";
            item.ImageAge = "25";
            StudyList.Add(item);

            item = new PatientItem();
            item.ItemId = "United";
            item.ItemGender = "All";
            item.ItemData = "2016";
            item.ItemBirthday = "2016";
            item.ImagePID = "22";
            item.ImageAge = "25";
            StudyList.Add(item);

            item = new PatientItem();
            item.ItemId = "United";
            item.ItemGender = "Other";
            item.ItemData = "2015";
            item.ItemBirthday = "2015";
            item.ImagePID = "22";
            item.ImageAge = "25";
            StudyList.Add(item);
        }


        private string _patientID = string.Empty;
        public string PatientID
        {
            get { return _patientID; }
            set
            {
                _patientID = value;
                OnPropertyChanged("PatientID");
            }
        }

        private string _gender = string.Empty;
        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged("Gender");
            }
        }

        private string _age;
        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        private string _pid;
        public string PID
        {
            get { return _pid; }
            set
            {
                _pid = value;
                OnPropertyChanged("PID");
            }
        }

        private string _data;
        public string Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }

        private string _birthday;
        public string Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
    }
}
