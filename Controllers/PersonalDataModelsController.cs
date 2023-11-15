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
            return myDbContext.personalDatas != null ?
                View(await myDbContext.personalDatas.ToListAsync()) :
                Problem("Entity set 'myDbContext.personalDatas' is null.");            
        }
    }
}
