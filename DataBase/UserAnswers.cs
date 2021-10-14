using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication2.DataBase
{
    public class UserAnswers {
        public int ID { get; set; }
        
        public string Quest_Name { get; set; }
        
        public string Answ { get; set; }
    }
    
}
