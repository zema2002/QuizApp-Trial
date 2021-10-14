using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class MyModel:PageModel
    {
        [Display(Name = "Remember me?")]
        public bool IsChecked { get; set; }
    }
}
