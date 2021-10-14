using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication2.DataBase
{
    public class Question {
        public int ID { get; set; }
        public string Name_Quest { get; set; }
        public string Var_Answ1 { get; set; }
        public string Var_Answ2 { get; set; }
        public string Var_Answ3 { get; set; }
        public string Answ { get; set; }
    }
    
}
