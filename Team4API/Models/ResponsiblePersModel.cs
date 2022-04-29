using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team4API.Models
{
    public class ResponsiblePersModel
    {
        public int _ID_responsible_persons { get; set; }
        public string _FIO { get; set; }       
        public int _ID_company { get; set; }
        public int _ID_division { get; set; }
        public ResponsiblePersModel(Responsible_persons pm)
        {
            _ID_responsible_persons = pm.ID_responsible_persons;
            _FIO = pm.FIO;
            _ID_company = Convert.ToInt32(pm.ID_company);
            _ID_division = Convert.ToInt32(pm.ID_division);
           
        }
    }
}