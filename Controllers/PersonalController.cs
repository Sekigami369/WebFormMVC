using Microsoft.AspNetCore.Mvc;
using WebFormMVC.Models;

namespace WebFormMVC.Controllers
{
    public class PersonalController : Controller
    {
        private readonly MyDatabaseDbContext  myDbContext;
        public PersonalController(MyDatabaseDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }                            

    }
}
