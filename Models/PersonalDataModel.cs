using MessagePack;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace WebFormMVC.Models
{
    [Table("PersonalData")]
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

        [Column("Gender")]
        [Required]
     
        public  string Gender { get; set; }

        [Column("JobName")]
        [Required]
        public string JobName { get; set; }

    }
}
