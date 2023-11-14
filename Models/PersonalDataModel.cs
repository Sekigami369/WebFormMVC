using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFormMVC.Models
{
    public class PersonalDataModel 
    {


        [Column("InputID")]
        [Required]
        public int InputID { get; set; }

        [Column("Name")]
        [Required]
        public string Name { get; set; }

        [Column("BirthDay")]
        [Required]
        public DateTime BirthDay { get; set; }

        [Column("Gendrt")]
        [Required]
     
        public  string Gender { get; set; }

        [Column("JobName")]
        [Required]
        public string JobName { get; set; }

    }
}
