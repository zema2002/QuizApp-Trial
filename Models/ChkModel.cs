using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ChkModel
    {
        
        public bool Checked { get; set; }
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
    }

   
}
