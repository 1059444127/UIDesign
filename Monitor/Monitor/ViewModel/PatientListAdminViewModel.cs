using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Monitor.PA;

namespace Monitor.ViewModel
{
    public class PatientListAdminViewModel:BasicModel
    {
        public ObservableCollection<PatitentModel> PatientList { get; set; } 

        public PatientListAdminViewModel()
        {
            PatientList = new ObservableCollection<PatitentModel>();
            var item = new PatitentModel();
            item.Age = "25";
            item.Birthday = "2014";
            item.Data = "2012";
            item.Gender = "Male";
            item.PID = "222";
            item.PatientID = "333";
            item.InitStudyList();
            PatientList.Add(item);

            item = new PatitentModel();
            item.Age = "28";
            item.Birthday = "2017";
            item.Data = "2013";
            item.Gender = "All";
            item.PID = "12";
            item.PatientID = "444";
            PatientList.Add(item);

            item = new PatitentModel();
            item.Age = "25";
            item.Birthday = "2014";
            item.Data = "2002";
            item.Gender = "Other";
            item.PID = "12";
            item.PatientID = "55";
            item.InitStudyList();
            PatientList.Add(item);

            item = new PatitentModel();
            item.Age = "24";
            item.Birthday = "2015";
            item.Data = "2011";
            item.Gender = "All";
            item.PID = "12";
            item.PatientID = "444";
            PatientList.Add(item);
        }


    }
}
