using System.Collections.Generic;
using WebApplication2.DataBase;

namespace PagerApp.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Question> Questions { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}