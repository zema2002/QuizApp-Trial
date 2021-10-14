using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class ChkDataModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool selected { get; set; }
        public List<checkListModel> lstCheck { get; set; }
    }

    public class checkListModel { 
        public int ID { get; set; }
        public string Name { get; set; }
        public bool selected { get; set; }
    }
}