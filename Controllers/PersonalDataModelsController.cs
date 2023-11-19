using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebFormMVC.Models;

namespace WebFormMVC.Controllers
{
    public class PersonalDataModelsController : Controller
    {
        private readonly MyDatabaseDbContext  myDbContext;
        public PersonalDataModelsController(MyDatabaseDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }
        public async Task<IActionResult> Index()
        {
            if(myDbContext.PersonalData != null)
            {
                var data =await myDbContext.PersonalData.ToListAsync();
                return View(data);
            }
            else
            {
                Console.WriteLine("myDbContextがnull");
                return Problem("データベースにデータがありません。");
            }
            
        }
    }
}
