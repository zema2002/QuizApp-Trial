using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class CreateDormViewModel
    {
        public ICollection<ChkModel> DormOptions { get; set; }

    }
}
