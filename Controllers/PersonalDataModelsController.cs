using Microsoft.AspNetCore.Mvc;
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

    }
}
