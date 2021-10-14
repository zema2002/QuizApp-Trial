using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PagerApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.DataBase;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplicationDbContext db;
        
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //} Questions.OrderBy(q=>Guid.NewGuid()).Take(6)

        public IActionResult Index() {
            return View();
        }
        public async Task<IActionResult> GetQuestions(int page=1)
        {
            int pagesize = 1;
            IQueryable<Question> source = db.Questions;
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pagesize).Take(pagesize).ToListAsync();
            PageViewModel pageViewModel = new PageViewModel(count, page, pagesize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Questions = items
            };
            return View(viewModel);


            //return View(await db.Questions.OrderBy(q=>Guid.NewGuid()).Take(5).ToArrayAsync());
            
        }

        public IActionResult Fill() {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserAnswers answer)
        {
            db.Answers.Add(answer);
            db.SaveChangesAsync();
            return RedirectToAction("GetQuestions");
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(Question question)
        //{
        //    db.Questions.Add(question);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Authorize]
        [Route("/Start")]
        public IActionResult Tests() {
            return View();
        }

        [Route("/Testing")]
        public IActionResult Testing() {
            return View();
        }

        [BindProperty]
        public UserAnswers userAnswers { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            

            db.Answers.Add(userAnswers);
            await db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        
        public ActionResult Index1() {
            return View();
        }

        

        public List<checkListModel> lstCheckList() {
            List<checkListModel> lst = new List<checkListModel>();
            checkListModel chk = new checkListModel();
            chk.ID = 1;
            chk.Name = "v1";
            lst.Add(chk);

            checkListModel chk1 = new checkListModel();
            chk1.ID = 2;
            chk1.Name = "v2";
            lst.Add(chk1);

            checkListModel chk2 = new checkListModel();
            chk2.ID = 3;
            chk2.Name = "v3";
            lst.Add(chk2);

            checkListModel chk3 = new checkListModel();
            chk3.ID = 4;
            chk3.Name = "v4";
            lst.Add(chk3);

            return (lst);
        }
       



        

        





    }
}
