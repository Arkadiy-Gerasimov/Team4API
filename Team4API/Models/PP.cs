using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Team4API.Models
{
    public class PP
    {
        public long _inventory_number { get; set; }
        public string _serial_number { get; set; }
        public int _number_act { get; set; }
        public string _specifications { get; set; }
        public int _ID_responsible_persons { get; set; }
        public int _ID_status { get; set; }
        public PP(Product_map pm)
        {
            _inventory_number = pm.inventory_number;
            _serial_number = pm.serial_number;
            _number_act = pm.number_act;
            _specifications = pm.specifications;
            _ID_responsible_persons = pm.ID_responsible_persons;
            _ID_status = pm.ID_status;
        }
    }
}